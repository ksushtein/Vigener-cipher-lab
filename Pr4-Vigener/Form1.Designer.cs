
namespace Pr4_Vigener
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
            this.tbKeyWord = new System.Windows.Forms.TextBox();
            this.rtbTextWord = new System.Windows.Forms.RichTextBox();
            this.rtbResWord = new System.Windows.Forms.RichTextBox();
            this.rtbResNums = new System.Windows.Forms.RichTextBox();
            this.rtbTextNums = new System.Windows.Forms.RichTextBox();
            this.tbKeyNums = new System.Windows.Forms.TextBox();
            this.btnEncodeText = new System.Windows.Forms.Button();
            this.btnDecodeText = new System.Windows.Forms.Button();
            this.btnDecodeNums = new System.Windows.Forms.Button();
            this.btnEncodeNums = new System.Windows.Forms.Button();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.btnLoadWord = new System.Windows.Forms.Button();
            this.btnLoadNums = new System.Windows.Forms.Button();
            this.btnSaveWord = new System.Windows.Forms.Button();
            this.btnSaveNums = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbKeyWord
            // 
            this.tbKeyWord.Location = new System.Drawing.Point(31, 36);
            this.tbKeyWord.Name = "tbKeyWord";
            this.tbKeyWord.Size = new System.Drawing.Size(248, 22);
            this.tbKeyWord.TabIndex = 0;
            this.tbKeyWord.Text = "ЛАЙМ";
            this.tbKeyWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyWord_KeyPress);
            // 
            // rtbTextWord
            // 
            this.rtbTextWord.Location = new System.Drawing.Point(31, 126);
            this.rtbTextWord.Name = "rtbTextWord";
            this.rtbTextWord.Size = new System.Drawing.Size(248, 145);
            this.rtbTextWord.TabIndex = 1;
            this.rtbTextWord.Text = "АХ КАК МНЕ ЗДОРОВО";
            this.rtbTextWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbTextWord_KeyPress);
            // 
            // rtbResWord
            // 
            this.rtbResWord.Location = new System.Drawing.Point(31, 365);
            this.rtbResWord.Name = "rtbResWord";
            this.rtbResWord.Size = new System.Drawing.Size(248, 145);
            this.rtbResWord.TabIndex = 2;
            this.rtbResWord.Text = "";
            // 
            // rtbResNums
            // 
            this.rtbResNums.Location = new System.Drawing.Point(23, 365);
            this.rtbResNums.Name = "rtbResNums";
            this.rtbResNums.Size = new System.Drawing.Size(252, 145);
            this.rtbResNums.TabIndex = 5;
            this.rtbResNums.Text = "";
            // 
            // rtbTextNums
            // 
            this.rtbTextNums.Location = new System.Drawing.Point(23, 126);
            this.rtbTextNums.Name = "rtbTextNums";
            this.rtbTextNums.Size = new System.Drawing.Size(252, 145);
            this.rtbTextNums.TabIndex = 4;
            this.rtbTextNums.Text = "АХ КАК МНЕ ЗДОРОВО";
            this.rtbTextNums.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbTextNums_KeyPress);
            // 
            // tbKeyNums
            // 
            this.tbKeyNums.Location = new System.Drawing.Point(23, 36);
            this.tbKeyNums.Name = "tbKeyNums";
            this.tbKeyNums.Size = new System.Drawing.Size(252, 22);
            this.tbKeyNums.TabIndex = 3;
            this.tbKeyNums.Text = "2 3 1 0";
            this.tbKeyNums.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyNums_KeyPress);
            // 
            // btnEncodeText
            // 
            this.btnEncodeText.Location = new System.Drawing.Point(31, 278);
            this.btnEncodeText.Name = "btnEncodeText";
            this.btnEncodeText.Size = new System.Drawing.Size(113, 36);
            this.btnEncodeText.TabIndex = 6;
            this.btnEncodeText.Text = "Зашифровать";
            this.btnEncodeText.UseVisualStyleBackColor = true;
            this.btnEncodeText.Click += new System.EventHandler(this.btnEncodeText_Click);
            // 
            // btnDecodeText
            // 
            this.btnDecodeText.Location = new System.Drawing.Point(150, 278);
            this.btnDecodeText.Name = "btnDecodeText";
            this.btnDecodeText.Size = new System.Drawing.Size(129, 36);
            this.btnDecodeText.TabIndex = 7;
            this.btnDecodeText.Text = "Расшифровать";
            this.btnDecodeText.UseVisualStyleBackColor = true;
            this.btnDecodeText.Click += new System.EventHandler(this.btnDecodeText_Click);
            // 
            // btnDecodeNums
            // 
            this.btnDecodeNums.Location = new System.Drawing.Point(142, 278);
            this.btnDecodeNums.Name = "btnDecodeNums";
            this.btnDecodeNums.Size = new System.Drawing.Size(133, 36);
            this.btnDecodeNums.TabIndex = 9;
            this.btnDecodeNums.Text = "Расшифровать";
            this.btnDecodeNums.UseVisualStyleBackColor = true;
            this.btnDecodeNums.Click += new System.EventHandler(this.btnDecodeNums_Click);
            // 
            // btnEncodeNums
            // 
            this.btnEncodeNums.Location = new System.Drawing.Point(23, 278);
            this.btnEncodeNums.Name = "btnEncodeNums";
            this.btnEncodeNums.Size = new System.Drawing.Size(113, 36);
            this.btnEncodeNums.TabIndex = 8;
            this.btnEncodeNums.Text = "Зашифровать";
            this.btnEncodeNums.UseVisualStyleBackColor = true;
            this.btnEncodeNums.Click += new System.EventHandler(this.btnEncodeNums_Click);
            // 
            // cbLanguage
            // 
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(240, 41);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(187, 24);
            this.cbLanguage.TabIndex = 10;
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // btnLoadWord
            // 
            this.btnLoadWord.Location = new System.Drawing.Point(31, 84);
            this.btnLoadWord.Name = "btnLoadWord";
            this.btnLoadWord.Size = new System.Drawing.Size(248, 36);
            this.btnLoadWord.TabIndex = 11;
            this.btnLoadWord.Text = "Загрузить";
            this.btnLoadWord.UseVisualStyleBackColor = true;
            this.btnLoadWord.Click += new System.EventHandler(this.btnLoadWord_Click);
            // 
            // btnLoadNums
            // 
            this.btnLoadNums.Location = new System.Drawing.Point(23, 84);
            this.btnLoadNums.Name = "btnLoadNums";
            this.btnLoadNums.Size = new System.Drawing.Size(252, 36);
            this.btnLoadNums.TabIndex = 12;
            this.btnLoadNums.Text = "Загрузить";
            this.btnLoadNums.UseVisualStyleBackColor = true;
            this.btnLoadNums.Click += new System.EventHandler(this.btnLoadNums_Click);
            // 
            // btnSaveWord
            // 
            this.btnSaveWord.Location = new System.Drawing.Point(31, 516);
            this.btnSaveWord.Name = "btnSaveWord";
            this.btnSaveWord.Size = new System.Drawing.Size(248, 36);
            this.btnSaveWord.TabIndex = 13;
            this.btnSaveWord.Text = "Сохранить";
            this.btnSaveWord.UseVisualStyleBackColor = true;
            this.btnSaveWord.Click += new System.EventHandler(this.btnSaveWord_Click);
            // 
            // btnSaveNums
            // 
            this.btnSaveNums.Location = new System.Drawing.Point(23, 516);
            this.btnSaveNums.Name = "btnSaveNums";
            this.btnSaveNums.Size = new System.Drawing.Size(248, 36);
            this.btnSaveNums.TabIndex = 14;
            this.btnSaveNums.Text = "Сохранить";
            this.btnSaveNums.UseVisualStyleBackColor = true;
            this.btnSaveNums.Click += new System.EventHandler(this.btnSaveNums_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadWord);
            this.groupBox1.Controls.Add(this.tbKeyWord);
            this.groupBox1.Controls.Add(this.btnSaveWord);
            this.groupBox1.Controls.Add(this.rtbTextWord);
            this.groupBox1.Controls.Add(this.rtbResWord);
            this.groupBox1.Controls.Add(this.btnEncodeText);
            this.groupBox1.Controls.Add(this.btnDecodeText);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 568);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ключ-слово";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveNums);
            this.groupBox2.Controls.Add(this.tbKeyNums);
            this.groupBox2.Controls.Add(this.rtbTextNums);
            this.groupBox2.Controls.Add(this.btnLoadNums);
            this.groupBox2.Controls.Add(this.rtbResNums);
            this.groupBox2.Controls.Add(this.btnEncodeNums);
            this.groupBox2.Controls.Add(this.btnDecodeNums);
            this.groupBox2.Location = new System.Drawing.Point(348, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 568);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ключ-числа";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 679);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbLanguage);
            this.Name = "Form1";
            this.Text = "Шифр виженера";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbKeyWord;
        private System.Windows.Forms.RichTextBox rtbTextWord;
        private System.Windows.Forms.RichTextBox rtbResWord;
        private System.Windows.Forms.RichTextBox rtbResNums;
        private System.Windows.Forms.RichTextBox rtbTextNums;
        private System.Windows.Forms.TextBox tbKeyNums;
        private System.Windows.Forms.Button btnEncodeText;
        private System.Windows.Forms.Button btnDecodeText;
        private System.Windows.Forms.Button btnDecodeNums;
        private System.Windows.Forms.Button btnEncodeNums;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Button btnLoadWord;
        private System.Windows.Forms.Button btnLoadNums;
        private System.Windows.Forms.Button btnSaveWord;
        private System.Windows.Forms.Button btnSaveNums;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

