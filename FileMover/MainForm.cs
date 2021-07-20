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
        private bool _isSelectFilesInExplorer;
        private string _fileMask;
        private bool _isSelectFilesByMask;
        public MainWindow()
        {
            InitializeComponent();
            selectFilesInExplorerRadioButton.Checked = true;

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

        /// <summary>
        /// Добавляет пути к файлам в ListBox и в _fileList.
        /// </summary>
        /// <param name="files"> пути к файлам в строковом массиве</param>
        private void AddToLists(string[] files)
        {
            foreach (var file in files)
            {
                if (!selectedFilesListBox.Items.Contains(file))
                {
                    selectedFilesListBox.Items.Add(file);
                    _filePaths.Add(file);
                }
            }
        }

        private void sourcePathExplorerButton_Click(object sender, EventArgs e)
        {
            sourcePathTextBox.ForeColor = Color.Black;
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
            if (targetDirectoryPath == string.Empty)
            {
                MessageBox.Show
                (
                   "Не указан путь куда перенести файлы!",
                   "Не выбран путь!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation
                );
                return;
            }

            if (targetDirectoryPath == sourcePathTextBox.Text)
            {
                MessageBox.Show
                (
                   "Пути совпадают!",
                   "Ошибка путей!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation
                );
                return;
            }

            try
            {
                if (!System.IO.Directory.Exists(targetDirectoryPath))
                {
                    var result = MessageBox.Show
                    (
                        "Не удаётся найти папку, создать папку?",
                        "Нет папки!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation
                     );

                    if (result == DialogResult.Yes)
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
                selectedFilesListBox.Items.Clear();

                MessageBox.Show("Файлы успешно перенесены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            if (_isSelectFilesByMask)
            {
                string[] files = System.IO.Directory.GetFiles(sourcePathTextBox.Text, _fileMask);
                AddToLists(files);
                return;
            }

            openFileDialog1.Multiselect = true;
            openFileDialog1.InitialDirectory = sourcePathTextBox.Text;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] files = openFileDialog1.FileNames;
                AddToLists(files);
            }
        }

        /// <summary>
        /// Записывает маску файла в переменную.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectMaskFileButton_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(sourcePathTextBox.Text))
            {
                MessageBox.Show
                (
                   "Не указан путь откуда перенести файлы!",
                   "Не выбран путь!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation
                );
                return;
            }

            _fileMask = selectMaskFileTextBox.Text;
        }

        private void selectFilesInExplorerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _isSelectFilesInExplorer = true;
            _isSelectFilesByMask = false;
            selectMaskFileButton.Enabled = false;
            selectMaskFileTextBox.Enabled = false;
        }

        private void selectFilesByMaskRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _isSelectFilesInExplorer = false;
            _isSelectFilesByMask = true;
            selectMaskFileButton.Enabled = true;
            selectMaskFileTextBox.Enabled = true;
        }

        /// <summary>
        /// Удаляет путь из списков ListBox и _filePath.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removePathFileButton_Click(object sender, EventArgs e)
        {
            if (selectedFilesListBox.SelectedIndex < 0)
            {
                return;
            }

            _filePaths.RemoveAt(selectedFilesListBox.SelectedIndex);
            selectedFilesListBox.Items.RemoveAt(selectedFilesListBox.SelectedIndex);
        }
    }
}
