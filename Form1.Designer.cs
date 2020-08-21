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
            this.TmrObstacle = new System.Windows.Forms.Timer(this.components);
            this.TmrShip = new System.Windows.Forms.Timer(this.components);
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
            // FrmSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlGame);
            this.Name = "FrmSpace";
            this.Text = "Space Race";
            this.PnlGame.ResumeLayout(false);
            this.PnlGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.PictureBox PictureMain;
        private System.Windows.Forms.Label lblinstruct1;
        private System.Windows.Forms.Label lblinstruct2;
        private System.Windows.Forms.Button btncontinue;
        private System.Windows.Forms.Timer TmrObstacle;
        private System.Windows.Forms.Timer TmrShip;
    }
}

