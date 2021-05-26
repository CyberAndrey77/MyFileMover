
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
            this.selectedFilesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selectMaskFileButton = new System.Windows.Forms.Button();
            this.selectMaskFileTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sourcePathExplorerButton
            // 
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
            this.moverButton.Location = new System.Drawing.Point(648, 240);
            this.moverButton.Name = "moverButton";
            this.moverButton.Size = new System.Drawing.Size(120, 28);
            this.moverButton.TabIndex = 6;
            this.moverButton.Text = "Перенести";
            this.moverButton.UseVisualStyleBackColor = true;
            this.moverButton.Click += new System.EventHandler(this.moverButton_Click);
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(51, 240);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(120, 28);
            this.selectFileButton.TabIndex = 7;
            this.selectFileButton.Text = "Выбор файлов";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // selectedFilesRichTextBox
            // 
            this.selectedFilesRichTextBox.Location = new System.Drawing.Point(51, 275);
            this.selectedFilesRichTextBox.Name = "selectedFilesRichTextBox";
            this.selectedFilesRichTextBox.Size = new System.Drawing.Size(570, 163);
            this.selectedFilesRichTextBox.TabIndex = 8;
            this.selectedFilesRichTextBox.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // selectMaskFileButton
            // 
            this.selectMaskFileButton.Location = new System.Drawing.Point(200, 240);
            this.selectMaskFileButton.Name = "selectMaskFileButton";
            this.selectMaskFileButton.Size = new System.Drawing.Size(182, 28);
            this.selectMaskFileButton.TabIndex = 9;
            this.selectMaskFileButton.Text = "Выбрать маску файла";
            this.selectMaskFileButton.UseVisualStyleBackColor = true;
            this.selectMaskFileButton.Click += new System.EventHandler(this.selectMaskFileButton_Click);
            // 
            // selectMaskFileTextBox
            // 
            this.selectMaskFileTextBox.Location = new System.Drawing.Point(402, 243);
            this.selectMaskFileTextBox.Name = "selectMaskFileTextBox";
            this.selectMaskFileTextBox.Size = new System.Drawing.Size(219, 22);
            this.selectMaskFileTextBox.TabIndex = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectMaskFileTextBox);
            this.Controls.Add(this.selectMaskFileButton);
            this.Controls.Add(this.selectedFilesRichTextBox);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.moverButton);
            this.Controls.Add(this.finalPathTextBox);
            this.Controls.Add(this.sourcePathTextBox);
            this.Controls.Add(this.finalPathExplorerButton);
            this.Controls.Add(this.finalPathLabel);
            this.Controls.Add(this.sourcePathLabel);
            this.Controls.Add(this.sourcePathExplorerButton);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "MainWindow";
            this.Text = "FileMover";
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
        private System.Windows.Forms.RichTextBox selectedFilesRichTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button selectMaskFileButton;
        private System.Windows.Forms.TextBox selectMaskFileTextBox;
    }
}

