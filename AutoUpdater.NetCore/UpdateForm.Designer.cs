namespace AutoUpdaterDotNetCore
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelReleaseNotes = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.buttonRemindLater = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::AutoUpdaterDotNetCore.Properties.Resources.update;
            this.pictureBoxIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxIcon.Location = new System.Drawing.Point(11, 13);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(70, 66);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxIcon.TabIndex = 16;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelReleaseNotes
            // 
            resources.ApplyResources(this.labelReleaseNotes, "labelReleaseNotes");
            this.labelReleaseNotes.AutoSize = true;
            this.labelReleaseNotes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelReleaseNotes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelReleaseNotes.Location = new System.Drawing.Point(90, 89);
            this.labelReleaseNotes.Name = "labelReleaseNotes";
            this.labelReleaseNotes.Size = new System.Drawing.Size(98, 17);
            this.labelReleaseNotes.TabIndex = 15;
            // 
            // labelDescription
            // 
            resources.ApplyResources(this.labelDescription, "labelDescription");
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDescription.Location = new System.Drawing.Point(90, 49);
            this.labelDescription.MaximumSize = new System.Drawing.Size(550, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(479, 15);
            this.labelDescription.TabIndex = 14;
            // 
            // labelUpdate
            // 
            resources.ApplyResources(this.labelUpdate, "labelUpdate");
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelUpdate.Location = new System.Drawing.Point(90, 13);
            this.labelUpdate.MaximumSize = new System.Drawing.Size(550, 0);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(227, 19);
            this.labelUpdate.TabIndex = 13;
            // 
            // webBrowser
            // 
            resources.ApplyResources(this.webBrowser, "webBrowser");
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(93, 119);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowser.MinimumSize = new System.Drawing.Size(23, 23);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(538, 432);
            this.webBrowser.TabIndex = 9;
            // 
            // buttonUpdate
            // 
            resources.ApplyResources(this.buttonUpdate, "buttonUpdate");
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonUpdate.Image = global::AutoUpdaterDotNetCore.Properties.Resources.download;
            this.buttonUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonUpdate.Location = new System.Drawing.Point(478, 572);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.Size = new System.Drawing.Size(153, 28);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);

            // 
            // buttonSkip
            // 
            resources.ApplyResources(this.buttonSkip, "buttonSkip");
            this.buttonSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSkip.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.buttonSkip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSkip.Image = global::AutoUpdaterDotNetCore.Properties.Resources.hand_point;
            this.buttonSkip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSkip.Location = new System.Drawing.Point(94, 572);
            this.buttonSkip.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Text = "Skip this version";
            this.buttonSkip.Size = new System.Drawing.Size(153, 28);
            this.buttonSkip.TabIndex = 10;
            this.buttonSkip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSkip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSkip.UseVisualStyleBackColor = true;
            this.buttonSkip.Click += new System.EventHandler(this.ButtonSkipClick);
            // 
            // buttonRemindLater
            // 
            resources.ApplyResources(this.buttonRemindLater, "buttonRemindLater");
            this.buttonRemindLater.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemindLater.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRemindLater.Image = global::AutoUpdaterDotNetCore.Properties.Resources.clock_go;
            this.buttonRemindLater.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRemindLater.Location = new System.Drawing.Point(321, 572);
            this.buttonRemindLater.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemindLater.Name = "buttonRemindLater";
            this.buttonRemindLater.Text = "Remind me later";
            this.buttonRemindLater.Size = new System.Drawing.Size(153, 28);
            this.buttonRemindLater.TabIndex = 12;
            this.buttonRemindLater.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRemindLater.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRemindLater.UseVisualStyleBackColor = true;
            this.buttonRemindLater.Click += new System.EventHandler(this.ButtonRemindLaterClick);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonUpdate;
            resources.ApplyResources(this, "$this");
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 612);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.labelReleaseNotes);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.buttonRemindLater);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateForm_FormClosed);
            this.Load += new System.EventHandler(this.UpdateFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelReleaseNotes;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.Button buttonRemindLater;
    }
}