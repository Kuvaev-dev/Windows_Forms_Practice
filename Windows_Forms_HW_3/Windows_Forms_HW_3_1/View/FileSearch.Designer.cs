using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Windows_Forms_HW_3_1
{
    partial class FileSearch
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FileSearch));
            statusStrip1 = new StatusStrip();
            file_path = new ToolStripStatusLabel();
            label1 = new Label();
            masks = new TextBox();
            start_search = new Button();
            open_folder = new Button();
            sf_lb_files = new ListBox();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { file_path });
            statusStrip1.Location = new Point(0, 360);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(370, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 0;
            // 
            // sf_st_path
            // 
            file_path.DisplayStyle = ToolStripItemDisplayStyle.Text;
            file_path.Font = new Font("Segoe UI", 12F);
            file_path.Name = "path";
            file_path.Size = new Size(0, 17);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14);
            label1.Location = new Point(65, 18);
            label1.Name = "label1";
            label1.Size = new Size(132, 24);
            label1.TabIndex = 2;
            label1.Text = "Маска поиска";
            // 
            // sf_tb_masks
            // 
            masks.Enabled = false;
            masks.Font = new Font("Microsoft Sans Serif", 14);
            masks.Location = new Point(202, 15);
            masks.Name = "masks";
            masks.Size = new Size(100, 29);
            masks.TabIndex = 3;
            // 
            // sf_b_startSearch
            // 
            start_search.Enabled = false;
            start_search.Location = new Point(311, 11);
            start_search.Name = "startSearch";
            start_search.Size = new Size(49, 36);
            start_search.TabIndex = 4;
            start_search.UseVisualStyleBackColor = true;
            // 
            // sf_b_openFolder
            // 
            open_folder.Location = new Point(12, 12);
            open_folder.Name = "sf_b_openFolder";
            open_folder.Size = new Size(46, 35);
            open_folder.TabIndex = 1;
            open_folder.UseVisualStyleBackColor = true;
            // 
            // sf_lb_files
            // 
            sf_lb_files.Enabled = false;
            sf_lb_files.FormattingEnabled = true;
            sf_lb_files.Location = new Point(12, 56);
            sf_lb_files.Name = "sf_lb_files";
            sf_lb_files.Size = new Size(346, 290);
            sf_lb_files.TabIndex = 5;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(370, 382);
            Controls.Add(sf_lb_files);
            Controls.Add(start_search);
            Controls.Add(masks);
            Controls.Add(label1);
            Controls.Add(open_folder);
            Controls.Add(statusStrip1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileSearch";
            this.Text = "Окно поиска";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel file_path;
        private Button open_folder;
        private Label label1;
        private TextBox masks;
        private Button start_search;
        private ListBox sf_lb_files;
    }
}