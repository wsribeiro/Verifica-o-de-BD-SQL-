namespace prj_02
{
    partial class Form1
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
            this.btn_executa_funcao = new System.Windows.Forms.Button();
            this.lbl_server = new System.Windows.Forms.Label();
            this.txt_host = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.lbl_port = new System.Windows.Forms.Label();
            this.Banco = new System.Windows.Forms.Label();
            this.txt_db = new System.Windows.Forms.TextBox();
            this.lbl_psw = new System.Windows.Forms.Label();
            this.txt_uid = new System.Windows.Forms.TextBox();
            this.lbl_uid = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.chk_nome = new System.Windows.Forms.CheckBox();
            this.chk_idade = new System.Windows.Forms.CheckBox();
            this.chk_prof = new System.Windows.Forms.CheckBox();
            this.chk_sexo = new System.Windows.Forms.CheckBox();
            this.chk_peso = new System.Windows.Forms.CheckBox();
            this.chk_altura = new System.Windows.Forms.CheckBox();
            this.chk_nacionalidade = new System.Windows.Forms.CheckBox();
            this.chk_nascimento = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_executa_funcao
            // 
            this.btn_executa_funcao.Location = new System.Drawing.Point(12, 136);
            this.btn_executa_funcao.Name = "btn_executa_funcao";
            this.btn_executa_funcao.Size = new System.Drawing.Size(153, 23);
            this.btn_executa_funcao.TabIndex = 0;
            this.btn_executa_funcao.Text = "Acessar SGBG";
            this.btn_executa_funcao.UseVisualStyleBackColor = true;
            this.btn_executa_funcao.Click += new System.EventHandler(this.btn_executa_funcao_Click);
            // 
            // lbl_server
            // 
            this.lbl_server.AutoSize = true;
            this.lbl_server.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_server.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_server.Location = new System.Drawing.Point(30, 9);
            this.lbl_server.Name = "lbl_server";
            this.lbl_server.Size = new System.Drawing.Size(33, 13);
            this.lbl_server.TabIndex = 1;
            this.lbl_server.Text = "Host";
            // 
            // txt_host
            // 
            this.txt_host.Location = new System.Drawing.Point(65, 6);
            this.txt_host.Name = "txt_host";
            this.txt_host.Size = new System.Drawing.Size(100, 20);
            this.txt_host.TabIndex = 2;
            this.txt_host.Text = "localhost";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(65, 32);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(100, 20);
            this.txt_port.TabIndex = 3;
            this.txt_port.Text = "3306";
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_port.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_port.Location = new System.Drawing.Point(27, 35);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(37, 13);
            this.lbl_port.TabIndex = 4;
            this.lbl_port.Text = "Porta";
            // 
            // Banco
            // 
            this.Banco.AutoSize = true;
            this.Banco.BackColor = System.Drawing.SystemColors.Control;
            this.Banco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Banco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Banco.Location = new System.Drawing.Point(6, 61);
            this.Banco.Name = "Banco";
            this.Banco.Size = new System.Drawing.Size(61, 13);
            this.Banco.TabIndex = 6;
            this.Banco.Text = "Database";
            // 
            // txt_db
            // 
            this.txt_db.Location = new System.Drawing.Point(65, 58);
            this.txt_db.Name = "txt_db";
            this.txt_db.Size = new System.Drawing.Size(100, 20);
            this.txt_db.TabIndex = 5;
            this.txt_db.Text = "meu_banco_de_dados";
            // 
            // lbl_psw
            // 
            this.lbl_psw.AutoSize = true;
            this.lbl_psw.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_psw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_psw.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_psw.Location = new System.Drawing.Point(6, 113);
            this.lbl_psw.Name = "lbl_psw";
            this.lbl_psw.Size = new System.Drawing.Size(61, 13);
            this.lbl_psw.TabIndex = 8;
            this.lbl_psw.Text = "Password";
            // 
            // txt_uid
            // 
            this.txt_uid.Location = new System.Drawing.Point(65, 84);
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.Size = new System.Drawing.Size(100, 20);
            this.txt_uid.TabIndex = 7;
            this.txt_uid.Text = "root";
            // 
            // lbl_uid
            // 
            this.lbl_uid.AutoSize = true;
            this.lbl_uid.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_uid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_uid.Location = new System.Drawing.Point(30, 87);
            this.lbl_uid.Name = "lbl_uid";
            this.lbl_uid.Size = new System.Drawing.Size(33, 13);
            this.lbl_uid.TabIndex = 10;
            this.lbl_uid.Text = "User";
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(65, 110);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(100, 20);
            this.txt_pwd.TabIndex = 9;
            this.txt_pwd.Text = "root";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Red;
            this.status.Location = new System.Drawing.Point(62, 162);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(44, 13);
            this.status.TabIndex = 11;
            this.status.Text = "Offline";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(171, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 169);
            this.dataGridView1.TabIndex = 12;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(714, 177);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(97, 23);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "Pesquisar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // chk_nome
            // 
            this.chk_nome.AutoSize = true;
            this.chk_nome.Location = new System.Drawing.Point(171, 181);
            this.chk_nome.Name = "chk_nome";
            this.chk_nome.Size = new System.Drawing.Size(54, 17);
            this.chk_nome.TabIndex = 14;
            this.chk_nome.Text = "Nome";
            this.chk_nome.UseVisualStyleBackColor = true;
            // 
            // chk_idade
            // 
            this.chk_idade.AutoSize = true;
            this.chk_idade.Location = new System.Drawing.Point(226, 181);
            this.chk_idade.Name = "chk_idade";
            this.chk_idade.Size = new System.Drawing.Size(53, 17);
            this.chk_idade.TabIndex = 15;
            this.chk_idade.Text = "Idade";
            this.chk_idade.UseVisualStyleBackColor = true;
            // 
            // chk_prof
            // 
            this.chk_prof.AutoSize = true;
            this.chk_prof.Location = new System.Drawing.Point(285, 181);
            this.chk_prof.Name = "chk_prof";
            this.chk_prof.Size = new System.Drawing.Size(69, 17);
            this.chk_prof.TabIndex = 16;
            this.chk_prof.Text = "Profissão";
            this.chk_prof.UseVisualStyleBackColor = true;
            // 
            // chk_sexo
            // 
            this.chk_sexo.AutoSize = true;
            this.chk_sexo.Location = new System.Drawing.Point(360, 181);
            this.chk_sexo.Name = "chk_sexo";
            this.chk_sexo.Size = new System.Drawing.Size(50, 17);
            this.chk_sexo.TabIndex = 17;
            this.chk_sexo.Text = "Sexo";
            this.chk_sexo.UseVisualStyleBackColor = true;
            // 
            // chk_peso
            // 
            this.chk_peso.AutoSize = true;
            this.chk_peso.Location = new System.Drawing.Point(416, 181);
            this.chk_peso.Name = "chk_peso";
            this.chk_peso.Size = new System.Drawing.Size(50, 17);
            this.chk_peso.TabIndex = 18;
            this.chk_peso.Text = "Peso";
            this.chk_peso.UseVisualStyleBackColor = true;
            // 
            // chk_altura
            // 
            this.chk_altura.AutoSize = true;
            this.chk_altura.Location = new System.Drawing.Point(472, 181);
            this.chk_altura.Name = "chk_altura";
            this.chk_altura.Size = new System.Drawing.Size(53, 17);
            this.chk_altura.TabIndex = 19;
            this.chk_altura.Text = "Altura";
            this.chk_altura.UseVisualStyleBackColor = true;
            // 
            // chk_nacionalidade
            // 
            this.chk_nacionalidade.AutoSize = true;
            this.chk_nacionalidade.Location = new System.Drawing.Point(531, 181);
            this.chk_nacionalidade.Name = "chk_nacionalidade";
            this.chk_nacionalidade.Size = new System.Drawing.Size(94, 17);
            this.chk_nacionalidade.TabIndex = 20;
            this.chk_nacionalidade.Text = "Nacionalidade";
            this.chk_nacionalidade.UseVisualStyleBackColor = true;
            // 
            // chk_nascimento
            // 
            this.chk_nascimento.AutoSize = true;
            this.chk_nascimento.Location = new System.Drawing.Point(631, 181);
            this.chk_nascimento.Name = "chk_nascimento";
            this.chk_nascimento.Size = new System.Drawing.Size(82, 17);
            this.chk_nascimento.TabIndex = 21;
            this.chk_nascimento.Text = "Nascimento";
            this.chk_nascimento.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(823, 206);
            this.Controls.Add(this.chk_nascimento);
            this.Controls.Add(this.chk_nacionalidade);
            this.Controls.Add(this.chk_altura);
            this.Controls.Add(this.chk_peso);
            this.Controls.Add(this.chk_sexo);
            this.Controls.Add(this.chk_prof);
            this.Controls.Add(this.chk_idade);
            this.Controls.Add(this.chk_nome);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.lbl_uid);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.lbl_psw);
            this.Controls.Add(this.txt_uid);
            this.Controls.Add(this.Banco);
            this.Controls.Add(this.txt_db);
            this.Controls.Add(this.lbl_port);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_host);
            this.Controls.Add(this.lbl_server);
            this.Controls.Add(this.btn_executa_funcao);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_executa_funcao;
        private System.Windows.Forms.Label lbl_server;
        private System.Windows.Forms.TextBox txt_host;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.Label Banco;
        private System.Windows.Forms.TextBox txt_db;
        private System.Windows.Forms.Label lbl_psw;
        private System.Windows.Forms.TextBox txt_uid;
        private System.Windows.Forms.Label lbl_uid;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.CheckBox chk_nome;
        private System.Windows.Forms.CheckBox chk_idade;
        private System.Windows.Forms.CheckBox chk_prof;
        private System.Windows.Forms.CheckBox chk_sexo;
        private System.Windows.Forms.CheckBox chk_peso;
        private System.Windows.Forms.CheckBox chk_altura;
        private System.Windows.Forms.CheckBox chk_nacionalidade;
        private System.Windows.Forms.CheckBox chk_nascimento;
    }
}

