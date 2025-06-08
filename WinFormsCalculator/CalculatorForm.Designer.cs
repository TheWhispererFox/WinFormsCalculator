namespace WinFormsCalculator
{
    partial class CalculatorMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorMainForm));
            MainTableLayout = new TableLayoutPanel();
            KeyboardPanel = new TableLayoutPanel();
            BtnClear = new Button();
            BtnCloseParenthesis = new Button();
            BtnOpenParenthesis = new Button();
            BtnSquareRoot = new Button();
            BtnEvaluation = new Button();
            BtnZero = new Button();
            BtnDelimiter = new Button();
            BtnAddition = new Button();
            BtnSubtract = new Button();
            BtnMultiplication = new Button();
            BtnDivision = new Button();
            BtnThree = new Button();
            BtnTwo = new Button();
            BtnOne = new Button();
            BtnFour = new Button();
            BtnFive = new Button();
            BtnSix = new Button();
            BtnNine = new Button();
            BtnEight = new Button();
            BtnSeven = new Button();
            CalculatorDisplayField = new TextBox();
            toolStrip1 = new ToolStrip();
            ChangeFontSizeBtn = new ToolStripDropDownButton();
            IncreaseFontSizeToolStripMenuItem = new ToolStripMenuItem();
            DecreaseFontSizeToolStripMenuItem = new ToolStripMenuItem();
            ImportExportBtn = new ToolStripDropDownButton();
            SaveResultToolStripMenuItem = new ToolStripMenuItem();
            LoadResultToolStripMenuItem = new ToolStripMenuItem();
            MainTableLayout.SuspendLayout();
            KeyboardPanel.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MainTableLayout
            // 
            MainTableLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MainTableLayout.ColumnCount = 1;
            MainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainTableLayout.Controls.Add(KeyboardPanel, 0, 2);
            MainTableLayout.Controls.Add(CalculatorDisplayField, 0, 1);
            MainTableLayout.Controls.Add(toolStrip1, 0, 0);
            MainTableLayout.Dock = DockStyle.Fill;
            MainTableLayout.Location = new Point(0, 0);
            MainTableLayout.Name = "MainTableLayout";
            MainTableLayout.RowCount = 3;
            MainTableLayout.RowStyles.Add(new RowStyle());
            MainTableLayout.RowStyles.Add(new RowStyle());
            MainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainTableLayout.Size = new Size(239, 339);
            MainTableLayout.TabIndex = 2;
            // 
            // KeyboardPanel
            // 
            KeyboardPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            KeyboardPanel.ColumnCount = 4;
            KeyboardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            KeyboardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            KeyboardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            KeyboardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            KeyboardPanel.Controls.Add(BtnClear, 3, 0);
            KeyboardPanel.Controls.Add(BtnCloseParenthesis, 2, 0);
            KeyboardPanel.Controls.Add(BtnOpenParenthesis, 1, 0);
            KeyboardPanel.Controls.Add(BtnSquareRoot, 0, 0);
            KeyboardPanel.Controls.Add(BtnEvaluation, 0, 4);
            KeyboardPanel.Controls.Add(BtnZero, 1, 4);
            KeyboardPanel.Controls.Add(BtnDelimiter, 2, 4);
            KeyboardPanel.Controls.Add(BtnAddition, 3, 4);
            KeyboardPanel.Controls.Add(BtnSubtract, 3, 3);
            KeyboardPanel.Controls.Add(BtnMultiplication, 3, 2);
            KeyboardPanel.Controls.Add(BtnDivision, 3, 1);
            KeyboardPanel.Controls.Add(BtnThree, 2, 3);
            KeyboardPanel.Controls.Add(BtnTwo, 1, 3);
            KeyboardPanel.Controls.Add(BtnOne, 0, 3);
            KeyboardPanel.Controls.Add(BtnFour, 0, 2);
            KeyboardPanel.Controls.Add(BtnFive, 1, 2);
            KeyboardPanel.Controls.Add(BtnSix, 2, 2);
            KeyboardPanel.Controls.Add(BtnNine, 2, 1);
            KeyboardPanel.Controls.Add(BtnEight, 1, 1);
            KeyboardPanel.Controls.Add(BtnSeven, 0, 1);
            KeyboardPanel.Dock = DockStyle.Fill;
            KeyboardPanel.Location = new Point(3, 105);
            KeyboardPanel.Name = "KeyboardPanel";
            KeyboardPanel.RowCount = 5;
            KeyboardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            KeyboardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            KeyboardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            KeyboardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            KeyboardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            KeyboardPanel.Size = new Size(233, 231);
            KeyboardPanel.TabIndex = 1;
            // 
            // BtnClear
            // 
            BtnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnClear.Dock = DockStyle.Fill;
            BtnClear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnClear.Location = new Point(177, 3);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(53, 40);
            BtnClear.TabIndex = 19;
            BtnClear.Text = "C";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnCloseParenthesis
            // 
            BtnCloseParenthesis.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCloseParenthesis.Dock = DockStyle.Fill;
            BtnCloseParenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnCloseParenthesis.Location = new Point(119, 3);
            BtnCloseParenthesis.Name = "BtnCloseParenthesis";
            BtnCloseParenthesis.Size = new Size(52, 40);
            BtnCloseParenthesis.TabIndex = 18;
            BtnCloseParenthesis.Tag = ")";
            BtnCloseParenthesis.Text = ")";
            BtnCloseParenthesis.UseVisualStyleBackColor = true;
            BtnCloseParenthesis.Click += SimpleBtn_Click;
            // 
            // BtnOpenParenthesis
            // 
            BtnOpenParenthesis.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnOpenParenthesis.Dock = DockStyle.Fill;
            BtnOpenParenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnOpenParenthesis.Location = new Point(61, 3);
            BtnOpenParenthesis.Name = "BtnOpenParenthesis";
            BtnOpenParenthesis.Size = new Size(52, 40);
            BtnOpenParenthesis.TabIndex = 17;
            BtnOpenParenthesis.Tag = "(";
            BtnOpenParenthesis.Text = "(";
            BtnOpenParenthesis.UseVisualStyleBackColor = true;
            BtnOpenParenthesis.Click += SimpleBtn_Click;
            // 
            // BtnSquareRoot
            // 
            BtnSquareRoot.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnSquareRoot.Dock = DockStyle.Fill;
            BtnSquareRoot.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnSquareRoot.Location = new Point(3, 3);
            BtnSquareRoot.Name = "BtnSquareRoot";
            BtnSquareRoot.Size = new Size(52, 40);
            BtnSquareRoot.TabIndex = 16;
            BtnSquareRoot.Tag = "sqrt";
            BtnSquareRoot.Text = "√";
            BtnSquareRoot.UseVisualStyleBackColor = true;
            BtnSquareRoot.Click += SimpleBtn_Click;
            // 
            // BtnEvaluation
            // 
            BtnEvaluation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnEvaluation.BackColor = SystemColors.Highlight;
            BtnEvaluation.Dock = DockStyle.Fill;
            BtnEvaluation.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnEvaluation.ForeColor = SystemColors.Control;
            BtnEvaluation.Location = new Point(3, 187);
            BtnEvaluation.Name = "BtnEvaluation";
            BtnEvaluation.Size = new Size(52, 41);
            BtnEvaluation.TabIndex = 13;
            BtnEvaluation.Text = "=";
            BtnEvaluation.UseVisualStyleBackColor = false;
            BtnEvaluation.Click += BtnEvaluation_Click;
            // 
            // BtnZero
            // 
            BtnZero.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnZero.Dock = DockStyle.Fill;
            BtnZero.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnZero.Location = new Point(61, 187);
            BtnZero.Name = "BtnZero";
            BtnZero.Size = new Size(52, 41);
            BtnZero.TabIndex = 14;
            BtnZero.Tag = "0";
            BtnZero.Text = "0";
            BtnZero.UseVisualStyleBackColor = true;
            BtnZero.Click += SimpleBtn_Click;
            // 
            // BtnDelimiter
            // 
            BtnDelimiter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnDelimiter.Dock = DockStyle.Fill;
            BtnDelimiter.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnDelimiter.Location = new Point(119, 187);
            BtnDelimiter.Name = "BtnDelimiter";
            BtnDelimiter.Size = new Size(52, 41);
            BtnDelimiter.TabIndex = 15;
            BtnDelimiter.Tag = ".";
            BtnDelimiter.Text = ",";
            BtnDelimiter.UseVisualStyleBackColor = true;
            BtnDelimiter.Click += SimpleBtn_Click;
            // 
            // BtnAddition
            // 
            BtnAddition.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnAddition.Dock = DockStyle.Fill;
            BtnAddition.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnAddition.Location = new Point(177, 187);
            BtnAddition.Name = "BtnAddition";
            BtnAddition.Size = new Size(53, 41);
            BtnAddition.TabIndex = 12;
            BtnAddition.Tag = "+";
            BtnAddition.Text = "+";
            BtnAddition.UseVisualStyleBackColor = true;
            BtnAddition.Click += SimpleBtn_Click;
            // 
            // BtnSubtract
            // 
            BtnSubtract.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnSubtract.Dock = DockStyle.Fill;
            BtnSubtract.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnSubtract.Location = new Point(177, 141);
            BtnSubtract.Name = "BtnSubtract";
            BtnSubtract.Size = new Size(53, 40);
            BtnSubtract.TabIndex = 11;
            BtnSubtract.Tag = "-";
            BtnSubtract.Text = "-";
            BtnSubtract.UseVisualStyleBackColor = true;
            BtnSubtract.Click += SimpleBtn_Click;
            // 
            // BtnMultiplication
            // 
            BtnMultiplication.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnMultiplication.Dock = DockStyle.Fill;
            BtnMultiplication.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnMultiplication.Location = new Point(177, 95);
            BtnMultiplication.Name = "BtnMultiplication";
            BtnMultiplication.Size = new Size(53, 40);
            BtnMultiplication.TabIndex = 10;
            BtnMultiplication.Tag = "*";
            BtnMultiplication.Text = "×";
            BtnMultiplication.UseVisualStyleBackColor = true;
            BtnMultiplication.Click += SimpleBtn_Click;
            // 
            // BtnDivision
            // 
            BtnDivision.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnDivision.Dock = DockStyle.Fill;
            BtnDivision.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnDivision.Location = new Point(177, 49);
            BtnDivision.Name = "BtnDivision";
            BtnDivision.Size = new Size(53, 40);
            BtnDivision.TabIndex = 9;
            BtnDivision.Tag = "/";
            BtnDivision.Text = "÷";
            BtnDivision.UseVisualStyleBackColor = true;
            BtnDivision.Click += SimpleBtn_Click;
            // 
            // BtnThree
            // 
            BtnThree.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnThree.Dock = DockStyle.Fill;
            BtnThree.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnThree.Location = new Point(119, 141);
            BtnThree.Name = "BtnThree";
            BtnThree.Size = new Size(52, 40);
            BtnThree.TabIndex = 8;
            BtnThree.Tag = "3";
            BtnThree.Text = "3";
            BtnThree.UseVisualStyleBackColor = true;
            BtnThree.Click += SimpleBtn_Click;
            // 
            // BtnTwo
            // 
            BtnTwo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnTwo.Dock = DockStyle.Fill;
            BtnTwo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnTwo.Location = new Point(61, 141);
            BtnTwo.Name = "BtnTwo";
            BtnTwo.Size = new Size(52, 40);
            BtnTwo.TabIndex = 7;
            BtnTwo.Tag = "2";
            BtnTwo.Text = "2";
            BtnTwo.UseVisualStyleBackColor = true;
            BtnTwo.Click += SimpleBtn_Click;
            // 
            // BtnOne
            // 
            BtnOne.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnOne.Dock = DockStyle.Fill;
            BtnOne.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnOne.Location = new Point(3, 141);
            BtnOne.Name = "BtnOne";
            BtnOne.Size = new Size(52, 40);
            BtnOne.TabIndex = 6;
            BtnOne.Tag = "1";
            BtnOne.Text = "1";
            BtnOne.UseVisualStyleBackColor = true;
            BtnOne.Click += SimpleBtn_Click;
            // 
            // BtnFour
            // 
            BtnFour.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnFour.Dock = DockStyle.Fill;
            BtnFour.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnFour.Location = new Point(3, 95);
            BtnFour.Name = "BtnFour";
            BtnFour.Size = new Size(52, 40);
            BtnFour.TabIndex = 3;
            BtnFour.Tag = "4";
            BtnFour.Text = "4";
            BtnFour.UseVisualStyleBackColor = true;
            BtnFour.Click += SimpleBtn_Click;
            // 
            // BtnFive
            // 
            BtnFive.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnFive.Dock = DockStyle.Fill;
            BtnFive.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnFive.Location = new Point(61, 95);
            BtnFive.Name = "BtnFive";
            BtnFive.Size = new Size(52, 40);
            BtnFive.TabIndex = 4;
            BtnFive.Tag = "5";
            BtnFive.Text = "5";
            BtnFive.UseVisualStyleBackColor = true;
            BtnFive.Click += SimpleBtn_Click;
            // 
            // BtnSix
            // 
            BtnSix.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnSix.Dock = DockStyle.Fill;
            BtnSix.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnSix.Location = new Point(119, 95);
            BtnSix.Name = "BtnSix";
            BtnSix.Size = new Size(52, 40);
            BtnSix.TabIndex = 5;
            BtnSix.Tag = "6";
            BtnSix.Text = "6";
            BtnSix.UseVisualStyleBackColor = true;
            BtnSix.Click += SimpleBtn_Click;
            // 
            // BtnNine
            // 
            BtnNine.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnNine.Dock = DockStyle.Fill;
            BtnNine.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnNine.Location = new Point(119, 49);
            BtnNine.Name = "BtnNine";
            BtnNine.Size = new Size(52, 40);
            BtnNine.TabIndex = 2;
            BtnNine.Tag = "9";
            BtnNine.Text = "9";
            BtnNine.UseVisualStyleBackColor = true;
            BtnNine.Click += SimpleBtn_Click;
            // 
            // BtnEight
            // 
            BtnEight.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnEight.Dock = DockStyle.Fill;
            BtnEight.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnEight.Location = new Point(61, 49);
            BtnEight.Name = "BtnEight";
            BtnEight.Size = new Size(52, 40);
            BtnEight.TabIndex = 1;
            BtnEight.Tag = "8";
            BtnEight.Text = "8";
            BtnEight.UseVisualStyleBackColor = true;
            BtnEight.Click += SimpleBtn_Click;
            // 
            // BtnSeven
            // 
            BtnSeven.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnSeven.Dock = DockStyle.Fill;
            BtnSeven.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnSeven.Location = new Point(3, 49);
            BtnSeven.Name = "BtnSeven";
            BtnSeven.Size = new Size(52, 40);
            BtnSeven.TabIndex = 0;
            BtnSeven.Tag = "7";
            BtnSeven.Text = "7";
            BtnSeven.UseVisualStyleBackColor = true;
            BtnSeven.Click += SimpleBtn_Click;
            // 
            // CalculatorDisplayField
            // 
            CalculatorDisplayField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CalculatorDisplayField.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CalculatorDisplayField.ForeColor = SystemColors.WindowText;
            CalculatorDisplayField.Location = new Point(3, 28);
            CalculatorDisplayField.Name = "CalculatorDisplayField";
            CalculatorDisplayField.PlaceholderText = "0";
            CalculatorDisplayField.Size = new Size(233, 71);
            CalculatorDisplayField.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { ChangeFontSizeBtn, ImportExportBtn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(239, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // ChangeFontSizeBtn
            // 
            ChangeFontSizeBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ChangeFontSizeBtn.DropDownItems.AddRange(new ToolStripItem[] { IncreaseFontSizeToolStripMenuItem, DecreaseFontSizeToolStripMenuItem });
            ChangeFontSizeBtn.Image = (Image)resources.GetObject("ChangeFontSizeBtn.Image");
            ChangeFontSizeBtn.ImageTransparentColor = Color.Magenta;
            ChangeFontSizeBtn.Name = "ChangeFontSizeBtn";
            ChangeFontSizeBtn.Size = new Size(29, 22);
            ChangeFontSizeBtn.Text = "toolStripDropDownButton1";
            // 
            // IncreaseFontSizeToolStripMenuItem
            // 
            IncreaseFontSizeToolStripMenuItem.Name = "IncreaseFontSizeToolStripMenuItem";
            IncreaseFontSizeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Oemplus;
            IncreaseFontSizeToolStripMenuItem.Size = new Size(272, 22);
            IncreaseFontSizeToolStripMenuItem.Text = "Increase Font Size +";
            IncreaseFontSizeToolStripMenuItem.Click += IncreaseFontSizeToolStripMenuItem_Click;
            // 
            // DecreaseFontSizeToolStripMenuItem
            // 
            DecreaseFontSizeToolStripMenuItem.Name = "DecreaseFontSizeToolStripMenuItem";
            DecreaseFontSizeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.OemMinus;
            DecreaseFontSizeToolStripMenuItem.Size = new Size(272, 22);
            DecreaseFontSizeToolStripMenuItem.Text = "Decrease Font Size -";
            DecreaseFontSizeToolStripMenuItem.Click += DecreaseFontSizeToolStripMenuItem_Click;
            // 
            // ImportExportBtn
            // 
            ImportExportBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ImportExportBtn.DropDownItems.AddRange(new ToolStripItem[] { SaveResultToolStripMenuItem, LoadResultToolStripMenuItem });
            ImportExportBtn.Image = (Image)resources.GetObject("ImportExportBtn.Image");
            ImportExportBtn.ImageTransparentColor = Color.Magenta;
            ImportExportBtn.Name = "ImportExportBtn";
            ImportExportBtn.Size = new Size(29, 22);
            ImportExportBtn.Text = "toolStripDropDownButton2";
            // 
            // SaveResultToolStripMenuItem
            // 
            SaveResultToolStripMenuItem.Name = "SaveResultToolStripMenuItem";
            SaveResultToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            SaveResultToolStripMenuItem.Size = new Size(178, 22);
            SaveResultToolStripMenuItem.Text = "Save Result";
            SaveResultToolStripMenuItem.Click += SaveResultToolStripMenuItem_Click;
            // 
            // LoadResultToolStripMenuItem
            // 
            LoadResultToolStripMenuItem.Name = "LoadResultToolStripMenuItem";
            LoadResultToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            LoadResultToolStripMenuItem.Size = new Size(178, 22);
            LoadResultToolStripMenuItem.Text = "Load Result";
            LoadResultToolStripMenuItem.Click += LoadResultToolStripMenuItem_Click;
            // 
            // CalculatorMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(239, 339);
            Controls.Add(MainTableLayout);
            Name = "CalculatorMainForm";
            Text = "Calculator";
            MainTableLayout.ResumeLayout(false);
            MainTableLayout.PerformLayout();
            KeyboardPanel.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainTableLayout;
        private TableLayoutPanel KeyboardPanel;
        private Button BtnDelimiter;
        private Button BtnZero;
        private Button BtnEvaluation;
        private Button BtnSubtract;
        private Button BtnMultiplication;
        private Button BtnDivision;
        private Button BtnThree;
        private Button BtnTwo;
        private Button BtnOne;
        private Button BtnSix;
        private Button BtnFive;
        private Button BtnFour;
        private Button BtnEight;
        private Button BtnSeven;
        private Button BtnAddition;
        private Button BtnNine;
        private TextBox CalculatorDisplayField;
        private Button BtnClear;
        private Button BtnCloseParenthesis;
        private Button BtnOpenParenthesis;
        private Button BtnSquareRoot;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton ChangeFontSizeBtn;
        private ToolStripMenuItem IncreaseFontSizeToolStripMenuItem;
        private ToolStripMenuItem DecreaseFontSizeToolStripMenuItem;
        private ToolStripDropDownButton ImportExportBtn;
        private ToolStripMenuItem SaveResultToolStripMenuItem;
        private ToolStripMenuItem LoadResultToolStripMenuItem;
    }
}
