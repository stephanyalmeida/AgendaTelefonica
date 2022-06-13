namespace Agenda
{
    partial class frmInserirEditar
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
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.text_numero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd_salvar = new System.Windows.Forms.Button();
            this.lista_contatos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_numero_registros = new System.Windows.Forms.Label();
            this.cmd_apagar = new System.Windows.Forms.Button();
            this.cmd_editar = new System.Windows.Forms.Button();
            this.cmd_novo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Location = new System.Drawing.Point(295, 392);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(78, 29);
            this.cmd_fechar.TabIndex = 0;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(72, 31);
            this.text_nome.MaxLength = 50;
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(251, 23);
            this.text_nome.TabIndex = 2;
            // 
            // text_numero
            // 
            this.text_numero.Location = new System.Drawing.Point(72, 71);
            this.text_numero.MaxLength = 20;
            this.text_numero.Name = "text_numero";
            this.text_numero.Size = new System.Drawing.Size(109, 23);
            this.text_numero.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmd_salvar
            // 
            this.cmd_salvar.Location = new System.Drawing.Point(72, 100);
            this.cmd_salvar.Name = "cmd_salvar";
            this.cmd_salvar.Size = new System.Drawing.Size(76, 33);
            this.cmd_salvar.TabIndex = 5;
            this.cmd_salvar.Text = "Salvar";
            this.cmd_salvar.UseVisualStyleBackColor = true;
            this.cmd_salvar.Click += new System.EventHandler(this.cmd_salvar_Click);
            // 
            // lista_contatos
            // 
            this.lista_contatos.FormattingEnabled = true;
            this.lista_contatos.ItemHeight = 15;
            this.lista_contatos.Location = new System.Drawing.Point(12, 172);
            this.lista_contatos.Name = "lista_contatos";
            this.lista_contatos.Size = new System.Drawing.Size(361, 214);
            this.lista_contatos.TabIndex = 6;
            this.lista_contatos.SelectedIndexChanged += new System.EventHandler(this.lista_contatos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lista de contatos registrados";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_numero_registros
            // 
            this.label_numero_registros.AutoSize = true;
            this.label_numero_registros.Location = new System.Drawing.Point(12, 392);
            this.label_numero_registros.Name = "label_numero_registros";
            this.label_numero_registros.Size = new System.Drawing.Size(67, 15);
            this.label_numero_registros.TabIndex = 8;
            this.label_numero_registros.Text = "Registros 0.";
            this.label_numero_registros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmd_apagar
            // 
            this.cmd_apagar.Location = new System.Drawing.Point(211, 392);
            this.cmd_apagar.Name = "cmd_apagar";
            this.cmd_apagar.Size = new System.Drawing.Size(78, 29);
            this.cmd_apagar.TabIndex = 9;
            this.cmd_apagar.Text = "Apagar";
            this.cmd_apagar.UseVisualStyleBackColor = true;
            this.cmd_apagar.Click += new System.EventHandler(this.cmd_apagar_Click);
            // 
            // cmd_editar
            // 
            this.cmd_editar.Location = new System.Drawing.Point(127, 392);
            this.cmd_editar.Name = "cmd_editar";
            this.cmd_editar.Size = new System.Drawing.Size(78, 29);
            this.cmd_editar.TabIndex = 10;
            this.cmd_editar.Text = "Editar";
            this.cmd_editar.UseVisualStyleBackColor = true;
            this.cmd_editar.Click += new System.EventHandler(this.cmd_editar_Click);
            // 
            // cmd_novo
            // 
            this.cmd_novo.Location = new System.Drawing.Point(127, 431);
            this.cmd_novo.Name = "cmd_novo";
            this.cmd_novo.Size = new System.Drawing.Size(78, 29);
            this.cmd_novo.TabIndex = 11;
            this.cmd_novo.Text = "Novo";
            this.cmd_novo.UseVisualStyleBackColor = true;
            this.cmd_novo.Click += new System.EventHandler(this.cmd_novo_Click);
            // 
            // frmInserirEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 472);
            this.Controls.Add(this.cmd_novo);
            this.Controls.Add(this.cmd_editar);
            this.Controls.Add(this.cmd_apagar);
            this.Controls.Add(this.label_numero_registros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lista_contatos);
            this.Controls.Add(this.cmd_salvar);
            this.Controls.Add(this.text_numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInserirEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGENDA- INSERIR/EDITAR";
            this.Load += new System.EventHandler(this.frmInserirEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cmd_fechar;
        private Label label1;
        private TextBox text_nome;
        private TextBox text_numero;
        private Label label2;
        private Button cmd_salvar;
        private ListBox lista_contatos;
        private Label label3;
        private Label label_numero_registros;
        private Button cmd_apagar;
        private Button cmd_editar;
        private Button cmd_novo;
    }
}