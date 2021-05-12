namespace Car_Rental_System
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.MyProgress = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.Percentage = new System.Windows.Forms.Label();
            this.MyCar = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MyProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyCar)).BeginInit();
            this.SuspendLayout();
            // 
            // MyProgress
            // 
            this.MyProgress.AnimationSpeed = 0.6F;
            this.MyProgress.BaseColor = System.Drawing.Color.ForestGreen;
            this.MyProgress.Controls.Add(this.Percentage);
            this.MyProgress.Controls.Add(this.MyCar);
            this.MyProgress.ForeColor = System.Drawing.SystemColors.Window;
            this.MyProgress.IdleColor = System.Drawing.Color.Gainsboro;
            this.MyProgress.IdleOffset = 20;
            this.MyProgress.IdleThickness = 8;
            this.MyProgress.Image = null;
            this.MyProgress.ImageSize = new System.Drawing.Size(52, 52);
            this.MyProgress.Location = new System.Drawing.Point(258, 95);
            this.MyProgress.Name = "MyProgress";
            this.MyProgress.ProgressMaxColor = System.Drawing.Color.Gold;
            this.MyProgress.ProgressMinColor = System.Drawing.Color.Yellow;
            this.MyProgress.ProgressOffset = 20;
            this.MyProgress.ProgressThickness = 8;
            this.MyProgress.Size = new System.Drawing.Size(436, 350);
            this.MyProgress.TabIndex = 1;
            // 
            // Percentage
            // 
            this.Percentage.AutoSize = true;
            this.Percentage.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percentage.ForeColor = System.Drawing.SystemColors.Window;
            this.Percentage.Location = new System.Drawing.Point(218, 288);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(25, 19);
            this.Percentage.TabIndex = 4;
            this.Percentage.Text = "%";
            // 
            // MyCar
            // 
            this.MyCar.BackColor = System.Drawing.Color.ForestGreen;
            this.MyCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MyCar.BaseColor = System.Drawing.Color.White;
            this.MyCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyCar.Image = ((System.Drawing.Image)(resources.GetObject("MyCar.Image")));
            this.MyCar.Location = new System.Drawing.Point(68, 78);
            this.MyCar.Name = "MyCar";
            this.MyCar.Size = new System.Drawing.Size(298, 194);
            this.MyCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyCar.TabIndex = 0;
            this.MyCar.TabStop = false;
            this.MyCar.UseTransfarantBackground = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(268, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Car Rental Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(417, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "SOUL SPARTANS";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(933, 702);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MyProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Splash_Load_1);
            this.MyProgress.ResumeLayout(false);
            this.MyProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCircleProgressBar MyProgress;
        private Guna.UI.WinForms.GunaCirclePictureBox MyCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Percentage;
    }
}

