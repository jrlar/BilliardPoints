using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Media;
using System.Speech.Synthesis;

namespace BilliardPoints
{
    public partial class MainForm : Form
    {
        Odd OddObject = new Odd();
        List<Hendelse> HendelseListe = new List<Hendelse>();
        List<InfoLinje> InfoListe = new List<InfoLinje>();
        string spillerANavn = "Spiller A";
        string spillerBNavn = "Spiller B";
        int spillNr = 0;
        DateTime forrigeHendelsesDato = DateTime.MinValue;
        TimeSpan OmgangsTidSpan = TimeSpan.Zero;

        public MainForm()
        {
            InitializeComponent();
            buttonVinnSpillerA.BackColor = Color.Green;
            buttonVinnSpillerB.BackColor = Color.Green;
            FyllNavneDDLer();
            labelSpillNr.Visible = false;


            //SetDataGrid();


        }


        private void FyllNavneDDLer()
        {
            int antallMuligeSpillere = ConfigurationManager.AppSettings.Count;

            //Fylle ddl med mulige spillere

            comboBoxSpillerA.Items.Add("Spiller A");
            comboBoxSpillerB.Items.Add("Spiller B");
            for (int i = 0; i < antallMuligeSpillere; i++)
            {
                comboBoxSpillerA.Items.Add(ConfigurationManager.AppSettings.GetValues(i)[0]);
                comboBoxSpillerB.Items.Add(ConfigurationManager.AppSettings.GetValues(i)[0]);
            }
            comboBoxSpillerA.SelectedIndex = 0;
            comboBoxSpillerB.SelectedIndex = 0;
        }

        private void SetDataGrid()
        {
            dataGridViewInfo.Columns.Add("Spill", "Spill #");
            dataGridViewInfo.Columns.Add("Hendelse", "Hendelse");
            dataGridViewInfo.Columns.Add("StartTid", "Tid");
            dataGridViewInfo.Columns.Add("OmgangsTid", "Omgangs tid");
        }

        private string OmgangsTidTekst()
        {
            string OmgangsTidTekst = "0 min. 0 sek.";

            if (forrigeHendelsesDato != DateTime.MinValue)
            {
                OmgangsTidSpan = DateTime.Now.Subtract(forrigeHendelsesDato);
                OmgangsTidTekst = OmgangsTidSpan.Minutes.ToString() + " min. " + OmgangsTidSpan.Seconds.ToString() + " sek.";
            }

            return OmgangsTidTekst;
        }

