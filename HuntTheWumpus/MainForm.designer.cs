namespace HuntTheWumpus
{
    partial class MainForm
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Start = new System.Windows.Forms.Button();
            this.Minigame = new System.Windows.Forms.Button();
            this.HighScores = new System.Windows.Forms.Button();
            this.whichCave = new System.Windows.Forms.TextBox();
            this.chooseCave1 = new System.Windows.Forms.Button();
            this.chooseCave2 = new System.Windows.Forms.Button();
            this.chooseCave3 = new System.Windows.Forms.Button();
            this.chooseCave4 = new System.Windows.Forms.Button();
            this.chooseCave5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(105, 414);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(139, 88);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Visible = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Minigame
            // 
            this.Minigame.BackColor = System.Drawing.Color.Transparent;
            this.Minigame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minigame.Location = new System.Drawing.Point(555, 414);
            this.Minigame.Name = "Minigame";
            this.Minigame.Size = new System.Drawing.Size(139, 88);
            this.Minigame.TabIndex = 2;
            this.Minigame.Text = "Minigame";
            this.Minigame.UseVisualStyleBackColor = false;
            this.Minigame.Click += new System.EventHandler(this.Minigame_Click);
            // 
            // HighScores
            // 
            this.HighScores.BackColor = System.Drawing.Color.Transparent;
            this.HighScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScores.Location = new System.Drawing.Point(199, 414);
            this.HighScores.Name = "HighScores";
            this.HighScores.Size = new System.Drawing.Size(139, 88);
            this.HighScores.TabIndex = 4;
            this.HighScores.Text = "HighScores";
            this.HighScores.UseVisualStyleBackColor = false;
            this.HighScores.Click += new System.EventHandler(this.HighScores_Click);
            // 
            // whichCave
            // 
            this.whichCave.BackColor = System.Drawing.Color.Gray;
            this.whichCave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.whichCave.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whichCave.ForeColor = System.Drawing.Color.Black;
            this.whichCave.Location = new System.Drawing.Point(311, 76);
            this.whichCave.Name = "whichCave";
            this.whichCave.Size = new System.Drawing.Size(272, 42);
            this.whichCave.TabIndex = 11;
            this.whichCave.Text = "Choose a Cave!";
            // 
            // chooseCave1
            // 
            this.chooseCave1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseCave1.Location = new System.Drawing.Point(53, 176);
            this.chooseCave1.Name = "chooseCave1";
            this.chooseCave1.Size = new System.Drawing.Size(119, 42);
            this.chooseCave1.TabIndex = 6;
            this.chooseCave1.Text = "Cave 1";
            this.chooseCave1.UseVisualStyleBackColor = true;
            this.chooseCave1.Click += new System.EventHandler(this.chooseCave1_Click);
            // 
            // chooseCave2
            // 
            this.chooseCave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseCave2.Location = new System.Drawing.Point(219, 176);
            this.chooseCave2.Name = "chooseCave2";
            this.chooseCave2.Size = new System.Drawing.Size(119, 42);
            this.chooseCave2.TabIndex = 7;
            this.chooseCave2.Text = "Cave 2";
            this.chooseCave2.UseVisualStyleBackColor = true;
            this.chooseCave2.Click += new System.EventHandler(this.chooseCave2_Click);
            // 
            // chooseCave3
            // 
            this.chooseCave3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseCave3.Location = new System.Drawing.Point(388, 176);
            this.chooseCave3.Name = "chooseCave3";
            this.chooseCave3.Size = new System.Drawing.Size(119, 42);
            this.chooseCave3.TabIndex = 8;
            this.chooseCave3.Text = "Cave 3";
            this.chooseCave3.UseVisualStyleBackColor = true;
            this.chooseCave3.Click += new System.EventHandler(this.chooseCave3_Click);
            // 
            // chooseCave4
            // 
            this.chooseCave4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseCave4.Location = new System.Drawing.Point(555, 176);
            this.chooseCave4.Name = "chooseCave4";
            this.chooseCave4.Size = new System.Drawing.Size(119, 42);
            this.chooseCave4.TabIndex = 9;
            this.chooseCave4.Text = "Cave 4";
            this.chooseCave4.UseVisualStyleBackColor = true;
            this.chooseCave4.Click += new System.EventHandler(this.chooseCave4_Click);
            // 
            // chooseCave5
            // 
            this.chooseCave5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseCave5.Location = new System.Drawing.Point(717, 176);
            this.chooseCave5.Name = "chooseCave5";
            this.chooseCave5.Size = new System.Drawing.Size(119, 42);
            this.chooseCave5.TabIndex = 10;
            this.chooseCave5.Text = "Cave 5";
            this.chooseCave5.UseVisualStyleBackColor = true;
            this.chooseCave5.Click += new System.EventHandler(this.chooseCave5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(877, 665);
            this.Controls.Add(this.chooseCave5);
            this.Controls.Add(this.chooseCave4);
            this.Controls.Add(this.chooseCave3);
            this.Controls.Add(this.chooseCave2);
            this.Controls.Add(this.chooseCave1);
            this.Controls.Add(this.whichCave);
            this.Controls.Add(this.HighScores);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Minigame);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Minigame;
        private System.Windows.Forms.Button HighScores;
        private System.Windows.Forms.TextBox whichCave;
        private System.Windows.Forms.Button chooseCave1;
        private System.Windows.Forms.Button chooseCave2;
        private System.Windows.Forms.Button chooseCave3;
        private System.Windows.Forms.Button chooseCave4;
        private System.Windows.Forms.Button chooseCave5;
    }
}

