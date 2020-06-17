using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Views
{
    public partial class FrmAdministrador : Form
    {
        private string Language { get; set; }

        public FrmAdministrador()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public FrmAdministrador(string idioma)
        {
            InitializeComponent();
            Language = idioma;
        }

        private void FrmAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            FrmListarUsuarios frm = new FrmListarUsuarios(Language);
            this.Hide();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
