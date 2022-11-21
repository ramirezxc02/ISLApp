using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISLApp
{
    public partial class FrmVerInfractor : Form
    {
        private Conexion conexion;
        public FrmVerInfractor()
        {
            InitializeComponent();
            this.conexion = new Conexion(FrmPrincipal.getStringConexion());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.BuscarInfractorPorNombre(this.txtNombre.Text.Trim());
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarInfractorPorNombre(string pNombre)
        {
            try
            {
                this.dtgDatos.DataSource = this.conexion.BuscarInfractor(pNombre).Tables[0];
                this.dtgDatos.AutoResizeColumns();
                this.dtgDatos.ReadOnly = true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dtgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAgregarReporte frmAddRep = this.Owner as FrmAgregarReporte;
            frmAddRep.textBoxIDInfractor.Text = this.dtgDatos.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
