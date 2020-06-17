namespace AirSystem.Views
{
    partial class FrmListarUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.adressBox = new System.Windows.Forms.TextBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.passConfirmBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.Pesquisador = new System.Windows.Forms.TextBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnEdite = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnDeletePhoto = new System.Windows.Forms.Button();
            this.BtnAlter = new System.Windows.Forms.Button();
            this.labDados = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labSurname = new System.Windows.Forms.Label();
            this.labAdress = new System.Windows.Forms.Label();
            this.labDate = new System.Windows.Forms.Label();
            this.labNumber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labPass = new System.Windows.Forms.Label();
            this.labConfirmPass = new System.Windows.Forms.Label();
            this.labSearch = new System.Windows.Forms.Label();
            this.labContador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.AllowUserToResizeColumns = false;
            this.grid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Location = new System.Drawing.Point(12, 12);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(357, 391);
            this.grid1.TabIndex = 0;
            // 
            // Photo
            // 
            this.Photo.Location = new System.Drawing.Point(568, 33);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(154, 94);
            this.Photo.TabIndex = 1;
            this.Photo.TabStop = false;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameBox.Location = new System.Drawing.Point(542, 162);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(222, 23);
            this.nameBox.TabIndex = 2;
            // 
            // dateBox
            // 
            this.dateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateBox.Location = new System.Drawing.Point(542, 271);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(222, 23);
            this.dateBox.TabIndex = 3;
            // 
            // surnameBox
            // 
            this.surnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.surnameBox.Location = new System.Drawing.Point(542, 197);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(222, 23);
            this.surnameBox.TabIndex = 4;
            // 
            // adressBox
            // 
            this.adressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.adressBox.Location = new System.Drawing.Point(542, 234);
            this.adressBox.Name = "adressBox";
            this.adressBox.Size = new System.Drawing.Size(222, 23);
            this.adressBox.TabIndex = 5;
            // 
            // numberBox
            // 
            this.numberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numberBox.Location = new System.Drawing.Point(542, 308);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(222, 23);
            this.numberBox.TabIndex = 6;
            // 
            // passConfirmBox
            // 
            this.passConfirmBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passConfirmBox.Location = new System.Drawing.Point(542, 419);
            this.passConfirmBox.Name = "passConfirmBox";
            this.passConfirmBox.Size = new System.Drawing.Size(222, 23);
            this.passConfirmBox.TabIndex = 7;
            // 
            // userBox
            // 
            this.userBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userBox.Location = new System.Drawing.Point(542, 348);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(222, 23);
            this.userBox.TabIndex = 8;
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.passBox.Location = new System.Drawing.Point(542, 383);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(222, 20);
            this.passBox.TabIndex = 9;
            // 
            // Pesquisador
            // 
            this.Pesquisador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Pesquisador.Location = new System.Drawing.Point(90, 439);
            this.Pesquisador.Name = "Pesquisador";
            this.Pesquisador.Size = new System.Drawing.Size(224, 23);
            this.Pesquisador.TabIndex = 10;
            this.Pesquisador.TextChanged += new System.EventHandler(this.Pesquisador_TextChanged);
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnBack.Location = new System.Drawing.Point(365, 464);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(96, 27);
            this.BtnBack.TabIndex = 11;
            this.BtnBack.Text = "Voltar";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnNew.Location = new System.Drawing.Point(499, 464);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(92, 27);
            this.BtnNew.TabIndex = 12;
            this.BtnNew.Text = "Novo";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnEdite
            // 
            this.BtnEdite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnEdite.Location = new System.Drawing.Point(597, 464);
            this.BtnEdite.Name = "BtnEdite";
            this.BtnEdite.Size = new System.Drawing.Size(92, 27);
            this.BtnEdite.TabIndex = 13;
            this.BtnEdite.Text = "Editar";
            this.BtnEdite.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnDelete.Location = new System.Drawing.Point(695, 464);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(93, 27);
            this.BtnDelete.TabIndex = 14;
            this.BtnDelete.Text = "Deletar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnDeletePhoto
            // 
            this.BtnDeletePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnDeletePhoto.Location = new System.Drawing.Point(660, 133);
            this.BtnDeletePhoto.Name = "BtnDeletePhoto";
            this.BtnDeletePhoto.Size = new System.Drawing.Size(75, 23);
            this.BtnDeletePhoto.TabIndex = 15;
            this.BtnDeletePhoto.Text = "Deletar";
            this.BtnDeletePhoto.UseVisualStyleBackColor = true;
            // 
            // BtnAlter
            // 
            this.BtnAlter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnAlter.Location = new System.Drawing.Point(558, 133);
            this.BtnAlter.Name = "BtnAlter";
            this.BtnAlter.Size = new System.Drawing.Size(75, 23);
            this.BtnAlter.TabIndex = 16;
            this.BtnAlter.Text = "Alterar";
            this.BtnAlter.UseVisualStyleBackColor = true;
            // 
            // labDados
            // 
            this.labDados.AutoSize = true;
            this.labDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labDados.Location = new System.Drawing.Point(576, 10);
            this.labDados.Name = "labDados";
            this.labDados.Size = new System.Drawing.Size(137, 20);
            this.labDados.TabIndex = 17;
            this.labDados.Text = "Dados do Usuário";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labName.Location = new System.Drawing.Point(394, 162);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(57, 22);
            this.labName.TabIndex = 18;
            this.labName.Text = "Nome";
            // 
            // labSurname
            // 
            this.labSurname.AutoSize = true;
            this.labSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labSurname.Location = new System.Drawing.Point(394, 197);
            this.labSurname.Name = "labSurname";
            this.labSurname.Size = new System.Drawing.Size(102, 22);
            this.labSurname.TabIndex = 19;
            this.labSurname.Text = "Sobrenome";
            // 
            // labAdress
            // 
            this.labAdress.AutoSize = true;
            this.labAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labAdress.Location = new System.Drawing.Point(394, 234);
            this.labAdress.Name = "labAdress";
            this.labAdress.Size = new System.Drawing.Size(87, 22);
            this.labAdress.TabIndex = 20;
            this.labAdress.Text = "Endereço";
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labDate.Location = new System.Drawing.Point(394, 272);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(104, 22);
            this.labDate.TabIndex = 21;
            this.labDate.Text = "Nascimento";
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labNumber.Location = new System.Drawing.Point(394, 309);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(73, 22);
            this.labNumber.TabIndex = 22;
            this.labNumber.Text = "Número";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(394, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Usuário";
            // 
            // labPass
            // 
            this.labPass.AutoSize = true;
            this.labPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labPass.Location = new System.Drawing.Point(394, 381);
            this.labPass.Name = "labPass";
            this.labPass.Size = new System.Drawing.Size(62, 22);
            this.labPass.TabIndex = 24;
            this.labPass.Text = "Senha";
            // 
            // labConfirmPass
            // 
            this.labConfirmPass.AutoSize = true;
            this.labConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labConfirmPass.Location = new System.Drawing.Point(394, 419);
            this.labConfirmPass.Name = "labConfirmPass";
            this.labConfirmPass.Size = new System.Drawing.Size(142, 22);
            this.labConfirmPass.TabIndex = 25;
            this.labConfirmPass.Text = "Confirmar senha";
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labSearch.Location = new System.Drawing.Point(27, 439);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(57, 22);
            this.labSearch.TabIndex = 26;
            this.labSearch.Text = "Nome";
            // 
            // labContador
            // 
            this.labContador.AutoSize = true;
            this.labContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labContador.Location = new System.Drawing.Point(167, 406);
            this.labContador.Name = "labContador";
            this.labContador.Size = new System.Drawing.Size(0, 20);
            this.labContador.TabIndex = 27;
            // 
            // FrmListarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.labContador);
            this.Controls.Add(this.labSearch);
            this.Controls.Add(this.labConfirmPass);
            this.Controls.Add(this.labPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labNumber);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.labAdress);
            this.Controls.Add(this.labSurname);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labDados);
            this.Controls.Add(this.BtnAlter);
            this.Controls.Add(this.BtnDeletePhoto);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdite);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.Pesquisador);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.passConfirmBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.adressBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.grid1);
            this.Name = "FrmListarUsuarios";
            this.Text = "FrmListarUsuarios";
            this.Load += new System.EventHandler(this.FrmListarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox adressBox;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox passConfirmBox;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox Pesquisador;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnEdite;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnDeletePhoto;
        private System.Windows.Forms.Button BtnAlter;
        private System.Windows.Forms.Label labDados;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labSurname;
        private System.Windows.Forms.Label labAdress;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labPass;
        private System.Windows.Forms.Label labConfirmPass;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.Label labContador;
    }
}