
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
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.islaSanLucasBDDataSet = new ISLApp.islaSanLucasBDDataSet();
            this.actividadIlegalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.actividadIlegalTableAdapter = new ISLApp.islaSanLucasBDDataSetTableAdapters.ActividadIlegalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.actividadIlegalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islaSanLucasBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadIlegalBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(181, 70);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Crear Informe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cédula Infractor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Infractor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(545, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo:";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(701, 579);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(170, 56);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear informe";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Turista",
            "Capitan"});
            this.cbTipo.Location = new System.Drawing.Point(648, 418);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(289, 21);
            this.cbTipo.TabIndex = 5;
            // 
            // tbCedula
            // 
            this.tbCedula.Location = new System.Drawing.Point(648, 241);
            this.tbCedula.MaxLength = 9;
            this.tbCedula.Multiline = true;
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(289, 33);
            this.tbCedula.TabIndex = 6;
            this.tbCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCedula_KeyPress);
            // 
            // tbNombreInfractor
            // 
            this.tbNombreInfractor.Enabled = false;
            this.tbNombreInfractor.Location = new System.Drawing.Point(648, 326);
            this.tbNombreInfractor.Multiline = true;
            this.tbNombreInfractor.Name = "tbNombreInfractor";
            this.tbNombreInfractor.Size = new System.Drawing.Size(289, 33);
            this.tbNombreInfractor.TabIndex = 7;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBusqueda.Location = new System.Drawing.Point(966, 241);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(110, 33);
            this.btnBusqueda.TabIndex = 8;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // actividadIlegalBindingSource
            // 
            this.actividadIlegalBindingSource.DataMember = "ActividadIlegal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Actividad Ilegal:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbActividades
            // 
            this.cbActividades.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.actividadIlegalBindingSource1, "idActividadIlegal", true));
            this.cbActividades.DataSource = this.actividadIlegalBindingSource1;
            this.cbActividades.DisplayMember = "nombreActividadIlegal";
            this.cbActividades.FormattingEnabled = true;
            this.cbActividades.Location = new System.Drawing.Point(648, 491);
            this.cbActividades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbActividades.Name = "cbActividades";
            this.cbActividades.Size = new System.Drawing.Size(289, 21);
            this.cbActividades.TabIndex = 11;
            this.cbActividades.ValueMember = "idActividadIlegal";
            // 
            // islaSanLucasBDDataSet
            // 
            this.islaSanLucasBDDataSet.DataSetName = "islaSanLucasBDDataSet";
            this.islaSanLucasBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actividadIlegalBindingSource1
            // 
            this.actividadIlegalBindingSource1.DataMember = "ActividadIlegal";
            this.actividadIlegalBindingSource1.DataSource = this.islaSanLucasBDDataSet;
            // 
            // actividadIlegalTableAdapter
            // 
            this.actividadIlegalTableAdapter.ClearBeforeFill = true;
            // 
            // FrmInfractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 682);
            this.Controls.Add(this.cbActividades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.tbNombreInfractor);
            this.Controls.Add(this.tbCedula);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmInfractor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInfractor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actividadIlegalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islaSanLucasBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadIlegalBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
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
    }
}