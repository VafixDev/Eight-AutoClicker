namespace accMinecraft
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.tbLeft = new System.Windows.Forms.TrackBar();
            this.lblLeftCPS = new System.Windows.Forms.Label();
            this.leftClicker = new System.Windows.Forms.Timer(this.components);
            this.chLeftButt = new System.Windows.Forms.CheckBox();
            this.chRightButt = new System.Windows.Forms.CheckBox();
            this.tbRight = new System.Windows.Forms.TrackBar();
            this.lblRightCPS = new System.Windows.Forms.Label();
            this.rightClicker = new System.Windows.Forms.Timer(this.components);
            this.btnLeftBind = new System.Windows.Forms.Button();
            this.btnRightBind = new System.Windows.Forms.Button();
            this.leftBind = new System.Windows.Forms.Timer(this.components);
            this.rightBind = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLeft
            // 
            this.tbLeft.Location = new System.Drawing.Point(12, 8);
            this.tbLeft.Maximum = 25;
            this.tbLeft.Minimum = 6;
            this.tbLeft.Name = "tbLeft";
            this.tbLeft.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbLeft.Size = new System.Drawing.Size(56, 383);
            this.tbLeft.TabIndex = 0;
            this.tbLeft.Value = 6;
            this.tbLeft.Scroll += new System.EventHandler(this.trackClick_Scroll);
            // 
            // lblLeftCPS
            // 
            this.lblLeftCPS.AutoSize = true;
            this.lblLeftCPS.BackColor = System.Drawing.Color.Transparent;
            this.lblLeftCPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLeftCPS.ForeColor = System.Drawing.Color.Coral;
            this.lblLeftCPS.Location = new System.Drawing.Point(54, 352);
            this.lblLeftCPS.Name = "lblLeftCPS";
            this.lblLeftCPS.Size = new System.Drawing.Size(93, 29);
            this.lblLeftCPS.TabIndex = 1;
            this.lblLeftCPS.Text = "CPS: 5";
            // 
            // leftClicker
            // 
            this.leftClicker.Enabled = true;
            this.leftClicker.Tick += new System.EventHandler(this.LeftAcc_Tick);
            // 
            // chLeftButt
            // 
            this.chLeftButt.AutoSize = true;
            this.chLeftButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chLeftButt.ForeColor = System.Drawing.Color.Coral;
            this.chLeftButt.Location = new System.Drawing.Point(59, 29);
            this.chLeftButt.Name = "chLeftButt";
            this.chLeftButt.Size = new System.Drawing.Size(125, 24);
            this.chLeftButt.TabIndex = 2;
            this.chLeftButt.Text = "Left Button";
            this.chLeftButt.UseVisualStyleBackColor = true;
            // 
            // chRightButt
            // 
            this.chRightButt.AutoSize = true;
            this.chRightButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chRightButt.ForeColor = System.Drawing.Color.Coral;
            this.chRightButt.Location = new System.Drawing.Point(228, 29);
            this.chRightButt.Name = "chRightButt";
            this.chRightButt.Size = new System.Drawing.Size(136, 24);
            this.chRightButt.TabIndex = 3;
            this.chRightButt.Text = "Right Button";
            this.chRightButt.UseVisualStyleBackColor = true;
            // 
            // tbRight
            // 
            this.tbRight.Location = new System.Drawing.Point(380, 8);
            this.tbRight.Maximum = 25;
            this.tbRight.Minimum = 6;
            this.tbRight.Name = "tbRight";
            this.tbRight.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbRight.Size = new System.Drawing.Size(56, 383);
            this.tbRight.TabIndex = 4;
            this.tbRight.Value = 6;
            this.tbRight.Scroll += new System.EventHandler(this.tbRight_Scroll);
            // 
            // lblRightCPS
            // 
            this.lblRightCPS.AutoSize = true;
            this.lblRightCPS.BackColor = System.Drawing.Color.Transparent;
            this.lblRightCPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRightCPS.ForeColor = System.Drawing.Color.Coral;
            this.lblRightCPS.Location = new System.Drawing.Point(271, 352);
            this.lblRightCPS.Name = "lblRightCPS";
            this.lblRightCPS.Size = new System.Drawing.Size(93, 29);
            this.lblRightCPS.TabIndex = 5;
            this.lblRightCPS.Text = "CPS: 5";
            // 
            // rightClicker
            // 
            this.rightClicker.Enabled = true;
            this.rightClicker.Tick += new System.EventHandler(this.rightClicker_Tick);
            // 
            // btnLeftBind
            // 
            this.btnLeftBind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLeftBind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeftBind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLeftBind.ForeColor = System.Drawing.Color.Coral;
            this.btnLeftBind.Location = new System.Drawing.Point(59, 59);
            this.btnLeftBind.Name = "btnLeftBind";
            this.btnLeftBind.Size = new System.Drawing.Size(125, 28);
            this.btnLeftBind.TabIndex = 6;
            this.btnLeftBind.Text = "None";
            this.btnLeftBind.UseVisualStyleBackColor = false;
            this.btnLeftBind.Click += new System.EventHandler(this.btnLeftBind_Click);
            this.btnLeftBind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnLeftBind_KeyUp);
            // 
            // btnRightBind
            // 
            this.btnRightBind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRightBind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRightBind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRightBind.ForeColor = System.Drawing.Color.Coral;
            this.btnRightBind.Location = new System.Drawing.Point(228, 59);
            this.btnRightBind.Name = "btnRightBind";
            this.btnRightBind.Size = new System.Drawing.Size(125, 28);
            this.btnRightBind.TabIndex = 7;
            this.btnRightBind.Text = "None";
            this.btnRightBind.UseVisualStyleBackColor = false;
            this.btnRightBind.Click += new System.EventHandler(this.btnRightBind_Click);
            this.btnRightBind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnRightBind_KeyUp);
            // 
            // leftBind
            // 
            this.leftBind.Enabled = true;
            this.leftBind.Interval = 150;
            this.leftBind.Tick += new System.EventHandler(this.leftBind_Tick);
            // 
            // rightBind
            // 
            this.rightBind.Enabled = true;
            this.rightBind.Interval = 150;
            this.rightBind.Tick += new System.EventHandler(this.rightBind_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::accMinecraft.Properties.Resources.whiteLogo;
            this.pictureBox1.Location = new System.Drawing.Point(87, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(448, 403);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRightBind);
            this.Controls.Add(this.btnLeftBind);
            this.Controls.Add(this.lblRightCPS);
            this.Controls.Add(this.tbRight);
            this.Controls.Add(this.chRightButt);
            this.Controls.Add(this.chLeftButt);
            this.Controls.Add(this.lblLeftCPS);
            this.Controls.Add(this.tbLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(466, 450);
            this.MinimumSize = new System.Drawing.Size(466, 450);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eight v1.0.0 by VafixDev";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbLeft;
        private System.Windows.Forms.Label lblLeftCPS;
        private System.Windows.Forms.Timer leftClicker;
        private System.Windows.Forms.CheckBox chLeftButt;
        private System.Windows.Forms.CheckBox chRightButt;
        private System.Windows.Forms.TrackBar tbRight;
        private System.Windows.Forms.Label lblRightCPS;
        private System.Windows.Forms.Timer rightClicker;
        private System.Windows.Forms.Button btnLeftBind;
        private System.Windows.Forms.Button btnRightBind;
        private System.Windows.Forms.Timer leftBind;
        private System.Windows.Forms.Timer rightBind;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

