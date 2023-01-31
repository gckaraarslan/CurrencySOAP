using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Döviz_Güncel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HESAPLABUTTON_Click(object sender, EventArgs e)
        {
            string bugununKuru = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc=new XmlDocument();
            xmldoc.Load(bugununKuru);
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
           
            string USD = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteSelling").InnerXml;
            USDTEXT.Text=string.Format("Tarih:{0} / 1 USD={1} TL'dir", tarih.ToShortDateString(), USD);

            string EURO = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            EUROTEXT.Text = string.Format("Tarih:{0} / 1 EURO={1} TL'dir", tarih.ToShortDateString(), EURO);

            string POUND = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
            POUNDTEXT.Text=string.Format("Tarih:{0} / 1 POUND={1} TL'dir",tarih.ToShortDateString(),POUND);
        }
    }
}