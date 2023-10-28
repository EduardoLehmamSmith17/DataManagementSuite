namespace DataManagementSuite
{
    partial class formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formulario));
            this.tabControlPage01 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonLimparLista = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdicionarNumero = new System.Windows.Forms.Button();
            this.inputDeValor = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.buttonGravarLista = new System.Windows.Forms.Button();
            this.buttonAbrirArquivo = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.tabControlPage02 = new System.Windows.Forms.TabPage();
            this.buttonLimparGrid = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCarregarGrid = new System.Windows.Forms.Button();
            this.buttonCriarDataJson = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.inputPesquisa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonLimparGridBanco = new System.Windows.Forms.Button();
            this.buttonConsultaBancos = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.listView4 = new System.Windows.Forms.ListView();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonBaixarGravar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControlPage01.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControlPage02.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPage01
            // 
            this.tabControlPage01.Controls.Add(this.tabPage1);
            this.tabControlPage01.Controls.Add(this.tabControlPage02);
            this.tabControlPage01.Controls.Add(this.tabPage2);
            this.tabControlPage01.Controls.Add(this.tabPage3);
            this.tabControlPage01.Controls.Add(this.tabPage4);
            this.tabControlPage01.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPage01.Location = new System.Drawing.Point(11, 125);
            this.tabControlPage01.Name = "tabControlPage01";
            this.tabControlPage01.SelectedIndex = 0;
            this.tabControlPage01.Size = new System.Drawing.Size(1138, 605);
            this.tabControlPage01.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.buttonLimparLista);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.buttonAdicionarNumero);
            this.tabPage1.Controls.Add(this.inputDeValor);
            this.tabPage1.Controls.Add(this.labelInput);
            this.tabPage1.Controls.Add(this.buttonGravarLista);
            this.tabPage1.Controls.Add(this.buttonAbrirArquivo);
            this.tabPage1.Controls.Add(this.listView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1130, 576);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pagina 01";
            this.tabPage1.ToolTipText = "QUESTÃO 01 & 02";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonLimparLista
            // 
            this.buttonLimparLista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLimparLista.Location = new System.Drawing.Point(739, 220);
            this.buttonLimparLista.Name = "buttonLimparLista";
            this.buttonLimparLista.Size = new System.Drawing.Size(102, 25);
            this.buttonLimparLista.TabIndex = 8;
            this.buttonLimparLista.Text = "Limpar lista";
            this.buttonLimparLista.UseVisualStyleBackColor = false;
            this.buttonLimparLista.Click += new System.EventHandler(this.buttonLimparLista_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(402, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 175);
            this.label4.TabIndex = 6;
            this.label4.Text = "- Adicionar Números.\r\n\r\n- Gravar Números.\r\n\r\n- Abrir arquivo com números.\r\n\r\n- Li" +
    "mpar números.";
            // 
            // buttonAdicionarNumero
            // 
            this.buttonAdicionarNumero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAdicionarNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarNumero.Location = new System.Drawing.Point(270, 217);
            this.buttonAdicionarNumero.Name = "buttonAdicionarNumero";
            this.buttonAdicionarNumero.Size = new System.Drawing.Size(105, 25);
            this.buttonAdicionarNumero.TabIndex = 5;
            this.buttonAdicionarNumero.Text = "Adicionar";
            this.buttonAdicionarNumero.UseVisualStyleBackColor = false;
            this.buttonAdicionarNumero.Click += new System.EventHandler(this.buttonAdicionarNumero_Click);
            // 
            // inputDeValor
            // 
            this.inputDeValor.Location = new System.Drawing.Point(180, 217);
            this.inputDeValor.Name = "inputDeValor";
            this.inputDeValor.Size = new System.Drawing.Size(84, 22);
            this.inputDeValor.TabIndex = 4;
            this.inputDeValor.TextChanged += new System.EventHandler(this.inputDeValor_TextChanged);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.Location = new System.Drawing.Point(6, 220);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(146, 18);
            this.labelInput.TabIndex = 3;
            this.labelInput.Text = "Digite um número:";
            this.labelInput.Click += new System.EventHandler(this.labelInput_Click);
            // 
            // buttonGravarLista
            // 
            this.buttonGravarLista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGravarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGravarLista.Location = new System.Drawing.Point(850, 220);
            this.buttonGravarLista.Name = "buttonGravarLista";
            this.buttonGravarLista.Size = new System.Drawing.Size(130, 25);
            this.buttonGravarLista.TabIndex = 2;
            this.buttonGravarLista.Text = "Gravar lista";
            this.buttonGravarLista.UseVisualStyleBackColor = false;
            this.buttonGravarLista.Click += new System.EventHandler(this.buttonGravarLista_Click);
            // 
            // buttonAbrirArquivo
            // 
            this.buttonAbrirArquivo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAbrirArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbrirArquivo.Location = new System.Drawing.Point(986, 220);
            this.buttonAbrirArquivo.Name = "buttonAbrirArquivo";
            this.buttonAbrirArquivo.Size = new System.Drawing.Size(128, 25);
            this.buttonAbrirArquivo.TabIndex = 1;
            this.buttonAbrirArquivo.Text = "Abrir arquivo";
            this.buttonAbrirArquivo.UseVisualStyleBackColor = false;
            this.buttonAbrirArquivo.Click += new System.EventHandler(this.buttonAbrirArquivo_Click);
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listView2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(9, 251);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1105, 318);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // tabControlPage02
            // 
            this.tabControlPage02.BackColor = System.Drawing.Color.DarkGray;
            this.tabControlPage02.Controls.Add(this.buttonLimparGrid);
            this.tabControlPage02.Controls.Add(this.dataGridView1);
            this.tabControlPage02.Controls.Add(this.buttonCarregarGrid);
            this.tabControlPage02.Controls.Add(this.buttonCriarDataJson);
            this.tabControlPage02.Controls.Add(this.listView1);
            this.tabControlPage02.Controls.Add(this.label1);
            this.tabControlPage02.Location = new System.Drawing.Point(4, 25);
            this.tabControlPage02.Name = "tabControlPage02";
            this.tabControlPage02.Padding = new System.Windows.Forms.Padding(3);
            this.tabControlPage02.Size = new System.Drawing.Size(1130, 576);
            this.tabControlPage02.TabIndex = 1;
            this.tabControlPage02.Text = "Pagina 02";
            this.tabControlPage02.ToolTipText = "QUESTÃO 03, 04 & 05";
            this.tabControlPage02.Click += new System.EventHandler(this.tabControlPage02_Click);
            // 
            // buttonLimparGrid
            // 
            this.buttonLimparGrid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLimparGrid.Location = new System.Drawing.Point(932, 208);
            this.buttonLimparGrid.Name = "buttonLimparGrid";
            this.buttonLimparGrid.Size = new System.Drawing.Size(178, 27);
            this.buttonLimparGrid.TabIndex = 7;
            this.buttonLimparGrid.Text = "Limpar grid";
            this.buttonLimparGrid.UseVisualStyleBackColor = false;
            this.buttonLimparGrid.Click += new System.EventHandler(this.buttonLimparGrid_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1086, 305);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonCarregarGrid
            // 
            this.buttonCarregarGrid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCarregarGrid.Location = new System.Drawing.Point(243, 208);
            this.buttonCarregarGrid.Name = "buttonCarregarGrid";
            this.buttonCarregarGrid.Size = new System.Drawing.Size(202, 28);
            this.buttonCarregarGrid.TabIndex = 5;
            this.buttonCarregarGrid.Text = "Carregar grid";
            this.buttonCarregarGrid.UseVisualStyleBackColor = false;
            this.buttonCarregarGrid.Click += new System.EventHandler(this.buttonCarregarGrid_Click);
            // 
            // buttonCriarDataJson
            // 
            this.buttonCriarDataJson.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCriarDataJson.Location = new System.Drawing.Point(18, 208);
            this.buttonCriarDataJson.Name = "buttonCriarDataJson";
            this.buttonCriarDataJson.Size = new System.Drawing.Size(198, 28);
            this.buttonCriarDataJson.TabIndex = 4;
            this.buttonCriarDataJson.Text = "Criar arquivo data.json";
            this.buttonCriarDataJson.UseVisualStyleBackColor = false;
            this.buttonCriarDataJson.Click += new System.EventHandler(this.buttonCriarDataJson_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 242);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1112, 327);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 125);
            this.label1.TabIndex = 0;
            this.label1.Text = "- Criar lista com 100 linhas e o horario atual.\r\n\r\n- Carregar com as informações " +
    "da lista.\r\n\r\n- Limpar lista.";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.buttonLimpar);
            this.tabPage2.Controls.Add(this.buttonConsultar);
            this.tabPage2.Controls.Add(this.inputPesquisa);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.listView3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1130, 576);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Pagina 03";
            this.tabPage2.ToolTipText = "QUESTÃO 06";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLimpar.Location = new System.Drawing.Point(999, 175);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(125, 26);
            this.buttonLimpar.TabIndex = 5;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonConsultar.Location = new System.Drawing.Point(277, 175);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(185, 26);
            this.buttonConsultar.TabIndex = 4;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = false;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // inputPesquisa
            // 
            this.inputPesquisa.Location = new System.Drawing.Point(140, 175);
            this.inputPesquisa.Name = "inputPesquisa";
            this.inputPesquisa.Size = new System.Drawing.Size(132, 22);
            this.inputPesquisa.TabIndex = 3;
            this.inputPesquisa.TextChanged += new System.EventHandler(this.inputPesquisa_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Informe o CEP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(226, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(682, 87);
            this.label6.TabIndex = 1;
            this.label6.Text = "- Realizar consulta no site dos correios, passando o CEP.\r\n\r\n- Limpar informações" +
    "";
            // 
            // listView3
            // 
            this.listView3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(10, 203);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(1114, 366);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage3.Controls.Add(this.buttonLimparGridBanco);
            this.tabPage3.Controls.Add(this.buttonConsultaBancos);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.listView4);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1130, 576);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Pagina 04";
            this.tabPage3.ToolTipText = "QUESTÃO 07";
            // 
            // buttonLimparGridBanco
            // 
            this.buttonLimparGridBanco.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLimparGridBanco.Location = new System.Drawing.Point(932, 197);
            this.buttonLimparGridBanco.Name = "buttonLimparGridBanco";
            this.buttonLimparGridBanco.Size = new System.Drawing.Size(169, 29);
            this.buttonLimparGridBanco.TabIndex = 4;
            this.buttonLimparGridBanco.Text = "Limpar grid";
            this.buttonLimparGridBanco.UseVisualStyleBackColor = false;
            this.buttonLimparGridBanco.Click += new System.EventHandler(this.buttonLimparGridBanco_Click);
            // 
            // buttonConsultaBancos
            // 
            this.buttonConsultaBancos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonConsultaBancos.Location = new System.Drawing.Point(31, 193);
            this.buttonConsultaBancos.Name = "buttonConsultaBancos";
            this.buttonConsultaBancos.Size = new System.Drawing.Size(317, 30);
            this.buttonConsultaBancos.TabIndex = 3;
            this.buttonConsultaBancos.Text = "Consultar e Mostrar";
            this.buttonConsultaBancos.UseVisualStyleBackColor = false;
            this.buttonConsultaBancos.Click += new System.EventHandler(this.buttonConsultaBancos_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(27, 244);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1074, 306);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // listView4
            // 
            this.listView4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(17, 232);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(1098, 332);
            this.listView4.TabIndex = 1;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(312, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(618, 156);
            this.label10.TabIndex = 0;
            this.label10.Text = "- Consumir a API para listar os bancos brasileiros.\r\n\r\n- Listar os bancos\r\n\r\n- Li" +
    "mpar o grid";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Controls.Add(this.richTextBox1);
            this.tabPage4.Controls.Add(this.buttonBaixarGravar);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1130, 576);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Pagina 05";
            this.tabPage4.ToolTipText = "QUESTÃO 08";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(132, 224);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(317, 332);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // buttonBaixarGravar
            // 
            this.buttonBaixarGravar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBaixarGravar.Location = new System.Drawing.Point(356, 139);
            this.buttonBaixarGravar.Name = "buttonBaixarGravar";
            this.buttonBaixarGravar.Size = new System.Drawing.Size(333, 39);
            this.buttonBaixarGravar.TabIndex = 2;
            this.buttonBaixarGravar.Text = "Baixar imagem e Gravar";
            this.buttonBaixarGravar.UseVisualStyleBackColor = false;
            this.buttonBaixarGravar.Click += new System.EventHandler(this.buttonBaixarGravar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(413, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(243, 87);
            this.label11.TabIndex = 0;
            this.label11.Text = "- Exibir imagem\r\n\r\n- Listar informações";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(211, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(632, 37);
            this.label8.TabIndex = 1;
            this.label8.Text = "PROJETO EDUARDO LEHMAM SMITH";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(132, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 332);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(530, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(507, 275);
            this.label12.TabIndex = 7;
            this.label12.Text = resources.GetString("label12.Text");
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // formulario
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1158, 736);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tabControlPage01);
            this.Name = "formulario";
            this.Text = "Form1";
            this.tabControlPage01.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControlPage02.ResumeLayout(false);
            this.tabControlPage02.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPage01;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabControlPage02;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAbrirArquivo;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button buttonGravarLista;
        private System.Windows.Forms.Button buttonAdicionarNumero;
        private System.Windows.Forms.TextBox inputDeValor;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonLimparLista;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonCarregarGrid;
        private System.Windows.Forms.Button buttonCriarDataJson;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonLimparGrid;
        private System.Windows.Forms.TextBox inputPesquisa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonConsultaBancos;
        private System.Windows.Forms.Button buttonBaixarGravar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonLimparGridBanco;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
    }
}

