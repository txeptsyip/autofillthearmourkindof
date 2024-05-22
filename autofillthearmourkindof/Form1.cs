using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace autofillthearmourkindof
{
    public partial class Form1 : Form
    {
        private XmlDocument xmlDoc;
        public Form1()
        {
            InitializeComponent();
            xmlDoc = new XmlDocument();
            xmlDoc.Load("merged - Copy.lsx");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HumanMaleList.Items.Add(HumanMaleInput.Text);
            HumanMaleInput.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HumanMaleList.Items.RemoveAt(HumanMaleList.SelectedIndex);
        }

        private void addtohumanfemale_Click(object sender, EventArgs e)
        {
            HumanFemaleList.Items.Add(HumanFemaleInput.Text);
            HumanFemaleInput.Text = "";
        }

        private void removefromhumanfemale_Click(object sender, EventArgs e)
        {
            HumanFemaleList.Items.RemoveAt(HumanFemaleList.SelectedIndex);
        }

        private void Writetofile_Click(object sender, EventArgs e)
        {
            //string selectedValue = HumanMaleList.SelectedItem?.ToString();


            writetofile(HumanMaleList, "7d73f501-f65e-46af-a13b-2cacf3985d05");
            writetofile(HumanFemaleList, "71180b76-5752-4a97-b71f-911a69197f58");

            //}
            //else
            //{
            //    MessageBox.Show("Please select a value from the ListBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //MessageBox.Show($"Data saved for '{selectedValue}'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void writetofile(ListBox boxlist, string raceUUID)
        {
            foreach (string selectedValue in boxlist.Items)
            {
                //if (!string.IsNullOrEmpty(selectedValue))
                //{
                XmlNode mapValueNode = xmlDoc.CreateElement("node");
                XmlAttribute objectIdAttribute = xmlDoc.CreateAttribute("id");
                objectIdAttribute.Value = "MapValue";
                mapValueNode.Attributes.Append(objectIdAttribute);

                XmlNode objectNode = xmlDoc.CreateElement("attribute");
                XmlAttribute objectAttribute = xmlDoc.CreateAttribute("id");
                objectAttribute.Value = "Object";
                objectNode.Attributes.Append(objectAttribute);
                objectAttribute = xmlDoc.CreateAttribute("type");
                objectAttribute.Value = "FixedString";
                objectNode.Attributes.Append(objectAttribute);
                objectAttribute = xmlDoc.CreateAttribute("value");
                objectAttribute.Value = selectedValue;
                objectNode.Attributes.Append(objectAttribute);

                mapValueNode.AppendChild(objectNode);

                XmlNode existingObjectNode = xmlDoc.SelectSingleNode($"//node[@id='Object'][attribute/@value='{raceUUID}']");
                existingObjectNode?.AppendChild(mapValueNode);

            }

            xmlDoc.Save("modified_xml_file.xml");
        }


    }
}
