using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AutoRenewingChecklist
{
    public partial class TaskSetter : Form
    {
        public TaskSetter()
        {
            InitializeComponent();
            InitializeFreqOptions();
            
        }


        private void InitializeFreqOptions()
        {
            // Frequency picker adding each value for enum.
            foreach (string i in Enum.GetNames(typeof(AutoRenewingChecklist.frequency)))
            {
                FrequencyPicker.Items.Add(i);
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            frequency f = (frequency)Enum.Parse(typeof(frequency), FrequencyPicker.Text, true);
            item i = new item(descTask.Text, false, f, DateTime.Now);
            var doc = XDocument.Load(AutoChecklist.xmlPath);
            i.addItemToChecklist(Program.getAutoChecklist().getCheckListBox(), doc);
        }

    }
}
