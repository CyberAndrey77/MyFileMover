using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FileMover
{
    public partial class MainWindow : Form
    {
        private List<string> _filePaths = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchDirectoryPath(Control textBox)
        {
            var result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBox.Text = folderBrowserDialog1.SelectedPath;
            }

            return;
        }

        private void sourcePathExplorerButton_Click(object sender, EventArgs e)
        {
            SearchDirectoryPath(sourcePathTextBox);
        }

        private void finalPathExplorerButton_Click(object sender, EventArgs e)
        {
            SearchDirectoryPath(finalPathTextBox);
        }

        private void moverButton_Click(object sender, EventArgs e)
        {
            if (_filePaths.Count == 0)
            {
                return;
            }

            var targetDirectoryPath = finalPathTextBox.Text;

            if (!System.IO.Directory.Exists(targetDirectoryPath))
            {
                var result = MessageBox.Show
                (
                    "Не удаётся найти папку, создать папку?", 
                    "Нет папки!", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Exclamation
                 );

                if (result == DialogResult.OK)
                {
                    System.IO.Directory.CreateDirectory(targetDirectoryPath);
                }
                else
                {
                    return;
                }
            }

            foreach (var filePath in _filePaths)
            {
                var fileName = System.IO.Path.GetFileName(filePath);
                var targetFile = System.IO.Path.Combine(targetDirectoryPath, fileName);

                System.IO.File.Move(filePath, targetFile);
            }
            _filePaths.Clear();
            selectedFilesRichTextBox.Text = string.Empty;
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.InitialDirectory = sourcePathTextBox.Text;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (var fileName in openFileDialog1.FileNames)
                {
                    if (!selectedFilesRichTextBox.Text.Contains(fileName))
                    {
                        selectedFilesRichTextBox.Text += $"{fileName} \n";
                        _filePaths.Add(fileName);
                    }
                }
            }
        }

        private void selectMaskFileButton_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(sourcePathTextBox.Text))
            {
                selectedFilesRichTextBox.Text = "Не выбран путь!";
                selectedFilesRichTextBox.ForeColor = Color.Brown;
                return;
            }

            if (selectedFilesRichTextBox.Text.Contains("Не выбран путь!"))
            {
                selectedFilesRichTextBox.Text = string.Empty;
                selectedFilesRichTextBox.ForeColor = Color.Black;
            }

            if (_filePaths.Count == 0)
            {
                _filePaths = System.IO.Directory.GetFiles(sourcePathTextBox.Text, selectMaskFileTextBox.Text).ToList();
            }
            else
            {
                string [] files = System.IO.Directory.GetFiles(sourcePathTextBox.Text, selectMaskFileTextBox.Text);
                foreach (var file in files)
                {
                    _filePaths.Add(file);
                }
            }
            

            foreach (var fileName in _filePaths)
            {
                if (!selectedFilesRichTextBox.Text.Contains(fileName))
                {
                    selectedFilesRichTextBox.Text += $"{fileName} \n";
                }
            }
        }
    }
}
