using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionUnirPuntos
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            string dato = txtUser.Text;
            Juego jg = new Juego(dato);
            jg.Show();
            this.Close();

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
