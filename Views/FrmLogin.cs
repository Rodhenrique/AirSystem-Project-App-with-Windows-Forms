using AirSystem.Models;
using AirSystem.Repositories;
using AirSystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem
{
    public partial class FrmLogin : Form
    {
        private string Language { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            UsuarioRepository repository = new UsuarioRepository();
            Usuario user = new Usuario() { User = "user", Nome = "user", Senha = "1234", Endereco = "rua heroi 9", Numero = 123, IsAdmin = false, Nascimento = Convert.ToDateTime("12/02/2000"), Sobrenome = "Hercule" };
            Usuario user1 = new Usuario() { User = "admin", Nome = "admin", Senha = "1234", Endereco = "rua admin 10", Numero = 987, IsAdmin = true, Nascimento = Convert.ToDateTime("12/02/1998"), Sobrenome = "superman" };

            repository.AddUser(user);
            repository.AddUser(user1);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            string[] itens = new string[]{"Português PT-BR","English EN-US"};

            foreach(var item in itens)
            {
            idiomaBox.Items.Add(item);
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastro frm = new FrmCadastro();
            frm.Show();
        }

        private void idiomaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idioma = idiomaBox.Text.ToString();
            Language = idioma;
            string[] itens = new string[] { "Português PT-BR", "English EN-US" };

            if (idioma == itens[1])
            {
                labIdioma.Text = "Language";
                labPass.Text = "Password";
                labUser.Text = "User";
                BtnCadastrar.Text = "New User";
                BtnSair.Text = "Get Out";
                BtnEntrar.Text = "Log In";
            }else if (idioma == itens[0])
            {
                labIdioma.Text = "Idioma";
                labPass.Text = "Senha";
                labUser.Text = "Usuário";
                BtnCadastrar.Text = "Novo Usuário";
                BtnSair.Text = "Sair";
                BtnEntrar.Text = "Entrar";
            }
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            string user = userBox.Text.ToString();
            string pass = passBox.Text.ToString();

            string Admin = "admin";
            string passAdmin = "1234";
            if (user != "" && pass != "")
            {
                if (Language == null)
                {
                    Language = "Português PT - BR";
                }
                MessageBox.Show("Seja Bem-Vindo");
                if (user == Admin && pass == passAdmin)
                {               
                    FrmAdministrador frm = new FrmAdministrador(Language);
                    this.Hide();
                    frm.Closed += (s, args) => this.Close();
                    frm.Show();
                }
                else
                {
                    FrmUsuario frm = new FrmUsuario(Language);
                    this.Hide();
                    frm.Closed += (s, args) => this.Close();
                    frm.Show();
                }
            }
            else{
                MessageBox.Show("Senha ou Usuário Incorreta");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToLongTimeString();

        }
    }
}
