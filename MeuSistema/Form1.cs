using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuSistema {
    public partial class FrmMeuSistema : Form {
        public FrmMeuSistema() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnCancelar_Click(object sender, EventArgs e) 
        {
            Application.Exit();
            
        }

        private void btnOk_Click(object sender, EventArgs e) 
        {
            this.Close();
        }    

        private void txtFrase_TextChanged(object sender, EventArgs e) {

        }
    }
}
