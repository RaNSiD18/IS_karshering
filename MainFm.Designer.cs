
namespace IS_SERYAKOV
{
    partial class MainFm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьТаблицуКлиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьТаблицуАвтомобилиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьТаблицуВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьСписокСвободныхМашинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьСписокАвтомобилейНаходящихсяВРемонтеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьРейтингЧастоИспользуемыхАвтомобилейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьОтчетАрендованныхАвтомобилейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьСписокСвободныхАвтмообилейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.редактироватьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.загрузитьТаблицуКлиентыToolStripMenuItem,
            this.загрузитьТаблицуАвтомобилиToolStripMenuItem,
            this.сохранитьТаблицуВExcelToolStripMenuItem,
            this.редактироватьТаблицуToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.открытьToolStripMenuItem.Text = "Открыть excel файл";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // загрузитьТаблицуКлиентыToolStripMenuItem
            // 
            this.загрузитьТаблицуКлиентыToolStripMenuItem.Name = "загрузитьТаблицуКлиентыToolStripMenuItem";
            this.загрузитьТаблицуКлиентыToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.загрузитьТаблицуКлиентыToolStripMenuItem.Text = "Загрузить таблицу \"Клиенты\"";
            this.загрузитьТаблицуКлиентыToolStripMenuItem.Click += new System.EventHandler(this.загрузитьТаблицуКлиентыToolStripMenuItem_Click);
            // 
            // загрузитьТаблицуАвтомобилиToolStripMenuItem
            // 
            this.загрузитьТаблицуАвтомобилиToolStripMenuItem.Name = "загрузитьТаблицуАвтомобилиToolStripMenuItem";
            this.загрузитьТаблицуАвтомобилиToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.загрузитьТаблицуАвтомобилиToolStripMenuItem.Text = "Загрузить таблицу \"Автомобили\"";
            this.загрузитьТаблицуАвтомобилиToolStripMenuItem.Click += new System.EventHandler(this.загрузитьТаблицуАвтомобилиToolStripMenuItem_Click);
            // 
            // сохранитьТаблицуВExcelToolStripMenuItem
            // 
            this.сохранитьТаблицуВExcelToolStripMenuItem.Name = "сохранитьТаблицуВExcelToolStripMenuItem";
            this.сохранитьТаблицуВExcelToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.сохранитьТаблицуВExcelToolStripMenuItem.Text = "Сохранить таблицу в Excel";
            this.сохранитьТаблицуВExcelToolStripMenuItem.Click += new System.EventHandler(this.сохранитьТаблицуВExcelToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сформироватьСписокСвободныхМашинToolStripMenuItem,
            this.сформироватьСписокАвтомобилейНаходящихсяВРемонтеToolStripMenuItem,
            this.сформироватьРейтингЧастоИспользуемыхАвтомобилейToolStripMenuItem,
            this.сформироватьОтчетАрендованныхАвтомобилейToolStripMenuItem,
            this.сформироватьСписокСвободныхАвтмообилейToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // сформироватьСписокСвободныхМашинToolStripMenuItem
            // 
            this.сформироватьСписокСвободныхМашинToolStripMenuItem.Name = "сформироватьСписокСвободныхМашинToolStripMenuItem";
            this.сформироватьСписокСвободныхМашинToolStripMenuItem.Size = new System.Drawing.Size(416, 22);
            this.сформироватьСписокСвободныхМашинToolStripMenuItem.Text = "Сформировать список свободных машин";
            this.сформироватьСписокСвободныхМашинToolStripMenuItem.Click += new System.EventHandler(this.сформироватьСписокСвободныхМашинToolStripMenuItem_Click);
            // 
            // сформироватьСписокАвтомобилейНаходящихсяВРемонтеToolStripMenuItem
            // 
            this.сформироватьСписокАвтомобилейНаходящихсяВРемонтеToolStripMenuItem.Name = "сформироватьСписокАвтомобилейНаходящихсяВРемонтеToolStripMenuItem";
            this.сформироватьСписокАвтомобилейНаходящихсяВРемонтеToolStripMenuItem.Size = new System.Drawing.Size(416, 22);
            this.сформироватьСписокАвтомобилейНаходящихсяВРемонтеToolStripMenuItem.Text = "Сформировать список автомобилей, находящихся в ремонте";
            this.сформироватьСписокАвтомобилейНаходящихсяВРемонтеToolStripMenuItem.Click += new System.EventHandler(this.сформироватьСписокАвтомобилейНаходящихсяВРемонтеToolStripMenuItem_Click);
            // 
            // сформироватьРейтингЧастоИспользуемыхАвтомобилейToolStripMenuItem
            // 
            this.сформироватьРейтингЧастоИспользуемыхАвтомобилейToolStripMenuItem.Name = "сформироватьРейтингЧастоИспользуемыхАвтомобилейToolStripMenuItem";
            this.сформироватьРейтингЧастоИспользуемыхАвтомобилейToolStripMenuItem.Size = new System.Drawing.Size(416, 22);
            this.сформироватьРейтингЧастоИспользуемыхАвтомобилейToolStripMenuItem.Text = "Сформировать рейтинг, часто используемых автомобилей";
            // 
            // сформироватьОтчетАрендованныхАвтомобилейToolStripMenuItem
            // 
            this.сформироватьОтчетАрендованныхАвтомобилейToolStripMenuItem.Name = "сформироватьОтчетАрендованныхАвтомобилейToolStripMenuItem";
            this.сформироватьОтчетАрендованныхАвтомобилейToolStripMenuItem.Size = new System.Drawing.Size(416, 22);
            this.сформироватьОтчетАрендованныхАвтомобилейToolStripMenuItem.Text = "Сформировать отчет арендованных автомобилей";
            // 
            // сформироватьСписокСвободныхАвтмообилейToolStripMenuItem
            // 
            this.сформироватьСписокСвободныхАвтмообилейToolStripMenuItem.Name = "сформироватьСписокСвободныхАвтмообилейToolStripMenuItem";
            this.сформироватьСписокСвободныхАвтмообилейToolStripMenuItem.Size = new System.Drawing.Size(416, 22);
            this.сформироватьСписокСвободныхАвтмообилейToolStripMenuItem.Text = "Сформировать список арендованных автомобилей";
            this.сформироватьСписокСвободныхАвтмообилейToolStripMenuItem.Click += new System.EventHandler(this.сформироватьСписокСвободныхАвтмообилейToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(33, 22);
            this.toolStripLabel1.Text = "Лист";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 401);
            this.dataGridView1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel|*.xlsx";
            // 
            // редактироватьТаблицуToolStripMenuItem
            // 
            this.редактироватьТаблицуToolStripMenuItem.Name = "редактироватьТаблицуToolStripMenuItem";
            this.редактироватьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.редактироватьТаблицуToolStripMenuItem.Text = "Редактировать таблицу";
            this.редактироватьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.редактироватьТаблицуToolStripMenuItem_Click);
            // 
            // MainFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ИС Каршеринг";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьТаблицуКлиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьТаблицуАвтомобилиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьСписокСвободныхМашинToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьСписокАвтомобилейНаходящихсяВРемонтеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьРейтингЧастоИспользуемыхАвтомобилейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьОтчетАрендованныхАвтомобилейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьСписокСвободныхАвтмообилейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьТаблицуВExcelToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьТаблицуToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}