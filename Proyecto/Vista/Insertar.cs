using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Vista
{
    public partial class Insertar : Form
    {
        public Insertar()
        {
            InitializeComponent();
        }
        public Button getIniciar() { return this.btnIniciar; }
        public ComboBox getSele() { return this.cmbSele; }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }
    }
}
