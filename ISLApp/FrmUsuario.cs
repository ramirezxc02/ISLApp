using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace ISLApp
{
    public partial class FrmUsuario : Form
    {
        Usuario usuario;
        Conexion conexion;
        public FrmUsuario()
        {
            InitializeComponent();
            this.conexion = new Conexion(FrmPrincipal.getStringConexion()); // obtiene la conexion para la base de datos.
            usuario = new Usuario();
            //BtnEditar.Enabled = false;
            //BtnEliminar.Enabled = false;
        }

        //private void FrmUsuario_Load(object sender, EventArgs e)
        //{
        //    FrmInformeInfractor frm = new FrmInformeInfractor();
        //    frm.Show();
        //    this.Hide();
            
        //}

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsuario frmRegistrarUsuario = new FrmRegistrarUsuario();

            frmRegistrarUsuario.Show();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.DgUsuarios.CurrentRow != null)
                {

                    string nombreUsuario = DgUsuarios.CurrentRow.Cells[0].Value.ToString();
                    FrmRegistrarUsuario frm = new FrmRegistrarUsuario(nombreUsuario);
                    frm.BtnAgregar.Text = "Modificar Usuario";
                    frm.BtnAgregar.Text = "Editar";
                    frm.TxtNombreUsuario.Text = DgUsuarios.CurrentRow.Cells[0].Value.ToString();
                    frm.TxtCorreo.Text = DgUsuarios.CurrentRow.Cells[1].Value.ToString();
                    frm.CbRol.Text = DgUsuarios.CurrentRow.Cells[2].Value.ToString();
                    frm.TxtContrasenia.Text = DgUsuarios.CurrentRow.Cells[3].Value.ToString();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void ConsultarUsuario(string nombreUsuario)
        {
            try
            {

                this.DgUsuarios.DataSource = this.conexion.BuscarUsuario(nombreUsuario).Tables[0];
                this.DgUsuarios.AutoResizeColumns();
                this.DgUsuarios.ReadOnly = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.ConsultarUsuario(this.TxtBusqueda.Text);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    

        private void DgUsuarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //BtnEditar.Enabled = true;
                //BtnEliminar.Enabled = true;

                this.usuario.nombreUsuario = DgUsuarios.CurrentRow.Cells[0].Value.ToString();
                this.usuario.email = DgUsuarios.CurrentRow.Cells[1].Value.ToString();
                this.usuario.rol = DgUsuarios.CurrentRow.Cells[2].Value.ToString();
                this.usuario.password = DgUsuarios.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void EliminarUsuario()
        {
            try
            {
                if (this.DgUsuarios.CurrentRow != null)
                {
                    string username = DgUsuarios.CurrentRow.Cells[0].Value.ToString();
                    DialogResult boton = MessageBox.Show("¿Está seguro que desea eliminar el usuario " + username + "? ", "Warning",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (boton == DialogResult.OK)
                    {
                        this.conexion.EliminarUsuario(username);
                        MessageBox.Show("Usuario eliminado exitosamente", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ConsultarUsuario(this.TxtBusqueda.Text);

                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                EliminarUsuario();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void mostrarUsuarios()
        {
            try
            {
                this.DgUsuarios.DataSource = this.conexion.mostrarUsuarios().Tables[0];
                this.DgUsuarios.AutoResizeColumns();
                this.DgUsuarios.ReadOnly = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsuario frmRegistrarUsuario = new FrmRegistrarUsuario();

            frmRegistrarUsuario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.DgUsuarios.CurrentRow != null)
                {

                    string nombreUsuario = DgUsuarios.CurrentRow.Cells[0].Value.ToString();
                    FrmRegistrarUsuario frm = new FrmRegistrarUsuario(nombreUsuario);
                    frm.BtnAgregar.Text = "MODIFICAR";
                    frm.TxtNombreUsuario.Text = DgUsuarios.CurrentRow.Cells[0].Value.ToString();
                    frm.TxtCorreo.Text = DgUsuarios.CurrentRow.Cells[1].Value.ToString();
                    frm.CbRol.Text = DgUsuarios.CurrentRow.Cells[2].Value.ToString();
                    frm.TxtContrasenia.Text = DgUsuarios.CurrentRow.Cells[3].Value.ToString();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                EliminarUsuario();
                this.mostrarUsuarios();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.mostrarUsuarios();
        }
    }//fin de la clase
}//fin del namespace
