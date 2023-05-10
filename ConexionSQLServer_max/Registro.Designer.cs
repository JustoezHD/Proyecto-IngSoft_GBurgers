namespace ProyectoIS
{
    partial class Registro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxContrasena = new System.Windows.Forms.TextBox();
            this.txtBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtBoxNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBoxDireccionEmpleado = new System.Windows.Forms.TextBox();
            this.txtBoxCURPEmpleado = new System.Windows.Forms.TextBox();
            this.txtBoxTelefonoEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IniciarSesion = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(0, -6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(805, 203);
            this.label2.TabIndex = 4;
            // 
            // txtBoxContrasena
            // 
            this.txtBoxContrasena.Font = new System.Drawing.Font("Evil Dead", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxContrasena.Location = new System.Drawing.Point(347, 289);
            this.txtBoxContrasena.Name = "txtBoxContrasena";
            this.txtBoxContrasena.PasswordChar = '%';
            this.txtBoxContrasena.Size = new System.Drawing.Size(328, 27);
            this.txtBoxContrasena.TabIndex = 10;
            this.txtBoxContrasena.TextChanged += new System.EventHandler(this.txtBoxContrasena_TextChanged);
            // 
            // txtBoxNombreUsuario
            // 
            this.txtBoxNombreUsuario.Font = new System.Drawing.Font("Evil Dead", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombreUsuario.Location = new System.Drawing.Point(347, 252);
            this.txtBoxNombreUsuario.Name = "txtBoxNombreUsuario";
            this.txtBoxNombreUsuario.Size = new System.Drawing.Size(328, 27);
            this.txtBoxNombreUsuario.TabIndex = 9;
            this.txtBoxNombreUsuario.TextChanged += new System.EventHandler(this.txtBoxNombreUsuario_TextChanged);
            // 
            // txtBoxNombreEmpleado
            // 
            this.txtBoxNombreEmpleado.Font = new System.Drawing.Font("Evil Dead", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombreEmpleado.Location = new System.Drawing.Point(347, 215);
            this.txtBoxNombreEmpleado.Name = "txtBoxNombreEmpleado";
            this.txtBoxNombreEmpleado.Size = new System.Drawing.Size(328, 27);
            this.txtBoxNombreEmpleado.TabIndex = 8;
            this.txtBoxNombreEmpleado.TextChanged += new System.EventHandler(this.txtBoxNombreEmpleado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Evil Dead", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(334, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "REGISTRO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtBoxDireccionEmpleado
            // 
            this.txtBoxDireccionEmpleado.Font = new System.Drawing.Font("Evil Dead", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDireccionEmpleado.Location = new System.Drawing.Point(347, 326);
            this.txtBoxDireccionEmpleado.Name = "txtBoxDireccionEmpleado";
            this.txtBoxDireccionEmpleado.Size = new System.Drawing.Size(328, 27);
            this.txtBoxDireccionEmpleado.TabIndex = 11;
            this.txtBoxDireccionEmpleado.TextChanged += new System.EventHandler(this.txtBoxDireccionEmpleado_TextChanged);
            // 
            // txtBoxCURPEmpleado
            // 
            this.txtBoxCURPEmpleado.Font = new System.Drawing.Font("Evil Dead", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCURPEmpleado.Location = new System.Drawing.Point(347, 363);
            this.txtBoxCURPEmpleado.Name = "txtBoxCURPEmpleado";
            this.txtBoxCURPEmpleado.Size = new System.Drawing.Size(328, 27);
            this.txtBoxCURPEmpleado.TabIndex = 12;
            this.txtBoxCURPEmpleado.TextChanged += new System.EventHandler(this.txtBoxCURPEmpleado_TextChanged);
            // 
            // txtBoxTelefonoEmpleado
            // 
            this.txtBoxTelefonoEmpleado.Font = new System.Drawing.Font("Evil Dead", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTelefonoEmpleado.Location = new System.Drawing.Point(347, 401);
            this.txtBoxTelefonoEmpleado.Name = "txtBoxTelefonoEmpleado";
            this.txtBoxTelefonoEmpleado.Size = new System.Drawing.Size(328, 27);
            this.txtBoxTelefonoEmpleado.TabIndex = 13;
            this.txtBoxTelefonoEmpleado.TextChanged += new System.EventHandler(this.txtBoxTelefonoEmpleado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Evil Dead", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre empleado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Evil Dead", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nombre usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Evil Dead", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Evil Dead", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(147, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Dirección empleado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Evil Dead", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(189, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "CURP empleado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Evil Dead", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(147, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Teléfono empleado";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Evil Dead", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(371, 454);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(122, 33);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Evil Dead", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(563, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "SAlir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IniciarSesion
            // 
            this.IniciarSesion.Font = new System.Drawing.Font("Evil Dead", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSesion.Location = new System.Drawing.Point(151, 454);
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.Size = new System.Drawing.Size(146, 33);
            this.IniciarSesion.TabIndex = 22;
            this.IniciarSesion.Text = "Iniciar Sesión";
            this.IniciarSesion.UseVisualStyleBackColor = true;
            this.IniciarSesion.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox2.Image = global::ProyectoIS.Properties.Resources.ifrit;
            this.pictureBox2.Location = new System.Drawing.Point(458, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(330, 458);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(367, 458);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.IniciarSesion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxTelefonoEmpleado);
            this.Controls.Add(this.txtBoxCURPEmpleado);
            this.Controls.Add(this.txtBoxDireccionEmpleado);
            this.Controls.Add(this.txtBoxContrasena);
            this.Controls.Add(this.txtBoxNombreUsuario);
            this.Controls.Add(this.txtBoxNombreEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxContrasena;
        private System.Windows.Forms.TextBox txtBoxNombreUsuario;
        private System.Windows.Forms.TextBox txtBoxNombreEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBoxDireccionEmpleado;
        private System.Windows.Forms.TextBox txtBoxCURPEmpleado;
        private System.Windows.Forms.TextBox txtBoxTelefonoEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button IniciarSesion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

