namespace AutoUpdaterDotNetCore
{
    partial class RemindLaterForm
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
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.comboBoxRemindLater = new System.Windows.Forms.ComboBox();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxIcon.Image = global::AutoUpdaterDotNetCore.Properties.Resources.clock_go_32;
            this.pictureBoxIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxIcon.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.tableLayoutPanel.SetRowSpan(this.pictureBoxIcon, 2);
            this.pictureBoxIcon.Size = new System.Drawing.Size(79, 90);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxIcon.TabIndex = 1;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.labelTitle, 2);
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTitle.Location = new System.Drawing.Point(88, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(409, 19);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Do you want to download updates later?";
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.radioButtonNo, 2);
            this.radioButtonNo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radioButtonNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.radioButtonNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioButtonNo.Location = new System.Drawing.Point(91, 138);
            this.radioButtonNo.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(406, 19);
            this.radioButtonNo.TabIndex = 4;
            this.radioButtonNo.Text = "No, download updates now (recommended)";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // comboBoxRemindLater
            // 
            this.comboBoxRemindLater.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comboBoxRemindLater.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRemindLater.FormattingEnabled = true;
            this.comboBoxRemindLater.Items.AddRange(new object[] {
            "After 30 minutes",
            "After 12 hours",
            "After 1 day",
            "After 2 days",
            "After 4 days",
            "After 8 days",
            "After 10 days"});
            this.comboBoxRemindLater.Location = new System.Drawing.Point(375, 104);
            this.comboBoxRemindLater.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.comboBoxRemindLater.Name = "comboBoxRemindLater";
            this.comboBoxRemindLater.Size = new System.Drawing.Size(115, 21);
            this.comboBoxRemindLater.TabIndex = 5;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Checked = true;
            this.radioButtonYes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radioButtonYes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radioButtonYes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioButtonYes.Location = new System.Drawing.Point(91, 106);
            this.radioButtonYes.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(271, 19);
            this.radioButtonYes.TabIndex = 3;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes, please remind me later : ";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.labelDescription, 2);
            this.labelDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDescription.Location = new System.Drawing.Point(88, 51);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(409, 45);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "You should download updates now. This only takes few minutes depending on your in" +
    "ternet connection and ensures you have latest version of the application.\r\n";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOK.Image = global::AutoUpdaterDotNetCore.Properties.Resources.clock_play;
            this.buttonOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOK.Location = new System.Drawing.Point(375, 163);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(115, 32);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel.Controls.Add(this.pictureBoxIcon, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelTitle, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.radioButtonNo, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.comboBoxRemindLater, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.radioButtonYes, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelDescription, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonOK, 2, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(499, 198);
            this.tableLayoutPanel.TabIndex = 8;
            // 
            // RemindLaterForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 198);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "RemindLaterForm2";
            this.Text = "RemindLaterForm2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.ComboBox comboBoxRemindLater;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonOK;
    }
}