namespace BankomatClient.Views
{
    partial class LoginView
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
            this.buttonInsertCard = new System.Windows.Forms.Button();
            this.buttonAddCash = new System.Windows.Forms.Button();
            this.buttonGetCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInstructions
            // 
            this.labelInstructions.Location = new System.Drawing.Point(188, 212);
            // 
            // labelPageName
            // 
            this.labelPageName.Location = new System.Drawing.Point(186, 132);
            // 
            // labelDetails
            // 
            this.labelDetails.Location = new System.Drawing.Point(188, 181);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(189, 241);
            // 
            // buttonToStartPage
            // 
            this.buttonToStartPage.Location = new System.Drawing.Point(689, 132);
            // 
            // buttonInsertCard
            // 
            this.buttonInsertCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInsertCard.Location = new System.Drawing.Point(220, 299);
            this.buttonInsertCard.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInsertCard.Name = "buttonInsertCard";
            this.buttonInsertCard.Size = new System.Drawing.Size(269, 58);
            this.buttonInsertCard.TabIndex = 2;
            this.buttonInsertCard.Text = "Вставить карту";
            this.buttonInsertCard.UseVisualStyleBackColor = true;
            this.buttonInsertCard.Click += new System.EventHandler(this.buttonInsertCard_Click);
            // 
            // buttonAddCash
            // 
            this.buttonAddCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCash.Location = new System.Drawing.Point(219, 365);
            this.buttonAddCash.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddCash.Name = "buttonAddCash";
            this.buttonAddCash.Size = new System.Drawing.Size(269, 58);
            this.buttonAddCash.TabIndex = 2;
            this.buttonAddCash.Text = "Пополнить карту по номеру";
            this.buttonAddCash.UseVisualStyleBackColor = true;
            this.buttonAddCash.Click += new System.EventHandler(this.buttonAddCash_Click);
            // 
            // buttonGetCard
            // 
            this.buttonGetCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetCard.Location = new System.Drawing.Point(220, 431);
            this.buttonGetCard.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetCard.Name = "buttonGetCard";
            this.buttonGetCard.Size = new System.Drawing.Size(269, 55);
            this.buttonGetCard.TabIndex = 3;
            this.buttonGetCard.Text = "Получить карту";
            this.buttonGetCard.UseVisualStyleBackColor = true;
            this.buttonGetCard.Click += new System.EventHandler(this.buttonGetCard_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonGetCard);
            this.Controls.Add(this.buttonAddCash);
            this.Controls.Add(this.buttonInsertCard);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1000, 760);
            this.Name = "LoginView";
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.buttonToStartPage, 0);
            this.Controls.SetChildIndex(this.labelDetails, 0);
            this.Controls.SetChildIndex(this.labelNotifyMessage, 0);
            this.Controls.SetChildIndex(this.labelPageName, 0);
            this.Controls.SetChildIndex(this.labelInstructions, 0);
            this.Controls.SetChildIndex(this.buttonInsertCard, 0);
            this.Controls.SetChildIndex(this.buttonAddCash, 0);
            this.Controls.SetChildIndex(this.buttonGetCard, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInsertCard;
        private System.Windows.Forms.Button buttonAddCash;
        private System.Windows.Forms.Button buttonGetCard;
    }
}
