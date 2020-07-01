namespace WinManager
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.btnLogin = new System.Windows.Forms.Button();
            this.tlpSplash = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbSplash = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSplashImage = new System.Windows.Forms.PictureBox();
            this.tlpSplash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSplashImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.Location = new System.Drawing.Point(587, 434);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 24);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.OnLogin);
            // 
            // tlpSplash
            // 
            this.tlpSplash.ColumnCount = 3;
            this.tlpSplash.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSplash.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpSplash.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpSplash.Controls.Add(this.btnLogin, 1, 2);
            this.tlpSplash.Controls.Add(this.btnExit, 2, 2);
            this.tlpSplash.Controls.Add(this.pbSplash, 0, 2);
            this.tlpSplash.Controls.Add(this.label1, 0, 1);
            this.tlpSplash.Controls.Add(this.pbSplashImage, 0, 0);
            this.tlpSplash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSplash.Location = new System.Drawing.Point(0, 0);
            this.tlpSplash.Name = "tlpSplash";
            this.tlpSplash.RowCount = 3;
            this.tlpSplash.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSplash.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSplash.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSplash.Size = new System.Drawing.Size(784, 461);
            this.tlpSplash.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Location = new System.Drawing.Point(687, 434);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 24);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.OnExit);
            // 
            // pbSplash
            // 
            this.pbSplash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSplash.Location = new System.Drawing.Point(3, 434);
            this.pbSplash.Name = "pbSplash";
            this.pbSplash.Size = new System.Drawing.Size(578, 24);
            this.pbSplash.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tlpSplash.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(778, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ready";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbSplashImage
            // 
            this.tlpSplash.SetColumnSpan(this.pbSplashImage, 3);
            this.pbSplashImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSplashImage.Image = ((System.Drawing.Image)(resources.GetObject("pbSplashImage.Image")));
            this.pbSplashImage.Location = new System.Drawing.Point(3, 3);
            this.pbSplashImage.Name = "pbSplashImage";
            this.pbSplashImage.Size = new System.Drawing.Size(778, 405);
            this.pbSplashImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSplashImage.TabIndex = 4;
            this.pbSplashImage.TabStop = false;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tlpSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.tlpSplash.ResumeLayout(false);
            this.tlpSplash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSplashImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TableLayoutPanel tlpSplash;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ProgressBar pbSplash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbSplashImage;
    }
}

