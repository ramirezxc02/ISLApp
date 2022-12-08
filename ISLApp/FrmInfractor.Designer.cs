
namespace ISLApp
{
    partial class FrmInfractor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.tbNombreInfractor = new System.Windows.Forms.TextBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.actividadIlegalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbActividades = new System.Windows.Forms.ComboBox();
            this.actividadIlegalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.islaSanLucasBDDataSet = new ISLApp.islaSanLucasBDDataSet();
            this.actividadIlegalTableAdapter = new ISLApp.islaSanLucasBDDataSetTableAdapters.ActividadIlegalTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButtonRegresar = new FontAwesome.Sharp.IconButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxNumeroOficio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.actividadIlegalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadIlegalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islaSanLucasBDDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cédula Infractor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Infractor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo:";
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(443, 444);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(384, 46);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "GUARDAR ";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Turista",
            "Capitan"});
            this.cbTipo.Location = new System.Drawing.Point(443, 250);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(384, 33);
            this.cbTipo.TabIndex = 5;
            // 
            // tbCedula
            // 
            this.tbCedula.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCedula.Location = new System.Drawing.Point(443, 68);
            this.tbCedula.Margin = new System.Windows.Forms.Padding(4);
            this.tbCedula.MaxLength = 9;
            this.tbCedula.Multiline = true;
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(384, 40);
            this.tbCedula.TabIndex = 6;
            this.tbCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCedula_KeyPress);
            // 
            // tbNombreInfractor
            // 
            this.tbNombreInfractor.Enabled = false;
            this.tbNombreInfractor.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreInfractor.Location = new System.Drawing.Point(443, 156);
            this.tbNombreInfractor.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombreInfractor.Multiline = true;
            this.tbNombreInfractor.Name = "tbNombreInfractor";
            this.tbNombreInfractor.Size = new System.Drawing.Size(384, 40);
            this.tbNombreInfractor.TabIndex = 7;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBusqueda.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBusqueda.FlatAppearance.BorderSize = 0;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.Location = new System.Drawing.Point(894, 67);
            this.btnBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(147, 41);
            this.btnBusqueda.TabIndex = 8;
            this.btnBusqueda.Text = "BUSCAR";
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // actividadIlegalBindingSource
            // 
            this.actividadIlegalBindingSource.DataMember = "ActividadIlegal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 333);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Actividad ilegal:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbActividades
            // 
            this.cbActividades.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.actividadIlegalBindingSource1, "idActividadIlegal", true));
            this.cbActividades.DataSource = this.actividadIlegalBindingSource1;
            this.cbActividades.DisplayMember = "nombreActividadIlegal";
            this.cbActividades.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActividades.FormattingEnabled = true;
            this.cbActividades.Location = new System.Drawing.Point(443, 337);
            this.cbActividades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbActividades.Name = "cbActividades";
            this.cbActividades.Size = new System.Drawing.Size(384, 33);
            this.cbActividades.TabIndex = 11;
            this.cbActividades.ValueMember = "idActividadIlegal";
            // 
            // actividadIlegalBindingSource1
            // 
            this.actividadIlegalBindingSource1.DataMember = "ActividadIlegal";
            this.actividadIlegalBindingSource1.DataSource = this.islaSanLucasBDDataSet;
            // 
            // islaSanLucasBDDataSet
            // 
            this.islaSanLucasBDDataSet.DataSetName = "islaSanLucasBDDataSet";
            this.islaSanLucasBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actividadIlegalTableAdapter
            // 
            this.actividadIlegalTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Controls.Add(this.btnBusqueda);
            this.groupBox1.Controls.Add(this.cbActividades);
            this.groupBox1.Controls.Add(this.tbCedula);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbNombreInfractor);
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(0, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1159, 516);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.OliveDrab;
            this.panelTitleBar.Controls.Add(this.iconButton1);
            this.panelTitleBar.Controls.Add(this.iconButtonRegresar);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Controls.Add(this.label17);
            this.panelTitleBar.Controls.Add(this.textBoxNumeroOficio);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1159, 80);
            this.panelTitleBar.TabIndex = 23;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(1053, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(74, 65);
            this.iconButton1.TabIndex = 38;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // iconButtonRegresar
            // 
            this.iconButtonRegresar.FlatAppearance.BorderSize = 0;
            this.iconButtonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRegresar.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.iconButtonRegresar.IconColor = System.Drawing.Color.White;
            this.iconButtonRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRegresar.Location = new System.Drawing.Point(1713, 16);
            this.iconButtonRegresar.Name = "iconButtonRegresar";
            this.iconButtonRegresar.Size = new System.Drawing.Size(74, 65);
            this.iconButtonRegresar.TabIndex = 37;
            this.iconButtonRegresar.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(44, 29);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(235, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "AGREGAR INFORME";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(1247, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(163, 23);
            this.label17.TabIndex = 21;
            this.label17.Text = "Número de oficio:";
            // 
            // textBoxNumeroOficio
            // 
            this.textBoxNumeroOficio.Location = new System.Drawing.Point(1493, 29);
            this.textBoxNumeroOficio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNumeroOficio.Multiline = true;
            this.textBoxNumeroOficio.Name = "textBoxNumeroOficio";
            this.textBoxNumeroOficio.Size = new System.Drawing.Size(150, 29);
            this.textBoxNumeroOficio.TabIndex = 36;
            // 
            // FrmInfractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1159, 613);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInfractor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmInfractor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actividadIlegalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadIlegalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islaSanLucasBDDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.TextBox tbNombreInfractor;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.BindingSource actividadIlegalBindingSource;
        private System.Windows.Forms.ComboBox cbActividades;
        private islaSanLucasBDDataSet islaSanLucasBDDataSet;
        private System.Windows.Forms.BindingSource actividadIlegalBindingSource1;
        private islaSanLucasBDDataSetTableAdapters.ActividadIlegalTableAdapter actividadIlegalTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButtonRegresar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox textBoxNumeroOficio;
    }
}