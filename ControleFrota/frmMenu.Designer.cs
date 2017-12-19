namespace ControleFrota
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBoletimOcorrencia = new System.Windows.Forms.ToolStripButton();
            this.btnEquipes = new System.Windows.Forms.ToolStripButton();
            this.btnViaturas = new System.Windows.Forms.ToolStripButton();
            this.btnGuardas = new System.Windows.Forms.ToolStripButton();
            this.btnRelatorio = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBoletimOcorrencia,
            this.toolStripSeparator2,
            this.btnEquipes,
            this.toolStripSeparator1,
            this.btnViaturas,
            this.toolStripSeparator3,
            this.btnGuardas,
            this.toolStripSeparator4,
            this.btnRelatorio,
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1051, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ControleFrota.Properties.Resources.BRASÃO_GM_GWS_2009;
            this.pictureBox1.Location = new System.Drawing.Point(0, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1051, 502);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnBoletimOcorrencia
            // 
            this.btnBoletimOcorrencia.AutoSize = false;
            this.btnBoletimOcorrencia.Image = ((System.Drawing.Image)(resources.GetObject("btnBoletimOcorrencia.Image")));
            this.btnBoletimOcorrencia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBoletimOcorrencia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoletimOcorrencia.Name = "btnBoletimOcorrencia";
            this.btnBoletimOcorrencia.Size = new System.Drawing.Size(36, 35);
            this.btnBoletimOcorrencia.Text = "B. O.";
            this.btnBoletimOcorrencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBoletimOcorrencia.Click += new System.EventHandler(this.btnBoletimOcorrencia_Click);
            // 
            // btnEquipes
            // 
            this.btnEquipes.Image = ((System.Drawing.Image)(resources.GetObject("btnEquipes.Image")));
            this.btnEquipes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEquipes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEquipes.Name = "btnEquipes";
            this.btnEquipes.Size = new System.Drawing.Size(52, 35);
            this.btnEquipes.Text = "Equipes";
            this.btnEquipes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnViaturas
            // 
            this.btnViaturas.AutoSize = false;
            this.btnViaturas.Image = ((System.Drawing.Image)(resources.GetObject("btnViaturas.Image")));
            this.btnViaturas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnViaturas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViaturas.Name = "btnViaturas";
            this.btnViaturas.Size = new System.Drawing.Size(53, 35);
            this.btnViaturas.Text = "Viaturas";
            this.btnViaturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnGuardas
            // 
            this.btnGuardas.AutoSize = false;
            this.btnGuardas.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardas.Image")));
            this.btnGuardas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGuardas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardas.Name = "btnGuardas";
            this.btnGuardas.Size = new System.Drawing.Size(54, 35);
            this.btnGuardas.Text = "Guardas";
            this.btnGuardas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardas.Click += new System.EventHandler(this.btnGuardas_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.AutoSize = false;
            this.btnRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.Image")));
            this.btnRelatorio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(58, 35);
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnSair
            // 
            this.btnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSair.AutoSize = false;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(30, 35);
            this.btnSair.Text = "&Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1051, 540);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBoletimOcorrencia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEquipes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnViaturas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnGuardas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnRelatorio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton btnSair;
    }
}

