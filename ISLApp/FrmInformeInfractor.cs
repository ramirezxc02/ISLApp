using BLL;
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
    public partial class FrmInformeInfractor : Form
    {
        private Conexion conexion;
        private string  nombre, cedula, tipo;
         int id= 0;
        public FrmInformeInfractor()
        {
            InitializeComponent();
            this.conexion = new Conexion(FrmPrincipal.getStringConexion());
            this.cargarTabla();
        }


        private void FrmInformeInfractor_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmInfractor infractor = new FrmInfractor(this);
            infractor.Show();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dgInfractores.DataSource = conexion.busqueda(txtBusqueda.Text);
                this.dgInfractores.ReadOnly = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se encontro un error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmInfractor modificarInfractor = new FrmInfractor(this, true, cedula, nombre, tipo, id);
            modificarInfractor.Show();
        }

        public void cargarTabla() {
            try
            {
                this.dgInfractores.DataSource = conexion.consultaInfractores();
                this.dgInfractores.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro un error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0) {
                    conexion.deshabilitar(id);
                    MessageBox.Show("Se ha eliminado de manera correcta","Proceso realizado de manera correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cargarTabla();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar a un infractor", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se encontro un error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //permite selecionar y guardar los datos de la celda selecionada para modificar o eliminar 
        private void dgInfractores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgInfractores.CurrentRow.Cells[0].Value.ToString());
            nombre = dgInfractores.CurrentRow.Cells[1].Value.ToString();
            cedula = dgInfractores.CurrentRow.Cells[2].Value.ToString();
            tipo = dgInfractores.CurrentRow.Cells[3].Value.ToString();
            
        }
    }
}