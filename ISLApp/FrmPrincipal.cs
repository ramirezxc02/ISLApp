using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ISLApp.Properties;

namespace ISLApp
{
    public partial class FrmPrincipal : Form
    {
        FrmInformeInfractor frmInforme;
        
        public FrmPrincipal()
        {
            InitializeComponent();
            
        }

        public static String getStringConexion()
        {
            return Settings.Default.StrConexion;
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {

        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void btnCrearInforme_Click(object sender, EventArgs e)
        {
            frmInforme = new FrmInformeInfractor();
            this.frmInforme.MdiParent = this;
            this.frmInforme.Show();
        }
    }
}
