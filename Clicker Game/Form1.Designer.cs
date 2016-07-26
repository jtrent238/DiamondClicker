namespace Clicker_Game
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Miner = new System.Windows.Forms.Timer(this.components);
            this.DrawDiamonds = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.DrillTimer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.MakerTimer = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Catch = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.QuarryTimer = new System.Windows.Forms.Timer(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.DrawItems = new System.Windows.Forms.Timer(this.components);
            this.Achivements = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.AutoSave = new System.Windows.Forms.Timer(this.components);
            this.AutoSaveText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diamonds: 0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 130);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mine Diamond";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 61);
            this.button2.TabIndex = 2;
            this.button2.Text = "Buy Diamond Miner $25";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "You have 0 Miners";
            // 
            // Miner
            // 
            this.Miner.Interval = 2500;
            this.Miner.Tick += new System.EventHandler(this.Miner_Tick);
            // 
            // DrawDiamonds
            // 
            this.DrawDiamonds.Interval = 75;
            this.DrawDiamonds.Tick += new System.EventHandler(this.DrawDiamonds_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "You have 0 Drills";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 61);
            this.button3.TabIndex = 4;
            this.button3.Text = "Buy Diamond Drill $200";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DrillTimer
            // 
            this.DrillTimer.Interval = 2000;
            this.DrillTimer.Tick += new System.EventHandler(this.DrillTimer_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "You have 0 Makers";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(248, 260);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 61);
            this.button4.TabIndex = 6;
            this.button4.Text = "Buy Diamond Maker $1000";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MakerTimer
            // 
            this.MakerTimer.Interval = 1000;
            this.MakerTimer.Tick += new System.EventHandler(this.MakerTimer_Tick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 403);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 81);
            this.button5.TabIndex = 8;
            this.button5.Text = "Save Game";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(140, 403);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 81);
            this.button6.TabIndex = 9;
            this.button6.Text = "Load Saved Game";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Catch
            // 
            this.Catch.AutoSize = true;
            this.Catch.Location = new System.Drawing.Point(744, 468);
            this.Catch.Name = "Catch";
            this.Catch.Size = new System.Drawing.Size(51, 13);
            this.Catch.TabIndex = 10;
            this.Catch.Text = "No Errors";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "You have 0 Quarrys";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(406, 34);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(133, 61);
            this.button7.TabIndex = 11;
            this.button7.Text = "Buy Diamond Quarry $10000";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // QuarryTimer
            // 
            this.QuarryTimer.Interval = 1000;
            this.QuarryTimer.Tick += new System.EventHandler(this.QuarryTimer_Tick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(616, 403);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(122, 81);
            this.button8.TabIndex = 13;
            this.button8.Text = "Restart Save";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // DrawItems
            // 
            this.DrawItems.Interval = 150;
            this.DrawItems.Tick += new System.EventHandler(this.DrawItems_Tick);
            // 
            // Achivements
            // 
            this.Achivements.Interval = 150;
            this.Achivements.Tick += new System.EventHandler(this.Achivements_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Achivement";
            this.label6.Visible = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(673, 149);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(122, 81);
            this.button9.TabIndex = 15;
            this.button9.Text = "Achivement List";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // AutoSave
            // 
            this.AutoSave.Interval = 120000;
            this.AutoSave.Tick += new System.EventHandler(this.AutoSave_Tick);
            // 
            // AutoSaveText
            // 
            this.AutoSaveText.AutoSize = true;
            this.AutoSaveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoSaveText.Location = new System.Drawing.Point(268, 403);
            this.AutoSaveText.Name = "AutoSaveText";
            this.AutoSaveText.Size = new System.Drawing.Size(158, 29);
            this.AutoSaveText.TabIndex = 16;
            this.AutoSaveText.Text = "Auto Saving...";
            this.AutoSaveText.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 490);
            this.Controls.Add(this.AutoSaveText);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Catch);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Miner;
        private System.Windows.Forms.Timer DrawDiamonds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer DrillTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer MakerTimer;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label Catch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer QuarryTimer;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Timer DrawItems;
        private System.Windows.Forms.Timer Achivements;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button9;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Timer AutoSave;
        private System.Windows.Forms.Label AutoSaveText;

    }
}

