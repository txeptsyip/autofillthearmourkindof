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

        private void writetofile(ListBox boxlist, string raceUUID)
        {
            foreach (string selectedValue in boxlist.Items)
            {

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

        private void Writetofile_Click(object sender, EventArgs e)
        {
            writetofile(HumanMaleList, "7d73f501-f65e-46af-a13b-2cacf3985d05");
            writetofile(HumanFemaleList, "71180b76-5752-4a97-b71f-911a69197f58");
            writetofile(StrongMaleList, "e39505f7-f576-4e70-9ea9-298e38cd111a");
            writetofile(StrongFemaleList, "47c0315c-7dc6-4862-b39b-8bf3a10f8b54");
            writetofile(GithyankiMList, "f07faafa-0c6f-4f79-a049-70e96b23d51b");
            writetofile(GithyankiFList, "06aaae02-bb9e-4fa3-ac00-b08e13a5b0fa");
            writetofile(DwarfMList, "abf674d2-2ea4-4a74-ade0-125429f69f83");
            writetofile(DwarfFList, "b4a34ce7-41be-44d9-8486-938fe1472149");
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

        private void AddtoStrongMale_Click(object sender, EventArgs e)
        {
            StrongMaleList.Items.Add(StrongMaleInput.Text);
            StrongMaleInput.Text = "";
        }

        private void RemoveFromStrongMale_Click(object sender, EventArgs e)
        {
            StrongMaleList.Items.RemoveAt(StrongMaleList.SelectedIndex);
        }

        private void AddtoStrongFemale_Click(object sender, EventArgs e)
        {
            StrongFemaleList.Items.Add(StrongFemaleInput.Text);
            StrongFemaleInput.Text = "";
        }

        private void RemovefromStrongFemale_Click(object sender, EventArgs e)
        {
            StrongFemaleList.Items.RemoveAt(StrongFemaleList.SelectedIndex);
        }

        private void AddtoGithyankiM_Click(object sender, EventArgs e)
        {
            GithyankiMList.Items.Add(GithyankiMInput.Text);
            GithyankiMInput.Text = "";
        }

        private void RemoveFromGithyankiM_Click(object sender, EventArgs e)
        {
            GithyankiMList.Items.RemoveAt(GithyankiMList.SelectedIndex);
        }

        private void AddtoGithyankiF_Click(object sender, EventArgs e)
        {
            GithyankiFList.Items.Add(GithyankiFInput.Text);
            GithyankiFInput.Text = "";
        }

        private void RemoveFromGithyankiF_Click(object sender, EventArgs e)
        {
            GithyankiFList.Items.RemoveAt(GithyankiFList.SelectedIndex);
        }

        private void AddtoDwarfM_Click(object sender, EventArgs e)
        {
            DwarfMList.Items.Add(DwarfMInput.Text);
            DwarfMInput.Text = "";
        }

        private void RemoveFromDwarfM_Click(object sender, EventArgs e)
        {
            DwarfMList.Items.RemoveAt(DwarfMList.SelectedIndex);
        }

        private void AddtoDwarfF_Click(object sender, EventArgs e)
        {
            DwarfFList.Items.Add(DwarfFInput.Text);
            DwarfFInput.Text = "";
        }

        private void RemoveFromDwarfF_Click(object sender, EventArgs e)
        {
            DwarfFList.Items.RemoveAt(DwarfFList.SelectedIndex);
        }
    }
}
