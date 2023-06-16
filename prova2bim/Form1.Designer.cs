namespace prova2bim
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tx_matricula = new System.Windows.Forms.Label();
            this.tex_matricula = new System.Windows.Forms.TextBox();
            this.tx_cpf = new System.Windows.Forms.Label();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tx_nome = new System.Windows.Forms.Label();
            this.tex_nome = new System.Windows.Forms.TextBox();
            this.tx_funcao = new System.Windows.Forms.Label();
            this.com_funcao = new System.Windows.Forms.ComboBox();
            this.tx_salario = new System.Windows.Forms.Label();
            this.tex_salario = new System.Windows.Forms.TextBox();
            this.tx_salariot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Funcionário";
            // 
            // tx_matricula
            // 
            this.tx_matricula.AutoSize = true;
            this.tx_matricula.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_matricula.Location = new System.Drawing.Point(30, 81);
            this.tx_matricula.Name = "tx_matricula";
            this.tx_matricula.Size = new System.Drawing.Size(88, 20);
            this.tx_matricula.TabIndex = 1;
            this.tx_matricula.Text = "Matrícula :";
            this.tx_matricula.Click += new System.EventHandler(this.label2_Click);
            // 
            // tex_matricula
            // 
            this.tex_matricula.Location = new System.Drawing.Point(124, 81);
            this.tex_matricula.Name = "tex_matricula";
            this.tex_matricula.Size = new System.Drawing.Size(141, 20);
            this.tex_matricula.TabIndex = 2;
            // 
            // tx_cpf
            // 
            this.tx_cpf.AutoSize = true;
            this.tx_cpf.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_cpf.Location = new System.Drawing.Point(295, 81);
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(46, 20);
            this.tx_cpf.TabIndex = 3;
            this.tx_cpf.Text = "CPF :";
            // 
            // mask_cpf
            // 
            this.mask_cpf.Location = new System.Drawing.Point(347, 81);
            this.mask_cpf.Mask = "000,000,000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.ReadOnly = true;
            this.mask_cpf.Size = new System.Drawing.Size(128, 20);
            this.mask_cpf.TabIndex = 4;
            this.mask_cpf.UseWaitCursor = true;
            // 
            // tx_nome
            // 
            this.tx_nome.AutoSize = true;
            this.tx_nome.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nome.Location = new System.Drawing.Point(54, 135);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(64, 20);
            this.tx_nome.TabIndex = 5;
            this.tx_nome.Text = "Nome :";
            // 
            // tex_nome
            // 
            this.tex_nome.Location = new System.Drawing.Point(124, 135);
            this.tex_nome.Name = "tex_nome";
            this.tex_nome.Size = new System.Drawing.Size(351, 20);
            this.tex_nome.TabIndex = 6;
            // 
            // tx_funcao
            // 
            this.tx_funcao.AutoSize = true;
            this.tx_funcao.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_funcao.Location = new System.Drawing.Point(46, 189);
            this.tx_funcao.Name = "tx_funcao";
            this.tx_funcao.Size = new System.Drawing.Size(72, 20);
            this.tx_funcao.TabIndex = 7;
            this.tx_funcao.Text = "Função :";
            // 
            // com_funcao
            // 
            this.com_funcao.FormattingEnabled = true;
            this.com_funcao.Items.AddRange(new object[] {
            "Médico",
            "TI",
            "ADM"});
            this.com_funcao.Location = new System.Drawing.Point(124, 188);
            this.com_funcao.Name = "com_funcao";
            this.com_funcao.Size = new System.Drawing.Size(121, 21);
            this.com_funcao.TabIndex = 8;
            this.com_funcao.SelectedIndexChanged += new System.EventHandler(this.com_funcao_SelectedIndexChanged);
            // 
            // tx_salario
            // 
            this.tx_salario.AutoSize = true;
            this.tx_salario.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_salario.Location = new System.Drawing.Point(50, 243);
            this.tx_salario.Name = "tx_salario";
            this.tx_salario.Size = new System.Drawing.Size(68, 20);
            this.tx_salario.TabIndex = 9;
            this.tx_salario.Text = "Salário :";
            // 
            // tex_salario
            // 
            this.tex_salario.Location = new System.Drawing.Point(124, 245);
            this.tex_salario.Name = "tex_salario";
            this.tex_salario.Size = new System.Drawing.Size(121, 20);
            this.tex_salario.TabIndex = 10;
            // 
            // tx_salariot
            // 
            this.tx_salariot.AutoSize = true;
            this.tx_salariot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_salariot.Location = new System.Drawing.Point(54, 315);
            this.tx_salariot.Name = "tx_salariot";
            this.tx_salariot.Size = new System.Drawing.Size(101, 20);
            this.tx_salariot.TabIndex = 11;
            this.tx_salariot.Text = "Salário total :";
            this.tx_salariot.Click += new System.EventHandler(this.tx_salariot_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "IRPF :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(110, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(363, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_salariot);
            this.Controls.Add(this.tex_salario);
            this.Controls.Add(this.tx_salario);
            this.Controls.Add(this.com_funcao);
            this.Controls.Add(this.tx_funcao);
            this.Controls.Add(this.tex_nome);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.mask_cpf);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.tex_matricula);
            this.Controls.Add(this.tx_matricula);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tx_matricula;
        private System.Windows.Forms.TextBox tex_matricula;
        private System.Windows.Forms.Label tx_cpf;
        private System.Windows.Forms.MaskedTextBox mask_cpf;
        private System.Windows.Forms.Label tx_nome;
        private System.Windows.Forms.TextBox tex_nome;
        private System.Windows.Forms.Label tx_funcao;
        private System.Windows.Forms.ComboBox com_funcao;
        private System.Windows.Forms.Label tx_salario;
        private System.Windows.Forms.TextBox tex_salario;
        private System.Windows.Forms.Label tx_salariot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

