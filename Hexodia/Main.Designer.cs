namespace Hexodia
{
    partial class Hexodia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hexodia));
            minimizeBtn = new Button();
            exitBtn = new Button();
            customTabControl = new Forms.customTabControl();
            tabPage5 = new TabPage();
            runLabel = new Label();
            runToggleButton = new MagicUI.MagicControl.MagicToggleButton();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            littleEndianRadioButton = new MagicUI.MagicControl.MagicRadioButton();
            bigEndianRadioButton = new MagicUI.MagicControl.MagicRadioButton();
            label3 = new Label();
            copyOutputBtn = new FontAwesome.Sharp.IconButton();
            outputLabel = new Label();
            outputTextBox = new TextBox();
            inputValueLabel = new Label();
            inputValueTextBox = new TextBox();
            doubleRadioButton = new MagicUI.MagicControl.MagicRadioButton();
            floatRadioButton = new MagicUI.MagicControl.MagicRadioButton();
            intRadioButton = new MagicUI.MagicControl.MagicRadioButton();
            label2 = new Label();
            stringRadioButton = new MagicUI.MagicControl.MagicRadioButton();
            tabPage4 = new TabPage();
            inputLabel = new Label();
            inputTextBox = new TextBox();
            doubleLabel = new Label();
            doubleTextBox = new TextBox();
            copyDoubleBtn = new FontAwesome.Sharp.IconButton();
            floatLabel = new Label();
            floatTextBox = new TextBox();
            copyFloatBtn = new FontAwesome.Sharp.IconButton();
            intLabel = new Label();
            intTextBox = new TextBox();
            copyIntBtn = new FontAwesome.Sharp.IconButton();
            stringLabel = new Label();
            stringTextBox = new TextBox();
            copyStringBtn = new FontAwesome.Sharp.IconButton();
            logoPictureBox = new PictureBox();
            customTabControl.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // minimizeBtn
            // 
            minimizeBtn.Cursor = Cursors.Hand;
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            minimizeBtn.ForeColor = Color.White;
            minimizeBtn.Location = new Point(1152, 12);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(57, 33);
            minimizeBtn.TabIndex = 2;
            minimizeBtn.Text = "-";
            minimizeBtn.UseVisualStyleBackColor = true;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatAppearance.MouseOverBackColor = Color.Red;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            exitBtn.ForeColor = Color.White;
            exitBtn.Location = new Point(1215, 12);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(57, 33);
            exitBtn.TabIndex = 0;
            exitBtn.Text = "X";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // customTabControl
            // 
            customTabControl.Controls.Add(tabPage1);
            customTabControl.Controls.Add(tabPage4);
            customTabControl.Controls.Add(tabPage5);
            customTabControl.Cursor = Cursors.Hand;
            customTabControl.ImeMode = ImeMode.NoControl;
            customTabControl.Location = new Point(12, 174);
            customTabControl.Name = "customTabControl";
            customTabControl.Padding = new Point(6, 8);
            customTabControl.SelectedIndex = 0;
            customTabControl.Size = new Size(1260, 436);
            customTabControl.TabIndex = 4;
            customTabControl.SelectedIndexChanged += customTabControl_SelectedIndexChanged;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = SystemColors.WindowFrame;
            tabPage5.Controls.Add(runLabel);
            tabPage5.Controls.Add(runToggleButton);
            tabPage5.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage5.Location = new Point(4, 35);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1252, 397);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "Settings";
            tabPage5.Click += tabPage5_Click;
            // 
            // runLabel
            // 
            runLabel.AutoSize = true;
            runLabel.FlatStyle = FlatStyle.Flat;
            runLabel.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            runLabel.ForeColor = Color.Gold;
            runLabel.Location = new Point(3, 25);
            runLabel.Name = "runLabel";
            runLabel.Size = new Size(139, 26);
            runLabel.TabIndex = 3;
            runLabel.Text = "Run On Startup";
            // 
            // runToggleButton
            // 
            runToggleButton.AutoSize = true;
            runToggleButton.Location = new Point(148, 30);
            runToggleButton.MinimumSize = new Size(45, 22);
            runToggleButton.Name = "runToggleButton";
            runToggleButton.OffBackColor = Color.Red;
            runToggleButton.OffToggleColor = Color.Gainsboro;
            runToggleButton.OnBackColor = Color.Gold;
            runToggleButton.OnToggleColor = Color.WhiteSmoke;
            runToggleButton.Size = new Size(45, 22);
            runToggleButton.TabIndex = 2;
            runToggleButton.UseVisualStyleBackColor = true;
            runToggleButton.CheckedChanged += runToggleButton_CheckedChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.WindowFrame;
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(copyOutputBtn);
            tabPage1.Controls.Add(outputLabel);
            tabPage1.Controls.Add(outputTextBox);
            tabPage1.Controls.Add(inputValueLabel);
            tabPage1.Controls.Add(inputValueTextBox);
            tabPage1.Controls.Add(doubleRadioButton);
            tabPage1.Controls.Add(floatRadioButton);
            tabPage1.Controls.Add(intRadioButton);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(stringRadioButton);
            tabPage1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 35);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1252, 397);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Value to Hex";
            tabPage1.Click += tabPage1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(littleEndianRadioButton);
            panel1.Controls.Add(bigEndianRadioButton);
            panel1.Location = new Point(993, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 13;
            // 
            // littleEndianRadioButton
            // 
            littleEndianRadioButton.AutoSize = true;
            littleEndianRadioButton.CheckedColor = Color.Gold;
            littleEndianRadioButton.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            littleEndianRadioButton.ForeColor = Color.White;
            littleEndianRadioButton.Location = new Point(36, 9);
            littleEndianRadioButton.MinimumSize = new Size(0, 21);
            littleEndianRadioButton.Name = "littleEndianRadioButton";
            littleEndianRadioButton.Padding = new Padding(10, 0, 0, 0);
            littleEndianRadioButton.Size = new Size(143, 30);
            littleEndianRadioButton.TabIndex = 11;
            littleEndianRadioButton.TabStop = true;
            littleEndianRadioButton.Tag = "";
            littleEndianRadioButton.Text = "Little Endian";
            littleEndianRadioButton.UnCheckedColor = Color.Gray;
            littleEndianRadioButton.UseVisualStyleBackColor = true;
            // 
            // bigEndianRadioButton
            // 
            bigEndianRadioButton.AutoSize = true;
            bigEndianRadioButton.CheckedColor = Color.Gold;
            bigEndianRadioButton.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bigEndianRadioButton.ForeColor = Color.White;
            bigEndianRadioButton.Location = new Point(36, 45);
            bigEndianRadioButton.MinimumSize = new Size(0, 21);
            bigEndianRadioButton.Name = "bigEndianRadioButton";
            bigEndianRadioButton.Padding = new Padding(10, 0, 0, 0);
            bigEndianRadioButton.Size = new Size(130, 30);
            bigEndianRadioButton.TabIndex = 12;
            bigEndianRadioButton.TabStop = true;
            bigEndianRadioButton.Tag = "";
            bigEndianRadioButton.Text = "Big Endian";
            bigEndianRadioButton.UnCheckedColor = Color.Gray;
            bigEndianRadioButton.UseVisualStyleBackColor = true;
            bigEndianRadioButton.CheckedChanged += bigEndianRadioButton_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(1029, 28);
            label3.Name = "label3";
            label3.Size = new Size(113, 26);
            label3.TabIndex = 10;
            label3.Text = "Type Output";
            // 
            // copyOutputBtn
            // 
            copyOutputBtn.Cursor = Cursors.Hand;
            copyOutputBtn.FlatAppearance.BorderSize = 0;
            copyOutputBtn.FlatStyle = FlatStyle.Flat;
            copyOutputBtn.IconChar = FontAwesome.Sharp.IconChar.Copy;
            copyOutputBtn.IconColor = Color.Gold;
            copyOutputBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            copyOutputBtn.IconSize = 28;
            copyOutputBtn.Location = new Point(394, 237);
            copyOutputBtn.Name = "copyOutputBtn";
            copyOutputBtn.Size = new Size(39, 39);
            copyOutputBtn.TabIndex = 9;
            copyOutputBtn.UseVisualStyleBackColor = true;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.FlatStyle = FlatStyle.Flat;
            outputLabel.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            outputLabel.ForeColor = Color.Gold;
            outputLabel.Location = new Point(578, 182);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(68, 26);
            outputLabel.TabIndex = 8;
            outputLabel.Text = "Output";
            // 
            // outputTextBox
            // 
            outputTextBox.BorderStyle = BorderStyle.None;
            outputTextBox.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            outputTextBox.Location = new Point(439, 241);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ReadOnly = true;
            outputTextBox.Size = new Size(339, 26);
            outputTextBox.TabIndex = 7;
            // 
            // inputValueLabel
            // 
            inputValueLabel.AutoSize = true;
            inputValueLabel.FlatStyle = FlatStyle.Flat;
            inputValueLabel.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputValueLabel.ForeColor = Color.Gold;
            inputValueLabel.Location = new Point(554, 28);
            inputValueLabel.Name = "inputValueLabel";
            inputValueLabel.Size = new Size(117, 26);
            inputValueLabel.TabIndex = 6;
            inputValueLabel.Text = "Input Value :";
            // 
            // inputValueTextBox
            // 
            inputValueTextBox.BorderStyle = BorderStyle.None;
            inputValueTextBox.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputValueTextBox.Location = new Point(439, 87);
            inputValueTextBox.Name = "inputValueTextBox";
            inputValueTextBox.Size = new Size(339, 26);
            inputValueTextBox.TabIndex = 5;
            inputValueTextBox.TextChanged += inputValueTextBox_TextChanged;
            // 
            // doubleRadioButton
            // 
            doubleRadioButton.AutoSize = true;
            doubleRadioButton.CheckedColor = Color.Gold;
            doubleRadioButton.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            doubleRadioButton.ForeColor = Color.White;
            doubleRadioButton.Location = new Point(33, 182);
            doubleRadioButton.MinimumSize = new Size(0, 21);
            doubleRadioButton.Name = "doubleRadioButton";
            doubleRadioButton.Padding = new Padding(10, 0, 0, 0);
            doubleRadioButton.Size = new Size(101, 30);
            doubleRadioButton.TabIndex = 4;
            doubleRadioButton.TabStop = true;
            doubleRadioButton.Tag = "";
            doubleRadioButton.Text = "Double";
            doubleRadioButton.UnCheckedColor = Color.Gray;
            doubleRadioButton.UseVisualStyleBackColor = true;
            // 
            // floatRadioButton
            // 
            floatRadioButton.AutoSize = true;
            floatRadioButton.CheckedColor = Color.Gold;
            floatRadioButton.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            floatRadioButton.ForeColor = Color.White;
            floatRadioButton.Location = new Point(33, 146);
            floatRadioButton.MinimumSize = new Size(0, 21);
            floatRadioButton.Name = "floatRadioButton";
            floatRadioButton.Padding = new Padding(10, 0, 0, 0);
            floatRadioButton.Size = new Size(81, 30);
            floatRadioButton.TabIndex = 3;
            floatRadioButton.TabStop = true;
            floatRadioButton.Tag = "";
            floatRadioButton.Text = "Float";
            floatRadioButton.UnCheckedColor = Color.Gray;
            floatRadioButton.UseVisualStyleBackColor = true;
            // 
            // intRadioButton
            // 
            intRadioButton.AutoSize = true;
            intRadioButton.CheckedColor = Color.Gold;
            intRadioButton.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            intRadioButton.ForeColor = Color.White;
            intRadioButton.Location = new Point(33, 110);
            intRadioButton.MinimumSize = new Size(0, 21);
            intRadioButton.Name = "intRadioButton";
            intRadioButton.Padding = new Padding(10, 0, 0, 0);
            intRadioButton.Size = new Size(63, 30);
            intRadioButton.TabIndex = 2;
            intRadioButton.TabStop = true;
            intRadioButton.Tag = "";
            intRadioButton.Text = "Int";
            intRadioButton.UnCheckedColor = Color.Gray;
            intRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(33, 28);
            label2.Name = "label2";
            label2.Size = new Size(105, 26);
            label2.TabIndex = 1;
            label2.Text = "Type Value";
            // 
            // stringRadioButton
            // 
            stringRadioButton.AutoSize = true;
            stringRadioButton.CheckedColor = Color.Gold;
            stringRadioButton.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            stringRadioButton.ForeColor = Color.White;
            stringRadioButton.Location = new Point(33, 74);
            stringRadioButton.MinimumSize = new Size(0, 21);
            stringRadioButton.Name = "stringRadioButton";
            stringRadioButton.Padding = new Padding(10, 0, 0, 0);
            stringRadioButton.Size = new Size(92, 30);
            stringRadioButton.TabIndex = 0;
            stringRadioButton.TabStop = true;
            stringRadioButton.Tag = "";
            stringRadioButton.Text = "String";
            stringRadioButton.UnCheckedColor = Color.Gray;
            stringRadioButton.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = SystemColors.WindowFrame;
            tabPage4.Controls.Add(inputLabel);
            tabPage4.Controls.Add(inputTextBox);
            tabPage4.Controls.Add(doubleLabel);
            tabPage4.Controls.Add(doubleTextBox);
            tabPage4.Controls.Add(copyDoubleBtn);
            tabPage4.Controls.Add(floatLabel);
            tabPage4.Controls.Add(floatTextBox);
            tabPage4.Controls.Add(copyFloatBtn);
            tabPage4.Controls.Add(intLabel);
            tabPage4.Controls.Add(intTextBox);
            tabPage4.Controls.Add(copyIntBtn);
            tabPage4.Controls.Add(stringLabel);
            tabPage4.Controls.Add(stringTextBox);
            tabPage4.Controls.Add(copyStringBtn);
            tabPage4.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage4.Location = new Point(4, 35);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1252, 397);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Hex to Value";
            tabPage4.Click += tabPage4_Click;
            // 
            // inputLabel
            // 
            inputLabel.AutoSize = true;
            inputLabel.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            inputLabel.ForeColor = Color.Gold;
            inputLabel.Location = new Point(507, 279);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(171, 29);
            inputLabel.TabIndex = 13;
            inputLabel.Text = "Input Hex Value :";
            // 
            // inputTextBox
            // 
            inputTextBox.BorderStyle = BorderStyle.None;
            inputTextBox.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputTextBox.Location = new Point(364, 333);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(450, 26);
            inputTextBox.TabIndex = 12;
            inputTextBox.TextChanged += inputTextBox_TextChanged;
            // 
            // doubleLabel
            // 
            doubleLabel.AutoSize = true;
            doubleLabel.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            doubleLabel.ForeColor = Color.Gold;
            doubleLabel.Location = new Point(935, 129);
            doubleLabel.Name = "doubleLabel";
            doubleLabel.Size = new Size(81, 29);
            doubleLabel.TabIndex = 11;
            doubleLabel.Text = "Double";
            // 
            // doubleTextBox
            // 
            doubleTextBox.BackColor = Color.White;
            doubleTextBox.BorderStyle = BorderStyle.None;
            doubleTextBox.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            doubleTextBox.ForeColor = Color.Black;
            doubleTextBox.Location = new Point(809, 172);
            doubleTextBox.Name = "doubleTextBox";
            doubleTextBox.ReadOnly = true;
            doubleTextBox.Size = new Size(340, 26);
            doubleTextBox.TabIndex = 10;
            // 
            // copyDoubleBtn
            // 
            copyDoubleBtn.Cursor = Cursors.Hand;
            copyDoubleBtn.FlatAppearance.BorderSize = 0;
            copyDoubleBtn.FlatStyle = FlatStyle.Flat;
            copyDoubleBtn.IconChar = FontAwesome.Sharp.IconChar.Copy;
            copyDoubleBtn.IconColor = Color.Gold;
            copyDoubleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            copyDoubleBtn.IconSize = 28;
            copyDoubleBtn.Location = new Point(754, 163);
            copyDoubleBtn.Name = "copyDoubleBtn";
            copyDoubleBtn.Size = new Size(39, 39);
            copyDoubleBtn.TabIndex = 9;
            copyDoubleBtn.UseVisualStyleBackColor = true;
            copyDoubleBtn.Click += copyDoubleBtn_Click;
            // 
            // floatLabel
            // 
            floatLabel.AutoSize = true;
            floatLabel.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            floatLabel.ForeColor = Color.Gold;
            floatLabel.Location = new Point(208, 129);
            floatLabel.Name = "floatLabel";
            floatLabel.Size = new Size(60, 29);
            floatLabel.TabIndex = 8;
            floatLabel.Text = "Float";
            // 
            // floatTextBox
            // 
            floatTextBox.BorderStyle = BorderStyle.None;
            floatTextBox.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            floatTextBox.Location = new Point(93, 172);
            floatTextBox.Name = "floatTextBox";
            floatTextBox.ReadOnly = true;
            floatTextBox.Size = new Size(340, 26);
            floatTextBox.TabIndex = 7;
            // 
            // copyFloatBtn
            // 
            copyFloatBtn.Cursor = Cursors.Hand;
            copyFloatBtn.FlatAppearance.BorderSize = 0;
            copyFloatBtn.FlatStyle = FlatStyle.Flat;
            copyFloatBtn.IconChar = FontAwesome.Sharp.IconChar.Copy;
            copyFloatBtn.IconColor = Color.Gold;
            copyFloatBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            copyFloatBtn.IconSize = 28;
            copyFloatBtn.Location = new Point(38, 163);
            copyFloatBtn.Name = "copyFloatBtn";
            copyFloatBtn.Size = new Size(39, 39);
            copyFloatBtn.TabIndex = 6;
            copyFloatBtn.UseVisualStyleBackColor = true;
            copyFloatBtn.Click += copyFloatBtn_Click;
            // 
            // intLabel
            // 
            intLabel.AutoSize = true;
            intLabel.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            intLabel.ForeColor = Color.Gold;
            intLabel.Location = new Point(952, 20);
            intLabel.Name = "intLabel";
            intLabel.Size = new Size(40, 29);
            intLabel.TabIndex = 5;
            intLabel.Text = "Int";
            // 
            // intTextBox
            // 
            intTextBox.BorderStyle = BorderStyle.None;
            intTextBox.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            intTextBox.Location = new Point(809, 63);
            intTextBox.Name = "intTextBox";
            intTextBox.ReadOnly = true;
            intTextBox.Size = new Size(340, 26);
            intTextBox.TabIndex = 4;
            // 
            // copyIntBtn
            // 
            copyIntBtn.Cursor = Cursors.Hand;
            copyIntBtn.FlatAppearance.BorderSize = 0;
            copyIntBtn.FlatStyle = FlatStyle.Flat;
            copyIntBtn.IconChar = FontAwesome.Sharp.IconChar.Copy;
            copyIntBtn.IconColor = Color.Gold;
            copyIntBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            copyIntBtn.IconSize = 28;
            copyIntBtn.Location = new Point(754, 54);
            copyIntBtn.Name = "copyIntBtn";
            copyIntBtn.Size = new Size(39, 39);
            copyIntBtn.TabIndex = 3;
            copyIntBtn.UseVisualStyleBackColor = true;
            copyIntBtn.Click += copyIntBtn_Click;
            // 
            // stringLabel
            // 
            stringLabel.AutoSize = true;
            stringLabel.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            stringLabel.ForeColor = Color.Gold;
            stringLabel.Location = new Point(208, 20);
            stringLabel.Name = "stringLabel";
            stringLabel.Size = new Size(72, 29);
            stringLabel.TabIndex = 2;
            stringLabel.Text = "String";
            // 
            // stringTextBox
            // 
            stringTextBox.BorderStyle = BorderStyle.None;
            stringTextBox.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            stringTextBox.Location = new Point(93, 63);
            stringTextBox.Name = "stringTextBox";
            stringTextBox.ReadOnly = true;
            stringTextBox.Size = new Size(340, 26);
            stringTextBox.TabIndex = 1;
            // 
            // copyStringBtn
            // 
            copyStringBtn.Cursor = Cursors.Hand;
            copyStringBtn.FlatAppearance.BorderSize = 0;
            copyStringBtn.FlatStyle = FlatStyle.Flat;
            copyStringBtn.IconChar = FontAwesome.Sharp.IconChar.Copy;
            copyStringBtn.IconColor = Color.Gold;
            copyStringBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            copyStringBtn.IconSize = 28;
            copyStringBtn.Location = new Point(38, 54);
            copyStringBtn.Name = "copyStringBtn";
            copyStringBtn.Size = new Size(39, 39);
            copyStringBtn.TabIndex = 0;
            copyStringBtn.UseVisualStyleBackColor = true;
            copyStringBtn.Click += copyStringBtn_Click;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = Properties.Resources.HexodiaLogo;
            logoPictureBox.Location = new Point(273, 37);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(687, 147);
            logoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            logoPictureBox.TabIndex = 5;
            logoPictureBox.TabStop = false;
            logoPictureBox.MouseDown += logoPictureBox_MouseDown;
            logoPictureBox.MouseMove += logoPictureBox_MouseMove;
            logoPictureBox.MouseUp += logoPictureBox_MouseUp;
            // 
            // Hexodia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1284, 622);
            Controls.Add(logoPictureBox);
            Controls.Add(customTabControl);
            Controls.Add(exitBtn);
            Controls.Add(minimizeBtn);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Hexodia";
            Text = "Hexodia";
            Load += Hexodia_Load;
            Paint += Hexodia_Paint;
            MouseDown += Hexodia_MouseDown;
            MouseMove += Hexodia_MouseMove;
            MouseUp += Hexodia_MouseUp;
            customTabControl.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button exitBtn;
        private Button minimizeBtn;
        private Forms.customTabControl customTabControl;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label runLabel;
        private MagicUI.MagicControl.MagicToggleButton runToggleButton;
        private Label inputLabel;
        private TextBox inputTextBox;
        private Label doubleLabel;
        private TextBox doubleTextBox;
        private FontAwesome.Sharp.IconButton copyDoubleBtn;
        private Label floatLabel;
        private TextBox floatTextBox;
        private FontAwesome.Sharp.IconButton copyFloatBtn;
        private Label intLabel;
        private TextBox intTextBox;
        private FontAwesome.Sharp.IconButton copyIntBtn;
        private Label stringLabel;
        private TextBox stringTextBox;
        private FontAwesome.Sharp.IconButton copyStringBtn;
        private TabPage tabPage1;
        private FontAwesome.Sharp.IconButton copyOutputBtn;
        private Label outputLabel;
        private TextBox outputTextBox;
        private Label inputValueLabel;
        private TextBox inputValueTextBox;
        private MagicUI.MagicControl.MagicRadioButton doubleRadioButton;
        private MagicUI.MagicControl.MagicRadioButton floatRadioButton;
        private MagicUI.MagicControl.MagicRadioButton intRadioButton;
        private Label label2;
        private MagicUI.MagicControl.MagicRadioButton stringRadioButton;
        private MagicUI.MagicControl.MagicRadioButton bigEndianRadioButton;
        private MagicUI.MagicControl.MagicRadioButton littleEndianRadioButton;
        private Label label3;
        private Panel panel1;
        private PictureBox logoPictureBox;
    }
}