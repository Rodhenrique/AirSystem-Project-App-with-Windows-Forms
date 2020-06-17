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
    public partial class FrmUsuario : Form
    {
        private string Language { get; set; }

        public FrmUsuario()
        {
            InitializeComponent();
        }
        public FrmUsuario(string idioma)
        {
            InitializeComponent();
            Language = idioma;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
