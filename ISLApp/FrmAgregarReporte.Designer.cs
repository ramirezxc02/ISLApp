namespace ISLApp
{
    partial class FrmAgregarReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarReporte));
            this.panelSlideMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCrearInforme = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.textBoxIDreporte = new System.Windows.Forms.TextBox();
            this.labelIDReporte = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxNumeroOficio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonAcciones = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.dateTimeHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimeHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFechaReporte = new System.Windows.Forms.DateTimePicker();
            this.textBoxIDInfractor = new System.Windows.Forms.TextBox();
            this.textBoxCentroOperativo = new System.Windows.Forms.TextBox();
            this.textBoxCodigoPresupuestario = new System.Windows.Forms.TextBox();
            this.textBoxActividad = new System.Windows.Forms.TextBox();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.textBoxCombustible = new System.Windows.Forms.TextBox();
            this.textBoxKmInicial = new System.Windows.Forms.TextBox();
            this.textBoxViatico = new System.Windows.Forms.TextBox();
            this.textBoxKmFinal = new System.Windows.Forms.TextBox();
            this.textBoxRecomendacion = new System.Windows.Forms.TextBox();
            this.textBoxObservacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxNumFuncionariosOtrasInstituciones = new System.Windows.Forms.TextBox();
            this.textBoxNumFuncionariosSINAC = new System.Windows.Forms.TextBox();
            this.checkBoxNorte = new System.Windows.Forms.CheckBox();
            this.checkBoxOeste = new System.Windows.Forms.CheckBox();
            this.checkBoxSur = new System.Windows.Forms.CheckBox();
            this.checkBoxEste = new System.Windows.Forms.CheckBox();
            this.islaSanLucasBDDataSet = new ISLApp.islaSanLucasBDDataSet();
            this.infractorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infractorTableAdapter = new ISLApp.islaSanLucasBDDataSetTableAdapters.InfractorTableAdapter();
            this.pbInf = new System.Windows.Forms.PictureBox();
            this.panelSlideMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.islaSanLucasBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infractorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInf)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSlideMenu
            // 
            this.panelSlideMenu.BackColor = System.Drawing.Color.Gray;
            this.panelSlideMenu.Controls.Add(this.button4);
            this.panelSlideMenu.Controls.Add(this.btnReporte);
            this.panelSlideMenu.Controls.Add(this.btnUsuario);
            this.panelSlideMenu.Controls.Add(this.btnConsultar);
            this.panelSlideMenu.Controls.Add(this.btnCrearInforme);
            this.panelSlideMenu.Controls.Add(this.panel2);
            this.panelSlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSlideMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelSlideMenu.Name = "panelSlideMenu";
            this.panelSlideMenu.Size = new System.Drawing.Size(188, 655);
            this.panelSlideMenu.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(0, 618);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 37);
            this.button4.TabIndex = 5;
            this.button4.Text = "Cerrar sesión";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReporte.Location = new System.Drawing.Point(0, 152);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Padding = new System.Windows.Forms.Padding(9, 0, 0, 4);
            this.btnReporte.Size = new System.Drawing.Size(188, 37);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // btnUsuario
            // 
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsuario.Location = new System.Drawing.Point(2, 110);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Padding = new System.Windows.Forms.Padding(9, 0, 0, 4);
            this.btnUsuario.Size = new System.Drawing.Size(188, 37);
            this.btnUsuario.TabIndex = 3;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuario.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultar.Location = new System.Drawing.Point(0, 193);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Padding = new System.Windows.Forms.Padding(9, 0, 0, 4);
            this.btnConsultar.Size = new System.Drawing.Size(188, 37);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnCrearInforme
            // 
            this.btnCrearInforme.FlatAppearance.BorderSize = 0;
            this.btnCrearInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearInforme.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearInforme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrearInforme.Location = new System.Drawing.Point(0, 63);
            this.btnCrearInforme.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearInforme.Name = "btnCrearInforme";
            this.btnCrearInforme.Padding = new System.Windows.Forms.Padding(9, 0, 0, 4);
            this.btnCrearInforme.Size = new System.Drawing.Size(188, 43);
            this.btnCrearInforme.TabIndex = 1;
            this.btnCrearInforme.Text = "Crear informe";
            this.btnCrearInforme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearInforme.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 65);
            this.panel2.TabIndex = 1;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.OliveDrab;
            this.panelTitleBar.Controls.Add(this.textBoxIDreporte);
            this.panelTitleBar.Controls.Add(this.labelIDReporte);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Controls.Add(this.label17);
            this.panelTitleBar.Controls.Add(this.textBoxNumeroOficio);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(188, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1255, 65);
            this.panelTitleBar.TabIndex = 4;
            // 
            // textBoxIDreporte
            // 
            this.textBoxIDreporte.Enabled = false;
            this.textBoxIDreporte.Location = new System.Drawing.Point(584, 34);
            this.textBoxIDreporte.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIDreporte.Multiline = true;
            this.textBoxIDreporte.Name = "textBoxIDreporte";
            this.textBoxIDreporte.Size = new System.Drawing.Size(62, 24);
            this.textBoxIDreporte.TabIndex = 38;
            // 
            // labelIDReporte
            // 
            this.labelIDReporte.AutoSize = true;
            this.labelIDReporte.Enabled = false;
            this.labelIDReporte.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            this.labelIDReporte.Location = new System.Drawing.Point(503, 39);
            this.labelIDReporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIDReporte.Name = "labelIDReporte";
            this.labelIDReporte.Size = new System.Drawing.Size(82, 19);
            this.labelIDReporte.TabIndex = 37;
            this.labelIDReporte.Text = "ID reporte:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(8, 15);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(177, 28);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Agregar reporte";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            this.label17.Location = new System.Drawing.Point(664, 39);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 19);
            this.label17.TabIndex = 21;
            this.label17.Text = "Número de oficio:";
            // 
            // textBoxNumeroOficio
            // 
            this.textBoxNumeroOficio.Location = new System.Drawing.Point(800, 34);
            this.textBoxNumeroOficio.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumeroOficio.Multiline = true;
            this.textBoxNumeroOficio.Name = "textBoxNumeroOficio";
            this.textBoxNumeroOficio.Size = new System.Drawing.Size(62, 24);
            this.textBoxNumeroOficio.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            this.label1.Location = new System.Drawing.Point(226, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Centro operativo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            this.label2.Location = new System.Drawing.Point(226, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Actividad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            this.label3.Location = new System.Drawing.Point(226, 304);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Código presupuestario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            this.label4.Location = new System.Drawing.Point(673, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hora de inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            this.label5.Location = new System.Drawing.Point(673, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hora de finalización:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            this.label6.Location = new System.Drawing.Point(675, 408);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Combustible:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            this.label7.Location = new System.Drawing.Point(1070, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Viatico:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            this.label9.Location = new System.Drawing.Point(1070, 188);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "km inicial / horas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            this.label10.Location = new System.Drawing.Point(1070, 246);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "km final / horas:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            this.label11.Location = new System.Drawing.Point(226, 374);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 19);
            this.label11.TabIndex = 15;
            this.label11.Text = "Lugares recorridos:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            this.label14.Location = new System.Drawing.Point(1070, 362);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 19);
            this.label14.TabIndex = 18;
            this.label14.Text = "Observación:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            this.label15.Location = new System.Drawing.Point(1066, 307);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 19);
            this.label15.TabIndex = 19;
            this.label15.Text = "Recomendación:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            this.label16.Location = new System.Drawing.Point(675, 355);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 19);
            this.label16.TabIndex = 40;
            this.label16.Text = "Matricula:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            this.label18.Location = new System.Drawing.Point(671, 110);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 19);
            this.label18.TabIndex = 42;
            this.label18.Text = "Fecha:";
            // 
            // buttonAcciones
            // 
            this.buttonAcciones.BackColor = System.Drawing.Color.Green;
            this.buttonAcciones.FlatAppearance.BorderSize = 0;
            this.buttonAcciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcciones.Location = new System.Drawing.Point(661, 576);
            this.buttonAcciones.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAcciones.Name = "buttonAcciones";
            this.buttonAcciones.Size = new System.Drawing.Size(280, 50);
            this.buttonAcciones.TabIndex = 44;
            this.buttonAcciones.Text = "Guardar reporte";
            this.buttonAcciones.UseVisualStyleBackColor = false;
            this.buttonAcciones.Click += new System.EventHandler(this.button1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            this.label19.Location = new System.Drawing.Point(226, 106);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 19);
            this.label19.TabIndex = 45;
            this.label19.Text = "ID Infractor:";
            // 
            // dateTimeHoraInicio
            // 
            this.dateTimeHoraInicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimeHoraInicio.CustomFormat = " HH:mm:ss";
            this.dateTimeHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeHoraInicio.Location = new System.Drawing.Point(835, 179);
            this.dateTimeHoraInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeHoraInicio.Name = "dateTimeHoraInicio";
            this.dateTimeHoraInicio.ShowUpDown = true;
            this.dateTimeHoraInicio.Size = new System.Drawing.Size(91, 20);
            this.dateTimeHoraInicio.TabIndex = 1;
            // 
            // dateTimeHoraFinal
            // 
            this.dateTimeHoraFinal.CustomFormat = "hh:mm:ss";
            this.dateTimeHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeHoraFinal.Location = new System.Drawing.Point(835, 232);
            this.dateTimeHoraFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeHoraFinal.Name = "dateTimeHoraFinal";
            this.dateTimeHoraFinal.ShowUpDown = true;
            this.dateTimeHoraFinal.Size = new System.Drawing.Size(91, 20);
            this.dateTimeHoraFinal.TabIndex = 47;
            // 
            // dateTimeFechaReporte
            // 
            this.dateTimeFechaReporte.CustomFormat = "dd-mm-yyyy";
            this.dateTimeFechaReporte.Location = new System.Drawing.Point(734, 106);
            this.dateTimeFechaReporte.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeFechaReporte.Name = "dateTimeFechaReporte";
            this.dateTimeFechaReporte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimeFechaReporte.Size = new System.Drawing.Size(240, 20);
            this.dateTimeFechaReporte.TabIndex = 48;
            // 
            // textBoxIDInfractor
            // 
            this.textBoxIDInfractor.Enabled = false;
            this.textBoxIDInfractor.Location = new System.Drawing.Point(388, 106);
            this.textBoxIDInfractor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIDInfractor.Multiline = true;
            this.textBoxIDInfractor.Name = "textBoxIDInfractor";
            this.textBoxIDInfractor.Size = new System.Drawing.Size(121, 24);
            this.textBoxIDInfractor.TabIndex = 49;
            // 
            // textBoxCentroOperativo
            // 
            this.textBoxCentroOperativo.Location = new System.Drawing.Point(388, 178);
            this.textBoxCentroOperativo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCentroOperativo.Multiline = true;
            this.textBoxCentroOperativo.Name = "textBoxCentroOperativo";
            this.textBoxCentroOperativo.Size = new System.Drawing.Size(240, 24);
            this.textBoxCentroOperativo.TabIndex = 50;
            // 
            // textBoxCodigoPresupuestario
            // 
            this.textBoxCodigoPresupuestario.Location = new System.Drawing.Point(396, 299);
            this.textBoxCodigoPresupuestario.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCodigoPresupuestario.Multiline = true;
            this.textBoxCodigoPresupuestario.Name = "textBoxCodigoPresupuestario";
            this.textBoxCodigoPresupuestario.Size = new System.Drawing.Size(192, 24);
            this.textBoxCodigoPresupuestario.TabIndex = 51;
            // 
            // textBoxActividad
            // 
            this.textBoxActividad.Location = new System.Drawing.Point(388, 234);
            this.textBoxActividad.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxActividad.Multiline = true;
            this.textBoxActividad.Name = "textBoxActividad";
            this.textBoxActividad.Size = new System.Drawing.Size(240, 24);
            this.textBoxActividad.TabIndex = 52;
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(808, 350);
            this.textBoxMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMatricula.Multiline = true;
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(240, 24);
            this.textBoxMatricula.TabIndex = 55;
            // 
            // textBoxCombustible
            // 
            this.textBoxCombustible.Location = new System.Drawing.Point(808, 408);
            this.textBoxCombustible.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCombustible.Multiline = true;
            this.textBoxCombustible.Name = "textBoxCombustible";
            this.textBoxCombustible.Size = new System.Drawing.Size(240, 24);
            this.textBoxCombustible.TabIndex = 56;
            // 
            // textBoxKmInicial
            // 
            this.textBoxKmInicial.Location = new System.Drawing.Point(1204, 188);
            this.textBoxKmInicial.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKmInicial.Multiline = true;
            this.textBoxKmInicial.Name = "textBoxKmInicial";
            this.textBoxKmInicial.Size = new System.Drawing.Size(139, 24);
            this.textBoxKmInicial.TabIndex = 57;
            // 
            // textBoxViatico
            // 
            this.textBoxViatico.Location = new System.Drawing.Point(1204, 118);
            this.textBoxViatico.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxViatico.Multiline = true;
            this.textBoxViatico.Name = "textBoxViatico";
            this.textBoxViatico.Size = new System.Drawing.Size(208, 24);
            this.textBoxViatico.TabIndex = 58;
            // 
            // textBoxKmFinal
            // 
            this.textBoxKmFinal.Location = new System.Drawing.Point(1204, 245);
            this.textBoxKmFinal.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKmFinal.Multiline = true;
            this.textBoxKmFinal.Name = "textBoxKmFinal";
            this.textBoxKmFinal.Size = new System.Drawing.Size(139, 24);
            this.textBoxKmFinal.TabIndex = 59;
            // 
            // textBoxRecomendacion
            // 
            this.textBoxRecomendacion.Location = new System.Drawing.Point(1204, 302);
            this.textBoxRecomendacion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRecomendacion.Multiline = true;
            this.textBoxRecomendacion.Name = "textBoxRecomendacion";
            this.textBoxRecomendacion.Size = new System.Drawing.Size(208, 24);
            this.textBoxRecomendacion.TabIndex = 60;
            // 
            // textBoxObservacion
            // 
            this.textBoxObservacion.Location = new System.Drawing.Point(1204, 360);
            this.textBoxObservacion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxObservacion.Multiline = true;
            this.textBoxObservacion.Name = "textBoxObservacion";
            this.textBoxObservacion.Size = new System.Drawing.Size(208, 24);
            this.textBoxObservacion.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            this.label8.Location = new System.Drawing.Point(675, 302);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 19);
            this.label8.TabIndex = 62;
            this.label8.Text = "Placa:";
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(808, 299);
            this.textBoxPlaca.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPlaca.Multiline = true;
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(240, 24);
            this.textBoxPlaca.TabIndex = 63;
            this.textBoxPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPlaca_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            this.label12.Location = new System.Drawing.Point(665, 461);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(208, 19);
            this.label12.TabIndex = 64;
            this.label12.Text = "Núm de funcionarios SINAC:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F);
            this.label13.Location = new System.Drawing.Point(652, 514);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(289, 19);
            this.label13.TabIndex = 65;
            this.label13.Text = "Núm de funcionarios otras instituciones:";
            // 
            // textBoxNumFuncionariosOtrasInstituciones
            // 
            this.textBoxNumFuncionariosOtrasInstituciones.Location = new System.Drawing.Point(921, 511);
            this.textBoxNumFuncionariosOtrasInstituciones.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumFuncionariosOtrasInstituciones.Multiline = true;
            this.textBoxNumFuncionariosOtrasInstituciones.Name = "textBoxNumFuncionariosOtrasInstituciones";
            this.textBoxNumFuncionariosOtrasInstituciones.Size = new System.Drawing.Size(240, 24);
            this.textBoxNumFuncionariosOtrasInstituciones.TabIndex = 66;
            this.textBoxNumFuncionariosOtrasInstituciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumFuncionariosOtrasInstituciones_KeyPress);
            // 
            // textBoxNumFuncionariosSINAC
            // 
            this.textBoxNumFuncionariosSINAC.Location = new System.Drawing.Point(880, 456);
            this.textBoxNumFuncionariosSINAC.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumFuncionariosSINAC.Multiline = true;
            this.textBoxNumFuncionariosSINAC.Name = "textBoxNumFuncionariosSINAC";
            this.textBoxNumFuncionariosSINAC.Size = new System.Drawing.Size(240, 24);
            this.textBoxNumFuncionariosSINAC.TabIndex = 67;
            this.textBoxNumFuncionariosSINAC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumFuncionariosSINAC_KeyPress);
            // 
            // checkBoxNorte
            // 
            this.checkBoxNorte.AutoSize = true;
            this.checkBoxNorte.Location = new System.Drawing.Point(232, 409);
            this.checkBoxNorte.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxNorte.Name = "checkBoxNorte";
            this.checkBoxNorte.Size = new System.Drawing.Size(239, 17);
            this.checkBoxNorte.TabIndex = 68;
            this.checkBoxNorte.Text = "Norte de Playa Cocos hasta Playa Bella Vista";
            this.checkBoxNorte.UseVisualStyleBackColor = true;
            // 
            // checkBoxOeste
            // 
            this.checkBoxOeste.AutoSize = true;
            this.checkBoxOeste.Location = new System.Drawing.Point(230, 442);
            this.checkBoxOeste.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOeste.Name = "checkBoxOeste";
            this.checkBoxOeste.Size = new System.Drawing.Size(270, 17);
            this.checkBoxOeste.TabIndex = 69;
            this.checkBoxOeste.Text = "Oeste de Playa Bella Vista hasta Playa Tumbabotes";
            this.checkBoxOeste.UseVisualStyleBackColor = true;
            // 
            // checkBoxSur
            // 
            this.checkBoxSur.AutoSize = true;
            this.checkBoxSur.Location = new System.Drawing.Point(230, 475);
            this.checkBoxSur.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxSur.Name = "checkBoxSur";
            this.checkBoxSur.Size = new System.Drawing.Size(237, 17);
            this.checkBoxSur.TabIndex = 70;
            this.checkBoxSur.Text = "Sur de Playa Tumbabotes hasta Playa Limón";
            this.checkBoxSur.UseVisualStyleBackColor = true;
            // 
            // checkBoxEste
            // 
            this.checkBoxEste.AutoSize = true;
            this.checkBoxEste.Location = new System.Drawing.Point(230, 511);
            this.checkBoxEste.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEste.Name = "checkBoxEste";
            this.checkBoxEste.Size = new System.Drawing.Size(230, 17);
            this.checkBoxEste.TabIndex = 71;
            this.checkBoxEste.Text = "Este desde Playa Limón hasta Playa Cocos";
            this.checkBoxEste.UseVisualStyleBackColor = true;
            // 
            // islaSanLucasBDDataSet
            // 
            this.islaSanLucasBDDataSet.DataSetName = "islaSanLucasBDDataSet";
            this.islaSanLucasBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infractorBindingSource
            // 
            this.infractorBindingSource.DataMember = "Infractor";
            this.infractorBindingSource.DataSource = this.islaSanLucasBDDataSet;
            // 
            // infractorTableAdapter
            // 
            this.infractorTableAdapter.ClearBeforeFill = true;
            // 
            // pbInf
            // 
            this.pbInf.Image = ((System.Drawing.Image)(resources.GetObject("pbInf.Image")));
            this.pbInf.Location = new System.Drawing.Point(526, 106);
            this.pbInf.Margin = new System.Windows.Forms.Padding(2);
            this.pbInf.Name = "pbInf";
            this.pbInf.Size = new System.Drawing.Size(33, 29);
            this.pbInf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInf.TabIndex = 72;
            this.pbInf.TabStop = false;
            this.pbInf.Click += new System.EventHandler(this.pbProd_Click);
            // 
            // FrmAgregarReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 655);
            this.Controls.Add(this.pbInf);
            this.Controls.Add(this.checkBoxEste);
            this.Controls.Add(this.checkBoxSur);
            this.Controls.Add(this.checkBoxOeste);
            this.Controls.Add(this.checkBoxNorte);
            this.Controls.Add(this.textBoxNumFuncionariosSINAC);
            this.Controls.Add(this.textBoxNumFuncionariosOtrasInstituciones);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxObservacion);
            this.Controls.Add(this.textBoxRecomendacion);
            this.Controls.Add(this.textBoxKmFinal);
            this.Controls.Add(this.textBoxViatico);
            this.Controls.Add(this.textBoxKmInicial);
            this.Controls.Add(this.textBoxCombustible);
            this.Controls.Add(this.textBoxMatricula);
            this.Controls.Add(this.textBoxActividad);
            this.Controls.Add(this.textBoxCodigoPresupuestario);
            this.Controls.Add(this.textBoxCentroOperativo);
            this.Controls.Add(this.textBoxIDInfractor);
            this.Controls.Add(this.dateTimeFechaReporte);
            this.Controls.Add(this.dateTimeHoraFinal);
            this.Controls.Add(this.dateTimeHoraInicio);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.buttonAcciones);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelSlideMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAgregarReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarReporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAgregarReporte_Load);
            this.panelSlideMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.islaSanLucasBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infractorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSlideMenu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCrearInforme;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button buttonAcciones;
        public System.Windows.Forms.TextBox textBoxIDreporte;
        public System.Windows.Forms.Label labelIDReporte;
        public System.Windows.Forms.TextBox textBoxNumeroOficio;
        public System.Windows.Forms.DateTimePicker dateTimeHoraInicio;
        public System.Windows.Forms.DateTimePicker dateTimeHoraFinal;
        public System.Windows.Forms.DateTimePicker dateTimeFechaReporte;
        public System.Windows.Forms.TextBox textBoxIDInfractor;
        public System.Windows.Forms.TextBox textBoxCentroOperativo;
        public System.Windows.Forms.TextBox textBoxCodigoPresupuestario;
        public System.Windows.Forms.TextBox textBoxActividad;
        public System.Windows.Forms.TextBox textBoxMatricula;
        public System.Windows.Forms.TextBox textBoxCombustible;
        public System.Windows.Forms.TextBox textBoxKmInicial;
        public System.Windows.Forms.TextBox textBoxViatico;
        public System.Windows.Forms.TextBox textBoxKmFinal;
        public System.Windows.Forms.TextBox textBoxRecomendacion;
        public System.Windows.Forms.TextBox textBoxObservacion;
        public System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox textBoxNumFuncionariosOtrasInstituciones;
        public System.Windows.Forms.TextBox textBoxNumFuncionariosSINAC;
        private System.Windows.Forms.CheckBox checkBoxNorte;
        private System.Windows.Forms.CheckBox checkBoxOeste;
        private System.Windows.Forms.CheckBox checkBoxSur;
        private System.Windows.Forms.CheckBox checkBoxEste;
        private islaSanLucasBDDataSet islaSanLucasBDDataSet;
        private System.Windows.Forms.BindingSource infractorBindingSource;
        private islaSanLucasBDDataSetTableAdapters.InfractorTableAdapter infractorTableAdapter;
        private System.Windows.Forms.PictureBox pbInf;
    }
}