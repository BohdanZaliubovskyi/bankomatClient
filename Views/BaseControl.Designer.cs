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
            this.labelPageName = new System.Windows.Forms.Label();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonToStartPage = new System.Windows.Forms.Button();
            this.labelNotifyMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPageName
            // 
            this.labelPageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPageName.AutoSize = true;
            this.labelPageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPageName.Location = new System.Drawing.Point(109, 31);
            this.labelPageName.Name = "labelPageName";
            this.labelPageName.Size = new System.Drawing.Size(118, 25);
            this.labelPageName.TabIndex = 0;
            this.labelPageName.Text = "PageName";
            this.labelPageName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstructions.Location = new System.Drawing.Point(111, 83);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(74, 16);
            this.labelInstructions.TabIndex = 1;
            this.labelInstructions.Text = "Instructions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "_________________________________________________________________________________" +
    "__";
            // 
            // buttonToStartPage
            // 
            this.buttonToStartPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToStartPage.Location = new System.Drawing.Point(534, 31);
            this.buttonToStartPage.Name = "buttonToStartPage";
            this.buttonToStartPage.Size = new System.Drawing.Size(93, 35);
            this.buttonToStartPage.TabIndex = 3;
            this.buttonToStartPage.Text = "В начало";
            this.buttonToStartPage.UseVisualStyleBackColor = true;
            this.buttonToStartPage.Click += new System.EventHandler(this.buttonToStartPage_Click);
            // 
            // labelNotifyMessage
            // 
            this.labelNotifyMessage.AutoSize = true;
            this.labelNotifyMessage.Location = new System.Drawing.Point(178, 149);
            this.labelNotifyMessage.Name = "labelNotifyMessage";
            this.labelNotifyMessage.Size = new System.Drawing.Size(35, 13);
            this.labelNotifyMessage.TabIndex = 4;
            this.labelNotifyMessage.Text = "label2";
            // 
            // BaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNotifyMessage);
            this.Controls.Add(this.buttonToStartPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.labelPageName);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "BaseControl";
            this.Size = new System.Drawing.Size(750, 550);
            this.Load += new System.EventHandler(this.BaseControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label labelInstructions;
        protected System.Windows.Forms.Label labelPageName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonToStartPage;
        protected System.Windows.Forms.Label labelNotifyMessage;
    }
}
