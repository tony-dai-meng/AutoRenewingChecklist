namespace AutoRenewingChecklist
{
    partial class AutoChecklist
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.btn_DeleteItems = new System.Windows.Forms.Button();
            this.btn_Disable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(225, 409);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Location = new System.Drawing.Point(12, 427);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(225, 24);
            this.btn_AddItem.TabIndex = 1;
            this.btn_AddItem.Text = "Add item";
            this.btn_AddItem.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteItems
            // 
            this.btn_DeleteItems.Location = new System.Drawing.Point(12, 487);
            this.btn_DeleteItems.Name = "btn_DeleteItems";
            this.btn_DeleteItems.Size = new System.Drawing.Size(225, 24);
            this.btn_DeleteItems.TabIndex = 2;
            this.btn_DeleteItems.Text = "Delete item(s)";
            this.btn_DeleteItems.UseVisualStyleBackColor = true;
            // 
            // btn_Disable
            // 
            this.btn_Disable.Location = new System.Drawing.Point(11, 457);
            this.btn_Disable.Name = "btn_Disable";
            this.btn_Disable.Size = new System.Drawing.Size(225, 24);
            this.btn_Disable.TabIndex = 3;
            this.btn_Disable.Text = "Disable temporarily";
            this.btn_Disable.UseVisualStyleBackColor = true;
            // 
            // AutoChecklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 518);
            this.Controls.Add(this.btn_Disable);
            this.Controls.Add(this.btn_DeleteItems);
            this.Controls.Add(this.btn_AddItem);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "AutoChecklist";
            this.Text = "Routine planner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.Button btn_DeleteItems;
        private System.Windows.Forms.Button btn_Disable;
    }
}

