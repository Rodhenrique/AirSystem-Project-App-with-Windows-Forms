namespace AirSystem.Views
{
    partial class FrmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.adressbox = new System.Windows.Forms.TextBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.userBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.passConfirmBox = new System.Windows.Forms.TextBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.adminBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.aviso = new System.Windows.Forms.Label();
            this.labRegex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.Window;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.nameBox.Location = new System.Drawing.Point(172, 46);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(184, 23);
            this.nameBox.TabIndex = 0;
            this.nameBox.Text = "Digite o seu nome aqui";
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // surnameBox
            // 
            this.surnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.surnameBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.surnameBox.Location = new System.Drawing.Point(362, 46);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(184, 23);
            this.surnameBox.TabIndex = 1;
            this.surnameBox.Text = "Digite o seu Sobrenome";
            this.surnameBox.Enter += new System.EventHandler(this.surnameBox_Enter);
            this.surnameBox.Leave += new System.EventHandler(this.surnameBox_Leave);
            // 
            // adressbox
            // 
            this.adressbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.adressbox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.adressbox.Location = new System.Drawing.Point(172, 84);
            this.adressbox.Name = "adressbox";
            this.adressbox.Size = new System.Drawing.Size(283, 23);
            this.adressbox.TabIndex = 2;
            this.adressbox.Text = "Digite seu endereço";
            this.adressbox.Enter += new System.EventHandler(this.adressbox_Enter);
            this.adressbox.Leave += new System.EventHandler(this.adressbox_Leave);
            // 
            // numberBox
            // 
            this.numberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numberBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.numberBox.Location = new System.Drawing.Point(461, 84);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(85, 23);
            this.numberBox.TabIndex = 3;
            this.numberBox.Text = "Nº";
            this.numberBox.Enter += new System.EventHandler(this.numberBox_Enter);
            this.numberBox.Leave += new System.EventHandler(this.numberBox_Leave);
            // 
            // dateBox
            // 
            this.dateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateBox.Location = new System.Drawing.Point(172, 132);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(200, 23);
            this.dateBox.TabIndex = 4;
            // 
            // userBox
            // 
            this.userBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.userBox.Location = new System.Drawing.Point(172, 185);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(217, 23);
            this.userBox.TabIndex = 5;
            this.userBox.Text = "Digite o seu usuário";
            this.userBox.Enter += new System.EventHandler(this.userBox_Enter);
            this.userBox.Leave += new System.EventHandler(this.userBox_Leave);
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.passBox.Location = new System.Drawing.Point(172, 234);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(217, 23);
            this.passBox.TabIndex = 6;
            this.passBox.Text = "Digite sua senha";
            this.passBox.TextChanged += new System.EventHandler(this.passBox_TextChanged);
            this.passBox.Enter += new System.EventHandler(this.passBox_Enter);
            this.passBox.Leave += new System.EventHandler(this.passBox_Leave);
            // 
            // passConfirmBox
            // 
            this.passConfirmBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passConfirmBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.passConfirmBox.Location = new System.Drawing.Point(172, 292);
            this.passConfirmBox.Name = "passConfirmBox";
            this.passConfirmBox.Size = new System.Drawing.Size(217, 23);
            this.passConfirmBox.TabIndex = 7;
            this.passConfirmBox.Text = "Confirme sua senha";
            this.passConfirmBox.TextChanged += new System.EventHandler(this.passConfirmBox_TextChanged);
            this.passConfirmBox.Enter += new System.EventHandler(this.passConfirmBox_Enter);
            this.passConfirmBox.Leave += new System.EventHandler(this.passConfirmBox_Leave);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnCadastrar.Location = new System.Drawing.Point(172, 357);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(107, 27);
            this.BtnCadastrar.TabIndex = 8;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // Photo
            // 
            this.Photo.Location = new System.Drawing.Point(608, 46);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(153, 145);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo.TabIndex = 9;
            this.Photo.TabStop = false;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnAlterar.Location = new System.Drawing.Point(608, 197);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 10;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnDelete.Location = new System.Drawing.Point(686, 197);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "Deletar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // adminBox
            // 
            this.adminBox.AutoSize = true;
            this.adminBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.adminBox.Location = new System.Drawing.Point(608, 251);
            this.adminBox.Name = "adminBox";
            this.adminBox.Size = new System.Drawing.Size(102, 28);
            this.adminBox.TabIndex = 12;
            this.adminBox.Text = "É Admin";
            this.adminBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(40, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(40, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(40, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(40, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Usuário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(40, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(40, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Confirmar senha";
            // 
            // aviso
            // 
            this.aviso.AutoSize = true;
            this.aviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.aviso.ForeColor = System.Drawing.Color.Red;
            this.aviso.Location = new System.Drawing.Point(169, 318);
            this.aviso.Name = "aviso";
            this.aviso.Size = new System.Drawing.Size(0, 17);
            this.aviso.TabIndex = 19;
            // 
            // labRegex
            // 
            this.labRegex.AutoSize = true;
            this.labRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labRegex.ForeColor = System.Drawing.Color.Red;
            this.labRegex.Location = new System.Drawing.Point(172, 264);
            this.labRegex.Name = "labRegex";
            this.labRegex.Size = new System.Drawing.Size(0, 13);
            this.labRegex.TabIndex = 20;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labRegex);
            this.Controls.Add(this.aviso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminBox);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.passConfirmBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.adressbox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Name = "FrmCadastro";
            this.Text = "FrmCadastro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadastro_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox adressbox;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox passConfirmBox;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.CheckBox adminBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label aviso;
        private System.Windows.Forms.Label labRegex;
    }
}