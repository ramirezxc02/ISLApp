namespace ISLApp
{
    partial class FrmRegistrarUsuario
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
            this.TxtContrasenia = new System.Windows.Forms.TextBox();
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.CbRol = new System.Windows.Forms.ComboBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtContrasenia
            // 
            this.TxtContrasenia.Location = new System.Drawing.Point(426, 220);
            this.TxtContrasenia.Margin = new System.Windows.Forms.Padding(4);
            this.TxtContrasenia.Multiline = true;
            this.TxtContrasenia.Name = "TxtContrasenia";
            this.TxtContrasenia.PasswordChar = '*';
            this.TxtContrasenia.Size = new System.Drawing.Size(384, 40);
            this.TxtContrasenia.TabIndex = 16;
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Location = new System.Drawing.Point(426, 145);
            this.TxtNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombreUsuario.MaxLength = 50;
            this.TxtNombreUsuario.Multiline = true;
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(384, 40);
            this.TxtNombreUsuario.TabIndex = 15;
            this.TxtNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreUsuario_KeyPress);
            // 
            // CbRol
            // 
            this.CbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRol.FormattingEnabled = true;
            this.CbRol.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.CbRol.Location = new System.Drawing.Point(426, 362);
            this.CbRol.Margin = new System.Windows.Forms.Padding(4);
            this.CbRol.Name = "CbRol";
            this.CbRol.Size = new System.Drawing.Size(384, 24);
            this.CbRol.TabIndex = 14;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(498, 447);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(227, 69);
            this.BtnAgregar.TabIndex = 13;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 347);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 38);
            this.label4.TabIndex = 12;
            this.label4.Text = "Rol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 38);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre de usuario:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(-197, -66);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(325, 54);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Crear Informe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 290);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "Correo:";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(426, 289);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCorreo.Multiline = true;
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(384, 40);
            this.TxtCorreo.TabIndex = 19;
            // 
            // FrmRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 613);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtContrasenia);
            this.Controls.Add(this.TxtNombreUsuario);
            this.Controls.Add(this.CbRol);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmRegistrarUsuario";
            this.Text = "FrmRegistrarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox TxtContrasenia;
        public System.Windows.Forms.TextBox TxtNombreUsuario;
        public System.Windows.Forms.ComboBox CbRol;
        public System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtCorreo;
    }
}