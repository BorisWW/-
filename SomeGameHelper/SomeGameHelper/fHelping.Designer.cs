namespace SomeGameHelper
{
    partial class fHelping
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
            this.cbNumOfPlayers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb1ClrOfCard = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb1VleOfCard = new System.Windows.Forms.ComboBox();
            this.cb2VleOfCard = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb2ClrOfCard = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество игроков";
            // 
            // cbNumOfPlayers
            // 
            this.cbNumOfPlayers.FormattingEnabled = true;
            this.cbNumOfPlayers.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.cbNumOfPlayers.Location = new System.Drawing.Point(209, 66);
            this.cbNumOfPlayers.Name = "cbNumOfPlayers";
            this.cbNumOfPlayers.Size = new System.Drawing.Size(36, 21);
            this.cbNumOfPlayers.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ваши карты";
            // 
            // cb1ClrOfCard
            // 
            this.cb1ClrOfCard.FormattingEnabled = true;
            this.cb1ClrOfCard.Location = new System.Drawing.Point(209, 111);
            this.cb1ClrOfCard.Name = "cb1ClrOfCard";
            this.cb1ClrOfCard.Size = new System.Drawing.Size(36, 21);
            this.cb1ClrOfCard.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "масть";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "значение";
            // 
            // cb1VleOfCard
            // 
            this.cb1VleOfCard.FormattingEnabled = true;
            this.cb1VleOfCard.Location = new System.Drawing.Point(316, 111);
            this.cb1VleOfCard.Name = "cb1VleOfCard";
            this.cb1VleOfCard.Size = new System.Drawing.Size(35, 21);
            this.cb1VleOfCard.TabIndex = 6;
            // 
            // cb2VleOfCard
            // 
            this.cb2VleOfCard.FormattingEnabled = true;
            this.cb2VleOfCard.Location = new System.Drawing.Point(316, 149);
            this.cb2VleOfCard.Name = "cb2VleOfCard";
            this.cb2VleOfCard.Size = new System.Drawing.Size(35, 21);
            this.cb2VleOfCard.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "значение";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "масть";
            // 
            // cb2ClrOfCard
            // 
            this.cb2ClrOfCard.FormattingEnabled = true;
            this.cb2ClrOfCard.Location = new System.Drawing.Point(209, 149);
            this.cb2ClrOfCard.Name = "cb2ClrOfCard";
            this.cb2ClrOfCard.Size = new System.Drawing.Size(36, 21);
            this.cb2ClrOfCard.TabIndex = 7;
            // 
            // fHelping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SomeGameHelper.Properties.Resources.Backgrounds_On_blue_background_wallpaper_082199_;
            this.ClientSize = new System.Drawing.Size(499, 400);
            this.Controls.Add(this.cb2VleOfCard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb2ClrOfCard);
            this.Controls.Add(this.cb1VleOfCard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb1ClrOfCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNumOfPlayers);
            this.Controls.Add(this.label1);
            this.Name = "fHelping";
            this.Text = "Помощник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNumOfPlayers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb1ClrOfCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb1VleOfCard;
        private System.Windows.Forms.ComboBox cb2VleOfCard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb2ClrOfCard;
    }
}