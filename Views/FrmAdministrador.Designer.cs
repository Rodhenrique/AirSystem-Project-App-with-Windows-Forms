namespace AirSystem.Views
{
    partial class FrmAdministrador
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
            this.BtnUsers = new System.Windows.Forms.Button();
            this.BtnAirplane = new System.Windows.Forms.Button();
            this.BtnReports = new System.Windows.Forms.Button();
            this.BtnCompany = new System.Windows.Forms.Button();
            this.BtnAirManage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnUsers
            // 
            this.BtnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.BtnUsers.Location = new System.Drawing.Point(134, 64);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Size = new System.Drawing.Size(137, 91);
            this.BtnUsers.TabIndex = 0;
            this.BtnUsers.Text = "Listar Usuários";
            this.BtnUsers.UseVisualStyleBackColor = true;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // BtnAirplane
            // 
            this.BtnAirplane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.BtnAirplane.Location = new System.Drawing.Point(335, 64);
            this.BtnAirplane.Name = "BtnAirplane";
            this.BtnAirplane.Size = new System.Drawing.Size(137, 91);
            this.BtnAirplane.TabIndex = 1;
            this.BtnAirplane.Text = "Listar Aviões";
            this.BtnAirplane.UseVisualStyleBackColor = true;
            // 
            // BtnReports
            // 
            this.BtnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.BtnReports.Location = new System.Drawing.Point(335, 235);
            this.BtnReports.Name = "BtnReports";
            this.BtnReports.Size = new System.Drawing.Size(137, 91);
            this.BtnReports.TabIndex = 2;
            this.BtnReports.Text = "Gerenciar Relatórios";
            this.BtnReports.UseVisualStyleBackColor = true;
            // 
            // BtnCompany
            // 
            this.BtnCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.BtnCompany.Location = new System.Drawing.Point(134, 235);
            this.BtnCompany.Name = "BtnCompany";
            this.BtnCompany.Size = new System.Drawing.Size(137, 91);
            this.BtnCompany.TabIndex = 3;
            this.BtnCompany.Text = "Gerenciar Companhia";
            this.BtnCompany.UseVisualStyleBackColor = true;
            // 
            // BtnAirManage
            // 
            this.BtnAirManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.BtnAirManage.Location = new System.Drawing.Point(523, 64);
            this.BtnAirManage.Name = "BtnAirManage";
            this.BtnAirManage.Size = new System.Drawing.Size(137, 91);
            this.BtnAirManage.TabIndex = 4;
            this.BtnAirManage.Text = "Gerenciar Avião";
            this.BtnAirManage.UseVisualStyleBackColor = true;
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAirManage);
            this.Controls.Add(this.BtnCompany);
            this.Controls.Add(this.BtnReports);
            this.Controls.Add(this.BtnAirplane);
            this.Controls.Add(this.BtnUsers);
            this.Name = "FrmAdministrador";
            this.Text = "FrmAdministrador";
            this.Load += new System.EventHandler(this.FrmAdministrador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnUsers;
        private System.Windows.Forms.Button BtnAirplane;
        private System.Windows.Forms.Button BtnReports;
        private System.Windows.Forms.Button BtnCompany;
        private System.Windows.Forms.Button BtnAirManage;
    }
}