        private void SetDataGridFromHendelsesListe()
        {
            InfoListe.Clear();
            spillNr = 1;
            int vinnSpillerA = 0;
            int vinnSpillerB = 0;

            List<TimeSpan> OmgangsTidListe = new List<TimeSpan>();

            string OmgangsTid = "";

            foreach (var currHendelse in HendelseListe)
            {
                if (forrigeHendelsesDato != DateTime.MinValue)
                {
                    OmgangsTidSpan = currHendelse.tidspunkt.Subtract(forrigeHendelsesDato);
                    OmgangsTid = OmgangsTidSpan.Minutes.ToString() + " min." + OmgangsTidSpan.Seconds.ToString() + " sek.";
                }
                else
                {
                    OmgangsTid = "";
                }

                if (currHendelse.spillStart)
                {
                    InfoListe.Add(new InfoLinje() { Spill = "", Hendelse = "Spill startet", StartTid = "Spill startet " + currHendelse.tidspunkt.ToLongTimeString(), OmgangsTid = "" });
                    labelSpillNr.Visible = true;
                    labelSpillerSomSprer.Visible = true;
                }
                if (currHendelse.spillReStart)
                {
                    InfoListe.Add(new InfoLinje() { Spill = "", Hendelse = "Spill re-startet", StartTid = "Spill startet " + currHendelse.tidspunkt.ToLongTimeString(), OmgangsTid = "" });
                    OmgangsTidListe.Clear();
                    labelSpillNr.Visible = true;
                    labelSpillerSomSprer.Visible = true;
                    labelSnittOmgTid.Text = "0 min. 0 sek.";
                }
                if (currHendelse.vinnSpillerA)
                {                 
                    vinnSpillerA++;
                    InfoListe.Add(new InfoLinje() { Spill = spillNr.ToString(), Hendelse = spillerANavn + " vant", StartTid = "Spill ferdig " + currHendelse.tidspunkt.ToLongTimeString(), OmgangsTid = OmgangsTid });
                    OmgangsTidListe.Add(OmgangsTidSpan);
                    labelSnittOmgTid.Text = FinnGjennomsnittligOmgangsTidText(OmgangsTidListe);
                    spillNr++;
                }
                if (currHendelse.vinnSpillerB)
                {                   
                    vinnSpillerB++;
                    InfoListe.Add(new InfoLinje() { Spill = spillNr.ToString(), Hendelse = spillerBNavn + " vant", StartTid = "Spill ferdig " + currHendelse.tidspunkt.ToLongTimeString(), OmgangsTid = OmgangsTid });
                    OmgangsTidListe.Add(OmgangsTidSpan);
                    labelSnittOmgTid.Text = FinnGjennomsnittligOmgangsTidText(OmgangsTidListe);
                    spillNr++;
                }
                if (currHendelse.spillPause)
                {
                    InfoListe.Add(new InfoLinje() { Spill = "", Hendelse = "Spill pauset", StartTid = "Spill pauset " + currHendelse.tidspunkt.ToLongTimeString(), OmgangsTid = "" });
                }

                forrigeHendelsesDato = currHendelse.tidspunkt;
            }
            dataGridViewInfo.Rows.Clear();
            foreach (var item in InfoListe)
            {
                dataGridViewInfo.Rows.Add(item.Spill, item.Hendelse, item.StartTid, item.OmgangsTid);
            }

            labelSpillNr.Text = (spillNr).ToString();
            labelPoengSpillerA.Text = vinnSpillerA.ToString();
            labelPoengSpillerB.Text = vinnSpillerB.ToString();

            labelSpillerSomSprer.Text = FinnSpillerSomSprer(spillerANavn, spillerBNavn, spillNr, OddObject);



        }

        private string FinnSpillerSomSprer(string spillerANavn, string spillerBNavn, int spillNr, Odd oddObject)
        {
            string spillerSomSprer = "Sett - odd/even først.";

            bool OddOmgang = true;

            if (spillNr % 2 == 0)
            {
                OddOmgang = false;
            }

            if (OddOmgang)
            {
                if (OddObject.spillerAErOdd)
                {
                    spillerSomSprer = spillerANavn;
                }
                if (OddObject.spillerBErOdd)
                {
                    spillerSomSprer = spillerBNavn;
                }

            }
            if (!OddOmgang)
            {
                if (OddObject.spillerAErOdd)
                {
                    spillerSomSprer = spillerBNavn;
                }
                if (OddObject.spillerBErOdd)
                {
                    spillerSomSprer = spillerANavn;
                }
            };

            return spillerSomSprer;
        }

        private string FinnGjennomsnittligOmgangsTidText(List<TimeSpan> omgangsTidListe)
        {
            double doubleAverageTicks = omgangsTidListe.Average(timeSpan => timeSpan.Ticks);
            long longAverageTicks = Convert.ToInt64(doubleAverageTicks);

            var AvgOmgTider = new TimeSpan(longAverageTicks);
            string returStr = AvgOmgTider.Minutes + " min. " + AvgOmgTider.Seconds + " sek.";

            return returStr;
        }

        private void buttonOddSpillerA_Click(object sender, EventArgs e)
        {
            OddObject.spillerAErOdd = true;
            OddObject.spillerBErOdd = false;

            oppdaterOddKnapper();
            labelSpillerSomSprer.Text = FinnSpillerSomSprer(spillerANavn, spillerBNavn, spillNr, OddObject);
        }

        private void buttonOddSpillerB_Click(object sender, EventArgs e)
        {
            OddObject.spillerBErOdd = true;
            OddObject.spillerAErOdd = false;

            oppdaterOddKnapper();
            labelSpillerSomSprer.Text = FinnSpillerSomSprer(spillerANavn, spillerBNavn, spillNr, OddObject);
        }

