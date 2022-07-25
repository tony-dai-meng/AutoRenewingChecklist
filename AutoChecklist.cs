using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AutoRenewingChecklist
{
    public enum frequency
    {
        Once, Daily, Weekly, Monthly
    }

    public partial class AutoChecklist : Form
    {
        public const string xmlPath = @".\XMLSettingsFile.xml";

        private Queue<item> checkListBoxItems = new Queue<item>();

        public AutoChecklist()
        {
            InitializeComponent();
            InitializeChecklist();
        }
        
        public void InitializeChecklist()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            var checkListItems = checkedListBox1.Items;
            this.checkListBoxItems = parseXMLChecklist(doc);
            foreach (item i in this.checkListBoxItems)
            {
                if ((DateTime.Now > i.GetDateTime()) && i.getCheck())
                {
                    //reset date time
                    i.resetDateTime();
                    xmlHelper.EditXmlNode(AutoChecklist.xmlPath, "item", "text", i.getText(), "date", i.updateUncheckdate().ToString("dd/MM/yyyy"));
                    //reset checked time
                    xmlHelper.EditXmlNode(xmlPath, "item", "text", i.getText(), "checked", "false");
                    i.setCheck(false);
                }
                checkListItems.Add(i.getText(), i.getCheck());
            }
        }

        public CheckedListBox getCheckListBox()
        {
            return checkedListBox1;
        }

        private Queue<item> parseXMLChecklist(XmlDocument doc)
        {
            Queue<item> result = new Queue<item>();
            XmlNode currentNode;
            XmlNode currentSubNode;
            foreach (var accountNode in doc.LastChild.ChildNodes)
            {
                item newItem = new item();
                currentNode = accountNode as XmlNode;
                foreach (var subItemNode in currentNode.ChildNodes)
                {
                    currentSubNode = subItemNode as XmlNode;
                    switch (currentSubNode.Name)
                    {
                        case "text":
                            // assign text status
                            newItem.setText(currentSubNode.InnerText);
                            break;
                        case "checked":
                            // assign checked status
                            bool chk;
                            Boolean.TryParse(currentSubNode.InnerText, out chk);
                            newItem.setCheck(chk);
                            break;
                        case "freq":
                            // assign freq
                            frequency f;
                            f = (frequency)Enum.Parse(typeof(frequency), currentSubNode.InnerText, true);
                            newItem.setFreq(f);
                            break;
                        case "date":
                            // assign date
                            string[] dateFormats = new[] {"dd/MM/yyyy"};
                            CultureInfo provider = new CultureInfo("en-US");
                            DateTime date = DateTime.ParseExact(currentSubNode.InnerText, dateFormats, provider, DateTimeStyles.AdjustToUniversal);
                            newItem.setDateTime(date);
                            break;
                    }
                }
                result.Enqueue(newItem);
            }
            //return result;
            return result;
        }

        /// <summary>
        /// When click button is pressed the task setter form is opened.
        /// </summary>
        /// <param name="sender"> Object </param>
        /// <param name="e"> Event handler </param>
        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            TaskSetter ts = new TaskSetter();
            ts.Show();
        }

        /// <summary>
        /// Checklist box item checked changes parses the checklistbox and updates the XML file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkedListBox1_ItemCheckChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Deletes selected item from the list and the XML file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DeleteItems_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(xmlPath);

            for (int i = 0; i < checkedListBox1.SelectedItems.Count; i++)
            {
                string txt = checkedListBox1.SelectedItems[i].ToString();
                checkedListBox1.Items.Remove(checkedListBox1.SelectedItems[i]);
                xmlHelper.DeleteXmlNode(xmlPath, "item", "text", txt);
            }
        }

        private void AutoChecklist_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_MouseDoubleClick(object sender, EventArgs e)
        {
            string itemName = checkedListBox1.SelectedItem.ToString();
            IEnumerator<item> enumerator = this.checkListBoxItems.GetEnumerator();

            while (enumerator.MoveNext())
            {
                if (enumerator.Current.getText() == itemName) {
                    InfoBox ib = new InfoBox(enumerator.Current);
                    ib.Show();
                    break;
                }
            }
        }
    }

    public class item
    {
        private string text;
        private bool check;
        private frequency freq;
        private DateTime dt;

        public item()
        {
            text = "";
            check = false;
            freq = frequency.Once;
            dt = DateTime.Now;
        }

        public item(string text, bool check, frequency freq, DateTime dt)
        {
            this.text = text;
            this.check = check;
            this.freq = freq;
            this.dt = dt;
        }

        public string getText()
        {
            return text;
        }
        public bool getCheck()
        {
            return check;
        }
        public frequency getFreq()
        {
            return freq;
        }
        public DateTime GetDateTime()
        {
            return dt;
        }
        public void setText(string text)
        {
            this.text = text;
        }
        public void setCheck(bool check)
        {
            this.check = check;
        }
        public void setFreq(frequency freq)
        {
            this.freq = freq;
        }
        public void resetDateTime()
        {
            this.dt = DateTime.Now;
        }
        public void setDateTime(DateTime dt)
        {
            this.dt = dt;
        }
        public DateTime updateUncheckdate()
        {
            switch (this.freq)
            {
                case frequency.Daily:
                    this.dt = this.dt.AddDays(1);
                    break;
                case frequency.Monthly:
                    this.dt = this.dt.AddMonths(1);
                    break;
                case frequency.Weekly:
                    this.dt = this.dt.AddDays(7);
                    break;
                case frequency.Once:
                    //TODO delete object
                    break;
            }
            return this.dt;
        }

        //Adds an item to the checklist aswell as the XMLsettingsFile
        public void addItemToChecklist(CheckedListBox CheckListBox, XDocument doc)
        {
            CheckListBox.Items.Add(this.text, this.check);
            XElement node = new XElement("item");
            node.Add(new XElement("text", this.text));
            node.Add(new XElement("checked", this.check));
            node.Add(new XElement("freq", this.freq));
            node.Add(new XElement("date", this.dt.ToString("dd/MM/yyyy")));
            doc.Root.Add(node);
            doc.Save(AutoChecklist.xmlPath);
        }
    }

    public class xmlHelper
    {


        /// <summary>
        /// This function is use for delete xml node dynamically.
        /// </summary>
        /// <param name="path">xml file path</param>
        /// <param name="tagname">root tagname</param>
        /// <param name="searchconditionAttributename">Search Attribute Name</param>
        /// <param name="searchconditionAttributevalue">Search Attribute Value</param>

        public static void DeleteXmlNode(string path, string tagname, string searchconditionChildname, string searchconditionChildvalue)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNodeList nodes = doc.GetElementsByTagName(tagname);
            
            foreach (XmlNode node in nodes)
            {
                foreach (XmlNode childNode in node.ChildNodes)
                {
                    if ((childNode.Name == searchconditionChildname) && (childNode.InnerText == searchconditionChildvalue))
                    {
                        //delete item node contents and node itself
                        node.RemoveAll();
                        node.ParentNode.RemoveChild(node);
                        //save xml file.
                        //return xml.
                        doc.Save(path);
                        return;
                    }
                }
            }
        }


        /// <summary>
        /// This function is use for edit node in xml.
        /// </summary>
        /// <param name="path">xml file path</param>
        /// <param name="tagname">root tagname</param>
        /// <param name="searchconditionAttributename">Search Attribute Name</param>
        /// <param name="searchconditionAttributevalue">Search Attribute Value</param>
        /// <param name="editAttributename">Edit Attribute Name</param>
        /// <param name="editAttributevalue">Edit Attribute Value</param>

        public static void EditXmlNode(string path, string tagname, string searchconditionNodename, string searchconditionNodevalue, string editNodename, string editNodevalue)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNodeList nodes = doc.GetElementsByTagName(tagname);
            foreach (XmlNode node in nodes)
            {
                //Check attribute eixt which we want to edit.
                bool isEdit = false;
                foreach (XmlNode childNode in node.ChildNodes)
                {
                    if ((childNode.Name == searchconditionNodename) && (childNode.InnerText == searchconditionNodevalue))
                    {
                        isEdit = true;
                    }
                    if (isEdit)
                    {
                        // if (attribute.Name == "expireson")
                        if (childNode.Name == editNodename)
                        {
                            //attribute.Value = "2011-12-28";
                            childNode.InnerText = editNodevalue;
                            break;
                        }
                    }
                }
            }
            //save xml file.
            doc.Save(path);
        }

    }
}
