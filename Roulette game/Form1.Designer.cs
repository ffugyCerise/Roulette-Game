namespace Roulette_game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblslogan = new System.Windows.Forms.Label();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.btnLetsPlay = new System.Windows.Forms.Button();
            this.cb18yearsOld = new System.Windows.Forms.CheckBox();
            this.pbCasino = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCasino)).BeginInit();
            this.SuspendLayout();
            // 
            // lblslogan
            // 
            this.lblslogan.AutoSize = true;
            this.lblslogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblslogan.Location = new System.Drawing.Point(167, 77);
            this.lblslogan.Name = "lblslogan";
            this.lblslogan.Size = new System.Drawing.Size(219, 20);
            this.lblslogan.TabIndex = 0;
            this.lblslogan.Text = "\"Reality can\'t catch you here!\"";
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.Location = new System.Drawing.Point(81, 22);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(460, 39);
            this.lblwelcome.TabIndex = 1;
            this.lblwelcome.Text = "Welcome to Casino Royal! ";
            // 
            // btnLetsPlay
            // 
            this.btnLetsPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetsPlay.Location = new System.Drawing.Point(122, 299);
            this.btnLetsPlay.Name = "btnLetsPlay";
            this.btnLetsPlay.Size = new System.Drawing.Size(332, 83);
            this.btnLetsPlay.TabIndex = 2;
            this.btnLetsPlay.Text = "Lets Play!";
            this.btnLetsPlay.UseVisualStyleBackColor = true;
            this.btnLetsPlay.Click += new System.EventHandler(this.BtnLetsPlay_Click);
            // 
            // cb18yearsOld
            // 
            this.cb18yearsOld.AutoSize = true;
            this.cb18yearsOld.Location = new System.Drawing.Point(122, 397);
            this.cb18yearsOld.Name = "cb18yearsOld";
            this.cb18yearsOld.Size = new System.Drawing.Size(349, 17);
            this.cb18yearsOld.TabIndex = 3;
            this.cb18yearsOld.Text = "I am above the age of 18 and if I\'m not, I or my family will not sue you";
            this.cb18yearsOld.UseVisualStyleBackColor = true;
            // 
            // pbCasino
            // 
            this.pbCasino.Image = ((System.Drawing.Image)(resources.GetObject("pbCasino.Image")));
            this.pbCasino.Location = new System.Drawing.Point(12, 118);
            this.pbCasino.Name = "pbCasino";
            this.pbCasino.Size = new System.Drawing.Size(567, 156);
            this.pbCasino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCasino.TabIndex = 4;
            this.pbCasino.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 484);
            this.Controls.Add(this.pbCasino);
            this.Controls.Add(this.cb18yearsOld);
            this.Controls.Add(this.btnLetsPlay);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.lblslogan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Casino Royal";
            ((System.ComponentModel.ISupportInitialize)(this.pbCasino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblslogan;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Button btnLetsPlay;
        private System.Windows.Forms.CheckBox cb18yearsOld;
        private System.Windows.Forms.PictureBox pbCasino;
    }
}

