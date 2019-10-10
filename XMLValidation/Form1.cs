using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Diagnostics;

namespace XMLValidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitializeComponent();
            string current = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            WorkDirectory.Text = current;
            if (!File.Exists(current + "/Log.txt"))
            {
                var myFile = File.Create(current + "/Log.txt");
                myFile.Close();
                XMLViewer.AppendText("Aloha");
            }

            Log("Application launched!");
        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML Files (*.xml)|*.xml";
            ofd.FilterIndex = 0;
            ofd.DefaultExt = "xml";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlReaderSettings bookSet = new XmlReaderSettings();
                    bookSet.Schemas.Add("urn:cbr-ru:ed:v2.0", WorkDirectory.Text + "/XSDFiles/cbr_ed542_v2019.2.0.xsd");
                    bookSet.ValidationType = ValidationType.Schema;
                    bookSet.ValidationEventHandler += new ValidationEventHandler(bookSetValidateEventHandler);

                    bool errors = false;
                    XmlReader book = XmlReader.Create(ofd.FileName, bookSet);
                    XmlDocument document = new XmlDocument();
                    Log("Trying to validate " + ofd.FileName);
                    document.Load(book);
                    document.Validate((o, er) => { if (er.Severity == XmlSeverityType.Error) errors = true; });

                    MessageBox.Show(String.Format(Path.GetFileName(ofd.FileName) + ": {0} ", errors ? "Did not validate. You can't work with that file" : "Successfully validated"), "XML Document Validation", MessageBoxButtons.OK, errors ? MessageBoxIcon.Error : MessageBoxIcon.Information);
                    if (!errors)
                    {

                        XMLViewer.Text = document.InnerXml;
                        FilePath.Text = ofd.FileName;
                    }
                    Log(String.Format(Path.GetFileName(ofd.FileName) + ": {0} ", errors ? "Did not validate. You can't work with that file" : "Successfully validated"));
                    book.Close();
                    ofd.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        static void bookSetValidateEventHandler(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Warning)
            {
                Log("WARNING: " + e.Message);
            }
            else if (e.Severity == XmlSeverityType.Error)
            {
                Log("Error: " + e.Message);
            }
        }

        static void Log(String message)
        {
            try
            {
                string current = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                File.AppendAllText(current + "/Log.txt", DateTime.Now + " : " + message + "\n", System.Text.Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveTo_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "XML Files (*.xml)|*.xml";
                sfd.FilterIndex = 0;
                sfd.DefaultExt = "xml";
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, XMLViewer.Text);
                    MessageBox.Show("File saved");
                }
                Log("New file " + sfd.FileName + " saved!");
                sfd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(FilePath.Text, XMLViewer.Text);
                MessageBox.Show("File saved");
                Log("File " + FilePath.Text + " has been changed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteLog_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(WorkDirectory.Text + "/Log.txt");
                MessageBox.Show("File deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenLog_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("notepad.exe", WorkDirectory.Text + "/Log.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Closing(object sender, FormClosingEventArgs e)
        {
            Log("Application closed!\n");
        }
    }
}
