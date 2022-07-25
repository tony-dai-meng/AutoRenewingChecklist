namespace AutoRenewingChecklist
{
    partial class InfoBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.descTask = new System.Windows.Forms.TextBox();
            this.reminderDate = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Button();
            this.cb_freq = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frequency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Next reminder date";
            // 
            // descTask
            // 
            this.descTask.Location = new System.Drawing.Point(132, 18);
            this.descTask.Multiline = true;
            this.descTask.Name = "descTask";
            this.descTask.Size = new System.Drawing.Size(175, 43);
            this.descTask.TabIndex = 4;
            // 
            // reminderDate
            // 
            this.reminderDate.AutoSize = true;
            this.reminderDate.Location = new System.Drawing.Point(132, 92);
            this.reminderDate.Name = "reminderDate";
            this.reminderDate.Size = new System.Drawing.Size(0, 13);
            this.reminderDate.TabIndex = 6;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(83, 121);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(147, 24);
            this.btn_apply.TabIndex = 7;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // cb_freq
            // 
            this.cb_freq.FormattingEnabled = true;
            this.cb_freq.Location = new System.Drawing.Point(132, 67);
            this.cb_freq.Name = "cb_freq";
            this.cb_freq.Size = new System.Drawing.Size(174, 21);
            this.cb_freq.TabIndex = 8;
            // 
            // InfoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 157);
            this.Controls.Add(this.cb_freq);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.reminderDate);
            this.Controls.Add(this.descTask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InfoBox";
            this.Text = "InfoBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descTask;
        private System.Windows.Forms.Label reminderDate;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.ComboBox cb_freq;
    }
}