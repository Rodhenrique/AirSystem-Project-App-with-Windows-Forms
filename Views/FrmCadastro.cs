using AirSystem.Models;
using AirSystem.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Views
{
    public partial class FrmCadastro : Form
    {
        private string Languange { get; set; }
        public FrmCadastro()
        {
            InitializeComponent();
        }

        public FrmCadastro(string idioma)
        {
            InitializeComponent();
            Languange = idioma;
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            UsuarioRepository repository = new UsuarioRepository();

            if (true)
            {
                MessageBox.Show("Dados Salvos", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (adminBox.Checked)
                    user.IsAdmin = true;
                else
                    user.IsAdmin = false;

                user.Nome = nameBox.Text;
                user.Sobrenome = surnameBox.Text;
                user.Nascimento = dateBox.Value;
                user.Endereco = adressbox.Text;
                user.Numero = Convert.ToInt32(numberBox.Text);
                user.User = userBox.Text;
                user.Senha = passBox.Text;

                repository.AddUser(user);
                Close();
            }
            else
            {
                MessageBox.Show("Todos os campos são obrigatórios.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Arquivos de imagens (*.jpg, *.png) | *.jpg; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Photo.Image = Image.FromFile(open.FileName);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Photo.Image = null;
        }

        private void passConfirmBox_TextChanged(object sender, EventArgs e)
        {
            if(passConfirmBox.Text != passBox.Text)
                aviso.Text = "Senha Digitada não condiz com o campo senha";
            else
                aviso.Text = "";
        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {
            string Pattern = "(?=^.{8,})(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])";
            bool ver = Regex.IsMatch(passBox.Text,Pattern);
            if (ver)
                labRegex.Text = "";
            else
                labRegex.Text = "A senha dever 8 caracteres, 1 letra maiúscula,1 letra minúscula e um número.";
        }

        private void FrmCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza quer sair?", "Confirmação",
               MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            nameBox.BackColor = Color.Yellow;
            nameBox.ForeColor = Color.Black;
            if (nameBox.Text == "Digite o seu nome aqui")
                nameBox.Text = "";
        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            nameBox.BackColor = Color.White;
            if (nameBox.Text == "")
                nameBox.Text = "Digite o seu nome aqui";
        }

        private void surnameBox_Enter(object sender, EventArgs e)
        {
            surnameBox.BackColor = Color.Yellow;
            surnameBox.ForeColor = Color.Black;
            if (surnameBox.Text == "Digite o seu Sobrenome")
                surnameBox.Text = "";
        }

        private void surnameBox_Leave(object sender, EventArgs e)
        {
            surnameBox.BackColor = Color.White;
            if (surnameBox.Text == "")
                surnameBox.Text = "Digite o seu Sobrenome";
        }

        private void adressbox_Enter(object sender, EventArgs e)
        {
            adressbox.BackColor = Color.Yellow;
            adressbox.ForeColor = Color.Black;
            if (adressbox.Text == "Digite seu endereço")
                adressbox.Text = "";
        }

        private void adressbox_Leave(object sender, EventArgs e)
        {
            adressbox.BackColor = Color.White;
            if (adressbox.Text == "")
                adressbox.Text = "Digite seu endereço";
        }

        private void numberBox_Enter(object sender, EventArgs e)
        {
            numberBox.BackColor = Color.Yellow;
            numberBox.ForeColor = Color.Black;
            if (numberBox.Text == "Nº")
                numberBox.Text = "";
        }

        private void numberBox_Leave(object sender, EventArgs e)
        {
            numberBox.BackColor = Color.White;
            if (numberBox.Text == "")
                numberBox.Text = "Nº";
        }

        private void userBox_Enter(object sender, EventArgs e)
        {
            userBox.BackColor = Color.Yellow;
            userBox.ForeColor = Color.Black;
            if (userBox.Text == "Digite o seu usuário")
                userBox.Text = "";
        }

        private void userBox_Leave(object sender, EventArgs e)
        {
           userBox.BackColor = Color.White;
            if (userBox.Text == "")
                userBox.Text = "Digite o seu usuário";
        }

        private void passBox_Enter(object sender, EventArgs e)
        {
            passBox.BackColor = Color.Yellow;
            passBox.ForeColor = Color.Black;
            if (passBox.Text == "Digite sua senha")
            {
                passBox.Text = "";
                passBox.PasswordChar = '*';
            }
        }

        private void passBox_Leave(object sender, EventArgs e)
        {
            passBox.BackColor = Color.White;
            if (passBox.Text == "")
            {
                passBox.Text = "Digite sua senha";
                this.passBox.PasswordChar = char.Parse("\0");
            }
        }

        private void passConfirmBox_Enter(object sender, EventArgs e)
        {
            passConfirmBox.BackColor = Color.Yellow;
            passConfirmBox.ForeColor = Color.Black;
            if (passConfirmBox.Text == "Confirme sua senha")
            {
                passConfirmBox.Text = "";
                passConfirmBox.PasswordChar = '*';
            }
        }

        private void passConfirmBox_Leave(object sender, EventArgs e)
        {
            passConfirmBox.BackColor = Color.White;
            if (passConfirmBox.Text == "")
            {
                passConfirmBox.Text = "Confirme sua senha";
                this.passConfirmBox.PasswordChar = char.Parse("\0");
            }
        }
    }
}
