namespace AirSystem
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.idiomaBox = new System.Windows.Forms.ComboBox();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.labUser = new System.Windows.Forms.Label();
            this.labPass = new System.Windows.Forms.Label();
            this.labIdioma = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 362);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(475, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(284, 78);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // userBox
            // 
            this.userBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userBox.Location = new System.Drawing.Point(475, 187);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(266, 23);
            this.userBox.TabIndex = 2;
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passBox.Location = new System.Drawing.Point(475, 253);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(266, 23);
            this.passBox.TabIndex = 3;
            // 
            // idiomaBox
            // 
            this.idiomaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.idiomaBox.FormattingEnabled = true;
            this.idiomaBox.Location = new System.Drawing.Point(475, 318);
            this.idiomaBox.Name = "idiomaBox";
            this.idiomaBox.Size = new System.Drawing.Size(176, 24);
            this.idiomaBox.TabIndex = 4;
            this.idiomaBox.Text = "Seleciona idioma";
            this.idiomaBox.SelectedIndexChanged += new System.EventHandler(this.idiomaBox_SelectedIndexChanged);
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnEntrar.Location = new System.Drawing.Point(475, 384);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(78, 29);
            this.BtnEntrar.TabIndex = 5;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = true;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnSair.Location = new System.Drawing.Point(559, 384);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(78, 29);
            this.BtnSair.TabIndex = 6;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnCadastrar.Location = new System.Drawing.Point(643, 384);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(131, 29);
            this.BtnCadastrar.TabIndex = 7;
            this.BtnCadastrar.Text = "Novo Usuário";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labUser.Location = new System.Drawing.Point(471, 162);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(72, 22);
            this.labUser.TabIndex = 8;
            this.labUser.Text = "Usuário";
            // 
            // labPass
            // 
            this.labPass.AutoSize = true;
            this.labPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labPass.Location = new System.Drawing.Point(471, 228);
            this.labPass.Name = "labPass";
            this.labPass.Size = new System.Drawing.Size(62, 22);
            this.labPass.TabIndex = 9;
            this.labPass.Text = "Senha";
            // 
            // labIdioma
            // 
            this.labIdioma.AutoSize = true;
            this.labIdioma.BackColor = System.Drawing.Color.Transparent;
            this.labIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labIdioma.Location = new System.Drawing.Point(471, 293);
            this.labIdioma.Name = "labIdioma";
            this.labIdioma.Size = new System.Drawing.Size(62, 22);
            this.labIdioma.TabIndex = 10;
            this.labIdioma.Text = "Idioma";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.hora.Location = new System.Drawing.Point(670, 9);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(0, 29);
            this.hora.TabIndex = 11;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.labIdioma);
            this.Controls.Add(this.labPass);
            this.Controls.Add(this.labUser);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.idiomaBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.ComboBox idiomaBox;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.Label labPass;
        private System.Windows.Forms.Label labIdioma;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label hora;
    }
}