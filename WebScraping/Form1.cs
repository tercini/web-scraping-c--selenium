using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScraping
{
    public partial class frWebScraping : Form
    {
        public frWebScraping()
        {
            InitializeComponent();
        }

        private void btnScraping_Click(object sender, EventArgs e)
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("user-data-dir=" + path + "ChromeDriver\\Cache");
            ChromeDriver driver = new ChromeDriver(path, options);


            driver.Navigate().GoToUrl("https://www.google.com/search?ei=HbbjXvumFbin5OUP5ayu2A8&q=ranking+campeonato+brasileiro+2019&oq=ranking+campeonato+brasileiro+2019&gs_lcp=CgZwc3ktYWIQAzICCAAyBggAEBYQHjIGCAAQFhAeMgYIABAWEB4yBggAEBYQHjIGCAAQFhAeMgYIABAWEB4yBggAEBYQHjIGCAAQFhAeMgYIABAWEB5QnfkGWLr6BmDS-wZoAHAAeACAAXeIAdQCkgEDMC4zmAEAoAEBqgEHZ3dzLXdpeg&sclient=psy-ab&ved=0ahUKEwi7qeXM4fzpAhW4E7kGHWWWC_sQ4dUDCAw&uact=5");

            List<IWebElement> eleTab = driver.FindElements(By.ClassName("imso-hov")).ToList();

            string times = "posicao;time;pontos \n";
            string valSepVir = "";

            foreach(IWebElement item in eleTab)
            {
                valSepVir = item.Text.Substring(0, item.Text.IndexOf("\r")) + ";" + 
                    item.Text.Substring(item.Text.IndexOf("\n") +1, item.Text.LastIndexOf("\r") -3) + ";" +
                    item.Text.Substring(item.Text.LastIndexOf("\n") +1, item.Text.IndexOf(" ") - item.Text.LastIndexOf("\n") -1 ) + "\n";

                times = times + valSepVir;                             
            }

            richTextBox1.AppendText(times);


        }
    }
}
