namespace Agenda
{
    partial class frmResultados
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
            this.cmd_nova_pesquisa = new System.Windows.Forms.Button();
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.lista_final = new System.Windows.Forms.ListBox();
            this.label_numero_registros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_nova_pesquisa
            // 
            this.cmd_nova_pesquisa.Location = new System.Drawing.Point(193, 142);
            this.cmd_nova_pesquisa.Name = "cmd_nova_pesquisa";
            this.cmd_nova_pesquisa.Size = new System.Drawing.Size(105, 23);
            this.cmd_nova_pesquisa.TabIndex = 0;
            this.cmd_nova_pesquisa.Text = "Nova Pesquisa...";
            this.cmd_nova_pesquisa.UseVisualStyleBackColor = true;
            this.cmd_nova_pesquisa.Click += new System.EventHandler(this.cmd_nova_pesquisa_Click);
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Location = new System.Drawing.Point(304, 142);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(98, 23);
            this.cmd_fechar.TabIndex = 1;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // lista_final
            // 
            this.lista_final.FormattingEnabled = true;
            this.lista_final.ItemHeight = 15;
            this.lista_final.Location = new System.Drawing.Point(12, 12);
            this.lista_final.Name = "lista_final";
            this.lista_final.Size = new System.Drawing.Size(389, 124);
            this.lista_final.TabIndex = 2;
            // 
            // label_numero_registros
            // 
            this.label_numero_registros.AutoSize = true;
            this.label_numero_registros.Location = new System.Drawing.Point(12, 139);
            this.label_numero_registros.Name = "label_numero_registros";
            this.label_numero_registros.Size = new System.Drawing.Size(67, 15);
            this.label_numero_registros.TabIndex = 9;
            this.label_numero_registros.Text = "Registros 0.";
            this.label_numero_registros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_numero_registros.Click += new System.EventHandler(this.label_numero_registros_Click);
            // 
            // frmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 172);
            this.ControlBox = false;
            this.Controls.Add(this.label_numero_registros);
            this.Controls.Add(this.lista_final);
            this.Controls.Add(this.cmd_fechar);
            this.Controls.Add(this.cmd_nova_pesquisa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESULTADOS";
            this.Load += new System.EventHandler(this.frmResultados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cmd_nova_pesquisa;
        private Button cmd_fechar;
        private ListBox lista_final;
        private Label label_numero_registros;
    }
}