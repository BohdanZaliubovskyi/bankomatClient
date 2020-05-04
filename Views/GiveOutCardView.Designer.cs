namespace BankomatClient.Views
{
    partial class GiveOutCardView
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
            this.buttonGetCard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCardStatuses = new System.Windows.Forms.ComboBox();
            this.richTextBoxCardInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonPersonalArea
            // 
            this.buttonPersonalArea.Location = new System.Drawing.Point(583, 217);
            this.buttonPersonalArea.Size = new System.Drawing.Size(229, 29);
            // 
            // labelBalance
            // 
            this.labelBalance.Location = new System.Drawing.Point(612, 197);
            // 
            // buttonGetCard
            // 
            this.buttonGetCard.Location = new System.Drawing.Point(311, 449);
            this.buttonGetCard.Name = "buttonGetCard";
            this.buttonGetCard.Size = new System.Drawing.Size(332, 38);
            this.buttonGetCard.TabIndex = 5;
            this.buttonGetCard.Text = "Получить карту";
            this.buttonGetCard.UseVisualStyleBackColor = true;
            this.buttonGetCard.Click += new System.EventHandler(this.buttonGetCard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вид карты";
            // 
            // comboBoxCardStatuses
            // 
            this.comboBoxCardStatuses.FormattingEnabled = true;
            this.comboBoxCardStatuses.Location = new System.Drawing.Point(200, 303);
            this.comboBoxCardStatuses.Name = "comboBoxCardStatuses";
            this.comboBoxCardStatuses.Size = new System.Drawing.Size(211, 24);
            this.comboBoxCardStatuses.TabIndex = 7;
            this.comboBoxCardStatuses.SelectedValueChanged += new System.EventHandler(this.comboBoxCardStatuses_SelectedValueChanged);
            // 
            // richTextBoxCardInfo
            // 
            this.richTextBoxCardInfo.Location = new System.Drawing.Point(473, 268);
            this.richTextBoxCardInfo.Name = "richTextBoxCardInfo";
            this.richTextBoxCardInfo.Size = new System.Drawing.Size(339, 166);
            this.richTextBoxCardInfo.TabIndex = 8;
            this.richTextBoxCardInfo.Text = "";
            // 
            // GiveOutCardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBoxCardInfo);
            this.Controls.Add(this.comboBoxCardStatuses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGetCard);
            this.Name = "GiveOutCardView";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.buttonToStartPage, 0);
            this.Controls.SetChildIndex(this.buttonPersonalArea, 0);
            this.Controls.SetChildIndex(this.labelBalance, 0);
            this.Controls.SetChildIndex(this.labelPageName, 0);
            this.Controls.SetChildIndex(this.labelInstructions, 0);
            this.Controls.SetChildIndex(this.labelDetails, 0);
            this.Controls.SetChildIndex(this.labelNotifyMessage, 0);
            this.Controls.SetChildIndex(this.buttonGetCard, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.comboBoxCardStatuses, 0);
            this.Controls.SetChildIndex(this.richTextBoxCardInfo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCardStatuses;
        private System.Windows.Forms.RichTextBox richTextBoxCardInfo;
    }
}
