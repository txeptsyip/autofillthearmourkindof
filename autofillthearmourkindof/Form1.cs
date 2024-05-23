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
            writetofile(HalflingMList, "a933e2a8-aee1-4ecb-80d2-8f47b706f024");
            writetofile(HalflingFList, "8f00cf38-4588-433a-8175-8acdbbf33f33");
            writetofile(GnomeMList, "5640e766-aa53-428d-815b-6a0b4ef95aca");
            writetofile(GnomeFList, "c491d027-4332-4fda-948f-4a3df6772baa");
            writetofile(DragonbornMList, "9a8bbeba-850c-402f-bac5-ff15696e6497");
            writetofile(DragonbornFList, "6d38f246-15cb-48b5-9b85-378016a7a78e");
            writetofile(HalfOrcMList, "6dd3db4f-e2db-4097-b82e-12f379f94c2e");
            writetofile(HalfOrcFList, "eb81b1de-985e-4e3a-8573-5717dc1fa15c");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HumanMaleList.Items.Add(HumanMaleInput.Text);
            HumanMaleInput.Text = "";
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (HumanMaleList.SelectedIndex == -1)
            { }
            else
            {
                HumanMaleList.Items.RemoveAt(HumanMaleList.SelectedIndex);
            }
        }

        private void addtohumanfemale_Click(object sender, EventArgs e)
        {
            HumanFemaleList.Items.Add(HumanFemaleInput.Text);
            HumanFemaleInput.Text = "";
        }

        private void removefromhumanfemale_Click(object sender, EventArgs e)
        {
            if (HumanFemaleList.SelectedIndex == -1)
            { }
            else
            {
                HumanFemaleList.Items.RemoveAt(HumanFemaleList.SelectedIndex);
            }
        }

        private void AddtoStrongMale_Click(object sender, EventArgs e)
        {
            StrongMaleList.Items.Add(StrongMaleInput.Text);
            StrongMaleInput.Text = "";
        }

        private void RemoveFromStrongMale_Click(object sender, EventArgs e)
        {
            if (StrongMaleList.SelectedIndex == -1)
            { }
            else
            {
                StrongMaleList.Items.RemoveAt(StrongMaleList.SelectedIndex);
            }
        }

        private void AddtoStrongFemale_Click(object sender, EventArgs e)
        {
            StrongFemaleList.Items.Add(StrongFemaleInput.Text);
            StrongFemaleInput.Text = "";
        }

        private void RemovefromStrongFemale_Click(object sender, EventArgs e)
        {
            if (StrongFemaleList.SelectedIndex == -1)
            { }
            else
            {
                StrongFemaleList.Items.RemoveAt(StrongFemaleList.SelectedIndex);
            }
        }

        private void AddtoGithyankiM_Click(object sender, EventArgs e)
        {
            GithyankiMList.Items.Add(GithyankiMInput.Text);
            GithyankiMInput.Text = "";
        }

        private void RemoveFromGithyankiM_Click(object sender, EventArgs e)
        {
            if (GithyankiMList.SelectedIndex == -1)
            { }
            else
            {
                GithyankiMList.Items.RemoveAt(GithyankiMList.SelectedIndex);
            }
        }

        private void AddtoGithyankiF_Click(object sender, EventArgs e)
        {
            GithyankiFList.Items.Add(GithyankiFInput.Text);
            GithyankiFInput.Text = "";
        }

        private void RemoveFromGithyankiF_Click(object sender, EventArgs e)
        {
            if (GithyankiFList.SelectedIndex == -1)
            { }
            else
            {
                GithyankiFList.Items.RemoveAt(GithyankiFList.SelectedIndex);
            }
        }

        private void AddtoDwarfM_Click(object sender, EventArgs e)
        {
            DwarfMList.Items.Add(DwarfMInput.Text);
            DwarfMInput.Text = "";
        }

        private void RemoveFromDwarfM_Click(object sender, EventArgs e)
        {
            if (DwarfMList.SelectedIndex == -1)
            { }
            else
            { 
                DwarfMList.Items.RemoveAt(DwarfMList.SelectedIndex);
            }
        }

        private void AddtoDwarfF_Click(object sender, EventArgs e)
        {
            DwarfFList.Items.Add(DwarfFInput.Text);
            DwarfFInput.Text = "";
        }

        private void RemoveFromDwarfF_Click(object sender, EventArgs e)
        {
            if (DwarfFList.SelectedIndex == -1)
            { }
            else
            {
                DwarfFList.Items.RemoveAt(DwarfFList.SelectedIndex);
            }
        }

        private void AddtoHalflingM_Click(object sender, EventArgs e)
        {
            HalflingMList.Items.Add(HalflingMInput.Text);
            HalflingMInput.Text = "";
        }

        private void RemoveFromHalflingM_Click(object sender, EventArgs e)
        {
            if (HalflingMList.SelectedIndex == -1)
            { }
            else
            {
                HalflingMList.Items.RemoveAt(HalflingMList.SelectedIndex);
            }
        }

        private void AddtoHalflingF_Click(object sender, EventArgs e)
        {
            HalflingFList.Items.Add(HalflingFInput.Text);
            HalflingFInput.Text = "";
        }

        private void RemoveFromHalflingF_Click(object sender, EventArgs e)
        {
            if (HalflingFList.SelectedIndex == -1)
            { }
            else
            {
                HalflingFList.Items.RemoveAt(HalflingFList.SelectedIndex);
            }
        }

        private void AddtoGnomeM_Click(object sender, EventArgs e)
        {
            GnomeMList.Items.Add(GnomeMInput.Text);
            GnomeMInput.Text = "";
        }

        private void RemovefromGnomeM_Click(object sender, EventArgs e)
        {
            if (GnomeMList.SelectedIndex == -1)
            { }
            else
            {
                GnomeMList.Items.RemoveAt(GnomeMList.SelectedIndex);
            }
        }

        private void AddtoGnomeF_Click(object sender, EventArgs e)
        {
            GnomeFList.Items.Add(GnomeFInput.Text);
            GnomeFInput.Text = "";
        }

        private void RemoveFromGnomeF_Click(object sender, EventArgs e)
        {
            if (GnomeFList.SelectedIndex == -1)
            { }
            else
            {
                GnomeFList.Items.RemoveAt(GnomeFList.SelectedIndex);
            }
        }

        private void AddtoDragonbornM_Click(object sender, EventArgs e)
        {
            DragonbornMList.Items.Add(DragonbornMInput.Text);
            DragonbornMInput.Text = "";
        }

        private void RemoveFromDragonbornM_Click(object sender, EventArgs e)
        {
            if (DragonbornMList.SelectedIndex == -1)
            {

            }
            else
            {
                DragonbornMList.Items.RemoveAt(DragonbornMList.SelectedIndex);
            }
        }

        private void AddtoDragonbornF_Click(object sender, EventArgs e)
        {
            DragonbornFList.Items.Add(DragonbornFInput.Text);
            DragonbornFInput.Text = "";
        }

        private void RemoveFromDragonbornF_Click(object sender, EventArgs e)
        {
            if (DragonbornFList.SelectedIndex == -1)
            {
                
            }
            else
            {
                DragonbornFList.Items.RemoveAt(DragonbornFList.SelectedIndex);
            }
        }
    }
}
