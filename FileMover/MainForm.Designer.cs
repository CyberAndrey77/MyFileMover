
namespace FileMover
{
    partial class MainWindow
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
            this.sourcePathExplorerButton = new System.Windows.Forms.Button();
            this.sourcePathLabel = new System.Windows.Forms.Label();
            this.finalPathLabel = new System.Windows.Forms.Label();
            this.finalPathExplorerButton = new System.Windows.Forms.Button();
            this.sourcePathTextBox = new System.Windows.Forms.TextBox();
            this.finalPathTextBox = new System.Windows.Forms.TextBox();
            this.moverButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selectMaskFileButton = new System.Windows.Forms.Button();
            this.selectMaskFileTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectFilesByMaskRadioButton = new System.Windows.Forms.RadioButton();
            this.selectFilesInExplorerRadioButton = new System.Windows.Forms.RadioButton();
            this.selectMaskFileLabel = new System.Windows.Forms.Label();
            this.selectedFilesListBox = new System.Windows.Forms.ListBox();
            this.removePathFileButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourcePathExplorerButton
            // 
            this.sourcePathExplorerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sourcePathExplorerButton.Location = new System.Drawing.Point(648, 58);
            this.sourcePathExplorerButton.Name = "sourcePathExplorerButton";
            this.sourcePathExplorerButton.Size = new System.Drawing.Size(120, 28);
            this.sourcePathExplorerButton.TabIndex = 0;
            this.sourcePathExplorerButton.Text = "Обозреватель";
            this.sourcePathExplorerButton.UseVisualStyleBackColor = true;
            this.sourcePathExplorerButton.Click += new System.EventHandler(this.sourcePathExplorerButton_Click);
            // 
            // sourcePathLabel
            // 
            this.sourcePathLabel.AutoSize = true;
            this.sourcePathLabel.Location = new System.Drawing.Point(48, 30);
            this.sourcePathLabel.Name = "sourcePathLabel";
            this.sourcePathLabel.Size = new System.Drawing.Size(172, 17);
            this.sourcePathLabel.TabIndex = 1;
            this.sourcePathLabel.Text = "Путь от куда копировать";
            // 
            // finalPathLabel
            // 
            this.finalPathLabel.AutoSize = true;
            this.finalPathLabel.Location = new System.Drawing.Point(48, 115);
            this.finalPathLabel.Name = "finalPathLabel";
            this.finalPathLabel.Size = new System.Drawing.Size(153, 17);
            this.finalPathLabel.TabIndex = 2;
            this.finalPathLabel.Text = "Путь куда копировать";
            // 
            // finalPathExplorerButton
            // 
            this.finalPathExplorerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.finalPathExplorerButton.Location = new System.Drawing.Point(648, 142);
            this.finalPathExplorerButton.Name = "finalPathExplorerButton";
            this.finalPathExplorerButton.Size = new System.Drawing.Size(120, 28);
            this.finalPathExplorerButton.TabIndex = 3;
            this.finalPathExplorerButton.Text = "Обозреватель";
            this.finalPathExplorerButton.UseVisualStyleBackColor = true;
            this.finalPathExplorerButton.Click += new System.EventHandler(this.finalPathExplorerButton_Click);
            // 
            // sourcePathTextBox
            // 
            this.sourcePathTextBox.Location = new System.Drawing.Point(51, 61);
            this.sourcePathTextBox.Name = "sourcePathTextBox";
            this.sourcePathTextBox.Size = new System.Drawing.Size(570, 22);
            this.sourcePathTextBox.TabIndex = 4;
            // 
            // finalPathTextBox
            // 
            this.finalPathTextBox.Location = new System.Drawing.Point(51, 145);
            this.finalPathTextBox.Name = "finalPathTextBox";
            this.finalPathTextBox.Size = new System.Drawing.Size(570, 22);
            this.finalPathTextBox.TabIndex = 5;
            // 
            // moverButton
            // 
            this.moverButton.Location = new System.Drawing.Point(648, 592);
            this.moverButton.Name = "moverButton";
            this.moverButton.Size = new System.Drawing.Size(120, 28);
            this.moverButton.TabIndex = 6;
            this.moverButton.Text = "Перенести";
            this.moverButton.UseVisualStyleBackColor = true;
            this.moverButton.Click += new System.EventHandler(this.moverButton_Click);
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(51, 383);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(120, 28);
            this.selectFileButton.TabIndex = 7;
            this.selectFileButton.Text = "Выбор файлов";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // selectMaskFileButton
            // 
            this.selectMaskFileButton.Location = new System.Drawing.Point(376, 283);
            this.selectMaskFileButton.Name = "selectMaskFileButton";
            this.selectMaskFileButton.Size = new System.Drawing.Size(182, 28);
            this.selectMaskFileButton.TabIndex = 9;
            this.selectMaskFileButton.Text = "Выбрать маску файла";
            this.selectMaskFileButton.UseVisualStyleBackColor = true;
            this.selectMaskFileButton.Click += new System.EventHandler(this.selectMaskFileButton_Click);
            // 
            // selectMaskFileTextBox
            // 
            this.selectMaskFileTextBox.Location = new System.Drawing.Point(376, 240);
            this.selectMaskFileTextBox.Name = "selectMaskFileTextBox";
            this.selectMaskFileTextBox.Size = new System.Drawing.Size(182, 22);
            this.selectMaskFileTextBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectFilesByMaskRadioButton);
            this.groupBox1.Controls.Add(this.selectFilesInExplorerRadioButton);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(51, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 168);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // selectFilesByMaskRadioButton
            // 
            this.selectFilesByMaskRadioButton.AutoSize = true;
            this.selectFilesByMaskRadioButton.Location = new System.Drawing.Point(7, 69);
            this.selectFilesByMaskRadioButton.Name = "selectFilesByMaskRadioButton";
            this.selectFilesByMaskRadioButton.Size = new System.Drawing.Size(211, 21);
            this.selectFilesByMaskRadioButton.TabIndex = 1;
            this.selectFilesByMaskRadioButton.TabStop = true;
            this.selectFilesByMaskRadioButton.Text = "Выбор файлов через маску";
            this.selectFilesByMaskRadioButton.UseVisualStyleBackColor = true;
            this.selectFilesByMaskRadioButton.CheckedChanged += new System.EventHandler(this.selectFilesByMaskRadioButton_CheckedChanged);
            // 
            // selectFilesInExplorerRadioButton
            // 
            this.selectFilesInExplorerRadioButton.AutoSize = true;
            this.selectFilesInExplorerRadioButton.Location = new System.Drawing.Point(7, 22);
            this.selectFilesInExplorerRadioButton.Name = "selectFilesInExplorerRadioButton";
            this.selectFilesInExplorerRadioButton.Size = new System.Drawing.Size(219, 21);
            this.selectFilesInExplorerRadioButton.TabIndex = 0;
            this.selectFilesInExplorerRadioButton.TabStop = true;
            this.selectFilesInExplorerRadioButton.Text = "Выбор файлов в проводнике";
            this.selectFilesInExplorerRadioButton.UseVisualStyleBackColor = true;
            this.selectFilesInExplorerRadioButton.CheckedChanged += new System.EventHandler(this.selectFilesInExplorerRadioButton_CheckedChanged);
            // 
            // selectMaskFileLabel
            // 
            this.selectMaskFileLabel.AutoSize = true;
            this.selectMaskFileLabel.Location = new System.Drawing.Point(376, 197);
            this.selectMaskFileLabel.Name = "selectMaskFileLabel";
            this.selectMaskFileLabel.Size = new System.Drawing.Size(152, 17);
            this.selectMaskFileLabel.TabIndex = 12;
            this.selectMaskFileLabel.Text = "Введите маску файла";
            // 
            // selectedFilesListBox
            // 
            this.selectedFilesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectedFilesListBox.FormattingEnabled = true;
            this.selectedFilesListBox.IntegralHeight = false;
            this.selectedFilesListBox.ItemHeight = 16;
            this.selectedFilesListBox.Location = new System.Drawing.Point(51, 429);
            this.selectedFilesListBox.Name = "selectedFilesListBox";
            this.selectedFilesListBox.Size = new System.Drawing.Size(570, 191);
            this.selectedFilesListBox.TabIndex = 13;
            // 
            // removePathFileButton
            // 
            this.removePathFileButton.Location = new System.Drawing.Point(648, 429);
            this.removePathFileButton.Name = "removePathFileButton";
            this.removePathFileButton.Size = new System.Drawing.Size(120, 28);
            this.removePathFileButton.TabIndex = 14;
            this.removePathFileButton.Text = "Удалить путь";
            this.removePathFileButton.UseVisualStyleBackColor = true;
            this.removePathFileButton.Click += new System.EventHandler(this.removePathFileButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.removePathFileButton);
            this.Controls.Add(this.selectedFilesListBox);
            this.Controls.Add(this.selectMaskFileLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.selectMaskFileTextBox);
            this.Controls.Add(this.selectMaskFileButton);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.moverButton);
            this.Controls.Add(this.finalPathTextBox);
            this.Controls.Add(this.sourcePathTextBox);
            this.Controls.Add(this.finalPathExplorerButton);
            this.Controls.Add(this.finalPathLabel);
            this.Controls.Add(this.sourcePathLabel);
            this.Controls.Add(this.sourcePathExplorerButton);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "MainWindow";
            this.Text = "FileMover";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sourcePathExplorerButton;
        private System.Windows.Forms.Label sourcePathLabel;
        private System.Windows.Forms.Label finalPathLabel;
        private System.Windows.Forms.Button finalPathExplorerButton;
        private System.Windows.Forms.TextBox sourcePathTextBox;
        private System.Windows.Forms.TextBox finalPathTextBox;
        private System.Windows.Forms.Button moverButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button selectMaskFileButton;
        private System.Windows.Forms.TextBox selectMaskFileTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton selectFilesByMaskRadioButton;
        private System.Windows.Forms.RadioButton selectFilesInExplorerRadioButton;
        private System.Windows.Forms.Label selectMaskFileLabel;
        private System.Windows.Forms.ListBox selectedFilesListBox;
        private System.Windows.Forms.Button removePathFileButton;
    }
}

