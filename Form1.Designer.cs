namespace ZombieSim
{
    partial class FormMain
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
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxZombies = new System.Windows.Forms.PictureBox();
            this.pictureBoxButton = new System.Windows.Forms.PictureBox();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelBrainsCount = new System.Windows.Forms.Label();
            this.labelZombieCount = new System.Windows.Forms.Label();
            this.pictureBoxBrains = new System.Windows.Forms.PictureBox();
            this.labelZombiesPerSecond = new System.Windows.Forms.Label();
            this.labelZombiesPerClick = new System.Windows.Forms.Label();
            this.listBoxUpgrades = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZombies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrains)).BeginInit();
            this.SuspendLayout();
            // 
            // timerCount
            // 
            this.timerCount.Interval = 1000;
            this.timerCount.Tick += new System.EventHandler(this.timerCount_Tick);
            // 
            // pictureBoxZombies
            // 
            this.pictureBoxZombies.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxZombies.Image = global::ZombieSim.Properties.Resources.zombie;
            this.pictureBoxZombies.Location = new System.Drawing.Point(96, 378);
            this.pictureBoxZombies.Name = "pictureBoxZombies";
            this.pictureBoxZombies.Size = new System.Drawing.Size(67, 70);
            this.pictureBoxZombies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxZombies.TabIndex = 8;
            this.pictureBoxZombies.TabStop = false;
            // 
            // pictureBoxButton
            // 
            this.pictureBoxButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxButton.Image = global::ZombieSim.Properties.Resources.buttonReady;
            this.pictureBoxButton.Location = new System.Drawing.Point(167, 27);
            this.pictureBoxButton.Name = "pictureBoxButton";
            this.pictureBoxButton.Size = new System.Drawing.Size(245, 240);
            this.pictureBoxButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxButton.TabIndex = 6;
            this.pictureBoxButton.TabStop = false;
            this.pictureBoxButton.Click += new System.EventHandler(this.pictureBoxButton_Click);
            this.pictureBoxButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxButton_MouseDown);
            this.pictureBoxButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxButton_MouseUp);
            // 
            // labelBrainsCount
            // 
            this.labelBrainsCount.BackColor = System.Drawing.Color.Transparent;
            this.labelBrainsCount.Font = new System.Drawing.Font("Northwood High", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrainsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelBrainsCount.Location = new System.Drawing.Point(179, 469);
            this.labelBrainsCount.Name = "labelBrainsCount";
            this.labelBrainsCount.Size = new System.Drawing.Size(233, 38);
            this.labelBrainsCount.TabIndex = 11;
            this.labelBrainsCount.Text = "0";
            this.labelBrainsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelZombieCount
            // 
            this.labelZombieCount.BackColor = System.Drawing.Color.Transparent;
            this.labelZombieCount.Font = new System.Drawing.Font("Northwood High", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZombieCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelZombieCount.Location = new System.Drawing.Point(179, 396);
            this.labelZombieCount.Name = "labelZombieCount";
            this.labelZombieCount.Size = new System.Drawing.Size(233, 38);
            this.labelZombieCount.TabIndex = 10;
            this.labelZombieCount.Text = "0";
            this.labelZombieCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxBrains
            // 
            this.pictureBoxBrains.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBrains.Image = global::ZombieSim.Properties.Resources.brain;
            this.pictureBoxBrains.Location = new System.Drawing.Point(96, 454);
            this.pictureBoxBrains.Name = "pictureBoxBrains";
            this.pictureBoxBrains.Size = new System.Drawing.Size(67, 70);
            this.pictureBoxBrains.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBrains.TabIndex = 9;
            this.pictureBoxBrains.TabStop = false;
            // 
            // labelZombiesPerSecond
            // 
            this.labelZombiesPerSecond.BackColor = System.Drawing.Color.Transparent;
            this.labelZombiesPerSecond.Font = new System.Drawing.Font("Northwood High", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZombiesPerSecond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelZombiesPerSecond.Location = new System.Drawing.Point(96, 279);
            this.labelZombiesPerSecond.Name = "labelZombiesPerSecond";
            this.labelZombiesPerSecond.Size = new System.Drawing.Size(390, 26);
            this.labelZombiesPerSecond.TabIndex = 12;
            this.labelZombiesPerSecond.Text = "0 zombies per second";
            this.labelZombiesPerSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelZombiesPerClick
            // 
            this.labelZombiesPerClick.BackColor = System.Drawing.Color.Transparent;
            this.labelZombiesPerClick.Font = new System.Drawing.Font("Northwood High", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZombiesPerClick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelZombiesPerClick.Location = new System.Drawing.Point(96, 305);
            this.labelZombiesPerClick.Name = "labelZombiesPerClick";
            this.labelZombiesPerClick.Size = new System.Drawing.Size(390, 26);
            this.labelZombiesPerClick.TabIndex = 13;
            this.labelZombiesPerClick.Text = "1 zombies per click";
            this.labelZombiesPerClick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxUpgrades
            // 
            this.listBoxUpgrades.BackColor = System.Drawing.Color.Black;
            this.listBoxUpgrades.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxUpgrades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBoxUpgrades.FormattingEnabled = true;
            this.listBoxUpgrades.ItemHeight = 32;
            this.listBoxUpgrades.Location = new System.Drawing.Point(527, 0);
            this.listBoxUpgrades.Name = "listBoxUpgrades";
            this.listBoxUpgrades.Size = new System.Drawing.Size(417, 561);
            this.listBoxUpgrades.TabIndex = 14;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::ZombieSim.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.listBoxUpgrades);
            this.Controls.Add(this.labelZombiesPerClick);
            this.Controls.Add(this.labelZombiesPerSecond);
            this.Controls.Add(this.pictureBoxZombies);
            this.Controls.Add(this.pictureBoxButton);
            this.Controls.Add(this.labelBrainsCount);
            this.Controls.Add(this.labelZombieCount);
            this.Controls.Add(this.pictureBoxBrains);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Northwood High", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zombie Apocalypse Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZombies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrains)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerCount;
        private System.Windows.Forms.PictureBox pictureBoxZombies;
        private System.Windows.Forms.PictureBox pictureBoxButton;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private System.Windows.Forms.Label labelBrainsCount;
        private System.Windows.Forms.Label labelZombieCount;
        private System.Windows.Forms.PictureBox pictureBoxBrains;
        private System.Windows.Forms.Label labelZombiesPerSecond;
        private System.Windows.Forms.Label labelZombiesPerClick;
        private System.Windows.Forms.ListBox listBoxUpgrades;
    }
}

