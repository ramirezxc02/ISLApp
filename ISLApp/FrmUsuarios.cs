using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace ISLApp
{
    public partial class FrmUsuarios : Form
    {

        Conexion connection;
        Usuario usuario;
        
        public FrmUsuarios()
        {
            InitializeComponent();
            this.connection = new Conexion(FrmPrincipal.ObtenerStringConexion());
            usuario = new Usuario();
            btnEditar.Enabled = false;
           
        }

        private void btnAgrega_Click(object sender, EventArgs e)
        {
            try
            {
                FrmRegistrarUsuario frm = new FrmRegistrarUsuario();
                frm.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmRegistrarUsuario frm = new FrmRegistrarUsuario();
                frm.tituloFrmEdit.Text = "Modificar Usuario";
                frm.btnAgregar.Text = "Editar";
                frm.nombreUsuario.Enabled= false;
                frm.contrasena.Enabled= false;
                frm.nombreUsuario.Text = usuario.nombreUsuario.ToString();
                frm.email.Text = usuario.email.ToString();
                frm.cbxRol.Text = usuario.rol.ToString();
                frm.contrasena.Text = "*******";
                frm.ShowDialog();
                
                
            }
            catch(Exception ex)
            {

                throw ex;
            }
            
        }
        private void ConsultarUsuario(string nombreUsuario)
        {
            try
            {
                
                this.dgUsuarios.DataSource = this.connection.BuscarUsuario(nombreUsuario).Tables[0];
                this.dgUsuarios.AutoResizeColumns();
                this.dgUsuarios.ReadOnly = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.ConsultarUsuario(this.txtBuscar.Text);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
            
        }

        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnEditar.Enabled = true;  
                
                this.usuario.nombreUsuario = dgUsuarios.CurrentRow.Cells[0].Value.ToString();
                this.usuario.email = dgUsuarios.CurrentRow.Cells[1].Value.ToString();
                this.usuario.rol = dgUsuarios.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;              
            }
      
           

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                eliminarUsuario();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void eliminarUsuario()
        {
            try
            {
                DialogResult boton = MessageBox.Show("¿Está seguro que desea eliminar este usuario?", "Warning",
                      MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (boton == DialogResult.OK)
                {
                    this.connection.EliminarUsuario(this.usuario.nombreUsuario);
                    MessageBox.Show("Usuario eliminado exitosamente", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
    }//fin de la clase
}//fin del namespace
