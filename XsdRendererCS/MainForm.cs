using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XsdRendererCS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void parseXmlButton_Click(object sender, EventArgs e)
        {
          
            bindingSource.DataSource = ParseXML(xmlSourceBox.Text);

        }

        private Person ParseXML(string xml)
        {
            try
            {
                return ContactInfoFactory.Create<Person>(new StringReader(xml));
            }
            catch (System.Xml.XmlException e)
            {
                MessageBox.Show("Failed to parse xml");
                return null;
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream(assembly.GetName().Name + ".XMLData.xml");
            xmlSourceBox.Text = new StreamReader(stream).ReadToEnd();
        }


    }
}
