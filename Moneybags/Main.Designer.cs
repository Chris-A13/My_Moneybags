﻿namespace Moneybags
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.welcomeLabel = new MetroFramework.Controls.MetroLabel();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.createNewInvoicePictureBox = new System.Windows.Forms.PictureBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.createNewInvoiceLabel = new System.Windows.Forms.Label();
            this.choosePersonaLabel = new System.Windows.Forms.Label();
            this.choosePersonaPictureBox = new System.Windows.Forms.PictureBox();
            this.aboutLabel = new MetroFramework.Controls.MetroLabel();
            this.updateNotifyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.createNewInvoicePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choosePersonaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.welcomeLabel.Location = new System.Drawing.Point(23, 60);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(258, 25);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Please create a Persona to begin";
            // 
            // createNewInvoicePictureBox
            // 
            this.metroStyleExtender1.SetApplyMetroTheme(this.createNewInvoicePictureBox, true);
            this.createNewInvoicePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.createNewInvoicePictureBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.createNewInvoicePictureBox.Image = global::Moneybags.Properties.Resources.newinvoiceicon;
            this.createNewInvoicePictureBox.Location = new System.Drawing.Point(23, 110);
            this.createNewInvoicePictureBox.Name = "createNewInvoicePictureBox";
            this.createNewInvoicePictureBox.Size = new System.Drawing.Size(315, 317);
            this.createNewInvoicePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.createNewInvoicePictureBox.TabIndex = 1;
            this.createNewInvoicePictureBox.TabStop = false;
            this.createNewInvoicePictureBox.Click += new System.EventHandler(this.CreateNewInvoicePictureBox_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // createNewInvoiceLabel
            // 
            this.createNewInvoiceLabel.BackColor = System.Drawing.Color.Transparent;
            this.createNewInvoiceLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewInvoiceLabel.Location = new System.Drawing.Point(23, 406);
            this.createNewInvoiceLabel.Name = "createNewInvoiceLabel";
            this.createNewInvoiceLabel.Size = new System.Drawing.Size(315, 23);
            this.createNewInvoiceLabel.TabIndex = 3;
            this.createNewInvoiceLabel.Text = "Create an Invoice";
            // 
            // choosePersonaLabel
            // 
            this.choosePersonaLabel.BackColor = System.Drawing.Color.Transparent;
            this.choosePersonaLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosePersonaLabel.Location = new System.Drawing.Point(349, 406);
            this.choosePersonaLabel.Name = "choosePersonaLabel";
            this.choosePersonaLabel.Size = new System.Drawing.Size(315, 23);
            this.choosePersonaLabel.TabIndex = 4;
            this.choosePersonaLabel.Text = "Choose Persona";
            // 
            // choosePersonaPictureBox
            // 
            this.choosePersonaPictureBox.Image = global::Moneybags.Properties.Resources.choosepersonaicon1;
            this.choosePersonaPictureBox.Location = new System.Drawing.Point(349, 110);
            this.choosePersonaPictureBox.Name = "choosePersonaPictureBox";
            this.choosePersonaPictureBox.Size = new System.Drawing.Size(315, 317);
            this.choosePersonaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.choosePersonaPictureBox.TabIndex = 2;
            this.choosePersonaPictureBox.TabStop = false;
            this.choosePersonaPictureBox.Click += new System.EventHandler(this.ChoosePersonaPictureBox_Click);
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Location = new System.Drawing.Point(629, 64);
            this.aboutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(45, 19);
            this.aboutLabel.TabIndex = 5;
            this.aboutLabel.Text = "About";
            this.aboutLabel.Click += new System.EventHandler(this.AboutLabel_Click);
            // 
            // updateNotifyLabel
            // 
            this.updateNotifyLabel.AutoSize = true;
            this.updateNotifyLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateNotifyLabel.Location = new System.Drawing.Point(24, 440);
            this.updateNotifyLabel.Name = "updateNotifyLabel";
            this.updateNotifyLabel.Size = new System.Drawing.Size(0, 13);
            this.updateNotifyLabel.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 460);
            this.Controls.Add(this.updateNotifyLabel);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.choosePersonaLabel);
            this.Controls.Add(this.createNewInvoiceLabel);
            this.Controls.Add(this.choosePersonaPictureBox);
            this.Controls.Add(this.createNewInvoicePictureBox);
            this.Controls.Add(this.welcomeLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Welcome to Moneybags";
            ((System.ComponentModel.ISupportInitialize)(this.createNewInvoicePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choosePersonaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel welcomeLabel;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.PictureBox choosePersonaPictureBox;
        private System.Windows.Forms.Label createNewInvoiceLabel;
        private System.Windows.Forms.Label choosePersonaLabel;
        private System.Windows.Forms.PictureBox createNewInvoicePictureBox;
        private MetroFramework.Controls.MetroLabel aboutLabel;
        private System.Windows.Forms.Label updateNotifyLabel;
    }
}

