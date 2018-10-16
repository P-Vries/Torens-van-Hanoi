namespace TorensVanHanoi
{
    partial class frmInterface
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
            this.pbOut = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPilaar1 = new System.Windows.Forms.Button();
            this.btnPillaar2 = new System.Windows.Forms.Button();
            this.btnPilaar3 = new System.Windows.Forms.Button();
            this.lblZetO = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbOut)).BeginInit();
            this.SuspendLayout();
            // 
            // pbOut
            // 
            this.pbOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOut.Location = new System.Drawing.Point(12, 41);
            this.pbOut.Name = "pbOut";
            this.pbOut.Size = new System.Drawing.Size(1240, 628);
            this.pbOut.TabIndex = 0;
            this.pbOut.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPilaar1
            // 
            this.btnPilaar1.Enabled = false;
            this.btnPilaar1.Location = new System.Drawing.Point(141, 675);
            this.btnPilaar1.Name = "btnPilaar1";
            this.btnPilaar1.Size = new System.Drawing.Size(75, 23);
            this.btnPilaar1.TabIndex = 2;
            this.btnPilaar1.Text = "Pilaar 1";
            this.btnPilaar1.UseVisualStyleBackColor = true;
            this.btnPilaar1.Click += new System.EventHandler(this.btnPilaar1_Click);
            // 
            // btnPillaar2
            // 
            this.btnPillaar2.Enabled = false;
            this.btnPillaar2.Location = new System.Drawing.Point(558, 675);
            this.btnPillaar2.Name = "btnPillaar2";
            this.btnPillaar2.Size = new System.Drawing.Size(75, 23);
            this.btnPillaar2.TabIndex = 3;
            this.btnPillaar2.Text = "Pilaar 2";
            this.btnPillaar2.UseVisualStyleBackColor = true;
            this.btnPillaar2.Click += new System.EventHandler(this.btnPillaar2_Click);
            // 
            // btnPilaar3
            // 
            this.btnPilaar3.Enabled = false;
            this.btnPilaar3.Location = new System.Drawing.Point(971, 675);
            this.btnPilaar3.Name = "btnPilaar3";
            this.btnPilaar3.Size = new System.Drawing.Size(75, 23);
            this.btnPilaar3.TabIndex = 4;
            this.btnPilaar3.Text = "Pilaar 3";
            this.btnPilaar3.UseVisualStyleBackColor = true;
            this.btnPilaar3.Click += new System.EventHandler(this.btnPilaar3_Click);
            // 
            // lblZetO
            // 
            this.lblZetO.AutoSize = true;
            this.lblZetO.Location = new System.Drawing.Point(93, 17);
            this.lblZetO.Name = "lblZetO";
            this.lblZetO.Size = new System.Drawing.Size(75, 13);
            this.lblZetO.TabIndex = 5;
            this.lblZetO.Text = "Aantal zetten: ";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1177, 675);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 708);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblZetO);
            this.Controls.Add(this.btnPilaar3);
            this.Controls.Add(this.btnPillaar2);
            this.Controls.Add(this.btnPilaar1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbOut);
            this.Name = "frmInterface";
            this.Text = "Torens van Hanoi";
            ((System.ComponentModel.ISupportInitialize)(this.pbOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOut;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPilaar1;
        private System.Windows.Forms.Button btnPillaar2;
        private System.Windows.Forms.Button btnPilaar3;
        private System.Windows.Forms.Label lblZetO;
        private System.Windows.Forms.Button btnExit;
    }
}

