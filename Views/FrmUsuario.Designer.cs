namespace AirSystem.Views
{
    partial class FrmUsuario
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
            this.BtnAirplane = new System.Windows.Forms.Button();
            this.BtnAirplaneManage = new System.Windows.Forms.Button();
            this.BtnCompany = new System.Windows.Forms.Button();
            this.BtnReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAirplane
            // 
            this.BtnAirplane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.BtnAirplane.Location = new System.Drawing.Point(188, 69);
            this.BtnAirplane.Name = "BtnAirplane";
            this.BtnAirplane.Size = new System.Drawing.Size(137, 91);
            this.BtnAirplane.TabIndex = 1;
            this.BtnAirplane.Text = "Listar Aviões";
            this.BtnAirplane.UseVisualStyleBackColor = true;
            // 
            // BtnAirplaneManage
            // 
            this.BtnAirplaneManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.BtnAirplaneManage.Location = new System.Drawing.Point(454, 69);
            this.BtnAirplaneManage.Name = "BtnAirplaneManage";
            this.BtnAirplaneManage.Size = new System.Drawing.Size(137, 91);
            this.BtnAirplaneManage.TabIndex = 2;
            this.BtnAirplaneManage.Text = "Gerenciar Avião";
            this.BtnAirplaneManage.UseVisualStyleBackColor = true;
            // 
            // BtnCompany
            // 
            this.BtnCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.BtnCompany.Location = new System.Drawing.Point(188, 236);
            this.BtnCompany.Name = "BtnCompany";
            this.BtnCompany.Size = new System.Drawing.Size(137, 91);
            this.BtnCompany.TabIndex = 3;
            this.BtnCompany.Text = "Gerenciar Companhia";
            this.BtnCompany.UseVisualStyleBackColor = true;
            // 
            // BtnReports
            // 
            this.BtnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.BtnReports.Location = new System.Drawing.Point(454, 236);
            this.BtnReports.Name = "BtnReports";
            this.BtnReports.Size = new System.Drawing.Size(137, 91);
            this.BtnReports.TabIndex = 4;
            this.BtnReports.Text = "Gerenciar Relatórios";
            this.BtnReports.UseVisualStyleBackColor = true;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnReports);
            this.Controls.Add(this.BtnCompany);
            this.Controls.Add(this.BtnAirplaneManage);
            this.Controls.Add(this.BtnAirplane);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAirplane;
        private System.Windows.Forms.Button BtnAirplaneManage;
        private System.Windows.Forms.Button BtnCompany;
        private System.Windows.Forms.Button BtnReports;
    }
}