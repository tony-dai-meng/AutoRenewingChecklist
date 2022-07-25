namespace AutoRenewingChecklist
{
    partial class TaskSetter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddItemButton = new System.Windows.Forms.Button();
            this.FrequencyPicker = new System.Windows.Forms.ComboBox();
            this.descTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(12, 177);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(283, 21);
            this.AddItemButton.TabIndex = 0;
            this.AddItemButton.Text = "Add item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // FrequencyPicker
            // 
            this.FrequencyPicker.FormattingEnabled = true;
            this.FrequencyPicker.Location = new System.Drawing.Point(12, 150);
            this.FrequencyPicker.Name = "FrequencyPicker";
            this.FrequencyPicker.Size = new System.Drawing.Size(283, 21);
            this.FrequencyPicker.TabIndex = 1;
            // 
            // descTask
            // 
            this.descTask.Location = new System.Drawing.Point(12, 25);
            this.descTask.Multiline = true;
            this.descTask.Name = "descTask";
            this.descTask.Size = new System.Drawing.Size(283, 103);
            this.descTask.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Description of task";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Frequency";
            // 
            // TaskSetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 209);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descTask);
            this.Controls.Add(this.FrequencyPicker);
            this.Controls.Add(this.AddItemButton);
            this.Name = "TaskSetter";
            this.Text = "Set task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.ComboBox FrequencyPicker;
        private System.Windows.Forms.TextBox descTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}