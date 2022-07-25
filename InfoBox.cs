using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRenewingChecklist
{
    public partial class InfoBox : Form
    {
        private item i;
 
        public InfoBox()
        {
            InitializeComponent();
        }

        public InfoBox(item i)
        {
            InitializeComponent();
            this.i = i;
            descTask.Text = i.getText();
            foreach (string s in Enum.GetNames(typeof(AutoRenewingChecklist.frequency)))
            {
                cb_freq.Items.Add(s);
            }
            cb_freq.Text = i.getFreq().ToString();
            reminderDate.Text = i.GetDateTime().ToString("dd/MM/yyyy");
        }

        /// <summary>
        /// Action when apply button is clicked. Initialisation happens as well as refresh of the first form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_apply_Click(object sender, EventArgs e)
        {
            //XML node edit for freq and text value is changed
            xmlHelper.EditXmlNode(AutoChecklist.xmlPath, "item", "text", i.getText(), "freq", cb_freq.Text);
            i.setFreq((frequency)Enum.Parse(typeof(frequency), cb_freq.Text));
            //XML node edit for check value to unchecked
            xmlHelper.EditXmlNode(AutoChecklist.xmlPath, "item", "text", i.getText(), "checked", "false");
            i.setCheck(false);
            //XML node edit for date amd text value is changed
            i.resetDateTime();
            xmlHelper.EditXmlNode(AutoChecklist.xmlPath, "item", "text", i.getText(), "date", i.updateUncheckdate().ToString("dd/MM/yyyy"));
            //XML node edit for text and text value is changed
            xmlHelper.EditXmlNode(AutoChecklist.xmlPath, "item", "text", i.getText(), "text", descTask.Text);
            i.setText(descTask.Text);

            Program.getAutoChecklist().getCheckListBox().Items.Clear();
            Program.getAutoChecklist().InitializeChecklist();
            this.Close();
        }
    }
}