        private void oppdaterOddKnapper()
        {
            if (OddObject.spillerAErOdd)
            {
                buttonOddSpillerA.Text = "ODD";
                buttonOddSpillerA.BackColor = Color.Yellow;
                buttonOddSpillerB.Text = "EVEN";
                buttonOddSpillerB.BackColor = Color.Gray;
            }
            if (OddObject.spillerBErOdd)
            {
                buttonOddSpillerB.Text = "ODD";
                buttonOddSpillerB.BackColor = Color.Yellow;
                buttonOddSpillerA.Text = "EVEN";
                buttonOddSpillerA.BackColor = Color.Gray;
            }
        }

        private void buttonVinnSpillerA_Click(object sender, EventArgs e)
        {
            buttonVinnSpillerA.BackColor = Color.Yellow;
            Hendelse hendelse = new Hendelse();
            HendelseListe.Add(hendelse.vinnSpillerAHendelse());
            timer2Sekund.Enabled = true;
            SetDataGridFromHendelsesListe();
           
            speak(spillerANavn + " is the winner");

            playSimpleSound();
        }

        private void buttonVinnSpillerB_Click(object sender, EventArgs e)
        {
            buttonVinnSpillerB.BackColor = Color.Yellow;
            Hendelse hendelse = new Hendelse();
            HendelseListe.Add(hendelse.vinnSpillerBHendelse());
            timer2Sekund.Enabled = true;
            SetDataGridFromHendelsesListe();
            
            speak(spillerBNavn + " is the winner");

            playSimpleSound2();
        }

        private void timerSekund_Tick(object sender, EventArgs e)
        {
            labelKlokke.Text = DateTime.Now.ToShortTimeString();
            labelDato.Text = DateTime.Now.ToLongDateString();
            labelCurrOmgTid.Text = OmgangsTidTekst();

        }

        private void timer2Sekund_Tick(object sender, EventArgs e)
        {
            buttonVinnSpillerA.BackColor = Color.Green;
            buttonVinnSpillerB.BackColor = Color.Green;
            timer2Sekund.Enabled = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Hendelse hendelse = new Hendelse();
            HendelseListe.Add(hendelse.spillStartHendelse());
            SetDataGridFromHendelsesListe();
            buttonStart.Enabled = false;
            buttonReStart.Enabled = true;
            buttonPause.Enabled = true;
            buttonVinnSpillerA.Enabled = true;
            buttonVinnSpillerB.Enabled = true;
            buttonSlettSisteHendelse.Enabled = true;

        }

        private void buttonReStart_Click(object sender, EventArgs e)
        {
            HendelseListe.Clear();
            Hendelse hendelse = new Hendelse();
            HendelseListe.Add(hendelse.spillReStartHendelse());
            SetDataGridFromHendelsesListe();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            Hendelse hendelse = new Hendelse();
            HendelseListe.Add(hendelse.spillPauseHendelse());
            SetDataGridFromHendelsesListe();
            buttonStart.Enabled = true;
            buttonReStart.Enabled = true;
            buttonPause.Enabled = false;
            buttonVinnSpillerA.Enabled = false;
            buttonVinnSpillerB.Enabled = false;
            buttonSlettSisteHendelse.Enabled = true;

        }

        private void comboBoxSpillerA_SelectedIndexChanged(object sender, EventArgs e)
        {
            spillerANavn = comboBoxSpillerA.SelectedItem.ToString();
            SetDataGridFromHendelsesListe();
        }

        private void comboBoxSpillerB_SelectedIndexChanged(object sender, EventArgs e)
        {
            spillerBNavn = comboBoxSpillerB.SelectedItem.ToString();
            SetDataGridFromHendelsesListe();
        }

        private void buttonSlettSisteHendelse_Click(object sender, EventArgs e)
        {
            HendelseListe.RemoveAt(HendelseListe.Count-1);
            SetDataGridFromHendelsesListe();
        }

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer("Sounds\\HomerWoohoo1.wav");
            simpleSound.Play();
        }

        private void playSimpleSound2()
        {
            SoundPlayer simpleSound = new SoundPlayer("Sounds\\RUMBLE.wav");
            simpleSound.Play();
        }

        private void playRandomSound(string soundFile)
        {
            SoundPlayer simpleSound = new SoundPlayer();
            
        }


        private void speak(string words)
        {
            // Initialize a new instance of the SpeechSynthesizer.
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output. 
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.
            synth.Speak(words);
        }
    }
}
