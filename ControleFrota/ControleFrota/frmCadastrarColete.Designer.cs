namespace ControleFrota
{
    partial class frmCadastrarColete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarColete));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDataFabricacao = new System.Windows.Forms.DateTimePicker();
            this.txtProprietario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.txtNumCA = new System.Windows.Forms.TextBox();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.txtNumLote = new System.Windows.Forms.TextBox();
            this.cmbTamanho = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAgente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnVoltar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLimpar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Série:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDataFabricacao);
            this.groupBox1.Controls.Add(this.txtProprietario);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNivel);
            this.groupBox1.Controls.Add(this.txtNumCA);
            this.groupBox1.Controls.Add(this.txtNumSerie);
            this.groupBox1.Controls.Add(this.txtNumLote);
            this.groupBox1.Controls.Add(this.cmbTamanho);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblAgente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // dtpDataFabricacao
            // 
            this.dtpDataFabricacao.CustomFormat = "yyyy-MM-dd";
            this.dtpDataFabricacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataFabricacao.Location = new System.Drawing.Point(287, 58);
            this.dtpDataFabricacao.Name = "dtpDataFabricacao";
            this.dtpDataFabricacao.Size = new System.Drawing.Size(96, 24);
            this.dtpDataFabricacao.TabIndex = 16;
            this.dtpDataFabricacao.Value = new System.DateTime(2018, 3, 26, 0, 0, 0, 0);
            // 
            // txtProprietario
            // 
            this.txtProprietario.Location = new System.Drawing.Point(105, 120);
            this.txtProprietario.Name = "txtProprietario";
            this.txtProprietario.Size = new System.Drawing.Size(278, 24);
            this.txtProprietario.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Proprietário:";
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(287, 88);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(96, 24);
            this.txtNivel.TabIndex = 13;
            // 
            // txtNumCA
            // 
            this.txtNumCA.Location = new System.Drawing.Point(287, 28);
            this.txtNumCA.Name = "txtNumCA";
            this.txtNumCA.Size = new System.Drawing.Size(96, 24);
            this.txtNumCA.TabIndex = 11;
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Location = new System.Drawing.Point(105, 28);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(98, 24);
            this.txtNumSerie.TabIndex = 10;
            // 
            // txtNumLote
            // 
            this.txtNumLote.Location = new System.Drawing.Point(105, 58);
            this.txtNumLote.Name = "txtNumLote";
            this.txtNumLote.Size = new System.Drawing.Size(98, 24);
            this.txtNumLote.TabIndex = 9;
            // 
            // cmbTamanho
            // 
            this.cmbTamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTamanho.FormattingEnabled = true;
            this.cmbTamanho.Items.AddRange(new object[] {
            "P",
            "P(FEM)",
            "M",
            "M(FEM)",
            "G",
            "G(FEM)",
            "GG",
            "GG(FEM)"});
            this.cmbTamanho.Location = new System.Drawing.Point(105, 88);
            this.cmbTamanho.Name = "cmbTamanho";
            this.cmbTamanho.Size = new System.Drawing.Size(98, 26);
            this.cmbTamanho.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tamanho:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nº Lote:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nível:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nº CA:";
            // 
            // lblAgente
            // 
            this.lblAgente.AutoSize = true;
            this.lblAgente.Location = new System.Drawing.Point(106, 160);
            this.lblAgente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgente.Name = "lblAgente";
            this.lblAgente.Size = new System.Drawing.Size(0, 18);
            this.lblAgente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Agente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Fab:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVoltar,
            this.toolStripSeparator1,
            this.btnSalvar,
            this.toolStripSeparator3,
            this.btnLimpar,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 223);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(413, 38);
            this.toolStrip1.TabIndex = 89;
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
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(61, 35);
            this.btnSalvar.Text = "Cadastrar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
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
            this.btnLimpar.ToolTipText = "Informar apreensões";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // frmCadastrarColete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 261);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarColete";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Colete";
            this.Load += new System.EventHandler(this.frmCadastrarColete_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAgente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnVoltar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnLimpar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.TextBox txtNumCA;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.TextBox txtNumLote;
        private System.Windows.Forms.ComboBox cmbTamanho;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataFabricacao;
        private System.Windows.Forms.TextBox txtProprietario;
        private System.Windows.Forms.Label label8;
    }
}