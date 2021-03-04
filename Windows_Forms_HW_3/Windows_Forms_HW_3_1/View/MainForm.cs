using System;
using System.Windows.Forms;

namespace Windows_Forms_HW_3_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            form_close.Click += File_close_Click;
            file_search.Click += File_search_Click;
        }

        private void File_search_Click(object sender, EventArgs e)
        {
            FileSearch fs = new FileSearch();
            fs.Show();
        }

        private void File_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
