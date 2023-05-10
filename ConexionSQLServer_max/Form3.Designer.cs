namespace ProyectoIS
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Evil Dead", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(614, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "admin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(312, -25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(-4, -14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(805, 179);
            this.label2.TabIndex = 8;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Evil Dead", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(629, 66);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(87, 48);
            this.btnCerrarSesion.TabIndex = 11;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Evil Dead", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(489, 41);
            this.label3.TabIndex = 12;
            this.label3.Text = "usuarios";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label label3;
    }
}