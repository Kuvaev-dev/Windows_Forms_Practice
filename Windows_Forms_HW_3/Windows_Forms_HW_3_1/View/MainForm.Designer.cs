using System.Windows.Forms;
using System.Drawing;

namespace Windows_Forms_HW_3_1
{
    partial class MainForm
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
            file_search = new Button();
            form_close = new Button();
            SuspendLayout();
            // 
            // file_search
            // 
            file_search.FlatStyle = FlatStyle.Flat;
            file_search.Font = new Font("Microsoft Sans Serif", 14F);
            file_search.Location = new Point(12, 12);
            file_search.Name = "search";
            file_search.Size = new Size(235, 38);
            file_search.Text = "&Окно поиска";
            file_search.BackColor = Color.Green;
            file_search.UseVisualStyleBackColor = true;
            // 
            // form_close
            // 
            form_close.FlatStyle = FlatStyle.Flat;
            form_close.Font = new Font("Microsoft Sans Serif", 14);
            form_close.Location = new Point(257, 12);
            form_close.Name = "mf_b_close";
            form_close.Size = new Size(239, 38);
            form_close.Text = "&Закрыть";
            form_close.BackColor = Color.Red;
            form_close.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(507, 62);
            this.ControlBox = false;
            this.Controls.Add(form_close);
            this.Controls.Add(file_search);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            ResumeLayout(false);

        }
        private Button file_search;
        private Button form_close;
        #endregion
    }
}

