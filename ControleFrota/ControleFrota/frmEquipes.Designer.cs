namespace ControleFrota
{
    partial class frmEquipes
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGuardas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvViaturas = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvAbordados = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.dgvVeiculosAbordados = new System.Windows.Forms.DataGridView();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dgvMultas = new System.Windows.Forms.DataGridView();
            this.cmbPlantao = new System.Windows.Forms.ComboBox();
            this.cmbViatura = new System.Windows.Forms.ComboBox();
            this.cmbMotorista = new System.Windows.Forms.ComboBox();
            this.cmbEncarregado = new System.Windows.Forms.ComboBox();
            this.cmbAuxiliar = new System.Windows.Forms.ComboBox();
            this.cmbTrocarPlantao = new System.Windows.Forms.ComboBox();
            this.cmbMultas = new System.Windows.Forms.ComboBox();
            this.cmbAbastecido = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtKmInicio = new System.Windows.Forms.TextBox();
            this.txtKmTermino = new System.Windows.Forms.TextBox();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtNomeAbordado = new System.Windows.Forms.TextBox();
            this.txtRgAbordado = new System.Windows.Forms.TextBox();
            this.txtArtigoAbordado = new System.Windows.Forms.TextBox();
            this.txtEnderecoAbordado = new System.Windows.Forms.TextBox();
            this.cmbPassagem = new System.Windows.Forms.ComboBox();
            this.txtNomeCondutor = new System.Windows.Forms.TextBox();
            this.txtEnderecoCondutor = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btnInserirAbordado = new System.Windows.Forms.Button();
            this.btnInserirVeiculo = new System.Windows.Forms.Button();
            this.btnInserirMultas = new System.Windows.Forms.Button();
            this.btnTrocar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuardas)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViaturas)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbordados)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculosAbordados)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultas)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Plantão:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 91;
            this.label6.Text = "GCM:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTrocar);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.cmbTrocarPlantao);
            this.groupBox1.Controls.Add(this.dgvGuardas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 322);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerenciar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Controls.Add(this.txtLitros);
            this.groupBox2.Controls.Add(this.txtKmTermino);
            this.groupBox2.Controls.Add(this.txtKmInicio);
            this.groupBox2.Controls.Add(this.cmbAbastecido);
            this.groupBox2.Controls.Add(this.cmbAuxiliar);
            this.groupBox2.Controls.Add(this.cmbEncarregado);
            this.groupBox2.Controls.Add(this.cmbMotorista);
            this.groupBox2.Controls.Add(this.cmbViatura);
            this.groupBox2.Controls.Add(this.cmbPlantao);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(385, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(973, 322);
            this.groupBox2.TabIndex = 92;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Viaturas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 91;
            this.label1.Text = "Viatura:";
            // 
            // dgvGuardas
            // 
            this.dgvGuardas.AllowUserToAddRows = false;
            this.dgvGuardas.AllowUserToDeleteRows = false;
            this.dgvGuardas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuardas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGuardas.Location = new System.Drawing.Point(3, 154);
            this.dgvGuardas.Name = "dgvGuardas";
            this.dgvGuardas.ReadOnly = true;
            this.dgvGuardas.Size = new System.Drawing.Size(361, 165);
            this.dgvGuardas.TabIndex = 92;
            this.dgvGuardas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuardas_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Motorista:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 92;
            this.label3.Text = "Encarregado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 93;
            this.label4.Text = "Auxiliar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 93;
            this.label7.Text = "Plantão:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 94;
            this.label8.Text = "KM inicio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 95;
            this.label9.Text = "KM término:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 18);
            this.label10.TabIndex = 96;
            this.label10.Text = "OBS:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvViaturas);
            this.groupBox3.Location = new System.Drawing.Point(489, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(478, 306);
            this.groupBox3.TabIndex = 97;
            this.groupBox3.TabStop = false;
            // 
            // dgvViaturas
            // 
            this.dgvViaturas.AllowUserToAddRows = false;
            this.dgvViaturas.AllowUserToDeleteRows = false;
            this.dgvViaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViaturas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvViaturas.Location = new System.Drawing.Point(3, 13);
            this.dgvViaturas.Name = "dgvViaturas";
            this.dgvViaturas.ReadOnly = true;
            this.dgvViaturas.Size = new System.Drawing.Size(472, 290);
            this.dgvViaturas.TabIndex = 93;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 18);
            this.label11.TabIndex = 98;
            this.label11.Text = "Abastecido:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(287, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 18);
            this.label12.TabIndex = 99;
            this.label12.Text = "Litros:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(12, 340);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1346, 397);
            this.groupBox4.TabIndex = 93;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Relatórios";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnInserirAbordado);
            this.groupBox5.Controls.Add(this.cmbPassagem);
            this.groupBox5.Controls.Add(this.txtEnderecoAbordado);
            this.groupBox5.Controls.Add(this.txtArtigoAbordado);
            this.groupBox5.Controls.Add(this.txtRgAbordado);
            this.groupBox5.Controls.Add(this.txtNomeAbordado);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.dgvAbordados);
            this.groupBox5.Location = new System.Drawing.Point(6, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(535, 308);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Abordados";
            // 
            // dgvAbordados
            // 
            this.dgvAbordados.AllowUserToAddRows = false;
            this.dgvAbordados.AllowUserToDeleteRows = false;
            this.dgvAbordados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbordados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAbordados.Location = new System.Drawing.Point(3, 126);
            this.dgvAbordados.Name = "dgvAbordados";
            this.dgvAbordados.ReadOnly = true;
            this.dgvAbordados.Size = new System.Drawing.Size(529, 179);
            this.dgvAbordados.TabIndex = 93;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 18);
            this.label13.TabIndex = 100;
            this.label13.Text = "Nome:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 18);
            this.label14.TabIndex = 101;
            this.label14.Text = "Endereço:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(356, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 18);
            this.label15.TabIndex = 102;
            this.label15.Text = "RG:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 18);
            this.label16.TabIndex = 103;
            this.label16.Text = "Passagens:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(361, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 18);
            this.label17.TabIndex = 104;
            this.label17.Text = "Art:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnInserirVeiculo);
            this.groupBox6.Controls.Add(this.txtPlaca);
            this.groupBox6.Controls.Add(this.txtMarca);
            this.groupBox6.Controls.Add(this.txtModelo);
            this.groupBox6.Controls.Add(this.txtEnderecoCondutor);
            this.groupBox6.Controls.Add(this.txtNomeCondutor);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.dgvVeiculosAbordados);
            this.groupBox6.Location = new System.Drawing.Point(544, 23);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(535, 308);
            this.groupBox6.TabIndex = 105;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Veículos";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 65);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 18);
            this.label20.TabIndex = 102;
            this.label20.Text = "Modelo:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(353, 65);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 18);
            this.label21.TabIndex = 101;
            this.label21.Text = "Placa:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(348, 33);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 18);
            this.label22.TabIndex = 100;
            this.label22.Text = "Marca:";
            // 
            // dgvVeiculosAbordados
            // 
            this.dgvVeiculosAbordados.AllowUserToAddRows = false;
            this.dgvVeiculosAbordados.AllowUserToDeleteRows = false;
            this.dgvVeiculosAbordados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculosAbordados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvVeiculosAbordados.Location = new System.Drawing.Point(3, 126);
            this.dgvVeiculosAbordados.Name = "dgvVeiculosAbordados";
            this.dgvVeiculosAbordados.ReadOnly = true;
            this.dgvVeiculosAbordados.Size = new System.Drawing.Size(529, 179);
            this.dgvVeiculosAbordados.TabIndex = 93;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 94);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 18);
            this.label23.TabIndex = 105;
            this.label23.Text = "Endereço:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 18);
            this.label18.TabIndex = 106;
            this.label18.Text = "Condutor:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnInserirMultas);
            this.groupBox7.Controls.Add(this.cmbMultas);
            this.groupBox7.Controls.Add(this.dgvMultas);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Location = new System.Drawing.Point(1085, 23);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(255, 308);
            this.groupBox7.TabIndex = 106;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Fiscalização";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 33);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 18);
            this.label19.TabIndex = 107;
            this.label19.Text = "Multas:";
            // 
            // dgvMultas
            // 
            this.dgvMultas.AllowUserToAddRows = false;
            this.dgvMultas.AllowUserToDeleteRows = false;
            this.dgvMultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMultas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMultas.Location = new System.Drawing.Point(3, 129);
            this.dgvMultas.Name = "dgvMultas";
            this.dgvMultas.ReadOnly = true;
            this.dgvMultas.Size = new System.Drawing.Size(249, 176);
            this.dgvMultas.TabIndex = 110;
            // 
            // cmbPlantao
            // 
            this.cmbPlantao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlantao.FormattingEnabled = true;
            this.cmbPlantao.Location = new System.Drawing.Point(109, 26);
            this.cmbPlantao.Name = "cmbPlantao";
            this.cmbPlantao.Size = new System.Drawing.Size(121, 26);
            this.cmbPlantao.TabIndex = 100;
            // 
            // cmbViatura
            // 
            this.cmbViatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbViatura.FormattingEnabled = true;
            this.cmbViatura.Location = new System.Drawing.Point(342, 26);
            this.cmbViatura.Name = "cmbViatura";
            this.cmbViatura.Size = new System.Drawing.Size(121, 26);
            this.cmbViatura.TabIndex = 101;
            // 
            // cmbMotorista
            // 
            this.cmbMotorista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotorista.FormattingEnabled = true;
            this.cmbMotorista.Location = new System.Drawing.Point(109, 58);
            this.cmbMotorista.Name = "cmbMotorista";
            this.cmbMotorista.Size = new System.Drawing.Size(121, 26);
            this.cmbMotorista.TabIndex = 102;
            // 
            // cmbEncarregado
            // 
            this.cmbEncarregado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncarregado.FormattingEnabled = true;
            this.cmbEncarregado.Location = new System.Drawing.Point(342, 57);
            this.cmbEncarregado.Name = "cmbEncarregado";
            this.cmbEncarregado.Size = new System.Drawing.Size(121, 26);
            this.cmbEncarregado.TabIndex = 103;
            // 
            // cmbAuxiliar
            // 
            this.cmbAuxiliar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuxiliar.FormattingEnabled = true;
            this.cmbAuxiliar.Location = new System.Drawing.Point(109, 95);
            this.cmbAuxiliar.Name = "cmbAuxiliar";
            this.cmbAuxiliar.Size = new System.Drawing.Size(121, 26);
            this.cmbAuxiliar.TabIndex = 104;
            // 
            // cmbTrocarPlantao
            // 
            this.cmbTrocarPlantao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrocarPlantao.FormattingEnabled = true;
            this.cmbTrocarPlantao.Location = new System.Drawing.Point(93, 57);
            this.cmbTrocarPlantao.Name = "cmbTrocarPlantao";
            this.cmbTrocarPlantao.Size = new System.Drawing.Size(209, 26);
            this.cmbTrocarPlantao.TabIndex = 104;
            // 
            // cmbMultas
            // 
            this.cmbMultas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMultas.FormattingEnabled = true;
            this.cmbMultas.Location = new System.Drawing.Point(70, 30);
            this.cmbMultas.Name = "cmbMultas";
            this.cmbMultas.Size = new System.Drawing.Size(54, 26);
            this.cmbMultas.TabIndex = 105;
            // 
            // cmbAbastecido
            // 
            this.cmbAbastecido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAbastecido.FormattingEnabled = true;
            this.cmbAbastecido.Location = new System.Drawing.Point(148, 184);
            this.cmbAbastecido.Name = "cmbAbastecido";
            this.cmbAbastecido.Size = new System.Drawing.Size(82, 26);
            this.cmbAbastecido.TabIndex = 112;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(90, 29);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 18);
            this.label25.TabIndex = 113;
            this.label25.Text = "SIQUEIRA";
            // 
            // txtKmInicio
            // 
            this.txtKmInicio.Location = new System.Drawing.Point(136, 152);
            this.txtKmInicio.Name = "txtKmInicio";
            this.txtKmInicio.Size = new System.Drawing.Size(94, 24);
            this.txtKmInicio.TabIndex = 113;
            // 
            // txtKmTermino
            // 
            this.txtKmTermino.Location = new System.Drawing.Point(369, 155);
            this.txtKmTermino.Name = "txtKmTermino";
            this.txtKmTermino.Size = new System.Drawing.Size(94, 24);
            this.txtKmTermino.TabIndex = 114;
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(398, 187);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(65, 24);
            this.txtLitros.TabIndex = 115;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(109, 240);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(354, 55);
            this.txtObs.TabIndex = 116;
            // 
            // txtNomeAbordado
            // 
            this.txtNomeAbordado.Location = new System.Drawing.Point(96, 30);
            this.txtNomeAbordado.Name = "txtNomeAbordado";
            this.txtNomeAbordado.Size = new System.Drawing.Size(254, 24);
            this.txtNomeAbordado.TabIndex = 114;
            // 
            // txtRgAbordado
            // 
            this.txtRgAbordado.Location = new System.Drawing.Point(397, 30);
            this.txtRgAbordado.Name = "txtRgAbordado";
            this.txtRgAbordado.Size = new System.Drawing.Size(113, 24);
            this.txtRgAbordado.TabIndex = 115;
            // 
            // txtArtigoAbordado
            // 
            this.txtArtigoAbordado.Location = new System.Drawing.Point(415, 60);
            this.txtArtigoAbordado.Name = "txtArtigoAbordado";
            this.txtArtigoAbordado.Size = new System.Drawing.Size(94, 24);
            this.txtArtigoAbordado.TabIndex = 116;
            // 
            // txtEnderecoAbordado
            // 
            this.txtEnderecoAbordado.Location = new System.Drawing.Point(96, 91);
            this.txtEnderecoAbordado.Name = "txtEnderecoAbordado";
            this.txtEnderecoAbordado.Size = new System.Drawing.Size(254, 24);
            this.txtEnderecoAbordado.TabIndex = 117;
            // 
            // cmbPassagem
            // 
            this.cmbPassagem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPassagem.FormattingEnabled = true;
            this.cmbPassagem.Location = new System.Drawing.Point(96, 59);
            this.cmbPassagem.Name = "cmbPassagem";
            this.cmbPassagem.Size = new System.Drawing.Size(82, 26);
            this.cmbPassagem.TabIndex = 117;
            // 
            // txtNomeCondutor
            // 
            this.txtNomeCondutor.Location = new System.Drawing.Point(88, 30);
            this.txtNomeCondutor.Name = "txtNomeCondutor";
            this.txtNomeCondutor.Size = new System.Drawing.Size(254, 24);
            this.txtNomeCondutor.TabIndex = 115;
            // 
            // txtEnderecoCondutor
            // 
            this.txtEnderecoCondutor.Location = new System.Drawing.Point(88, 91);
            this.txtEnderecoCondutor.Name = "txtEnderecoCondutor";
            this.txtEnderecoCondutor.Size = new System.Drawing.Size(254, 24);
            this.txtEnderecoCondutor.TabIndex = 116;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(88, 59);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(129, 24);
            this.txtModelo.TabIndex = 117;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(408, 30);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(103, 24);
            this.txtMarca.TabIndex = 118;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(424, 62);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(87, 24);
            this.txtPlaca.TabIndex = 119;
            // 
            // btnInserirAbordado
            // 
            this.btnInserirAbordado.Location = new System.Drawing.Point(434, 91);
            this.btnInserirAbordado.Name = "btnInserirAbordado";
            this.btnInserirAbordado.Size = new System.Drawing.Size(75, 23);
            this.btnInserirAbordado.TabIndex = 118;
            this.btnInserirAbordado.Text = "Inserir";
            this.btnInserirAbordado.UseVisualStyleBackColor = true;
            // 
            // btnInserirVeiculo
            // 
            this.btnInserirVeiculo.Location = new System.Drawing.Point(436, 92);
            this.btnInserirVeiculo.Name = "btnInserirVeiculo";
            this.btnInserirVeiculo.Size = new System.Drawing.Size(75, 23);
            this.btnInserirVeiculo.TabIndex = 120;
            this.btnInserirVeiculo.Text = "Inserir";
            this.btnInserirVeiculo.UseVisualStyleBackColor = true;
            // 
            // btnInserirMultas
            // 
            this.btnInserirMultas.Location = new System.Drawing.Point(165, 92);
            this.btnInserirMultas.Name = "btnInserirMultas";
            this.btnInserirMultas.Size = new System.Drawing.Size(75, 23);
            this.btnInserirMultas.TabIndex = 121;
            this.btnInserirMultas.Text = "Inserir";
            this.btnInserirMultas.UseVisualStyleBackColor = true;
            // 
            // btnTrocar
            // 
            this.btnTrocar.Location = new System.Drawing.Point(227, 109);
            this.btnTrocar.Name = "btnTrocar";
            this.btnTrocar.Size = new System.Drawing.Size(75, 23);
            this.btnTrocar.TabIndex = 119;
            this.btnTrocar.Text = "Trocar";
            this.btnTrocar.UseVisualStyleBackColor = true;
            // 
            // frmEquipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEquipes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuardas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViaturas)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbordados)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculosAbordados)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGuardas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvViaturas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView dgvVeiculosAbordados;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvAbordados;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cmbTrocarPlantao;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.TextBox txtKmTermino;
        private System.Windows.Forms.TextBox txtKmInicio;
        private System.Windows.Forms.ComboBox cmbAbastecido;
        private System.Windows.Forms.ComboBox cmbAuxiliar;
        private System.Windows.Forms.ComboBox cmbEncarregado;
        private System.Windows.Forms.ComboBox cmbMotorista;
        private System.Windows.Forms.ComboBox cmbViatura;
        private System.Windows.Forms.ComboBox cmbPlantao;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnInserirMultas;
        private System.Windows.Forms.ComboBox cmbMultas;
        private System.Windows.Forms.DataGridView dgvMultas;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnInserirVeiculo;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtEnderecoCondutor;
        private System.Windows.Forms.TextBox txtNomeCondutor;
        private System.Windows.Forms.Button btnInserirAbordado;
        private System.Windows.Forms.ComboBox cmbPassagem;
        private System.Windows.Forms.TextBox txtEnderecoAbordado;
        private System.Windows.Forms.TextBox txtArtigoAbordado;
        private System.Windows.Forms.TextBox txtRgAbordado;
        private System.Windows.Forms.TextBox txtNomeAbordado;
        private System.Windows.Forms.Button btnTrocar;
    }
}