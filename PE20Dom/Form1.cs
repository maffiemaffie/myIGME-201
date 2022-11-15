using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE20Dom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);

            this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");
        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;

            htmlElement = webBrowser.Document.GetElementsByTagName("h1")[0];
            htmlElement.InnerText = "My UFO Page";

            htmlElement = webBrowser.Document.GetElementsByTagName("h2")[0];
            htmlElement.InnerText = "My UFO Info";

            htmlElement = webBrowser.Document.GetElementsByTagName("h2")[1];
            htmlElement.InnerText = "My UFO Pictures";

            htmlElement = webBrowser.Document.GetElementsByTagName("h2")[2];
            htmlElement.InnerText = "";

            htmlElement = webBrowser.Document.Body;
            htmlElement.Style = "font-family: sans-serif; color: #DD4203;";

            htmlElement = webBrowser.Document.GetElementsByTagName("p")[0];
            htmlElement.InnerHtml = "Report your UFO sightings here. <a href='http://www.nuforc.org'>http://www.nuforc.org</a>";
            htmlElement.Style = "color: green; font-weight: bold; font-size: 2em; text-transform: uppercase; text-shadow: 3px 2px #A44;";

            htmlElement = webBrowser.Document.GetElementsByTagName("p")[1];
            htmlElement.InnerText = "";

            HtmlElement imgElement = webBrowser.Document.CreateElement("img");
            imgElement.SetAttribute("src", "https://ichef.bbci.co.uk/news/976/cpsprodpb/16CE8/production/_109061439_hi018470968.jpg");
            htmlElement = webBrowser.Document.GetElementsByTagName("p")[2];
            htmlElement.InsertAdjacentElement(HtmlElementInsertionOrientation.AfterBegin, imgElement);

            HtmlElement footerElement = webBrowser.Document.CreateElement("footer");
            footerElement.InnerText = "&copy; 2022 Maffie Cohen";
            htmlElement = webBrowser.Document.Body;
            htmlElement.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeEnd, footerElement);
        }
    }
}
