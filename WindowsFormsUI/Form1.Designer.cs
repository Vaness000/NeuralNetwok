
namespace WindowsFormsUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.trainingData = new System.Windows.Forms.GroupBox();
            this.saveTrainingData = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.trainingsAmount = new System.Windows.Forms.NumericUpDown();
            this.trainingDataDGW = new System.Windows.Forms.DataGridView();
            this.inp1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.out1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geneticGB = new System.Windows.Forms.GroupBox();
            this.mutationTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.epsTB = new System.Windows.Forms.TextBox();
            this.iterationsAmountNUD = new System.Windows.Forms.NumericUpDown();
            this.populationSizeNUD = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showStatBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.saveToFileBtn = new System.Windows.Forms.Button();
            this.trainBtn = new System.Windows.Forms.Button();
            this.neuralNetworkGB = new System.Windows.Forms.GroupBox();
            this.neuronAmountPanel = new System.Windows.Forms.Panel();
            this.hidenLayersAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.inputsAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.outputsAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.activatorCB = new System.Windows.Forms.ComboBox();
            this.activatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loadFromfileBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.resultTB = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.amountTasksNUD = new System.Windows.Forms.NumericUpDown();
            this.calculateSolutionBtn = new System.Windows.Forms.Button();
            this.workDGW = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.trainingData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDataDGW)).BeginInit();
            this.geneticGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsAmountNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationSizeNUD)).BeginInit();
            this.panel1.SuspendLayout();
            this.neuralNetworkGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidenLayersAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputsAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputsAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activatorBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountTasksNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1090, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveToolStripMenuItem.Text = "Сохранить нейросеть";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.loadToolStripMenuItem.Text = "Открыть нейросеть";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.09227F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.90773F));
            this.tableLayoutPanel1.Controls.Add(this.trainingData, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.geneticGB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.neuralNetworkGB, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.47458F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.52542F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1073, 545);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // trainingData
            // 
            this.trainingData.Controls.Add(this.saveTrainingData);
            this.trainingData.Controls.Add(this.loadBtn);
            this.trainingData.Controls.Add(this.label8);
            this.trainingData.Controls.Add(this.trainingsAmount);
            this.trainingData.Controls.Add(this.trainingDataDGW);
            this.trainingData.Location = new System.Drawing.Point(401, 3);
            this.trainingData.Name = "trainingData";
            this.trainingData.Size = new System.Drawing.Size(669, 388);
            this.trainingData.TabIndex = 2;
            this.trainingData.TabStop = false;
            this.trainingData.Text = "Обучающий набор";
            // 
            // saveTrainingData
            // 
            this.saveTrainingData.Location = new System.Drawing.Point(212, 356);
            this.saveTrainingData.Name = "saveTrainingData";
            this.saveTrainingData.Size = new System.Drawing.Size(197, 23);
            this.saveTrainingData.TabIndex = 11;
            this.saveTrainingData.Text = "Сохранить обучающее множество";
            this.saveTrainingData.UseVisualStyleBackColor = true;
            this.saveTrainingData.Click += new System.EventHandler(this.saveTrainingDataBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(9, 356);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(197, 23);
            this.loadBtn.TabIndex = 10;
            this.loadBtn.Text = "Загрузить обучающее множество";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Количество обучающих примеров";
            // 
            // trainingsAmount
            // 
            this.trainingsAmount.Location = new System.Drawing.Point(212, 330);
            this.trainingsAmount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.trainingsAmount.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.trainingsAmount.Name = "trainingsAmount";
            this.trainingsAmount.Size = new System.Drawing.Size(197, 20);
            this.trainingsAmount.TabIndex = 9;
            this.trainingsAmount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.trainingsAmount.ValueChanged += new System.EventHandler(this.trainingsAmount_ValueChanged);
            // 
            // trainingDataDGW
            // 
            this.trainingDataDGW.AllowUserToAddRows = false;
            this.trainingDataDGW.AllowUserToDeleteRows = false;
            this.trainingDataDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.trainingDataDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainingDataDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inp1,
            this.out1});
            this.trainingDataDGW.Location = new System.Drawing.Point(6, 24);
            this.trainingDataDGW.Name = "trainingDataDGW";
            this.trainingDataDGW.Size = new System.Drawing.Size(657, 300);
            this.trainingDataDGW.TabIndex = 0;
            // 
            // inp1
            // 
            this.inp1.HeaderText = "Вход 1";
            this.inp1.Name = "inp1";
            // 
            // out1
            // 
            this.out1.HeaderText = "Выход 1";
            this.out1.Name = "out1";
            // 
            // geneticGB
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.geneticGB, 2);
            this.geneticGB.Controls.Add(this.mutationTB);
            this.geneticGB.Controls.Add(this.label9);
            this.geneticGB.Controls.Add(this.epsTB);
            this.geneticGB.Controls.Add(this.iterationsAmountNUD);
            this.geneticGB.Controls.Add(this.populationSizeNUD);
            this.geneticGB.Controls.Add(this.flowLayoutPanel1);
            this.geneticGB.Controls.Add(this.label7);
            this.geneticGB.Controls.Add(this.label6);
            this.geneticGB.Controls.Add(this.label5);
            this.geneticGB.Location = new System.Drawing.Point(3, 397);
            this.geneticGB.Name = "geneticGB";
            this.geneticGB.Size = new System.Drawing.Size(1067, 72);
            this.geneticGB.TabIndex = 1;
            this.geneticGB.TabStop = false;
            this.geneticGB.Text = "Параметры генетического алгоритма";
            // 
            // mutationTB
            // 
            this.mutationTB.Location = new System.Drawing.Point(901, 29);
            this.mutationTB.Name = "mutationTB";
            this.mutationTB.Size = new System.Drawing.Size(71, 20);
            this.mutationTB.TabIndex = 13;
            this.mutationTB.Text = "0,01";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Максимальное количество итераций";
            // 
            // epsTB
            // 
            this.epsTB.Location = new System.Drawing.Point(365, 28);
            this.epsTB.Name = "epsTB";
            this.epsTB.Size = new System.Drawing.Size(71, 20);
            this.epsTB.TabIndex = 11;
            this.epsTB.Text = "0,001";
            // 
            // iterationsAmountNUD
            // 
            this.iterationsAmountNUD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.iterationsAmountNUD.Location = new System.Drawing.Point(658, 29);
            this.iterationsAmountNUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.iterationsAmountNUD.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.iterationsAmountNUD.Name = "iterationsAmountNUD";
            this.iterationsAmountNUD.Size = new System.Drawing.Size(78, 20);
            this.iterationsAmountNUD.TabIndex = 10;
            this.iterationsAmountNUD.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // populationSizeNUD
            // 
            this.populationSizeNUD.Location = new System.Drawing.Point(117, 30);
            this.populationSizeNUD.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.populationSizeNUD.Name = "populationSizeNUD";
            this.populationSizeNUD.Size = new System.Drawing.Size(90, 20);
            this.populationSizeNUD.TabIndex = 9;
            this.populationSizeNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(122, 267);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 78);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(778, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Вероятность мутации";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Максимальная ошибка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Размер популяции";
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.showStatBtn);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.saveToFileBtn);
            this.panel1.Controls.Add(this.trainBtn);
            this.panel1.Location = new System.Drawing.Point(3, 475);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 67);
            this.panel1.TabIndex = 3;
            // 
            // showStatBtn
            // 
            this.showStatBtn.Location = new System.Drawing.Point(555, 24);
            this.showStatBtn.Name = "showStatBtn";
            this.showStatBtn.Size = new System.Drawing.Size(175, 23);
            this.showStatBtn.TabIndex = 4;
            this.showStatBtn.Text = "Показать статистику";
            this.showStatBtn.UseVisualStyleBackColor = true;
            this.showStatBtn.Click += new System.EventHandler(this.showStatBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(883, 24);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(175, 23);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // saveToFileBtn
            // 
            this.saveToFileBtn.Location = new System.Drawing.Point(374, 24);
            this.saveToFileBtn.Name = "saveToFileBtn";
            this.saveToFileBtn.Size = new System.Drawing.Size(175, 23);
            this.saveToFileBtn.TabIndex = 2;
            this.saveToFileBtn.Text = "Сохранить в файл";
            this.saveToFileBtn.UseVisualStyleBackColor = true;
            this.saveToFileBtn.Click += new System.EventHandler(this.saveToFileBtn_Click);
            // 
            // trainBtn
            // 
            this.trainBtn.Location = new System.Drawing.Point(12, 24);
            this.trainBtn.Name = "trainBtn";
            this.trainBtn.Size = new System.Drawing.Size(175, 23);
            this.trainBtn.TabIndex = 0;
            this.trainBtn.Text = "Создать и обучить нейросеть";
            this.trainBtn.UseVisualStyleBackColor = true;
            this.trainBtn.Click += new System.EventHandler(this.trainBtn_Click);
            // 
            // neuralNetworkGB
            // 
            this.neuralNetworkGB.Controls.Add(this.neuronAmountPanel);
            this.neuralNetworkGB.Controls.Add(this.hidenLayersAmount);
            this.neuralNetworkGB.Controls.Add(this.label4);
            this.neuralNetworkGB.Controls.Add(this.inputsAmount);
            this.neuralNetworkGB.Controls.Add(this.label3);
            this.neuralNetworkGB.Controls.Add(this.outputsAmount);
            this.neuralNetworkGB.Controls.Add(this.label2);
            this.neuralNetworkGB.Controls.Add(this.label1);
            this.neuralNetworkGB.Controls.Add(this.activatorCB);
            this.neuralNetworkGB.Location = new System.Drawing.Point(3, 3);
            this.neuralNetworkGB.Name = "neuralNetworkGB";
            this.neuralNetworkGB.Size = new System.Drawing.Size(392, 388);
            this.neuralNetworkGB.TabIndex = 0;
            this.neuralNetworkGB.TabStop = false;
            this.neuralNetworkGB.Text = "Параметры нейросети";
            // 
            // neuronAmountPanel
            // 
            this.neuronAmountPanel.AutoScroll = true;
            this.neuronAmountPanel.Location = new System.Drawing.Point(12, 202);
            this.neuronAmountPanel.Name = "neuronAmountPanel";
            this.neuronAmountPanel.Size = new System.Drawing.Size(376, 183);
            this.neuronAmountPanel.TabIndex = 8;
            // 
            // hidenLayersAmount
            // 
            this.hidenLayersAmount.Location = new System.Drawing.Point(218, 152);
            this.hidenLayersAmount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.hidenLayersAmount.Name = "hidenLayersAmount";
            this.hidenLayersAmount.Size = new System.Drawing.Size(170, 20);
            this.hidenLayersAmount.TabIndex = 7;
            this.hidenLayersAmount.ValueChanged += new System.EventHandler(this.hidenLayersAmount_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Количество скрытых слоев";
            // 
            // inputsAmount
            // 
            this.inputsAmount.Location = new System.Drawing.Point(218, 65);
            this.inputsAmount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.inputsAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputsAmount.Name = "inputsAmount";
            this.inputsAmount.Size = new System.Drawing.Size(170, 20);
            this.inputsAmount.TabIndex = 5;
            this.inputsAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputsAmount.ValueChanged += new System.EventHandler(this.inputsAmount_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество нейронов выходного слоя";
            // 
            // outputsAmount
            // 
            this.outputsAmount.Location = new System.Drawing.Point(218, 110);
            this.outputsAmount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.outputsAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.outputsAmount.Name = "outputsAmount";
            this.outputsAmount.Size = new System.Drawing.Size(170, 20);
            this.outputsAmount.TabIndex = 3;
            this.outputsAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.outputsAmount.ValueChanged += new System.EventHandler(this.outputsAmount_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество нейронов входного слоя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Функкция активации";
            // 
            // activatorCB
            // 
            this.activatorCB.DataSource = this.activatorBindingSource;
            this.activatorCB.DisplayMember = "TitleFunc";
            this.activatorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activatorCB.Location = new System.Drawing.Point(218, 24);
            this.activatorCB.Name = "activatorCB";
            this.activatorCB.Size = new System.Drawing.Size(170, 21);
            this.activatorCB.TabIndex = 0;
            this.activatorCB.ValueMember = "ActivationFinc";
            // 
            // activatorBindingSource
            // 
            this.activatorBindingSource.DataSource = typeof(Manager.Activator);
            // 
            // loadFromfileBtn
            // 
            this.loadFromfileBtn.Location = new System.Drawing.Point(9, 7);
            this.loadFromfileBtn.Name = "loadFromfileBtn";
            this.loadFromfileBtn.Size = new System.Drawing.Size(175, 23);
            this.loadFromfileBtn.TabIndex = 1;
            this.loadFromfileBtn.Text = "Загрузить нейросеть из файла";
            this.loadFromfileBtn.UseVisualStyleBackColor = true;
            this.loadFromfileBtn.Click += new System.EventHandler(this.loadFromfileBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1087, 580);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1079, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Настройка нейронной сети и генетического алгоритма";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.resultTB);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.amountTasksNUD);
            this.tabPage2.Controls.Add(this.calculateSolutionBtn);
            this.tabPage2.Controls.Add(this.workDGW);
            this.tabPage2.Controls.Add(this.loadFromfileBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1079, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Работа с нейронной сетью";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // resultTB
            // 
            this.resultTB.Location = new System.Drawing.Point(811, 36);
            this.resultTB.Name = "resultTB";
            this.resultTB.Size = new System.Drawing.Size(262, 480);
            this.resultTB.TabIndex = 8;
            this.resultTB.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(808, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Результат:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(898, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(191, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Количество задач";
            // 
            // amountTasksNUD
            // 
            this.amountTasksNUD.Location = new System.Drawing.Point(295, 10);
            this.amountTasksNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountTasksNUD.Name = "amountTasksNUD";
            this.amountTasksNUD.Size = new System.Drawing.Size(120, 20);
            this.amountTasksNUD.TabIndex = 4;
            this.amountTasksNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountTasksNUD.ValueChanged += new System.EventHandler(this.amountTasksNUD_ValueChanged);
            // 
            // calculateSolutionBtn
            // 
            this.calculateSolutionBtn.Location = new System.Drawing.Point(9, 522);
            this.calculateSolutionBtn.Name = "calculateSolutionBtn";
            this.calculateSolutionBtn.Size = new System.Drawing.Size(175, 23);
            this.calculateSolutionBtn.TabIndex = 3;
            this.calculateSolutionBtn.Text = "Вычислить";
            this.calculateSolutionBtn.UseVisualStyleBackColor = true;
            this.calculateSolutionBtn.Click += new System.EventHandler(this.calculateSolutionBtn_Click);
            // 
            // workDGW
            // 
            this.workDGW.AllowUserToAddRows = false;
            this.workDGW.AllowUserToDeleteRows = false;
            this.workDGW.AllowUserToResizeColumns = false;
            this.workDGW.AllowUserToResizeRows = false;
            this.workDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.workDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workDGW.Location = new System.Drawing.Point(9, 36);
            this.workDGW.Name = "workDGW";
            this.workDGW.Size = new System.Drawing.Size(794, 480);
            this.workDGW.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AcceptButton = this.trainBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(1090, 607);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Обнаруженние проблем в хранении данных";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.trainingData.ResumeLayout(false);
            this.trainingData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDataDGW)).EndInit();
            this.geneticGB.ResumeLayout(false);
            this.geneticGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsAmountNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationSizeNUD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.neuralNetworkGB.ResumeLayout(false);
            this.neuralNetworkGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidenLayersAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputsAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputsAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activatorBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountTasksNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workDGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox neuralNetworkGB;
        private System.Windows.Forms.GroupBox geneticGB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown hidenLayersAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown inputsAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown outputsAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox activatorCB;
        private System.Windows.Forms.Panel neuronAmountPanel;
        private System.Windows.Forms.BindingSource activatorBindingSource;
        private System.Windows.Forms.NumericUpDown iterationsAmountNUD;
        private System.Windows.Forms.NumericUpDown populationSizeNUD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox trainingData;
        private System.Windows.Forms.DataGridView trainingDataDGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn inp1;
        private System.Windows.Forms.DataGridViewTextBoxColumn out1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown trainingsAmount;
        private System.Windows.Forms.TextBox epsTB;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button saveToFileBtn;
        private System.Windows.Forms.Button loadFromfileBtn;
        private System.Windows.Forms.Button trainBtn;
        private System.Windows.Forms.TextBox mutationTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button showStatBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button saveTrainingData;
        private System.Windows.Forms.Button calculateSolutionBtn;
        private System.Windows.Forms.DataGridView workDGW;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown amountTasksNUD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox resultTB;
        private System.Windows.Forms.Label label11;
    }
}

