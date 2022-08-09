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
        public FrmPrincipal()
        {
            InitializeComponent();
        }



        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        public static string ObtenerStringConexion()
        {
            return Settings.Default.stringConexion;
        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
           
        }
    }
}
