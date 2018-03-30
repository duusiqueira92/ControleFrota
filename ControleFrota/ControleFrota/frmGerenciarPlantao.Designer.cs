namespace ControleFrota
{
    partial class frmGerenciarPlantao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarPlantao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPosicao = new System.Windows.Forms.ComboBox();
            this.cmbEquipe = new System.Windows.Forms.ComboBox();
            this.cmbPlantao = new System.Windows.Forms.ComboBox();
            this.dgvAgentes = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAgente = new System.Windows.Forms.Label();
            this.QRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_agente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plantão = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgentes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAgente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbPosicao);
            this.groupBox1.Controls.Add(this.cmbEquipe);
            this.groupBox1.Controls.Add(this.cmbPlantao);
            this.groupBox1.Controls.Add(this.dgvAgentes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 541);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerenciar plantão";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnSalvar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 513);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(582, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(23, 22);
            this.btnSalvar.Text = "toolStripButton2";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Posição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Equipe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plantão:";
            // 
            // cmbPosicao
            // 
            this.cmbPosicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosicao.FormattingEnabled = true;
            this.cmbPosicao.Items.AddRange(new object[] {
            "Motorista",
            "Encarregado",
            "Auxiliar"});
            this.cmbPosicao.Location = new System.Drawing.Point(430, 469);
            this.cmbPosicao.Name = "cmbPosicao";
            this.cmbPosicao.Size = new System.Drawing.Size(121, 26);
            this.cmbPosicao.TabIndex = 3;
            // 
            // cmbEquipe
            // 
            this.cmbEquipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipe.FormattingEnabled = true;
            this.cmbEquipe.Location = new System.Drawing.Point(216, 469);
            this.cmbEquipe.Name = "cmbEquipe";
            this.cmbEquipe.Size = new System.Drawing.Size(121, 26);
            this.cmbEquipe.TabIndex = 2;
            // 
            // cmbPlantao
            // 
            this.cmbPlantao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlantao.FormattingEnabled = true;
            this.cmbPlantao.Location = new System.Drawing.Point(17, 469);
            this.cmbPlantao.Name = "cmbPlantao";
            this.cmbPlantao.Size = new System.Drawing.Size(121, 26);
            this.cmbPlantao.TabIndex = 1;
            // 
            // dgvAgentes
            // 
            this.dgvAgentes.AllowUserToAddRows = false;
            this.dgvAgentes.AllowUserToDeleteRows = false;
            this.dgvAgentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QRA,
            this.PID,
            this.PSID,
            this.EID,
            this.id_agente,
            this.Plantão,
            this.Equipe,
            this.Posição});
            this.dgvAgentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAgentes.Location = new System.Drawing.Point(3, 20);
            this.dgvAgentes.Name = "dgvAgentes";
            this.dgvAgentes.ReadOnly = true;
            this.dgvAgentes.Size = new System.Drawing.Size(582, 370);
            this.dgvAgentes.TabIndex = 0;
            this.dgvAgentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgentes_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Agente:";
            // 
            // lblAgente
            // 
            this.lblAgente.AutoSize = true;
            this.lblAgente.Location = new System.Drawing.Point(77, 408);
            this.lblAgente.Name = "lblAgente";
            this.lblAgente.Size = new System.Drawing.Size(0, 18);
            this.lblAgente.TabIndex = 9;
            // 
            // QRA
            // 
            this.QRA.DataPropertyName = "QRA";
            this.QRA.HeaderText = "Agente";
            this.QRA.Name = "QRA";
            this.QRA.ReadOnly = true;
            this.QRA.Width = 160;
            // 
            // PID
            // 
            this.PID.DataPropertyName = "PID";
            this.PID.HeaderText = "PID";
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            this.PID.Visible = false;
            // 
            // PSID
            // 
            this.PSID.DataPropertyName = "PSID";
            this.PSID.HeaderText = "PSID";
            this.PSID.Name = "PSID";
            this.PSID.ReadOnly = true;
            this.PSID.Visible = false;
            // 
            // EID
            // 
            this.EID.DataPropertyName = "EID";
            this.EID.HeaderText = "EID";
            this.EID.Name = "EID";
            this.EID.ReadOnly = true;
            this.EID.Visible = false;
            // 
            // id_agente
            // 
            this.id_agente.DataPropertyName = "id_agente";
            this.id_agente.HeaderText = "ID";
            this.id_agente.Name = "id_agente";
            this.id_agente.ReadOnly = true;
            this.id_agente.Visible = false;
            // 
            // Plantão
            // 
            this.Plantão.DataPropertyName = "Plantão";
            this.Plantão.HeaderText = "Plantão";
            this.Plantão.Name = "Plantão";
            this.Plantão.ReadOnly = true;
            // 
            // Equipe
            // 
            this.Equipe.DataPropertyName = "Equipe";
            this.Equipe.HeaderText = "Equipe";
            this.Equipe.Name = "Equipe";
            this.Equipe.ReadOnly = true;
            this.Equipe.Width = 150;
            // 
            // Posição
            // 
            this.Posição.DataPropertyName = "Posição";
            this.Posição.HeaderText = "Posição";
            this.Posição.Name = "Posição";
            this.Posição.ReadOnly = true;
            this.Posição.Width = 120;
            // 
            // frmGerenciarPlantao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 559);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGerenciarPlantao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Plantão";
            this.Load += new System.EventHandler(this.frmGerenciarPlantao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPosicao;
        private System.Windows.Forms.ComboBox cmbEquipe;
        private System.Windows.Forms.ComboBox cmbPlantao;
        private System.Windows.Forms.DataGridView dgvAgentes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.Label lblAgente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn QRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EID;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_agente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plantão;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posição;
    }
}