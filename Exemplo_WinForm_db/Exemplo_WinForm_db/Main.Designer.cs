namespace Exemplo_WinForm_db
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Matricula = new System.Windows.Forms.TextBox();
            this.txt_Escola = new System.Windows.Forms.TextBox();
            this.dgv_Aluno = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Aluno)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(12, 50);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(280, 20);
            this.txt_Nome.TabIndex = 0;
            // 
            // txt_Matricula
            // 
            this.txt_Matricula.Location = new System.Drawing.Point(12, 131);
            this.txt_Matricula.Name = "txt_Matricula";
            this.txt_Matricula.Size = new System.Drawing.Size(280, 20);
            this.txt_Matricula.TabIndex = 1;
            // 
            // txt_Escola
            // 
            this.txt_Escola.Location = new System.Drawing.Point(12, 87);
            this.txt_Escola.Name = "txt_Escola";
            this.txt_Escola.Size = new System.Drawing.Size(280, 20);
            this.txt_Escola.TabIndex = 2;
            // 
            // dgv_Aluno
            // 
            this.dgv_Aluno.AllowUserToAddRows = false;
            this.dgv_Aluno.AllowUserToDeleteRows = false;
            this.dgv_Aluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Aluno.Location = new System.Drawing.Point(353, 50);
            this.dgv_Aluno.Name = "dgv_Aluno";
            this.dgv_Aluno.ReadOnly = true;
            this.dgv_Aluno.Size = new System.Drawing.Size(559, 234);
            this.dgv_Aluno.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(105, 157);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 5;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(837, 21);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Escola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Matricula";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 320);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Aluno);
            this.Controls.Add(this.txt_Escola);
            this.Controls.Add(this.txt_Matricula);
            this.Controls.Add(this.txt_Nome);
            this.Name = "Form1";
            this.Text = "Exemplo_WinForm_db";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Aluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Matricula;
        private System.Windows.Forms.TextBox txt_Escola;
        private System.Windows.Forms.DataGridView dgv_Aluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

