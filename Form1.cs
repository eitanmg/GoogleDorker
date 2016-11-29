using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string directory = System.IO.Directory.GetCurrentDirectory();
        string chromeDefaultProfile = System.Configuration.ConfigurationManager.AppSettings["chromeDefaultProfile"];
        string ExecutablePath = System.Configuration.ConfigurationManager.AppSettings["ExecutablePath"];
        string chromeDriverPath = System.IO.Directory.GetCurrentDirectory();
        string googleWebsiteAddress = System.Configuration.ConfigurationManager.AppSettings["googleWebsiteAddress"];

        private void button1_Click(object sender, EventArgs e)
        {

            if (QueryTextBox.Text == "")
            {
                MessageBox.Show("Please enter something in the Query textbox!", "Error", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
                return;
            }

            string[] queryLines = QueryTextBox.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            //Create Chrome default instance

            ChromeOptions options = new ChromeOptions();
            options.AddArguments(chromeDefaultProfile);
            options.BinaryLocation = ExecutablePath;
            IWebDriver driver = new ChromeDriver(chromeDriverPath, options);
            Random r = new Random();

            // Create a file to write to.
            string dateTimeString = string.Format("Query-{0:yyyy-MM-dd_hh-mm-ss-tt}.txt",DateTime.Now);
            string path = directory + "\\Logs\\" + dateTimeString;
            if (!File.Exists(path))
            {               
                TextWriter tw = new StreamWriter(path, true);
                tw.Close();
            }

            for (int k = 0; k < queryLines.Length; k++)
            {
                //query part
                Uri googleURI_1 = new Uri(driver.Url);
                driver.Navigate().GoToUrl(googleWebsiteAddress);
                
                //Check if its a CAPTCHA page
                while (googleURI_1.Host == "ipv4.google.com")
                {
                    MessageBox.Show("Enter the CAPTCHA! and then click OK", "CAPTCHA", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
                    Uri stillCapchaUrl = new Uri(driver.Url);
                    googleURI_1 = stillCapchaUrl;
                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
                }

                IWebElement queryTextBox = driver.FindElement(By.Id("lst-ib"));
                queryTextBox.SendKeys(queryLines[k]);
                queryTextBox.Submit();

                Uri googleURI_2 = new Uri(driver.Url);

                //Check if its a CAPTCHA page
                while (googleURI_2.Host == "ipv4.google.com")
                {
                    MessageBox.Show("Enter the CAPTCHA! and then click OK", "CAPTCHA", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
                    Uri stillCapchaUrl = new Uri(driver.Url);
                    googleURI_2 = stillCapchaUrl;
                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
                }

                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1));
                IList<IWebElement> rawGetTotalPages = driver.FindElements(By.CssSelector("div[id='navcnt']"));
                IList<IWebElement> pagesElement = rawGetTotalPages[0].FindElements(By.TagName("a"));

                //first page execution
                IList<IWebElement> rawGoogleUrls = driver.FindElements(By.TagName("h3"));
                writeUrlsinFile(rawGoogleUrls, path);
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(r.Next(0, 2)));

                if (allPagesCB.Checked == false)
                {
                    for (int i = 0; i < pagesElement.Count; i++)
                    {
                        IList<IWebElement> rawCuerrentTotalPages = driver.FindElements(By.CssSelector("div[id='navcnt']"));
                        IList<IWebElement> nextElement = rawCuerrentTotalPages[0].FindElements(By.CssSelector("a[class='pn']"));
                        for (int j = 0; j < nextElement.Count; j++)
                        {
                            if (nextElement[j].Text == "הבא" || nextElement[j].Text == "Next")
                            {
                                nextElement[j].Click();
                            }

                            Uri googleURI_3 = new Uri(driver.Url);

                            //Check if its a CAPTCHA page
                            while (googleURI_3.Host == "ipv4.google.com")
                            {
                                MessageBox.Show("Enter the CAPTCHA! and then click OK", "CAPTCHA", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
                                Uri stillCapchaUrl = new Uri(driver.Url);
                                googleURI_3 = stillCapchaUrl;
                                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
                            }
                        }
                        driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(r.Next(1, 3)));
                        IList<IWebElement> GoogleUrls = driver.FindElements(By.TagName("h3"));
                        writeUrlsinFile(GoogleUrls, path);
                    }
                }
            }

            string[] removeDuplicates = File.ReadAllLines(path);
            File.WriteAllLines(path, removeDuplicates.Distinct().ToArray());
            driver.Close();
            MessageBox.Show("All Done", "done", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
        }


        public void writeUrlsinFile(IList<IWebElement> rawGoogleUrls, string resultPath)
        {
            for (int i = 0; i < rawGoogleUrls.Count - 1; i++)
            {
                try
                {
                    Uri uri = new Uri(rawGoogleUrls[i].FindElement(By.TagName("a")).GetAttribute("href"));
                    GetDomain getdomain = new GetDomain();
                    string domainStr = getdomain.GetDomainFromUrl(uri);
                    bool answer = CheckIfUrlIsLegitimate(domainStr);
                    if (answer == true)
                    {
                        //do nothing
                    }
                    else
                    {
                        File.AppendAllText(resultPath, rawGoogleUrls[i].FindElement(By.TagName("a")).GetAttribute("href") + Environment.NewLine);
                    }    
                }
                catch (Exception ex)
                {
                    string errorDateTimeString = string.Format("Error-{0:yyyy-MM-dd}.txt", DateTime.Now);
                    string path = directory + "\\Logs\\" + errorDateTimeString;
                    if (!File.Exists(path))
                    {
                        TextWriter tw = new StreamWriter(path, true);
                        tw.Close();
                    }
                    File.AppendAllText(path, DateTime.Now.ToString() + ": " + ex.Message + Environment.NewLine);
                }
            }
        }

        public bool CheckIfUrlIsLegitimate(string url)
        {
            string[] WhitelistLines = WLTextBox.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            if (WhitelistLines.Contains(url))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Enable ctrl+A functions in textboxes

        protected override bool ProcessCmdKey(ref Message msg, System.Windows.Forms.Keys keyData)
        {
            const int WM_KEYDOWN = 0x100;
            var keyCode = (System.Windows.Forms.Keys)(msg.WParam.ToInt32() &
                                  Convert.ToInt32(System.Windows.Forms.Keys.KeyCode));
            if ((msg.Msg == WM_KEYDOWN && keyCode == System.Windows.Forms.Keys.A)
                && (ModifierKeys == System.Windows.Forms.Keys.Control)
                && QueryTextBox.Focused)
            {
                QueryTextBox.SelectAll();
                return true;
            }

            if ((msg.Msg == WM_KEYDOWN && keyCode == System.Windows.Forms.Keys.A)
                && (ModifierKeys == System.Windows.Forms.Keys.Control)
                && WLTextBox.Focused)
            {
                WLTextBox.SelectAll();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void LinkToGuide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string directory = System.IO.Directory.GetCurrentDirectory();
            string guidePath = directory + "\\Guide\\Guide.html";
            System.Diagnostics.Process.Start(guidePath);
        }

        private void allPagesCB_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}