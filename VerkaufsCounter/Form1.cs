using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VerkaufsCounter
{
    public partial class Form1 : Form

    {
        string username_pb = "";
        int intervall_pb = -1;
        bool enabled = false;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            
            //Possibility to disable the program by checking an URL
            if (getHTML("https://raw.githubusercontent.com/wase90168/ebayVerkaufscounter/master/enabled.html").Trim() == "1") { enabled = true; }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private Form2 progressForm;
        BackgroundWorker b = new BackgroundWorker();
        List<int> CountList = new List<int>();
        List<string> DataList = new List<string>();
        List<string> TimeList = new List<string>();
        List<string> CurrencyList = new List<string>();
        List<string> PriceList = new List<string>();
        private void auswerten_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                dataGridView1.Rows.Add();
            }
            if (!backgroundWorker1.IsBusy)
            {
                progressForm = new Form2();
                progressForm.Show();
                backgroundWorker1.RunWorkerAsync();
            }
        }
        private string getHTML(string url)
        {
            string html = "";
            try
            {
                html = new WebClient().DownloadString(url);
            }
            catch { }
            return html;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enable_buttons(false);
            string username = getEnteredUsername();
            int maxPages = getMaxPages(0, username);
            if (maxPages >= 0)
            {
                label4.Text = "Die Bewertungen von " + username + " umfassen " + Convert.ToString(maxPages) + " Seiten.";
            }
            else
            {
                label4.Text = "Bitte überprüfen Sie den eingegebenen Benutzernamen!";
            }
            label4.Visible = true;
            enable_buttons(true);
        }
        private void enable_buttons(Boolean enableType)
        {
            auswerten.Enabled = enableType;
            button1.Enabled = enableType;
            clear_bt.Enabled = enableType;
            usernametb.Enabled = enableType;
            maxsitetb.Enabled = enableType;
            minsitestb.Enabled = enableType;
            export.Enabled = enableType;
            comboBox1.Enabled = enableType;
            radioSearchSites.Enabled = enableType;
            radioSearchTime.Enabled = enableType;
            help.Enabled = enableType;
        }
        private int getMaxPages(int intervall, string username)
        {
            string pattern_nbr = @">\d*</span><span>von\s(\d*.?\d*)</span>";
            string url = "http://feedback.ebay.at/ws/eBayISAPI.dll?ViewFeedback2&ftab=FeedbackAsSeller&userid=" + username + "&iid=-1&de=off&items=25&interval="+intervall+"&mPg=1&page=1";
            string export = getHTML(url);
            Regex r = new Regex(pattern_nbr);
            Match m = r.Match(export);
            Group matchresult = m.Groups[1];
            if (m.Success)
            {
                return Convert.ToInt32(matchresult.Value.Replace(".", ""));
            }
            else
            {
                return -1;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clear_bt_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            DataList.Clear();
            CountList.Clear();
            TimeList.Clear();
            PriceList.Clear();
        }
        private string getEnteredUsername()
        {
            if (enabled)
            {
                return usernametb.Text;
            }
            else
            {
                return "";
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DataList.Clear();
            CountList.Clear();
            TimeList.Clear();
            PriceList.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            enable_buttons(false);
            string username = getEnteredUsername();
            username_pb = username;
            int intervall = 0;
            int maxSites = 0;
            int minSites = 0;
            int maxSites_max = -1;
            if (radioSearchTime.Checked)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        intervall = 0;
                        break;
                    case 1:
                        intervall = 30;
                        break;
                    case 2:
                        intervall = 180;
                        break;
                    case 3:
                        intervall = 365;
                        break;
                    default:
                        MessageBox.Show("Bitte treffen Sie eine Auswahl in dem DropDown-Menü!");
                        progressForm.Close();
                        break;
                }
                minSites = 1;
                maxSites = getMaxPages(intervall, username);
                maxSites_max = maxSites;
            }
            else if (radioSearchSites.Checked)
            {
                maxSites = Convert.ToInt16(maxsitetb.Value);
                minSites = Convert.ToInt16(minsitestb.Value);
                if (maxSites < minSites)
                {
                    MessageBox.Show("Es können nicht weniger als 0 Seiten durchsucht werden!");
                    progressForm.Close();
                    enable_buttons(true);
                    return;
                }
                maxSites_max = getMaxPages(intervall, username);
            }
            else {
                MessageBox.Show("Es gibt ein Problem bei der Auswahl der Durchsuchungsart (RadioButtons)!");
                progressForm.Close();
                enable_buttons(true);
                return;
            }
            intervall_pb = intervall;
            if (maxSites_max == -1)
            {
                MessageBox.Show("Keine Resultate gefunden, möglicherweise ist der eingegebene Benutzername falsch oder der User hat für den ausgewählten Zeitraum keine Bewertungen!");
                progressForm.Close();
                enable_buttons(true);
                return;
            }
            if (maxSites_max < maxSites)
            {
                MessageBox.Show("Es ist nicht möglich die " + maxSites + ". Seite zu durchsuchen, da der Nutzer " + username + " nur " + maxSites_max + " Seiten an Bewertungen hat!");
                progressForm.Close();
                enable_buttons(true);
                return;
            }
            string pattern = @"<td nowrap=.nowrap.\svalign=.top.>(.*?)</td>.*?</tr><tr\sclass=.bot.><td>&nbsp;</td><td>(.*?)(?:\(Nr\.\d{10,12}\))?</td><td>(?:<div.*?>)?(.*?)(\d+.\d+)?(?:</div>.*?)?</td>";
            if (maxSites - minSites > 25)
            {
                DialogResult result = MessageBox.Show("Die Durchsuchung von " + (maxSites - minSites+1) + " Seiten kann unter Umständen sehr viel Zeit in Anspruch nehmen!\nWollen Sie fortfahren?", "Viele Seiten", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    progressForm.Close();
                    enable_buttons(true);
                    return;
                }
            }
            double progress = 0;
            bool matched = false;
            string url = "http://feedback.ebay.at/ws/eBayISAPI.dll?ViewFeedback2&ftab=FeedbackAsSeller&userid=" + username + "&iid=-1&de=off&items=25&interval=" + intervall + "&mPg=" + maxSites_max + "&page=";
            for (int i = minSites; i <= maxSites; i++)
            {
                progress = (double)i / (double)maxSites * 100;
                string html = getHTML(url + i);
                foreach (Match match in Regex.Matches(html, pattern))
                {
                    matched = true;
                    bool breakout = false;
                    int count = 0;
                    foreach (string text in DataList)
                    {
                        if (text == match.Groups[2].Value)
                        {
                            breakout = true;
                            CountList[count]++;
                            break;
                        }
                        count++;
                    }
                    if (!breakout)
                    {
                        TimeList.Add(match.Groups[1].Value);
                        DataList.Add(match.Groups[2].Value);
                        CurrencyList.Add(match.Groups[3].Value);
                        PriceList.Add(match.Groups[4].Value);
                        CountList.Add(1);
                    }
                }
                progressForm.progressBar1.Value = (int)progress;
                progressForm.progress.Text = Math.Round(progress, 0) + " " + "%";
                html = "";
            }
            if (!matched)
            {
                MessageBox.Show("Keine Resultate gefunden, möglicherweise ist der eingegebene Benutzername falsch oder der User hat für den ausgewählten Zeitraum keine Bewertungen!");
                progressForm.Close();
                enable_buttons(true);
                return;
            }
            dataGridView1.Rows.Add(CountList.Count + 1);
            for (int i = 0; i < CountList.Count(); i++)
            {

                dataGridView1.Rows[i].Cells[0].Value = CountList[i];
                dataGridView1.Rows[i].Cells[1].Value = TimeList[i];
                dataGridView1.Rows[i].Cells[2].Value = CurrencyList[i];
                dataGridView1.Rows[i].Cells[3].Value = PriceList[i];
                dataGridView1.Rows[i].Cells[4].Value = DataList[i];

            }
            enable_buttons(true);
            progressForm.Close();
        }

        private void export_Click(object sender, EventArgs e)
        {
            string iv_text = "";
            DateTime zeitpunkt = DateTime.Now;
            switch (intervall_pb)
            {
                case 0:
                    iv_text = "alle";
                    break;
                case 30:
                    iv_text = "letztes Monat";
                    break;
                case 180:
                    iv_text = "letzten 6 Monate";
                    break;
                case 365:
                    iv_text = "letztes Jahr";
                    break;
                default:
                    break;
            }
            StringBuilder csv = new StringBuilder();
            for (int i = 0; i < DataList.Count; i++)
            {
                string newLine = string.Format("{0};{1};{2};{3};{4}", CountList[i], TimeList[i], CurrencyList[i], PriceList[i], DataList[i]);
                csv.AppendLine(newLine);
            }
            System.IO.StreamWriter file = new System.IO.StreamWriter(username_pb.Replace("\\","-").Replace("/", "-").Replace(":", "-").Replace("*", "-").Replace("?", "-").Replace("\"", "-").Replace("<", "-").Replace(">", "-").Replace("|", "-") + "_" + iv_text + "_" + zeitpunkt.ToString().Replace(":","-").Replace(".","-") + ".csv");
            file.WriteLine(csv.ToString());
            file.Close();
            MessageBox.Show("Die exportierten Daten wurden in die export.csv (Im selben\nVerzeichnis wie dieses Programm) gespeichert.");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            radioSearchSites.Checked = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            radioSearchTime.Checked = true;
        }
        private helpForm helpForm = new helpForm();
        private void help_Click(object sender, EventArgs e)
        {
            helpForm.Show();
        }
    }
}
