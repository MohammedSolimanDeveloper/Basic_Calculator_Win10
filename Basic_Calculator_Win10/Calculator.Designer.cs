namespace Basic_Calculator_Win10
{
    partial class Calculator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.imageListCal = new System.Windows.Forms.ImageList(this.components);
            this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.lblHistory = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSeparator = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.btnListCal = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.lblCalculator = new System.Windows.Forms.Label();
            this.tlpBottom = new System.Windows.Forms.TableLayoutPanel();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDeciemal = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.txtCal = new System.Windows.Forms.TextBox();
            this.tlpRight.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tlpTop.SuspendLayout();
            this.tlpBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListCal
            // 
            this.imageListCal.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCal.ImageStream")));
            this.imageListCal.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCal.Images.SetKeyName(0, "iconfinder_backspace_83227.png");
            this.imageListCal.Images.SetKeyName(1, "iconfinder_circle-backup-time-history-recent-time-machine-outline-stroke_763474.p" +
        "ng");
            this.imageListCal.Images.SetKeyName(2, "iconfinder_menu-lines-list_2931181 (1).png");
            this.imageListCal.Images.SetKeyName(3, "iconfinder_Trash_4472999.png");
            // 
            // tlpRight
            // 
            this.tlpRight.ColumnCount = 1;
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.Controls.Add(this.lbHistory, 0, 2);
            this.tlpRight.Controls.Add(this.lblHistory, 0, 0);
            this.tlpRight.Controls.Add(this.btnDelete, 0, 3);
            this.tlpRight.Controls.Add(this.btnSeparator, 0, 1);
            this.tlpRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.tlpRight.Location = new System.Drawing.Point(298, 0);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.RowCount = 4;
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.753621F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.263375F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.77366F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.085801F));
            this.tlpRight.Size = new System.Drawing.Size(254, 486);
            this.tlpRight.TabIndex = 0;
            // 
            // lbHistory
            // 
            this.lbHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lbHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHistory.Font = new System.Drawing.Font("LBC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.HorizontalScrollbar = true;
            this.lbHistory.ItemHeight = 26;
            this.lbHistory.Items.AddRange(new object[] {
            "There’s no history yet"});
            this.lbHistory.Location = new System.Drawing.Point(3, 41);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbHistory.Size = new System.Drawing.Size(248, 406);
            this.lbHistory.TabIndex = 8;
            this.lbHistory.SelectedIndexChanged += new System.EventHandler(this.lbHistory_SelectedIndexChanged);
            this.lbHistory.DoubleClick += new System.EventHandler(this.lbHistory_DoubleClick);
            // 
            // lblHistory
            // 
            this.lblHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("LBC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.Location = new System.Drawing.Point(3, 1);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(78, 26);
            this.lblHistory.TabIndex = 4;
            this.lblHistory.Text = "History";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageIndex = 3;
            this.btnDelete.ImageList = this.imageListCal;
            this.btnDelete.Location = new System.Drawing.Point(209, 453);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(42, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.TabStop = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSeparator
            // 
            this.btnSeparator.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSeparator.Enabled = false;
            this.btnSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeparator.Location = new System.Drawing.Point(3, 30);
            this.btnSeparator.Name = "btnSeparator";
            this.btnSeparator.Size = new System.Drawing.Size(75, 5);
            this.btnSeparator.TabIndex = 7;
            this.btnSeparator.UseVisualStyleBackColor = false;
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDisplay.Enabled = false;
            this.txtDisplay.Font = new System.Drawing.Font("LBC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(3, 51);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(292, 45);
            this.txtDisplay.TabIndex = 3;
            this.txtDisplay.TabStop = false;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpTop, 0, 0);
            this.tlpMain.Controls.Add(this.tlpBottom, 0, 3);
            this.tlpMain.Controls.Add(this.txtDisplay, 0, 1);
            this.tlpMain.Controls.Add(this.txtCal, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.994489F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.99394F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.99118F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.0204F));
            this.tlpMain.Size = new System.Drawing.Size(298, 486);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpTop
            // 
            this.tlpTop.ColumnCount = 3;
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.053942F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.94606F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpTop.Controls.Add(this.btnListCal, 0, 0);
            this.tlpTop.Controls.Add(this.btnHistory, 2, 0);
            this.tlpTop.Controls.Add(this.lblCalculator, 1, 0);
            this.tlpTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTop.Location = new System.Drawing.Point(3, 3);
            this.tlpTop.Name = "tlpTop";
            this.tlpTop.RowCount = 1;
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTop.Size = new System.Drawing.Size(292, 42);
            this.tlpTop.TabIndex = 0;
            // 
            // btnListCal
            // 
            this.btnListCal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnListCal.FlatAppearance.BorderSize = 0;
            this.btnListCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListCal.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListCal.ImageIndex = 2;
            this.btnListCal.ImageList = this.imageListCal;
            this.btnListCal.Location = new System.Drawing.Point(3, 3);
            this.btnListCal.Name = "btnListCal";
            this.btnListCal.Size = new System.Drawing.Size(11, 36);
            this.btnListCal.TabIndex = 3;
            this.btnListCal.TabStop = false;
            this.btnListCal.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            this.btnHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ImageIndex = 1;
            this.btnHistory.ImageList = this.imageListCal;
            this.btnHistory.Location = new System.Drawing.Point(253, 3);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(36, 36);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.TabStop = false;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // lblCalculator
            // 
            this.lblCalculator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCalculator.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculator.Location = new System.Drawing.Point(20, 3);
            this.lblCalculator.Name = "lblCalculator";
            this.lblCalculator.Size = new System.Drawing.Size(157, 35);
            this.lblCalculator.TabIndex = 0;
            this.lblCalculator.Text = "Standard";
            // 
            // tlpBottom
            // 
            this.tlpBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBottom.ColumnCount = 4;
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBottom.Controls.Add(this.btnEqual, 3, 4);
            this.tlpBottom.Controls.Add(this.btnDeciemal, 2, 4);
            this.tlpBottom.Controls.Add(this.btnZero, 1, 4);
            this.tlpBottom.Controls.Add(this.btnPlus, 3, 3);
            this.tlpBottom.Controls.Add(this.btnThree, 2, 3);
            this.tlpBottom.Controls.Add(this.btnTwo, 1, 3);
            this.tlpBottom.Controls.Add(this.btnOne, 0, 3);
            this.tlpBottom.Controls.Add(this.btnMinus, 3, 2);
            this.tlpBottom.Controls.Add(this.btnSix, 2, 2);
            this.tlpBottom.Controls.Add(this.btnFive, 1, 2);
            this.tlpBottom.Controls.Add(this.btnFour, 0, 2);
            this.tlpBottom.Controls.Add(this.btnMultiply, 3, 1);
            this.tlpBottom.Controls.Add(this.btnNine, 2, 1);
            this.tlpBottom.Controls.Add(this.btnEight, 1, 1);
            this.tlpBottom.Controls.Add(this.btnSeven, 0, 1);
            this.tlpBottom.Controls.Add(this.btnDivide, 3, 0);
            this.tlpBottom.Controls.Add(this.btnBackspace, 2, 0);
            this.tlpBottom.Controls.Add(this.btnCancel, 1, 0);
            this.tlpBottom.Controls.Add(this.btnClear, 0, 0);
            this.tlpBottom.Controls.Add(this.btnNegative, 0, 4);
            this.tlpBottom.Location = new System.Drawing.Point(3, 181);
            this.tlpBottom.Name = "tlpBottom";
            this.tlpBottom.RowCount = 5;
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBottom.Size = new System.Drawing.Size(292, 302);
            this.tlpBottom.TabIndex = 0;
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(186)))), ((int)(((byte)(224)))));
            this.btnEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(222, 243);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(67, 56);
            this.btnEqual.TabIndex = 0;
            this.btnEqual.TabStop = false;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnDeciemal
            // 
            this.btnDeciemal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnDeciemal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeciemal.FlatAppearance.BorderSize = 0;
            this.btnDeciemal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeciemal.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeciemal.Location = new System.Drawing.Point(149, 243);
            this.btnDeciemal.Name = "btnDeciemal";
            this.btnDeciemal.Size = new System.Drawing.Size(67, 56);
            this.btnDeciemal.TabIndex = 19;
            this.btnDeciemal.TabStop = false;
            this.btnDeciemal.Text = ".";
            this.btnDeciemal.UseVisualStyleBackColor = false;
            this.btnDeciemal.Click += new System.EventHandler(this.AddNumbersClick);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(76, 243);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(67, 56);
            this.btnZero.TabIndex = 18;
            this.btnZero.TabStop = false;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.AddNumbersClick);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(222, 183);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(67, 54);
            this.btnPlus.TabIndex = 16;
            this.btnPlus.TabStop = false;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.AddOperatorsClick);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThree.FlatAppearance.BorderSize = 0;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(149, 183);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(67, 54);
            this.btnThree.TabIndex = 15;
            this.btnThree.TabStop = false;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.AddNumbersClick);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTwo.FlatAppearance.BorderSize = 0;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(76, 183);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(67, 54);
            this.btnTwo.TabIndex = 14;
            this.btnTwo.TabStop = false;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.AddNumbersClick);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOne.FlatAppearance.BorderSize = 0;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(3, 183);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(67, 54);
            this.btnOne.TabIndex = 13;
            this.btnOne.TabStop = false;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.AddNumbersClick);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(222, 123);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(67, 54);
            this.btnMinus.TabIndex = 12;
            this.btnMinus.TabStop = false;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.AddOperatorsClick);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnSix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSix.FlatAppearance.BorderSize = 0;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(149, 123);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(67, 54);
            this.btnSix.TabIndex = 11;
            this.btnSix.TabStop = false;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.AddNumbersClick);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnFive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFive.FlatAppearance.BorderSize = 0;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(76, 123);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(67, 54);
            this.btnFive.TabIndex = 10;
            this.btnFive.TabStop = false;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.AddNumbersClick);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFour.FlatAppearance.BorderSize = 0;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(3, 123);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(67, 54);
            this.btnFour.TabIndex = 9;
            this.btnFour.TabStop = false;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.AddNumbersClick);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultiply.FlatAppearance.BorderSize = 0;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(222, 63);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(67, 54);
            this.btnMultiply.TabIndex = 8;
            this.btnMultiply.TabStop = false;
            this.btnMultiply.Text = "X";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.AddOperatorsClick);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNine.FlatAppearance.BorderSize = 0;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(149, 63);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(67, 54);
            this.btnNine.TabIndex = 7;
            this.btnNine.TabStop = false;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.AddNumbersClick);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnEight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEight.FlatAppearance.BorderSize = 0;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(76, 63);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(67, 54);
            this.btnEight.TabIndex = 6;
            this.btnEight.TabStop = false;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.AddNumbersClick);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnSeven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeven.FlatAppearance.BorderSize = 0;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(3, 63);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(67, 54);
            this.btnSeven.TabIndex = 5;
            this.btnSeven.TabStop = false;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.AddNumbersClick);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(222, 3);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(67, 54);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.TabStop = false;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.AddOperatorsClick);
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnBackspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackspace.FlatAppearance.BorderSize = 0;
            this.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackspace.ImageIndex = 0;
            this.btnBackspace.ImageList = this.imageListCal;
            this.btnBackspace.Location = new System.Drawing.Point(149, 3);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(67, 54);
            this.btnBackspace.TabIndex = 3;
            this.btnBackspace.TabStop = false;
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(76, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 54);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "C";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(3, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 54);
            this.btnClear.TabIndex = 1;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "CE";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNegative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNegative.FlatAppearance.BorderSize = 0;
            this.btnNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNegative.Font = new System.Drawing.Font("LBC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegative.Location = new System.Drawing.Point(3, 243);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(67, 56);
            this.btnNegative.TabIndex = 17;
            this.btnNegative.TabStop = false;
            this.btnNegative.Text = "±";
            this.btnNegative.UseVisualStyleBackColor = false;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // txtCal
            // 
            this.txtCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCal.Font = new System.Drawing.Font("LBC", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCal.Location = new System.Drawing.Point(3, 104);
            this.txtCal.Name = "txtCal";
            this.txtCal.ReadOnly = true;
            this.txtCal.Size = new System.Drawing.Size(292, 72);
            this.txtCal.TabIndex = 1;
            this.txtCal.TabStop = false;
            this.txtCal.Text = "0";
            this.txtCal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCal.TextChanged += new System.EventHandler(this.txtCal_TextChanged);
            // 
            // Calculator
            // 
            this.AcceptButton = this.btnEqual;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(552, 486);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.tlpRight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(380, 500);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Calculator_ClientSizeChanged);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.tlpRight.ResumeLayout(false);
            this.tlpRight.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpTop.ResumeLayout(false);
            this.tlpBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageListCal;
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private System.Windows.Forms.Button btnListCal;
        private System.Windows.Forms.Label lblCalculator;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.TableLayoutPanel tlpBottom;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDeciemal;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.TextBox txtCal;
        private System.Windows.Forms.Button btnSeparator;
        private System.Windows.Forms.ListBox lbHistory;
    }
}

