
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sorugetirButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Abutton = new System.Windows.Forms.Button();
            this.Bbutton = new System.Windows.Forms.Button();
            this.Cbutton = new System.Windows.Forms.Button();
            this.Dbutton = new System.Windows.Forms.Button();
            this.dogruLabel = new System.Windows.Forms.Label();
            this.yanlısLabel = new System.Windows.Forms.Label();
            this.harcananSureLabel = new System.Windows.Forms.Label();
            this.dogruSayisiLabel = new System.Windows.Forms.Label();
            this.yanlısSayisiLabel = new System.Windows.Forms.Label();
            this.harcananSureSayisiLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.harcananSureTimer = new System.Windows.Forms.Timer(this.components);
            this.yanlisPictureBox = new System.Windows.Forms.PictureBox();
            this.dogruPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yanlisPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogruPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sorugetirButton
            // 
            this.sorugetirButton.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorugetirButton.Location = new System.Drawing.Point(11, 25);
            this.sorugetirButton.Name = "sorugetirButton";
            this.sorugetirButton.Size = new System.Drawing.Size(154, 56);
            this.sorugetirButton.TabIndex = 0;
            this.sorugetirButton.Text = "soru getir";
            this.sorugetirButton.UseVisualStyleBackColor = true;
            this.sorugetirButton.Click += new System.EventHandler(this.sorugetirButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Lavender;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(220, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(818, 144);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Abutton
            // 
            this.Abutton.BackColor = System.Drawing.Color.LavenderBlush;
            this.Abutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Abutton.Location = new System.Drawing.Point(220, 173);
            this.Abutton.Name = "Abutton";
            this.Abutton.Size = new System.Drawing.Size(200, 80);
            this.Abutton.TabIndex = 2;
            this.Abutton.Text = "button1";
            this.Abutton.UseVisualStyleBackColor = false;
            this.Abutton.Click += new System.EventHandler(this.Abutton_Click);
            // 
            // Bbutton
            // 
            this.Bbutton.BackColor = System.Drawing.Color.LavenderBlush;
            this.Bbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Bbutton.Location = new System.Drawing.Point(426, 173);
            this.Bbutton.Name = "Bbutton";
            this.Bbutton.Size = new System.Drawing.Size(200, 80);
            this.Bbutton.TabIndex = 3;
            this.Bbutton.Text = "button2";
            this.Bbutton.UseVisualStyleBackColor = false;
            this.Bbutton.Click += new System.EventHandler(this.Bbutton_Click);
            // 
            // Cbutton
            // 
            this.Cbutton.BackColor = System.Drawing.Color.LavenderBlush;
            this.Cbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cbutton.Location = new System.Drawing.Point(632, 173);
            this.Cbutton.Name = "Cbutton";
            this.Cbutton.Size = new System.Drawing.Size(200, 80);
            this.Cbutton.TabIndex = 4;
            this.Cbutton.Text = "button3";
            this.Cbutton.UseVisualStyleBackColor = false;
            this.Cbutton.Click += new System.EventHandler(this.Cbutton_Click);
            // 
            // Dbutton
            // 
            this.Dbutton.BackColor = System.Drawing.Color.LavenderBlush;
            this.Dbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Dbutton.Location = new System.Drawing.Point(838, 173);
            this.Dbutton.Name = "Dbutton";
            this.Dbutton.Size = new System.Drawing.Size(200, 80);
            this.Dbutton.TabIndex = 5;
            this.Dbutton.Text = "button4";
            this.Dbutton.UseVisualStyleBackColor = false;
            this.Dbutton.Click += new System.EventHandler(this.Dbutton_Click);
            // 
            // dogruLabel
            // 
            this.dogruLabel.AutoSize = true;
            this.dogruLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.dogruLabel.Font = new System.Drawing.Font("Agency FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogruLabel.Location = new System.Drawing.Point(8, 95);
            this.dogruLabel.Name = "dogruLabel";
            this.dogruLabel.Size = new System.Drawing.Size(66, 23);
            this.dogruLabel.TabIndex = 6;
            this.dogruLabel.Text = "doğru:";
            // 
            // yanlısLabel
            // 
            this.yanlısLabel.AutoSize = true;
            this.yanlısLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.yanlısLabel.Font = new System.Drawing.Font("Agency FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yanlısLabel.Location = new System.Drawing.Point(8, 135);
            this.yanlısLabel.Name = "yanlısLabel";
            this.yanlısLabel.Size = new System.Drawing.Size(67, 23);
            this.yanlısLabel.TabIndex = 7;
            this.yanlısLabel.Text = "yanlış:";
            // 
            // harcananSureLabel
            // 
            this.harcananSureLabel.AutoSize = true;
            this.harcananSureLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.harcananSureLabel.Font = new System.Drawing.Font("Agency FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harcananSureLabel.Location = new System.Drawing.Point(8, 173);
            this.harcananSureLabel.Name = "harcananSureLabel";
            this.harcananSureLabel.Size = new System.Drawing.Size(135, 23);
            this.harcananSureLabel.TabIndex = 8;
            this.harcananSureLabel.Text = "harcanan süre";
            // 
            // dogruSayisiLabel
            // 
            this.dogruSayisiLabel.AutoSize = true;
            this.dogruSayisiLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.dogruSayisiLabel.Font = new System.Drawing.Font("Agency FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogruSayisiLabel.Location = new System.Drawing.Point(148, 95);
            this.dogruSayisiLabel.Name = "dogruSayisiLabel";
            this.dogruSayisiLabel.Size = new System.Drawing.Size(22, 23);
            this.dogruSayisiLabel.TabIndex = 9;
            this.dogruSayisiLabel.Text = "=";
            // 
            // yanlısSayisiLabel
            // 
            this.yanlısSayisiLabel.AutoSize = true;
            this.yanlısSayisiLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.yanlısSayisiLabel.Font = new System.Drawing.Font("Agency FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yanlısSayisiLabel.Location = new System.Drawing.Point(148, 135);
            this.yanlısSayisiLabel.Name = "yanlısSayisiLabel";
            this.yanlısSayisiLabel.Size = new System.Drawing.Size(22, 23);
            this.yanlısSayisiLabel.TabIndex = 10;
            this.yanlısSayisiLabel.Text = "=";
            // 
            // harcananSureSayisiLabel
            // 
            this.harcananSureSayisiLabel.AutoSize = true;
            this.harcananSureSayisiLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.harcananSureSayisiLabel.Font = new System.Drawing.Font("Agency FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harcananSureSayisiLabel.Location = new System.Drawing.Point(148, 173);
            this.harcananSureSayisiLabel.Name = "harcananSureSayisiLabel";
            this.harcananSureSayisiLabel.Size = new System.Drawing.Size(22, 23);
            this.harcananSureSayisiLabel.TabIndex = 11;
            this.harcananSureSayisiLabel.Text = "=";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Plum;
            this.groupBox1.Controls.Add(this.sorugetirButton);
            this.groupBox1.Controls.Add(this.yanlısSayisiLabel);
            this.groupBox1.Controls.Add(this.dogruLabel);
            this.groupBox1.Controls.Add(this.harcananSureSayisiLabel);
            this.groupBox1.Controls.Add(this.yanlısLabel);
            this.groupBox1.Controls.Add(this.harcananSureLabel);
            this.groupBox1.Controls.Add(this.dogruSayisiLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 241);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ":D";
            // 
            // harcananSureTimer
            // 
            this.harcananSureTimer.Enabled = true;
            this.harcananSureTimer.Interval = 1000;
            this.harcananSureTimer.Tick += new System.EventHandler(this.harcananSureTimer_Tick);
            // 
            // yanlisPictureBox
            // 
            this.yanlisPictureBox.ErrorImage = null;
            this.yanlisPictureBox.Location = new System.Drawing.Point(560, 25);
            this.yanlisPictureBox.Name = "yanlisPictureBox";
            this.yanlisPictureBox.Size = new System.Drawing.Size(457, 281);
            this.yanlisPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yanlisPictureBox.TabIndex = 13;
            this.yanlisPictureBox.TabStop = false;
            // 
            // dogruPictureBox
            // 
            this.dogruPictureBox.ErrorImage = null;
            this.dogruPictureBox.InitialImage = null;
            this.dogruPictureBox.Location = new System.Drawing.Point(22, 25);
            this.dogruPictureBox.Name = "dogruPictureBox";
            this.dogruPictureBox.Size = new System.Drawing.Size(366, 288);
            this.dogruPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogruPictureBox.TabIndex = 12;
            this.dogruPictureBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dogruPictureBox);
            this.groupBox2.Controls.Add(this.yanlisPictureBox);
            this.groupBox2.Location = new System.Drawing.Point(1, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1037, 341);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = ":D";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1056, 612);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dbutton);
            this.Controls.Add(this.Cbutton);
            this.Controls.Add(this.Bbutton);
            this.Controls.Add(this.Abutton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yanlisPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogruPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sorugetirButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Abutton;
        private System.Windows.Forms.Button Bbutton;
        private System.Windows.Forms.Button Cbutton;
        private System.Windows.Forms.Button Dbutton;
        private System.Windows.Forms.Label dogruLabel;
        private System.Windows.Forms.Label yanlısLabel;
        private System.Windows.Forms.Label harcananSureLabel;
        private System.Windows.Forms.Label dogruSayisiLabel;
        private System.Windows.Forms.Label yanlısSayisiLabel;
        private System.Windows.Forms.Label harcananSureSayisiLabel;
        private System.Windows.Forms.PictureBox dogruPictureBox;
        private System.Windows.Forms.PictureBox yanlisPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer harcananSureTimer;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

