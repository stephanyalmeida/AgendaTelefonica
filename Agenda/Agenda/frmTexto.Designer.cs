namespace Agenda
{
    partial class frmTexto
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
            this.text_texto = new System.Windows.Forms.TextBox();
            this.cmd_pesquisar = new System.Windows.Forms.Button();
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Termo de Pesquisa:";
            // 
            // text_texto
            // 
            this.text_texto.Location = new System.Drawing.Point(12, 27);
            this.text_texto.MaxLength = 30;
            this.text_texto.Name = "text_texto";
            this.text_texto.Size = new System.Drawing.Size(248, 23);
            this.text_texto.TabIndex = 1;
            this.text_texto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_texto_KeyDown);
            // 
            // cmd_pesquisar
            // 
            this.cmd_pesquisar.Location = new System.Drawing.Point(141, 71);
            this.cmd_pesquisar.Name = "cmd_pesquisar";
            this.cmd_pesquisar.Size = new System.Drawing.Size(92, 23);
            this.cmd_pesquisar.TabIndex = 2;
            this.cmd_pesquisar.Text = "Pesquisar";
            this.cmd_pesquisar.UseVisualStyleBackColor = true;
            this.cmd_pesquisar.Click += new System.EventHandler(this.cmd_pesquisar_Click);
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.Location = new System.Drawing.Point(28, 71);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(92, 23);
            this.cmd_cancelar.TabIndex = 3;
            this.cmd_cancelar.Text = "Cancelar";
            this.cmd_cancelar.UseVisualStyleBackColor = true;
            this.cmd_cancelar.Click += new System.EventHandler(this.cmd_cancelar_Click);
            // 
            // frmTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 109);
            this.ControlBox = false;
            this.Controls.Add(this.cmd_cancelar);
            this.Controls.Add(this.cmd_pesquisar);
            this.Controls.Add(this.text_texto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGENDA- PESQUISAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox text_texto;
        private Button cmd_pesquisar;
        private Button cmd_cancelar;
    }
}