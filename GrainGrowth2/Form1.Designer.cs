namespace GrainGrowth2
{
    partial class Form1
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.startButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.generationButton = new System.Windows.Forms.Button();
			this.widthTextBox = new System.Windows.Forms.TextBox();
			this.heigthTextBox = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.numberOfGrainsTextBox = new System.Windows.Forms.TextBox();
			this.numberOfInclusionsTextBox = new System.Windows.Forms.TextBox();
			this.sizeOfInclusionsTextBox = new System.Windows.Forms.TextBox();
			this.addInclusionsButton = new System.Windows.Forms.Button();
			this.inclusionsTypeComboBox = new System.Windows.Forms.ComboBox();
			this.cellSizeTextBox = new System.Windows.Forms.TextBox();
			this.redrawButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.algorithmComboBox = new System.Windows.Forms.ComboBox();
			this.probabilityTextBox = new System.Windows.Forms.TextBox();
			this.selectGrainButton = new System.Windows.Forms.Button();
			this.structureComboBox = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.getAllBoundariesButton = new System.Windows.Forms.Button();
			this.clearActiveGrainsButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Location = new System.Drawing.Point(12, 37);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(546, 400);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// startButton
			// 
			this.startButton.Enabled = false;
			this.startButton.Location = new System.Drawing.Point(659, 434);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(75, 23);
			this.startButton.TabIndex = 1;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(740, 434);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(75, 23);
			this.clearButton.TabIndex = 2;
			this.clearButton.Text = "Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// generationButton
			// 
			this.generationButton.Location = new System.Drawing.Point(715, 129);
			this.generationButton.Name = "generationButton";
			this.generationButton.Size = new System.Drawing.Size(100, 23);
			this.generationButton.TabIndex = 3;
			this.generationButton.Text = "Generate grains";
			this.generationButton.UseVisualStyleBackColor = true;
			this.generationButton.Click += new System.EventHandler(this.generationButton_Click);
			// 
			// widthTextBox
			// 
			this.widthTextBox.Location = new System.Drawing.Point(634, 39);
			this.widthTextBox.Name = "widthTextBox";
			this.widthTextBox.Size = new System.Drawing.Size(60, 20);
			this.widthTextBox.TabIndex = 4;
			this.widthTextBox.Text = "546";
			this.widthTextBox.TextChanged += new System.EventHandler(this.widthTextBox_TextChanged);
			// 
			// heigthTextBox
			// 
			this.heigthTextBox.Location = new System.Drawing.Point(740, 39);
			this.heigthTextBox.Name = "heigthTextBox";
			this.heigthTextBox.Size = new System.Drawing.Size(60, 20);
			this.heigthTextBox.TabIndex = 5;
			this.heigthTextBox.Text = "400";
			this.heigthTextBox.TextChanged += new System.EventHandler(this.heigthTextBox_TextChanged);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(932, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// importToolStripMenuItem
			// 
			this.importToolStripMenuItem.Name = "importToolStripMenuItem";
			this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
			this.importToolStripMenuItem.Text = "Import";
			this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
			this.exportToolStripMenuItem.Text = "Export";
			this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
			// 
			// numberOfGrainsTextBox
			// 
			this.numberOfGrainsTextBox.Location = new System.Drawing.Point(740, 103);
			this.numberOfGrainsTextBox.Name = "numberOfGrainsTextBox";
			this.numberOfGrainsTextBox.Size = new System.Drawing.Size(60, 20);
			this.numberOfGrainsTextBox.TabIndex = 7;
			this.numberOfGrainsTextBox.Text = "20";
			// 
			// numberOfInclusionsTextBox
			// 
			this.numberOfInclusionsTextBox.Location = new System.Drawing.Point(832, 175);
			this.numberOfInclusionsTextBox.Name = "numberOfInclusionsTextBox";
			this.numberOfInclusionsTextBox.Size = new System.Drawing.Size(62, 20);
			this.numberOfInclusionsTextBox.TabIndex = 8;
			this.numberOfInclusionsTextBox.Text = "10";
			// 
			// sizeOfInclusionsTextBox
			// 
			this.sizeOfInclusionsTextBox.Location = new System.Drawing.Point(832, 201);
			this.sizeOfInclusionsTextBox.Name = "sizeOfInclusionsTextBox";
			this.sizeOfInclusionsTextBox.Size = new System.Drawing.Size(62, 20);
			this.sizeOfInclusionsTextBox.TabIndex = 9;
			this.sizeOfInclusionsTextBox.Text = "6";
			// 
			// addInclusionsButton
			// 
			this.addInclusionsButton.Location = new System.Drawing.Point(794, 254);
			this.addInclusionsButton.Name = "addInclusionsButton";
			this.addInclusionsButton.Size = new System.Drawing.Size(100, 23);
			this.addInclusionsButton.TabIndex = 10;
			this.addInclusionsButton.Text = "Add inclusions";
			this.addInclusionsButton.UseVisualStyleBackColor = true;
			this.addInclusionsButton.Click += new System.EventHandler(this.addInclusionsButton_Click);
			// 
			// inclusionsTypeComboBox
			// 
			this.inclusionsTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inclusionsTypeComboBox.FormattingEnabled = true;
			this.inclusionsTypeComboBox.Items.AddRange(new object[] {
            "Circular",
            "Square"});
			this.inclusionsTypeComboBox.Location = new System.Drawing.Point(832, 227);
			this.inclusionsTypeComboBox.Name = "inclusionsTypeComboBox";
			this.inclusionsTypeComboBox.Size = new System.Drawing.Size(62, 21);
			this.inclusionsTypeComboBox.TabIndex = 11;
			// 
			// cellSizeTextBox
			// 
			this.cellSizeTextBox.Location = new System.Drawing.Point(854, 39);
			this.cellSizeTextBox.Name = "cellSizeTextBox";
			this.cellSizeTextBox.Size = new System.Drawing.Size(60, 20);
			this.cellSizeTextBox.TabIndex = 12;
			this.cellSizeTextBox.Text = "2";
			// 
			// redrawButton
			// 
			this.redrawButton.Location = new System.Drawing.Point(727, 65);
			this.redrawButton.Name = "redrawButton";
			this.redrawButton.Size = new System.Drawing.Size(75, 23);
			this.redrawButton.TabIndex = 13;
			this.redrawButton.Text = "Draw";
			this.redrawButton.UseVisualStyleBackColor = true;
			this.redrawButton.Click += new System.EventHandler(this.redrawButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(700, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Height";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(593, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Width";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(806, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Cellsize";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(782, 178);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Number";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(782, 204);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(27, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "Size";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(782, 230);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 19;
			this.label6.Text = "Type";
			// 
			// algorithmComboBox
			// 
			this.algorithmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.algorithmComboBox.FormattingEnabled = true;
			this.algorithmComboBox.Items.AddRange(new object[] {
            "Simple",
            "Shape control"});
			this.algorithmComboBox.Location = new System.Drawing.Point(649, 178);
			this.algorithmComboBox.Name = "algorithmComboBox";
			this.algorithmComboBox.Size = new System.Drawing.Size(100, 21);
			this.algorithmComboBox.TabIndex = 20;
			this.algorithmComboBox.SelectedIndexChanged += new System.EventHandler(this.algorithmComboBox_SelectedIndexChanged);
			// 
			// probabilityTextBox
			// 
			this.probabilityTextBox.Enabled = false;
			this.probabilityTextBox.Location = new System.Drawing.Point(687, 206);
			this.probabilityTextBox.Name = "probabilityTextBox";
			this.probabilityTextBox.Size = new System.Drawing.Size(61, 20);
			this.probabilityTextBox.TabIndex = 21;
			this.probabilityTextBox.Text = "15";
			// 
			// selectGrainButton
			// 
			this.selectGrainButton.Enabled = false;
			this.selectGrainButton.Location = new System.Drawing.Point(590, 353);
			this.selectGrainButton.Name = "selectGrainButton";
			this.selectGrainButton.Size = new System.Drawing.Size(92, 23);
			this.selectGrainButton.TabIndex = 22;
			this.selectGrainButton.Text = "Select grains";
			this.selectGrainButton.UseVisualStyleBackColor = true;
			this.selectGrainButton.Click += new System.EventHandler(this.selectGrainButton_Click);
			// 
			// structureComboBox
			// 
			this.structureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.structureComboBox.FormattingEnabled = true;
			this.structureComboBox.Items.AddRange(new object[] {
            "Substructure",
            "Dual phase"});
			this.structureComboBox.Location = new System.Drawing.Point(590, 317);
			this.structureComboBox.Name = "structureComboBox";
			this.structureComboBox.Size = new System.Drawing.Size(109, 21);
			this.structureComboBox.TabIndex = 23;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(593, 181);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 13);
			this.label7.TabIndex = 24;
			this.label7.Text = "Algorithm";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(593, 209);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 13);
			this.label8.TabIndex = 25;
			this.label8.Text = "Probability";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(598, 294);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(50, 13);
			this.label9.TabIndex = 26;
			this.label9.Text = "Structure";
			// 
			// getAllBoundariesButton
			// 
			this.getAllBoundariesButton.Enabled = false;
			this.getAllBoundariesButton.Location = new System.Drawing.Point(794, 315);
			this.getAllBoundariesButton.Name = "getAllBoundariesButton";
			this.getAllBoundariesButton.Size = new System.Drawing.Size(109, 23);
			this.getAllBoundariesButton.TabIndex = 28;
			this.getAllBoundariesButton.Text = "Get all boundary";
			this.getAllBoundariesButton.UseVisualStyleBackColor = true;
			this.getAllBoundariesButton.Click += new System.EventHandler(this.getAllBoundariesButton_Click);
			// 
			// clearActiveGrainsButton
			// 
			this.clearActiveGrainsButton.Enabled = false;
			this.clearActiveGrainsButton.Location = new System.Drawing.Point(794, 344);
			this.clearActiveGrainsButton.Name = "clearActiveGrainsButton";
			this.clearActiveGrainsButton.Size = new System.Drawing.Size(109, 23);
			this.clearActiveGrainsButton.TabIndex = 29;
			this.clearActiveGrainsButton.Text = "Clear grains";
			this.clearActiveGrainsButton.UseVisualStyleBackColor = true;
			this.clearActiveGrainsButton.Click += new System.EventHandler(this.clearActiveGrainsButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(932, 495);
			this.Controls.Add(this.clearActiveGrainsButton);
			this.Controls.Add(this.getAllBoundariesButton);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.structureComboBox);
			this.Controls.Add(this.selectGrainButton);
			this.Controls.Add(this.probabilityTextBox);
			this.Controls.Add(this.algorithmComboBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.redrawButton);
			this.Controls.Add(this.cellSizeTextBox);
			this.Controls.Add(this.inclusionsTypeComboBox);
			this.Controls.Add(this.addInclusionsButton);
			this.Controls.Add(this.sizeOfInclusionsTextBox);
			this.Controls.Add(this.numberOfInclusionsTextBox);
			this.Controls.Add(this.numberOfGrainsTextBox);
			this.Controls.Add(this.heigthTextBox);
			this.Controls.Add(this.widthTextBox);
			this.Controls.Add(this.generationButton);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button generationButton;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heigthTextBox;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.TextBox numberOfGrainsTextBox;
		private System.Windows.Forms.TextBox numberOfInclusionsTextBox;
		private System.Windows.Forms.TextBox sizeOfInclusionsTextBox;
		private System.Windows.Forms.Button addInclusionsButton;
		private System.Windows.Forms.ComboBox inclusionsTypeComboBox;
		private System.Windows.Forms.TextBox cellSizeTextBox;
		private System.Windows.Forms.Button redrawButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox algorithmComboBox;
		private System.Windows.Forms.TextBox probabilityTextBox;
		private System.Windows.Forms.Button selectGrainButton;
		private System.Windows.Forms.ComboBox structureComboBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button getAllBoundariesButton;
		private System.Windows.Forms.Button clearActiveGrainsButton;
	}
}

