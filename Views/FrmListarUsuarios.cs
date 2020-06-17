using AirSystem.Repositories;
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
    public partial class FrmListarUsuarios : Form
    {
        private string Language { get; set; }
        UsuarioRepository repository = new UsuarioRepository();

        public FrmListarUsuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FrmListarUsuarios(string idioma)
        {
            InitializeComponent();
            Language = idioma;
        }

        private void FrmListarUsuarios_Load(object sender, EventArgs e)
        {
            UsuarioRepository repository = new UsuarioRepository();  

            grid1.DataSource = repository.ListarUsers();
            this.grid1.Columns["Nascimento"].Visible = false;
            this.grid1.Columns["Endereco"].Visible = false;
            this.grid1.Columns["Numero"].Visible = false;
            this.grid1.Columns["User"].Visible = false;
            this.grid1.Columns["Senha"].Visible = false;
            this.grid1.Columns["IsAdmin"].Visible = false;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FrmAdministrador frm = new FrmAdministrador(Language);
            this.Hide();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmCadastro frm = new FrmCadastro(Language);
            frm.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void Pesquisador_TextChanged(object sender, EventArgs e)
        {
            grid1.DataSource = repository.ListarUsers().FindAll(x =>
            x.Nome.ToUpper().Contains(Pesquisador.Text.ToUpper()) ||
            x.Sobrenome.ToUpper().Contains(Pesquisador.Text.ToUpper()) ||
            x.ID.ToString().Contains(Pesquisador.Text.ToUpper())
            );
            Contador();
        }
        private void Contador()
        {
            labContador.Text = $"{grid1.RowCount} itens de {repository.ListarUsers().Count}";
        }
    }
}
