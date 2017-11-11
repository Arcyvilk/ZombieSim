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
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxBrains = new System.Windows.Forms.PictureBox();
            this.labelZombiesPerSecond = new System.Windows.Forms.Label();
            this.labelZombiesPerClick = new System.Windows.Forms.Label();
            this.textBoxZombieCount = new System.Windows.Forms.TextBox();
            this.textBoxBrainsCount = new System.Windows.Forms.TextBox();
            this.buttonIncrementZombies = new System.Windows.Forms.Button();
            this.panelStore = new System.Windows.Forms.Panel();
            this.labelStore = new System.Windows.Forms.Label();
            this.listBoxUpgrades = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZombies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrains)).BeginInit();
            this.panelStore.SuspendLayout();
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
            // textBoxZombieCount
            // 
            this.textBoxZombieCount.BackColor = System.Drawing.Color.Black;
            this.textBoxZombieCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxZombieCount.Enabled = false;
            this.textBoxZombieCount.ForeColor = System.Drawing.Color.White;
            this.textBoxZombieCount.Location = new System.Drawing.Point(185, 393);
            this.textBoxZombieCount.Name = "textBoxZombieCount";
            this.textBoxZombieCount.ReadOnly = true;
            this.textBoxZombieCount.Size = new System.Drawing.Size(275, 41);
            this.textBoxZombieCount.TabIndex = 15;
            this.textBoxZombieCount.Text = "0";
            this.textBoxZombieCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxZombieCount.WordWrap = false;
            // 
            // textBoxBrainsCount
            // 
            this.textBoxBrainsCount.BackColor = System.Drawing.Color.Black;
            this.textBoxBrainsCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBrainsCount.Enabled = false;
            this.textBoxBrainsCount.ForeColor = System.Drawing.Color.White;
            this.textBoxBrainsCount.Location = new System.Drawing.Point(185, 466);
            this.textBoxBrainsCount.Name = "textBoxBrainsCount";
            this.textBoxBrainsCount.ReadOnly = true;
            this.textBoxBrainsCount.Size = new System.Drawing.Size(275, 41);
            this.textBoxBrainsCount.TabIndex = 16;
            this.textBoxBrainsCount.Text = "0";
            this.textBoxBrainsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBrainsCount.WordWrap = false;
            // 
            // buttonIncrementZombies
            // 
            this.buttonIncrementZombies.BackColor = System.Drawing.Color.Red;
            this.buttonIncrementZombies.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonIncrementZombies.FlatAppearance.BorderSize = 20;
            this.buttonIncrementZombies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonIncrementZombies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIncrementZombies.Location = new System.Drawing.Point(192, 46);
            this.buttonIncrementZombies.Name = "buttonIncrementZombies";
            this.buttonIncrementZombies.Size = new System.Drawing.Size(200, 200);
            this.buttonIncrementZombies.TabIndex = 17;
            this.buttonIncrementZombies.UseVisualStyleBackColor = false;
            this.buttonIncrementZombies.Click += new System.EventHandler(this.buttonIncrementZombies_Click);
            // 
            // panelStore
            // 
            this.panelStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelStore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStore.Controls.Add(this.labelStore);
            this.panelStore.Controls.Add(this.listBoxUpgrades);
            this.panelStore.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelStore.Location = new System.Drawing.Point(570, 0);
            this.panelStore.Name = "panelStore";
            this.panelStore.Size = new System.Drawing.Size(374, 561);
            this.panelStore.TabIndex = 18;
            // 
            // labelStore
            // 
            this.labelStore.BackColor = System.Drawing.Color.Black;
            this.labelStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelStore.ForeColor = System.Drawing.Color.White;
            this.labelStore.Location = new System.Drawing.Point(0, 0);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(372, 42);
            this.labelStore.TabIndex = 20;
            this.labelStore.Text = "STORE";
            this.labelStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxUpgrades
            // 
            this.listBoxUpgrades.BackColor = System.Drawing.Color.Black;
            this.listBoxUpgrades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxUpgrades.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxUpgrades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBoxUpgrades.FormattingEnabled = true;
            this.listBoxUpgrades.ItemHeight = 32;
            this.listBoxUpgrades.Location = new System.Drawing.Point(0, 47);
            this.listBoxUpgrades.Name = "listBoxUpgrades";
            this.listBoxUpgrades.Size = new System.Drawing.Size(372, 512);
            this.listBoxUpgrades.TabIndex = 19;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::ZombieSim.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.panelStore);
            this.Controls.Add(this.buttonIncrementZombies);
            this.Controls.Add(this.textBoxBrainsCount);
            this.Controls.Add(this.textBoxZombieCount);
            this.Controls.Add(this.labelZombiesPerClick);
            this.Controls.Add(this.labelZombiesPerSecond);
            this.Controls.Add(this.pictureBoxZombies);
            this.Controls.Add(this.pictureBoxBrains);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Northwood High", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zombie Apocalypse Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZombies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrains)).EndInit();
            this.panelStore.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerCount;
        private System.Windows.Forms.PictureBox pictureBoxZombies;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private System.Windows.Forms.PictureBox pictureBoxBrains;
        private System.Windows.Forms.Label labelZombiesPerSecond;
        private System.Windows.Forms.Label labelZombiesPerClick;
        private System.Windows.Forms.TextBox textBoxZombieCount;
        private System.Windows.Forms.TextBox textBoxBrainsCount;
        private System.Windows.Forms.Button buttonIncrementZombies;
        private System.Windows.Forms.Panel panelStore;
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.ListBox listBoxUpgrades;
    }
}

