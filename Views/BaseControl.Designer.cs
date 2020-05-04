namespace BankomatClient.Views
{
    partial class BaseControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseControl));
            this.labelPageName = new System.Windows.Forms.Label();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonToStartPage = new System.Windows.Forms.Button();
            this.labelNotifyMessage = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.transparentPictureBoxLedLight = new BankomatClient.Views.TransparentPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.transparentPictureBoxLedLight)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPageName
            // 
            this.labelPageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPageName.AutoSize = true;
            this.labelPageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPageName.Location = new System.Drawing.Point(184, 122);
            this.labelPageName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPageName.Name = "labelPageName";
            this.labelPageName.Size = new System.Drawing.Size(149, 31);
            this.labelPageName.TabIndex = 0;
            this.labelPageName.Text = "PageName";
            this.labelPageName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstructions.Location = new System.Drawing.Point(186, 202);
            this.labelInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(96, 20);
            this.labelInstructions.TabIndex = 1;
            this.labelInstructions.Text = "Instructions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "_____________________________________________________________________________";
            // 
            // buttonToStartPage
            // 
            this.buttonToStartPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToStartPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToStartPage.Location = new System.Drawing.Point(677, 130);
            this.buttonToStartPage.Margin = new System.Windows.Forms.Padding(4);
            this.buttonToStartPage.Name = "buttonToStartPage";
            this.buttonToStartPage.Size = new System.Drawing.Size(124, 43);
            this.buttonToStartPage.TabIndex = 3;
            this.buttonToStartPage.Text = "В начало";
            this.buttonToStartPage.UseVisualStyleBackColor = true;
            this.buttonToStartPage.Click += new System.EventHandler(this.buttonToStartPage_Click);
            // 
            // labelNotifyMessage
            // 
            this.labelNotifyMessage.AutoSize = true;
            this.labelNotifyMessage.Location = new System.Drawing.Point(202, 264);
            this.labelNotifyMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNotifyMessage.Name = "labelNotifyMessage";
            this.labelNotifyMessage.Size = new System.Drawing.Size(46, 17);
            this.labelNotifyMessage.TabIndex = 4;
            this.labelNotifyMessage.Text = "label2";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDetails.Location = new System.Drawing.Point(186, 171);
            this.labelDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(62, 20);
            this.labelDetails.TabIndex = 1;
            this.labelDetails.Text = "Details";
            // 
            // transparentPictureBoxLedLight
            // 
            this.transparentPictureBoxLedLight.BackColor = System.Drawing.Color.Transparent;
            this.transparentPictureBoxLedLight.Image = ((System.Drawing.Image)(resources.GetObject("transparentPictureBoxLedLight.Image")));
            this.transparentPictureBoxLedLight.Location = new System.Drawing.Point(781, 568);
            this.transparentPictureBoxLedLight.Name = "transparentPictureBoxLedLight";
            this.transparentPictureBoxLedLight.Size = new System.Drawing.Size(47, 21);
            this.transparentPictureBoxLedLight.TabIndex = 5;
            this.transparentPictureBoxLedLight.TabStop = false;
            // 
            // BaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::BankomatClient.Properties.Resources.atm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.transparentPictureBoxLedLight);
            this.Controls.Add(this.labelNotifyMessage);
            this.Controls.Add(this.buttonToStartPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.labelPageName);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 760);
            this.Name = "BaseControl";
            this.Size = new System.Drawing.Size(1000, 760);
            this.Load += new System.EventHandler(this.BaseControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transparentPictureBoxLedLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label labelInstructions;
        protected System.Windows.Forms.Label labelPageName;
        protected System.Windows.Forms.Label labelNotifyMessage;
        protected System.Windows.Forms.Label labelDetails;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button buttonToStartPage;
        private TransparentPictureBox transparentPictureBoxLedLight;
    }
}
