namespace ClinicaVeterinaria
{
    partial class CadastroTutor
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
            this.label1 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.sobrenome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Endereço = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nome:";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(66, 9);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(239, 20);
            this.nome.TabIndex = 1;
            // 
            // sobrenome
            // 
            this.sobrenome.Location = new System.Drawing.Point(89, 39);
            this.sobrenome.Name = "sobrenome";
            this.sobrenome.Size = new System.Drawing.Size(169, 20);
            this.sobrenome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "sobrenome";
            // 
            // CPF
            // 
            this.CPF.Location = new System.Drawing.Point(60, 140);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(169, 20);
            this.CPF.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF:";
            // 
            // Telefone
            // 
            this.Telefone.Location = new System.Drawing.Point(66, 191);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(169, 20);
            this.Telefone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone:";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(60, 94);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(169, 20);
            this.Email.TabIndex = 9;
            this.Email.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email:";
            // 
            // Endereço
            // 
            this.Endereço.Location = new System.Drawing.Point(66, 340);
            this.Endereço.Name = "Endereço";
            this.Endereço.Size = new System.Drawing.Size(169, 20);
            this.Endereço.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Endereço:";
            // 
            // BtSalvar
            // 
            this.BtSalvar.Location = new System.Drawing.Point(477, 230);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(151, 52);
            this.BtSalvar.TabIndex = 12;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = true;
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(475, 288);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(153, 52);
            this.BtCancelar.TabIndex = 13;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // CadastroTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.Endereço);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sobrenome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastroTutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroTutor";
            this.Load += new System.EventHandler(this.CadastroTutor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox sobrenome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Telefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Endereço;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.Button BtCancelar;
    }
}