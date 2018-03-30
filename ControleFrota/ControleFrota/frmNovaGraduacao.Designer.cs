namespace ControleFrota
{
    partial class frmNovaGraduacao
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dgvGraduacao = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGraduacao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(191, 113);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(110, 113);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dgvGraduacao
            // 
            this.dgvGraduacao.AllowUserToAddRows = false;
            this.dgvGraduacao.AllowUserToDeleteRows = false;
            this.dgvGraduacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGraduacao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGraduacao.Location = new System.Drawing.Point(0, 142);
            this.dgvGraduacao.Name = "dgvGraduacao";
            this.dgvGraduacao.ReadOnly = true;
            this.dgvGraduacao.Size = new System.Drawing.Size(278, 134);
            this.dgvGraduacao.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(98, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(133, 24);
            this.txtNome.TabIndex = 5;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(98, 63);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(133, 24);
            this.txtDescricao.TabIndex = 6;
            // 
            // frmNovaGraduacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 276);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvGraduacao);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNovaGraduacao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Graduação";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGraduacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dgvGraduacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}