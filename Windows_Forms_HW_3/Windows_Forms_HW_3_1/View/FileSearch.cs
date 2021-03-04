using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Windows_Forms_HW_3_1
{
    public partial class FileSearch : Form
    {
        public FileSearch()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            open_folder.Click += open_folder_Click;

            masks.TextChanged += masks_TextChanged;

            start_search.Click += start_search_Click;
        }

        /// <summary>
        /// Запуск процедуры поиска файлов
        /// </summary>
        
        private void start_search_Click(object sender, EventArgs e)
        {
            sf_lb_files.Items.Clear(); 

            String[] _masks = masks.Text.Split('.').ToArray(); 

            if (_masks.Count() != 2 || _masks[1] == "")
            {
                MessageBox.Show("Вы ввели неправильную маску.\rМаска должна быть вида *.*",
                    "Ошибка ввода маски!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                sf_lb_files.Cursor = Cursors.WaitCursor;
                this.Cursor = Cursors.WaitCursor;

                foreach (var file in Directory.GetFiles(file_path.Text, masks.Text))
                {
                    sf_lb_files.Items.Add(file.ToString());
                }

                MessageBox.Show("Нашлось " + sf_lb_files.Items.Count.ToString() + " файлов", "Результат добавления", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Cursor = Cursors.Default;
                sf_lb_files.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Изменение текста в поле для ввода маски
        /// </summary>
        
        private void masks_TextChanged(object sender, EventArgs e)
        {
            if (masks.Text.Length > 0)
            {
                start_search.Enabled = true;
            }
            else
            {
                start_search.Enabled = false;
            }
        }

        /// <summary>
        /// При нажатии на кнопку открывется диалог выбора папки для поиска файла
        /// </summary>
        
        private void open_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dir = new FolderBrowserDialog();
            dir.ShowNewFolderButton = false; 

            if (dir.ShowDialog() == DialogResult.OK)
            {

                file_path.Text = dir.SelectedPath;
                masks.Enabled = true;
                masks.Focus();
            }
            else
            {
                dir = null;
                file_path.Text = "";
                masks.Text = "";
                if (masks.Enabled)
                {
                    masks.Enabled = false;
                }
            }
        }
    }
}
