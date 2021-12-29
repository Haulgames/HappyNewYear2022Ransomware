namespace SantaClausWillKillYourPC
{
    partial class SantaClausKillPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SantaClausKillPC));
            this.timertodeathpc = new System.Windows.Forms.Label();
            this.pcwillbedead = new System.Windows.Forms.Label();
            this.CountdownTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timertodeathpc
            // 
            this.timertodeathpc.AutoSize = true;
            this.timertodeathpc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.timertodeathpc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timertodeathpc.Cursor = System.Windows.Forms.Cursors.No;
            this.timertodeathpc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timertodeathpc.Font = new System.Drawing.Font("Bodoni MT Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timertodeathpc.ForeColor = System.Drawing.Color.RosyBrown;
            this.timertodeathpc.Location = new System.Drawing.Point(228, 469);
            this.timertodeathpc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timertodeathpc.Name = "timertodeathpc";
            this.timertodeathpc.Size = new System.Drawing.Size(140, 57);
            this.timertodeathpc.TabIndex = 0;
            this.timertodeathpc.Text = "00:00:00";
            // 
            // pcwillbedead
            // 
            this.pcwillbedead.AutoSize = true;
            this.pcwillbedead.BackColor = System.Drawing.Color.Black;
            this.pcwillbedead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcwillbedead.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.pcwillbedead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pcwillbedead.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pcwillbedead.ForeColor = System.Drawing.Color.Yellow;
            this.pcwillbedead.Location = new System.Drawing.Point(112, 34);
            this.pcwillbedead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pcwillbedead.Name = "pcwillbedead";
            this.pcwillbedead.Size = new System.Drawing.Size(420, 43);
            this.pcwillbedead.TabIndex = 1;
            this.pcwillbedead.Text = "Your PC will be Dead in...";
            // 
            // CountdownTimer
            // 
            this.CountdownTimer.Enabled = true;
            this.CountdownTimer.Interval = 300000;
            this.CountdownTimer.Tick += new System.EventHandler(this.CountdownTimer_Tick);
            // 
            // SantaClausKillPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(673, 554);
            this.Controls.Add(this.pcwillbedead);
            this.Controls.Add(this.timertodeathpc);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SantaClausKillPC";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Santa Claus is Going to Kill Your PC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SantaClausKillPC_FormClosing);
            this.Load += new System.EventHandler(this.SantaClausKillPC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label timertodeathpc;
        private System.Windows.Forms.Label pcwillbedead;
        private System.Windows.Forms.Timer CountdownTimer;
    }
}

