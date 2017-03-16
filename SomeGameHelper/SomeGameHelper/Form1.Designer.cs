namespace SomeGameHelper
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHelper = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNameofGame = new System.Windows.Forms.ComboBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHelper
            // 
            this.btnHelper.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHelper.Location = new System.Drawing.Point(116, 124);
            this.btnHelper.Name = "btnHelper";
            this.btnHelper.Size = new System.Drawing.Size(248, 53);
            this.btnHelper.TabIndex = 0;
            this.btnHelper.Text = "Помощник";
            this.btnHelper.UseVisualStyleBackColor = true;
            this.btnHelper.Click += new System.EventHandler(this.btnHelper_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(116, 287);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(248, 58);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Выход";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(116, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбирите игру";
            // 
            // cbNameofGame
            // 
            this.cbNameofGame.FormattingEnabled = true;
            this.cbNameofGame.Items.AddRange(new object[] {
            "Покер",
            "Бридж",
            "Дурак"});
            this.cbNameofGame.Location = new System.Drawing.Point(243, 63);
            this.cbNameofGame.Name = "cbNameofGame";
            this.cbNameofGame.Size = new System.Drawing.Size(121, 21);
            this.cbNameofGame.TabIndex = 3;
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInfo.Location = new System.Drawing.Point(116, 201);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(248, 62);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "Справка";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SomeGameHelper.Properties.Resources.Backgrounds_On_blue_background_wallpaper_082199_;
            this.ClientSize = new System.Drawing.Size(507, 396);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.cbNameofGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHelper);
            this.Name = "Form1";
            this.Text = "Game-Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHelper;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNameofGame;
        private System.Windows.Forms.Button btnInfo;
    }
}

