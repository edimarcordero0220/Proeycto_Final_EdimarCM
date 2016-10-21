namespace SistemaDiscografico
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.ContrasenatextBox = new System.Windows.Forms.TextBox();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Iniciarbutton = new System.Windows.Forms.Button();
            this.Registrartebutton = new System.Windows.Forms.Button();
            this.MostrarcheckBox = new System.Windows.Forms.CheckBox();
            this.contrasenaerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.contrasenaerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ContrasenatextBox
            // 
            this.ContrasenatextBox.Location = new System.Drawing.Point(239, 44);
            this.ContrasenatextBox.Name = "ContrasenatextBox";
            this.ContrasenatextBox.PasswordChar = '*';
            this.ContrasenatextBox.Size = new System.Drawing.Size(134, 20);
            this.ContrasenatextBox.TabIndex = 0;
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Location = new System.Drawing.Point(46, 44);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.Size = new System.Drawing.Size(135, 20);
            this.UsuariotextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // Iniciarbutton
            // 
            this.Iniciarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Iniciarbutton.Image")));
            this.Iniciarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Iniciarbutton.Location = new System.Drawing.Point(46, 106);
            this.Iniciarbutton.Name = "Iniciarbutton";
            this.Iniciarbutton.Size = new System.Drawing.Size(103, 35);
            this.Iniciarbutton.TabIndex = 4;
            this.Iniciarbutton.Text = "Iniciar";
            this.Iniciarbutton.UseVisualStyleBackColor = true;
            this.Iniciarbutton.Click += new System.EventHandler(this.Iniciarbutton_Click);
            // 
            // Registrartebutton
            // 
            this.Registrartebutton.Image = ((System.Drawing.Image)(resources.GetObject("Registrartebutton.Image")));
            this.Registrartebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Registrartebutton.Location = new System.Drawing.Point(210, 106);
            this.Registrartebutton.Name = "Registrartebutton";
            this.Registrartebutton.Size = new System.Drawing.Size(103, 34);
            this.Registrartebutton.TabIndex = 5;
            this.Registrartebutton.Text = "      Registrarte";
            this.Registrartebutton.UseVisualStyleBackColor = true;
            this.Registrartebutton.Click += new System.EventHandler(this.Registrartebutton_Click);
            // 
            // MostrarcheckBox
            // 
            this.MostrarcheckBox.AutoSize = true;
            this.MostrarcheckBox.Location = new System.Drawing.Point(239, 70);
            this.MostrarcheckBox.Name = "MostrarcheckBox";
            this.MostrarcheckBox.Size = new System.Drawing.Size(99, 17);
            this.MostrarcheckBox.TabIndex = 6;
            this.MostrarcheckBox.Text = "Ver Contraseña";
            this.MostrarcheckBox.UseVisualStyleBackColor = true;
            this.MostrarcheckBox.CheckedChanged += new System.EventHandler(this.VerContrasenacheckBox_CheckedChanged);
            // 
            // contrasenaerrorProvider
            // 
            this.contrasenaerrorProvider.ContainerControl = this;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 184);
            this.Controls.Add(this.MostrarcheckBox);
            this.Controls.Add(this.Registrartebutton);
            this.Controls.Add(this.Iniciarbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.ContrasenatextBox);
            this.Name = "login";
            this.Text = "Login Vcs Record";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contrasenaerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ContrasenatextBox;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Iniciarbutton;
        private System.Windows.Forms.Button Registrartebutton;
      
        private System.Windows.Forms.CheckBox MostrarcheckBox;
        private System.Windows.Forms.CheckBox MostrarContrasenacheckBox;
        private System.Windows.Forms.ErrorProvider UsuarioerrorProvider;
        private System.Windows.Forms.ErrorProvider contrasenaerrorProvider;
    }
}