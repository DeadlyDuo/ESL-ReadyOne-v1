namespace ESL_ReadyOne_v1
{
    partial class MainMenu
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
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.Label_ReadyToPlay = new System.Windows.Forms.Label();
            this.Pic_IndicatorBottom = new System.Windows.Forms.PictureBox();
            this.Label_FirstTimeSetup = new System.Windows.Forms.Label();
            this.Pic_IndicatorTop = new System.Windows.Forms.PictureBox();
            this.MainMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_IndicatorBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_IndicatorTop)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BackgroundImage = global::ESL_ReadyOne_v1.Properties.Resources.MainMenu_Background_01;
            this.MainMenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainMenuPanel.Controls.Add(this.Label_ReadyToPlay);
            this.MainMenuPanel.Controls.Add(this.Pic_IndicatorBottom);
            this.MainMenuPanel.Controls.Add(this.Label_FirstTimeSetup);
            this.MainMenuPanel.Controls.Add(this.Pic_IndicatorTop);
            this.MainMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(1008, 729);
            this.MainMenuPanel.TabIndex = 0;
            // 
            // Label_ReadyToPlay
            // 
            this.Label_ReadyToPlay.BackColor = System.Drawing.Color.Transparent;
            this.Label_ReadyToPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_ReadyToPlay.Font = new System.Drawing.Font("Tw Cen MT", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ReadyToPlay.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_ReadyToPlay.Location = new System.Drawing.Point(106, 341);
            this.Label_ReadyToPlay.Name = "Label_ReadyToPlay";
            this.Label_ReadyToPlay.Size = new System.Drawing.Size(501, 78);
            this.Label_ReadyToPlay.TabIndex = 3;
            this.Label_ReadyToPlay.Text = "READY TO PLAY";
            this.Label_ReadyToPlay.MouseEnter += new System.EventHandler(this.Label_ReadyToPlay_MouseEnter);
            this.Label_ReadyToPlay.MouseLeave += new System.EventHandler(this.Label_ReadyToPlay_MouseLeave);
            // 
            // Pic_IndicatorBottom
            // 
            this.Pic_IndicatorBottom.BackColor = System.Drawing.Color.Transparent;
            this.Pic_IndicatorBottom.BackgroundImage = global::ESL_ReadyOne_v1.Properties.Resources.MainMenu_SelectBar;
            this.Pic_IndicatorBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pic_IndicatorBottom.Location = new System.Drawing.Point(-23, 332);
            this.Pic_IndicatorBottom.Name = "Pic_IndicatorBottom";
            this.Pic_IndicatorBottom.Size = new System.Drawing.Size(123, 87);
            this.Pic_IndicatorBottom.TabIndex = 2;
            this.Pic_IndicatorBottom.TabStop = false;
            this.Pic_IndicatorBottom.Visible = false;
            // 
            // Label_FirstTimeSetup
            // 
            this.Label_FirstTimeSetup.BackColor = System.Drawing.Color.Transparent;
            this.Label_FirstTimeSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_FirstTimeSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_FirstTimeSetup.Font = new System.Drawing.Font("Tw Cen MT", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FirstTimeSetup.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_FirstTimeSetup.Location = new System.Drawing.Point(106, 205);
            this.Label_FirstTimeSetup.Name = "Label_FirstTimeSetup";
            this.Label_FirstTimeSetup.Size = new System.Drawing.Size(535, 79);
            this.Label_FirstTimeSetup.TabIndex = 1;
            this.Label_FirstTimeSetup.Text = "FIRST TIME SETUP";
            this.Label_FirstTimeSetup.Click += new System.EventHandler(this.Label_FirstTimeSetup_Click);
            this.Label_FirstTimeSetup.MouseEnter += new System.EventHandler(this.Label_FirstTimeSetup_MouseEnter);
            this.Label_FirstTimeSetup.MouseLeave += new System.EventHandler(this.Label_FirstTimeSetup_MouseLeave);
            // 
            // Pic_IndicatorTop
            // 
            this.Pic_IndicatorTop.BackColor = System.Drawing.Color.Transparent;
            this.Pic_IndicatorTop.BackgroundImage = global::ESL_ReadyOne_v1.Properties.Resources.MainMenu_SelectBar;
            this.Pic_IndicatorTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pic_IndicatorTop.Location = new System.Drawing.Point(-23, 197);
            this.Pic_IndicatorTop.Name = "Pic_IndicatorTop";
            this.Pic_IndicatorTop.Size = new System.Drawing.Size(123, 87);
            this.Pic_IndicatorTop.TabIndex = 0;
            this.Pic_IndicatorTop.TabStop = false;
            this.Pic_IndicatorTop.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.MainMenuPanel);
            this.Name = "MainMenu";
            this.Text = "ESL-ReadyOne";
            this.MainMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_IndicatorBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_IndicatorTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.PictureBox Pic_IndicatorTop;
        private System.Windows.Forms.Label Label_FirstTimeSetup;
        private System.Windows.Forms.Label Label_ReadyToPlay;
        private System.Windows.Forms.PictureBox Pic_IndicatorBottom;
    }
}

