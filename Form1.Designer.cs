namespace Space_Race
{
    partial class FrmSpace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpace));
            this.PnlGame = new System.Windows.Forms.Panel();
            this.btncontinue = new System.Windows.Forms.Button();
            this.lblinstruct2 = new System.Windows.Forms.Label();
            this.lblinstruct1 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.PictureMain = new System.Windows.Forms.PictureBox();
            this.TmrPlanet = new System.Windows.Forms.Timer(this.components);
            this.TmrShip = new System.Windows.Forms.Timer(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.PnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMain)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.SystemColors.Desktop;
            this.PnlGame.Controls.Add(this.btncontinue);
            this.PnlGame.Controls.Add(this.lblinstruct2);
            this.PnlGame.Controls.Add(this.lblinstruct1);
            this.PnlGame.Controls.Add(this.BtnStart);
            this.PnlGame.Controls.Add(this.PictureMain);
            this.PnlGame.Location = new System.Drawing.Point(12, 12);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(750, 400);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // btncontinue
            // 
            this.btncontinue.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontinue.ForeColor = System.Drawing.Color.Red;
            this.btncontinue.Location = new System.Drawing.Point(297, 243);
            this.btncontinue.Name = "btncontinue";
            this.btncontinue.Size = new System.Drawing.Size(167, 41);
            this.btncontinue.TabIndex = 4;
            this.btncontinue.Text = "Continue";
            this.btncontinue.UseVisualStyleBackColor = true;
            this.btncontinue.Click += new System.EventHandler(this.btncontinue_Click);
            // 
            // lblinstruct2
            // 
            this.lblinstruct2.AutoSize = true;
            this.lblinstruct2.BackColor = System.Drawing.Color.White;
            this.lblinstruct2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinstruct2.Location = new System.Drawing.Point(70, 191);
            this.lblinstruct2.Name = "lblinstruct2";
            this.lblinstruct2.Size = new System.Drawing.Size(634, 21);
            this.lblinstruct2.TabIndex = 3;
            this.lblinstruct2.Text = "Through the moving obstacles, reach the top of the panel to get a point.";
            // 
            // lblinstruct1
            // 
            this.lblinstruct1.AutoSize = true;
            this.lblinstruct1.BackColor = System.Drawing.Color.White;
            this.lblinstruct1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinstruct1.ForeColor = System.Drawing.Color.Black;
            this.lblinstruct1.Location = new System.Drawing.Point(122, 170);
            this.lblinstruct1.Name = "lblinstruct1";
            this.lblinstruct1.Size = new System.Drawing.Size(522, 21);
            this.lblinstruct1.TabIndex = 2;
            this.lblinstruct1.Text = "Instructions: Use The Arrow Keys to Guide your Spaceship";
            this.lblinstruct1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.White;
            this.BtnStart.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(300, 300);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(164, 76);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // PictureMain
            // 
            this.PictureMain.Image = ((System.Drawing.Image)(resources.GetObject("PictureMain.Image")));
            this.PictureMain.Location = new System.Drawing.Point(3, 0);
            this.PictureMain.Name = "PictureMain";
            this.PictureMain.Size = new System.Drawing.Size(750, 400);
            this.PictureMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureMain.TabIndex = 0;
            this.PictureMain.TabStop = false;
            // 
            // TmrPlanet
            // 
            this.TmrPlanet.Enabled = true;
            this.TmrPlanet.Tick += new System.EventHandler(this.TmrPlanet_Tick);
            // 
            // TmrShip
            // 
            this.TmrShip.Enabled = true;
            this.TmrShip.Interval = 50;
            this.TmrShip.Tick += new System.EventHandler(this.TmrShip_Tick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(805, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(823, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(823, 169);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(56, 20);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score";
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(805, 216);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 27);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "0";
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.PnlGame);
            this.KeyPreview = true;
            this.Name = "FrmSpace";
            this.Text = "Space Race";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSpace_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmSpace_KeyUp);
            this.PnlGame.ResumeLayout(false);
            this.PnlGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.PictureBox PictureMain;
        private System.Windows.Forms.Label lblinstruct1;
        private System.Windows.Forms.Label lblinstruct2;
        private System.Windows.Forms.Button btncontinue;
        private System.Windows.Forms.Timer TmrPlanet;
        private System.Windows.Forms.Timer TmrShip;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtScore;
    }
}

