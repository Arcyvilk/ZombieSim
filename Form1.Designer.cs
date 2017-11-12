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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxZombies = new System.Windows.Forms.PictureBox();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxBrains = new System.Windows.Forms.PictureBox();
            this.labelZombiesPerSecond = new System.Windows.Forms.Label();
            this.labelZombiesPerClick = new System.Windows.Forms.Label();
            this.textBoxZombieCount = new System.Windows.Forms.TextBox();
            this.textBoxBrainsCount = new System.Windows.Forms.TextBox();
            this.panelStore = new System.Windows.Forms.Panel();
            this.dataGridViewUpgrades = new System.Windows.Forms.DataGridView();
            this.pictureBoxButton = new System.Windows.Forms.PictureBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAchievement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZombies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrains)).BeginInit();
            this.panelStore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpgrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton)).BeginInit();
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
            this.pictureBoxZombies.Location = new System.Drawing.Point(25, 338);
            this.pictureBoxZombies.Name = "pictureBoxZombies";
            this.pictureBoxZombies.Size = new System.Drawing.Size(67, 70);
            this.pictureBoxZombies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxZombies.TabIndex = 8;
            this.pictureBoxZombies.TabStop = false;
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.Sort = "";
            // 
            // pictureBoxBrains
            // 
            this.pictureBoxBrains.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBrains.Image = global::ZombieSim.Properties.Resources.brain;
            this.pictureBoxBrains.Location = new System.Drawing.Point(25, 414);
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
            this.labelZombiesPerSecond.Location = new System.Drawing.Point(51, 268);
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
            this.labelZombiesPerClick.Location = new System.Drawing.Point(51, 294);
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
            this.textBoxZombieCount.Location = new System.Drawing.Point(114, 353);
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
            this.textBoxBrainsCount.Location = new System.Drawing.Point(114, 426);
            this.textBoxBrainsCount.Name = "textBoxBrainsCount";
            this.textBoxBrainsCount.ReadOnly = true;
            this.textBoxBrainsCount.Size = new System.Drawing.Size(275, 41);
            this.textBoxBrainsCount.TabIndex = 16;
            this.textBoxBrainsCount.Text = "0";
            this.textBoxBrainsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBrainsCount.WordWrap = false;
            // 
            // panelStore
            // 
            this.panelStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelStore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStore.Controls.Add(this.dataGridViewUpgrades);
            this.panelStore.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelStore.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelStore.Location = new System.Drawing.Point(436, 0);
            this.panelStore.Name = "panelStore";
            this.panelStore.Size = new System.Drawing.Size(430, 566);
            this.panelStore.TabIndex = 18;
            // 
            // dataGridViewUpgrades
            // 
            this.dataGridViewUpgrades.AllowUserToAddRows = false;
            this.dataGridViewUpgrades.AllowUserToDeleteRows = false;
            this.dataGridViewUpgrades.AllowUserToResizeColumns = false;
            this.dataGridViewUpgrades.AllowUserToResizeRows = false;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle26.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewUpgrades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewUpgrades.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewUpgrades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUpgrades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewUpgrades.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewUpgrades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUpgrades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewUpgrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle28.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUpgrades.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewUpgrades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUpgrades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewUpgrades.EnableHeadersVisualStyles = false;
            this.dataGridViewUpgrades.GridColor = System.Drawing.Color.Black;
            this.dataGridViewUpgrades.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUpgrades.Name = "dataGridViewUpgrades";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUpgrades.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridViewUpgrades.RowHeadersVisible = false;
            this.dataGridViewUpgrades.RowHeadersWidth = 10;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle30.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUpgrades.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridViewUpgrades.RowTemplate.Height = 110;
            this.dataGridViewUpgrades.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewUpgrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUpgrades.ShowCellErrors = false;
            this.dataGridViewUpgrades.ShowRowErrors = false;
            this.dataGridViewUpgrades.Size = new System.Drawing.Size(428, 564);
            this.dataGridViewUpgrades.TabIndex = 23;
            this.dataGridViewUpgrades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUpgrades_CellDoubleClick);
            this.dataGridViewUpgrades.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUpgrades_CellMouseEnter);
            // 
            // pictureBoxButton
            // 
            this.pictureBoxButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxButton.Image = global::ZombieSim.Properties.Resources.buttonReady;
            this.pictureBoxButton.Location = new System.Drawing.Point(151, 35);
            this.pictureBoxButton.Name = "pictureBoxButton";
            this.pictureBoxButton.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxButton.TabIndex = 19;
            this.pictureBoxButton.TabStop = false;
            this.pictureBoxButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxButton_MouseDown);
            this.pictureBoxButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxButton_MouseUp);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.Black;
            this.buttonHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHelp.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.Color.Red;
            this.buttonHelp.Location = new System.Drawing.Point(25, 503);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(83, 35);
            this.buttonHelp.TabIndex = 20;
            this.buttonHelp.Text = "POMOC";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 0;
            this.toolTip.BackColor = System.Drawing.Color.Black;
            this.toolTip.ForeColor = System.Drawing.Color.Yellow;
            // 
            // buttonAchievement
            // 
            this.buttonAchievement.BackColor = System.Drawing.Color.Black;
            this.buttonAchievement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAchievement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAchievement.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAchievement.ForeColor = System.Drawing.Color.Red;
            this.buttonAchievement.Location = new System.Drawing.Point(114, 503);
            this.buttonAchievement.Name = "buttonAchievement";
            this.buttonAchievement.Size = new System.Drawing.Size(275, 35);
            this.buttonAchievement.TabIndex = 21;
            this.buttonAchievement.Text = "OSIĄGNIĘCIA";
            this.buttonAchievement.UseVisualStyleBackColor = false;
            this.buttonAchievement.Click += new System.EventHandler(this.buttonAchievement_Click);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::ZombieSim.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(866, 566);
            this.Controls.Add(this.buttonAchievement);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.pictureBoxButton);
            this.Controls.Add(this.panelStore);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpgrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton)).EndInit();
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
        private System.Windows.Forms.Panel panelStore;
        private System.Windows.Forms.DataGridView dataGridViewUpgrades;
        private System.Windows.Forms.PictureBox pictureBoxButton;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonAchievement;
    }
}

