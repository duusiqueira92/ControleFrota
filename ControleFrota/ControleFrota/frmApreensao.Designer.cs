namespace ControleFrota
{
    partial class frmApreensao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApreensao));
            this.grbApreensao = new System.Windows.Forms.GroupBox();
            this.btnNovoObjeto = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbObjeto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEspecificacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtNumeracao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnVoltar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLimpar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grbApreensao.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbApreensao
            // 
            this.grbApreensao.Controls.Add(this.btnCadastrar);
            this.grbApreensao.Controls.Add(this.btnNovoObjeto);
            this.grbApreensao.Controls.Add(this.txtQuantidade);
            this.grbApreensao.Controls.Add(this.label7);
            this.grbApreensao.Controls.Add(this.cmbObjeto);
            this.grbApreensao.Controls.Add(this.label1);
            this.grbApreensao.Controls.Add(this.txtEspecificacao);
            this.grbApreensao.Controls.Add(this.label6);
            this.grbApreensao.Controls.Add(this.txtMarca);
            this.grbApreensao.Controls.Add(this.txtNumeracao);
            this.grbApreensao.Controls.Add(this.label2);
            this.grbApreensao.Controls.Add(this.label5);
            this.grbApreensao.Controls.Add(this.txtCor);
            this.grbApreensao.Controls.Add(this.txtModelo);
            this.grbApreensao.Controls.Add(this.label3);
            this.grbApreensao.Controls.Add(this.label4);
            this.grbApreensao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbApreensao.Location = new System.Drawing.Point(12, 6);
            this.grbApreensao.Name = "grbApreensao";
            this.grbApreensao.Size = new System.Drawing.Size(430, 212);
            this.grbApreensao.TabIndex = 15;
            this.grbApreensao.TabStop = false;
            this.grbApreensao.Text = "Apreensão";
            // 
            // btnNovoObjeto
            // 
            this.btnNovoObjeto.Location = new System.Drawing.Point(323, 176);
            this.btnNovoObjeto.Name = "btnNovoObjeto";
            this.btnNovoObjeto.Size = new System.Drawing.Size(101, 27);
            this.btnNovoObjeto.TabIndex = 14;
            this.btnNovoObjeto.Text = "Novo objeto";
            this.btnNovoObjeto.UseVisualStyleBackColor = true;
            this.btnNovoObjeto.Click += new System.EventHandler(this.btnNovoObjeto_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(303, 82);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(121, 24);
            this.txtQuantidade.TabIndex = 13;
            this.txtQuantidade.Text = "0";
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quantidade:";
            // 
            // cmbObjeto
            // 
            this.cmbObjeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObjeto.FormattingEnabled = true;
            this.cmbObjeto.Location = new System.Drawing.Point(79, 23);
            this.cmbObjeto.Name = "cmbObjeto";
            this.cmbObjeto.Size = new System.Drawing.Size(121, 26);
            this.cmbObjeto.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Objeto:";
            // 
            // txtEspecificacao
            // 
            this.txtEspecificacao.Location = new System.Drawing.Point(77, 115);
            this.txtEspecificacao.Multiline = true;
            this.txtEspecificacao.Name = "txtEspecificacao";
            this.txtEspecificacao.Size = new System.Drawing.Size(347, 55);
            this.txtEspecificacao.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Detalhes:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(79, 55);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(121, 24);
            this.txtMarca.TabIndex = 6;
            // 
            // txtNumeracao
            // 
            this.txtNumeracao.Location = new System.Drawing.Point(303, 23);
            this.txtNumeracao.Name = "txtNumeracao";
            this.txtNumeracao.Size = new System.Drawing.Size(121, 24);
            this.txtNumeracao.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numeração:";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(303, 55);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(121, 24);
            this.txtCor.TabIndex = 8;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(79, 85);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(121, 24);
            this.txtModelo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cor:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVoltar,
            this.btnSalvar,
            this.toolStripSeparator1,
            this.btnLimpar,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 255);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(468, 38);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(41, 35);
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltar.ToolTipText = "Voltar à tela anterior";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(42, 35);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.ToolTipText = "Salvar apreensão de objeto";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLimpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(48, 35);
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.ToolTipText = "Limpar formulário";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(13, 179);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(101, 27);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar objeto";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmApreensao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 293);
            this.Controls.Add(this.grbApreensao);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmApreensao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmApreensoes";
            this.Load += new System.EventHandler(this.frmApreensao_Load);
            this.grbApreensao.ResumeLayout(false);
            this.grbApreensao.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbApreensao;
        private System.Windows.Forms.Button btnNovoObjeto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbObjeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEspecificacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtNumeracao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnVoltar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnLimpar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btnCadastrar;
    }
}