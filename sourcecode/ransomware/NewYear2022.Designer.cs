namespace HappyNewYear2022Ransomware
{
    partial class NewYear2022
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewYear2022));
            this.label1 = new System.Windows.Forms.Label();
            this.Lock1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lock2 = new System.Windows.Forms.PictureBox();
            this.Lock3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timertodeleteencfiles = new System.Windows.Forms.Label();
            this.TimertoExittothisapp = new System.Windows.Forms.Timer(this.components);
            this.Happy2022 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Lock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lock3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Happy2022)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(815, 126);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Lock1
            // 
            this.Lock1.Location = new System.Drawing.Point(60, 192);
            this.Lock1.Margin = new System.Windows.Forms.Padding(4);
            this.Lock1.Name = "Lock1";
            this.Lock1.Size = new System.Drawing.Size(231, 177);
            this.Lock1.TabIndex = 1;
            this.Lock1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(301, 519);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 60);
            this.textBox1.TabIndex = 3;
            // 
            // Lock2
            // 
            this.Lock2.Location = new System.Drawing.Point(371, 174);
            this.Lock2.Margin = new System.Windows.Forms.Padding(4);
            this.Lock2.Name = "Lock2";
            this.Lock2.Size = new System.Drawing.Size(231, 177);
            this.Lock2.TabIndex = 4;
            this.Lock2.TabStop = false;
            // 
            // Lock3
            // 
            this.Lock3.Location = new System.Drawing.Point(665, 174);
            this.Lock3.Margin = new System.Windows.Forms.Padding(4);
            this.Lock3.Name = "Lock3";
            this.Lock3.Size = new System.Drawing.Size(231, 177);
            this.Lock3.TabIndex = 5;
            this.Lock3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(347, 603);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "DECRYPT FILES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(117)))), ((int)(((byte)(74)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(233, 373);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(487, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Password to Decrypt your Files";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(703, 519);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 53);
            this.button2.TabIndex = 8;
            this.button2.Text = "Rules";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timertodeleteencfiles
            // 
            this.timertodeleteencfiles.AutoSize = true;
            this.timertodeleteencfiles.BackColor = System.Drawing.Color.White;
            this.timertodeleteencfiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timertodeleteencfiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timertodeleteencfiles.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timertodeleteencfiles.ForeColor = System.Drawing.Color.Green;
            this.timertodeleteencfiles.Location = new System.Drawing.Point(399, 447);
            this.timertodeleteencfiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timertodeleteencfiles.Name = "timertodeleteencfiles";
            this.timertodeleteencfiles.Size = new System.Drawing.Size(106, 33);
            this.timertodeleteencfiles.TabIndex = 9;
            this.timertodeleteencfiles.Text = "00:00:00";
            // 
            // TimertoExittothisapp
            // 
            this.TimertoExittothisapp.Enabled = true;
            this.TimertoExittothisapp.Interval = 18000000;
            this.TimertoExittothisapp.Tick += new System.EventHandler(this.TimertoExittothisapp_Tick);
            // 
            // Happy2022
            // 
            this.Happy2022.Enabled = true;
            this.Happy2022.Location = new System.Drawing.Point(210, 456);
            this.Happy2022.Name = "Happy2022";
            this.Happy2022.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Happy2022.OcxState")));
            this.Happy2022.Size = new System.Drawing.Size(75, 23);
            this.Happy2022.TabIndex = 10;
            // 
            // NewYear2022
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(912, 660);
            this.Controls.Add(this.Happy2022);
            this.Controls.Add(this.timertodeleteencfiles);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lock3);
            this.Controls.Add(this.Lock2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lock1);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewYear2022";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Happy New Year 2022";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewYear2022_FormClosing);
            this.Load += new System.EventHandler(this.NewYear2022_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lock3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Happy2022)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Lock1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox Lock2;
        private System.Windows.Forms.PictureBox Lock3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label timertodeleteencfiles;
        private System.Windows.Forms.Timer TimertoExittothisapp;
        private AxWMPLib.AxWindowsMediaPlayer Happy2022;
    }
}

