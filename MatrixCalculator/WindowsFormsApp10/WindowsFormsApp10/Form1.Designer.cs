namespace WindowsFormsApp10
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MultipliNumber = new System.Windows.Forms.NumericUpDown();
            this.panelA = new System.Windows.Forms.Panel();
            this.dataGridViewA = new System.Windows.Forms.DataGridView();
            this.StringA = new System.Windows.Forms.Label();
            this.numeriсStringA = new System.Windows.Forms.NumericUpDown();
            this.ColumnA = new System.Windows.Forms.Label();
            this.numericColumnA = new System.Windows.Forms.NumericUpDown();
            this.RandomA = new System.Windows.Forms.Button();
            this.panelB = new System.Windows.Forms.Panel();
            this.dataGridViewB = new System.Windows.Forms.DataGridView();
            this.numericColumnB = new System.Windows.Forms.NumericUpDown();
            this.numericStringB = new System.Windows.Forms.NumericUpDown();
            this.RandomB = new System.Windows.Forms.Button();
            this.ColumnB = new System.Windows.Forms.Label();
            this.StringB = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.OperA = new System.Windows.Forms.Label();
            this.OperAB = new System.Windows.Forms.Label();
            this.MatrixB = new System.Windows.Forms.Label();
            this.MatrixA = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Inverse = new System.Windows.Forms.Button();
            this.Determinant = new System.Windows.Forms.Button();
            this.Minor = new System.Windows.Forms.Button();
            this.MultiplyByNumber = new System.Windows.Forms.Button();
            this.Rank = new System.Windows.Forms.Button();
            this.Transposition = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Multyplication = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.panelRes = new System.Windows.Forms.Panel();
            this.dataGridViewRes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MultipliNumber)).BeginInit();
            this.panelA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeriсStringA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColumnA)).BeginInit();
            this.panelB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColumnB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStringB)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.MultipliNumber);
            this.panel1.Controls.Add(this.panelA);
            this.panel1.Controls.Add(this.StringA);
            this.panel1.Controls.Add(this.numeriсStringA);
            this.panel1.Controls.Add(this.ColumnA);
            this.panel1.Controls.Add(this.numericColumnA);
            this.panel1.Controls.Add(this.RandomA);
            this.panel1.Controls.Add(this.panelB);
            this.panel1.Controls.Add(this.numericColumnB);
            this.panel1.Controls.Add(this.numericStringB);
            this.panel1.Controls.Add(this.RandomB);
            this.panel1.Controls.Add(this.ColumnB);
            this.panel1.Controls.Add(this.StringB);
            this.panel1.Controls.Add(this.Result);
            this.panel1.Controls.Add(this.OperA);
            this.panel1.Controls.Add(this.OperAB);
            this.panel1.Controls.Add(this.MatrixB);
            this.panel1.Controls.Add(this.MatrixA);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panelRes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 621);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MultipliNumber
            // 
            this.MultipliNumber.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.MultipliNumber.Location = new System.Drawing.Point(942, 267);
            this.MultipliNumber.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.MultipliNumber.Name = "MultipliNumber";
            this.MultipliNumber.Size = new System.Drawing.Size(57, 25);
            this.MultipliNumber.TabIndex = 29;
            this.MultipliNumber.ValueChanged += new System.EventHandler(this.MultiplicatorNumeric_ValueChanged);
            // 
            // panelA
            // 
            this.panelA.Controls.Add(this.dataGridViewA);
            this.panelA.Location = new System.Drawing.Point(27, 49);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(375, 214);
            this.panelA.TabIndex = 1;
            // 
            // dataGridViewA
            // 
            this.dataGridViewA.AllowUserToAddRows = false;
            this.dataGridViewA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewA.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewA.ColumnHeadersVisible = false;
            this.dataGridViewA.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewA.Name = "dataGridViewA";
            this.dataGridViewA.RowHeadersVisible = false;
            this.dataGridViewA.Size = new System.Drawing.Size(369, 208);
            this.dataGridViewA.TabIndex = 0;
            this.dataGridViewA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StringA
            // 
            this.StringA.AutoSize = true;
            this.StringA.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.StringA.ForeColor = System.Drawing.Color.White;
            this.StringA.Location = new System.Drawing.Point(27, 15);
            this.StringA.Name = "StringA";
            this.StringA.Size = new System.Drawing.Size(45, 18);
            this.StringA.TabIndex = 27;
            this.StringA.Text = "Строк";
            this.StringA.Click += new System.EventHandler(this.label7_Click);
            // 
            // numeriсStringA
            // 
            this.numeriсStringA.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.numeriсStringA.Location = new System.Drawing.Point(80, 9);
            this.numeriсStringA.Name = "numeriсStringA";
            this.numeriсStringA.Size = new System.Drawing.Size(42, 25);
            this.numeriсStringA.TabIndex = 26;
            this.numeriсStringA.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // ColumnA
            // 
            this.ColumnA.AutoSize = true;
            this.ColumnA.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.ColumnA.ForeColor = System.Drawing.Color.White;
            this.ColumnA.Location = new System.Drawing.Point(141, 14);
            this.ColumnA.Name = "ColumnA";
            this.ColumnA.Size = new System.Drawing.Size(66, 18);
            this.ColumnA.TabIndex = 25;
            this.ColumnA.Text = "Столбцов";
            this.ColumnA.Click += new System.EventHandler(this.label6_Click);
            // 
            // numericColumnA
            // 
            this.numericColumnA.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.numericColumnA.Location = new System.Drawing.Point(219, 9);
            this.numericColumnA.Name = "numericColumnA";
            this.numericColumnA.Size = new System.Drawing.Size(42, 25);
            this.numericColumnA.TabIndex = 24;
            this.numericColumnA.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // RandomA
            // 
            this.RandomA.AutoSize = true;
            this.RandomA.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RandomA.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.RandomA.ForeColor = System.Drawing.Color.White;
            this.RandomA.Location = new System.Drawing.Point(289, 6);
            this.RandomA.Name = "RandomA";
            this.RandomA.Size = new System.Drawing.Size(113, 32);
            this.RandomA.TabIndex = 23;
            this.RandomA.Text = "Заполнить";
            this.RandomA.UseVisualStyleBackColor = false;
            this.RandomA.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelB
            // 
            this.panelB.Controls.Add(this.dataGridViewB);
            this.panelB.Location = new System.Drawing.Point(27, 351);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(375, 214);
            this.panelB.TabIndex = 0;
            // 
            // dataGridViewB
            // 
            this.dataGridViewB.AllowUserToAddRows = false;
            this.dataGridViewB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewB.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewB.ColumnHeadersVisible = false;
            this.dataGridViewB.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewB.Name = "dataGridViewB";
            this.dataGridViewB.RowHeadersVisible = false;
            this.dataGridViewB.Size = new System.Drawing.Size(372, 214);
            this.dataGridViewB.TabIndex = 0;
            this.dataGridViewB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // numericColumnB
            // 
            this.numericColumnB.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.numericColumnB.Location = new System.Drawing.Point(219, 309);
            this.numericColumnB.Name = "numericColumnB";
            this.numericColumnB.Size = new System.Drawing.Size(42, 25);
            this.numericColumnB.TabIndex = 17;
            this.numericColumnB.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // numericStringB
            // 
            this.numericStringB.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.numericStringB.Location = new System.Drawing.Point(80, 309);
            this.numericStringB.Name = "numericStringB";
            this.numericStringB.Size = new System.Drawing.Size(42, 25);
            this.numericStringB.TabIndex = 16;
            this.numericStringB.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // RandomB
            // 
            this.RandomB.AutoSize = true;
            this.RandomB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RandomB.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomB.ForeColor = System.Drawing.Color.White;
            this.RandomB.Location = new System.Drawing.Point(286, 309);
            this.RandomB.Name = "RandomB";
            this.RandomB.Size = new System.Drawing.Size(113, 32);
            this.RandomB.TabIndex = 13;
            this.RandomB.Text = "Заполнить";
            this.RandomB.UseVisualStyleBackColor = false;
            this.RandomB.Click += new System.EventHandler(this.button2_Click);
            // 
            // ColumnB
            // 
            this.ColumnB.AutoSize = true;
            this.ColumnB.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.ColumnB.ForeColor = System.Drawing.Color.White;
            this.ColumnB.Location = new System.Drawing.Point(141, 316);
            this.ColumnB.Name = "ColumnB";
            this.ColumnB.Size = new System.Drawing.Size(66, 18);
            this.ColumnB.TabIndex = 12;
            this.ColumnB.Text = "Столбцов";
            this.ColumnB.Click += new System.EventHandler(this.label9_Click);
            // 
            // StringB
            // 
            this.StringB.AutoSize = true;
            this.StringB.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.StringB.ForeColor = System.Drawing.Color.White;
            this.StringB.Location = new System.Drawing.Point(27, 316);
            this.StringB.Name = "StringB";
            this.StringB.Size = new System.Drawing.Size(45, 18);
            this.StringB.TabIndex = 11;
            this.StringB.Text = "Строк";
            this.StringB.Click += new System.EventHandler(this.label8_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.BackColor = System.Drawing.Color.MidnightBlue;
            this.Result.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.White;
            this.Result.Location = new System.Drawing.Point(681, 571);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(226, 26);
            this.Result.TabIndex = 7;
            this.Result.Text = "Результат вычисления";
            this.Result.Click += new System.EventHandler(this.label5_Click);
            // 
            // OperA
            // 
            this.OperA.AutoSize = true;
            this.OperA.BackColor = System.Drawing.Color.MidnightBlue;
            this.OperA.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.OperA.ForeColor = System.Drawing.Color.White;
            this.OperA.Location = new System.Drawing.Point(635, 129);
            this.OperA.Name = "OperA";
            this.OperA.Size = new System.Drawing.Size(271, 26);
            this.OperA.TabIndex = 6;
            this.OperA.Text = "Операции над матрицей А";
            this.OperA.Click += new System.EventHandler(this.label4_Click);
            // 
            // OperAB
            // 
            this.OperAB.AutoSize = true;
            this.OperAB.BackColor = System.Drawing.Color.MidnightBlue;
            this.OperAB.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.OperAB.ForeColor = System.Drawing.Color.White;
            this.OperAB.Location = new System.Drawing.Point(614, 31);
            this.OperAB.Name = "OperAB";
            this.OperAB.Size = new System.Drawing.Size(321, 26);
            this.OperAB.TabIndex = 5;
            this.OperAB.Text = "Операции над матрицами А и В";
            this.OperAB.Click += new System.EventHandler(this.label3_Click);
            // 
            // MatrixB
            // 
            this.MatrixB.AutoSize = true;
            this.MatrixB.BackColor = System.Drawing.Color.MidnightBlue;
            this.MatrixB.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.MatrixB.ForeColor = System.Drawing.Color.White;
            this.MatrixB.Location = new System.Drawing.Point(145, 571);
            this.MatrixB.Name = "MatrixB";
            this.MatrixB.Size = new System.Drawing.Size(117, 26);
            this.MatrixB.TabIndex = 4;
            this.MatrixB.Text = "Матрица В";
            this.MatrixB.Click += new System.EventHandler(this.label2_Click);
            // 
            // MatrixA
            // 
            this.MatrixA.AutoSize = true;
            this.MatrixA.BackColor = System.Drawing.Color.MidnightBlue;
            this.MatrixA.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.MatrixA.ForeColor = System.Drawing.Color.White;
            this.MatrixA.Location = new System.Drawing.Point(145, 266);
            this.MatrixA.Name = "MatrixA";
            this.MatrixA.Size = new System.Drawing.Size(119, 26);
            this.MatrixA.TabIndex = 3;
            this.MatrixA.Text = "Матрица А";
            this.MatrixA.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Inverse);
            this.panel6.Controls.Add(this.Determinant);
            this.panel6.Controls.Add(this.Minor);
            this.panel6.Controls.Add(this.MultiplyByNumber);
            this.panel6.Controls.Add(this.Rank);
            this.panel6.Controls.Add(this.Transposition);
            this.panel6.Location = new System.Drawing.Point(491, 169);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(552, 94);
            this.panel6.TabIndex = 2;
            // 
            // Inverse
            // 
            this.Inverse.AutoSize = true;
            this.Inverse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Inverse.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.Inverse.ForeColor = System.Drawing.Color.White;
            this.Inverse.Location = new System.Drawing.Point(3, 5);
            this.Inverse.Name = "Inverse";
            this.Inverse.Size = new System.Drawing.Size(164, 31);
            this.Inverse.TabIndex = 17;
            this.Inverse.Text = "Обратная матрица";
            this.Inverse.UseVisualStyleBackColor = false;
            this.Inverse.Click += new System.EventHandler(this.button6_Click);
            // 
            // Determinant
            // 
            this.Determinant.AutoSize = true;
            this.Determinant.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Determinant.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.Determinant.ForeColor = System.Drawing.Color.White;
            this.Determinant.Location = new System.Drawing.Point(3, 58);
            this.Determinant.Name = "Determinant";
            this.Determinant.Size = new System.Drawing.Size(164, 31);
            this.Determinant.TabIndex = 18;
            this.Determinant.Text = "Определитель";
            this.Determinant.UseVisualStyleBackColor = false;
            this.Determinant.Click += new System.EventHandler(this.button7_Click);
            // 
            // Minor
            // 
            this.Minor.AutoSize = true;
            this.Minor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Minor.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.Minor.ForeColor = System.Drawing.Color.White;
            this.Minor.Location = new System.Drawing.Point(380, 5);
            this.Minor.Name = "Minor";
            this.Minor.Size = new System.Drawing.Size(166, 32);
            this.Minor.TabIndex = 20;
            this.Minor.Text = "Минор элемента";
            this.Minor.UseVisualStyleBackColor = false;
            this.Minor.Click += new System.EventHandler(this.button9_Click);
            // 
            // MultiplyByNumber
            // 
            this.MultiplyByNumber.AutoSize = true;
            this.MultiplyByNumber.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MultiplyByNumber.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyByNumber.ForeColor = System.Drawing.Color.White;
            this.MultiplyByNumber.Location = new System.Drawing.Point(383, 57);
            this.MultiplyByNumber.Name = "MultiplyByNumber";
            this.MultiplyByNumber.Size = new System.Drawing.Size(166, 32);
            this.MultiplyByNumber.TabIndex = 22;
            this.MultiplyByNumber.Text = "Умножить на число";
            this.MultiplyByNumber.UseVisualStyleBackColor = false;
            this.MultiplyByNumber.Click += new System.EventHandler(this.button11_Click);
            // 
            // Rank
            // 
            this.Rank.AutoSize = true;
            this.Rank.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Rank.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.Rank.ForeColor = System.Drawing.Color.White;
            this.Rank.Location = new System.Drawing.Point(195, 5);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(166, 31);
            this.Rank.TabIndex = 21;
            this.Rank.Text = "Ранг матрицы";
            this.Rank.UseVisualStyleBackColor = false;
            this.Rank.Click += new System.EventHandler(this.button10_Click);
            // 
            // Transposition
            // 
            this.Transposition.AutoSize = true;
            this.Transposition.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Transposition.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.Transposition.ForeColor = System.Drawing.Color.White;
            this.Transposition.Location = new System.Drawing.Point(195, 57);
            this.Transposition.Name = "Transposition";
            this.Transposition.Size = new System.Drawing.Size(166, 31);
            this.Transposition.TabIndex = 19;
            this.Transposition.Text = "Транспонирование";
            this.Transposition.UseVisualStyleBackColor = false;
            this.Transposition.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Multyplication);
            this.panel5.Controls.Add(this.Subtraction);
            this.panel5.Controls.Add(this.Addition);
            this.panel5.Location = new System.Drawing.Point(494, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(549, 42);
            this.panel5.TabIndex = 1;
            // 
            // Multyplication
            // 
            this.Multyplication.AutoSize = true;
            this.Multyplication.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Multyplication.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.Multyplication.ForeColor = System.Drawing.Color.White;
            this.Multyplication.Location = new System.Drawing.Point(380, 0);
            this.Multyplication.Name = "Multyplication";
            this.Multyplication.Size = new System.Drawing.Size(166, 30);
            this.Multyplication.TabIndex = 16;
            this.Multyplication.Text = "Умножение матриц";
            this.Multyplication.UseVisualStyleBackColor = false;
            this.Multyplication.Click += new System.EventHandler(this.button5_Click);
            // 
            // Subtraction
            // 
            this.Subtraction.AutoSize = true;
            this.Subtraction.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Subtraction.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.Subtraction.ForeColor = System.Drawing.Color.White;
            this.Subtraction.Location = new System.Drawing.Point(192, 0);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(166, 30);
            this.Subtraction.TabIndex = 15;
            this.Subtraction.Text = "Вычитание матриц";
            this.Subtraction.UseVisualStyleBackColor = false;
            this.Subtraction.Click += new System.EventHandler(this.button4_Click);
            // 
            // Addition
            // 
            this.Addition.AutoSize = true;
            this.Addition.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Addition.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.Addition.ForeColor = System.Drawing.Color.White;
            this.Addition.Location = new System.Drawing.Point(3, -1);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(161, 31);
            this.Addition.TabIndex = 14;
            this.Addition.Text = "Сложение матриц";
            this.Addition.UseVisualStyleBackColor = false;
            this.Addition.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelRes
            // 
            this.panelRes.Controls.Add(this.dataGridViewRes);
            this.panelRes.Location = new System.Drawing.Point(491, 309);
            this.panelRes.Name = "panelRes";
            this.panelRes.Size = new System.Drawing.Size(549, 259);
            this.panelRes.TabIndex = 1;
            // 
            // dataGridViewRes
            // 
            this.dataGridViewRes.AllowUserToAddRows = false;
            this.dataGridViewRes.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes.ColumnHeadersVisible = false;
            this.dataGridViewRes.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewRes.Name = "dataGridViewRes";
            this.dataGridViewRes.RowHeadersVisible = false;
            this.dataGridViewRes.Size = new System.Drawing.Size(543, 253);
            this.dataGridViewRes.TabIndex = 0;
            this.dataGridViewRes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1061, 621);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Матричный калькулятор";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MultipliNumber)).EndInit();
            this.panelA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeriсStringA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColumnA)).EndInit();
            this.panelB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColumnB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStringB)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelRes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericColumnB;
        private System.Windows.Forms.NumericUpDown numericStringB;
        private System.Windows.Forms.Button RandomB;
        private System.Windows.Forms.Label ColumnB;
        private System.Windows.Forms.Label StringB;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label OperA;
        private System.Windows.Forms.Label OperAB;
        private System.Windows.Forms.Label MatrixB;
        private System.Windows.Forms.Label MatrixA;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button MultiplyByNumber;
        private System.Windows.Forms.Button Rank;
        private System.Windows.Forms.Button Minor;
        private System.Windows.Forms.Button Transposition;
        private System.Windows.Forms.Button Determinant;
        private System.Windows.Forms.Button Inverse;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Multyplication;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Panel panelRes;
        private System.Windows.Forms.DataGridView dataGridViewRes;
        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.DataGridView dataGridViewB;
        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.DataGridView dataGridViewA;
        private System.Windows.Forms.Label StringA;
        private System.Windows.Forms.NumericUpDown numeriсStringA;
        private System.Windows.Forms.Label ColumnA;
        private System.Windows.Forms.NumericUpDown numericColumnA;
        private System.Windows.Forms.Button RandomA;
        private System.Windows.Forms.NumericUpDown MultipliNumber;
    }
}

