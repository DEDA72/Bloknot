
namespace Bloknot
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File_ = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.NewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.WYDall = new System.Windows.Forms.ToolStripMenuItem();
            this.DateAndTime = new System.Windows.Forms.ToolStripMenuItem();
            this.Format = new System.Windows.Forms.ToolStripMenuItem();
            this.Font = new System.Windows.Forms.ToolStripMenuItem();
            this.View = new System.Windows.Forms.ToolStripMenuItem();
            this.Strip = new System.Windows.Forms.ToolStripMenuItem();
            this.Spravka = new System.Windows.Forms.ToolStripMenuItem();
            this.Progg = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(0, 27);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(583, 398);
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_,
            this.Edit,
            this.Format,
            this.View,
            this.Spravka});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File_
            // 
            this.File_.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFile,
            this.NewWindow,
            this.Open,
            this.Save,
            this.Exit});
            this.File_.Name = "File_";
            this.File_.Size = new System.Drawing.Size(48, 20);
            this.File_.Text = "Файл";
            // 
            // NewFile
            // 
            this.NewFile.Name = "NewFile";
            this.NewFile.ShortcutKeyDisplayString = "Ctrl+N";
            this.NewFile.Size = new System.Drawing.Size(214, 22);
            this.NewFile.Text = "Новый файл";
            this.NewFile.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // NewWindow
            // 
            this.NewWindow.Name = "NewWindow";
            this.NewWindow.ShortcutKeyDisplayString = "Ctrl+Shift+N";
            this.NewWindow.Size = new System.Drawing.Size(214, 22);
            this.NewWindow.Text = "Новое окно";
            this.NewWindow.Click += new System.EventHandler(this.NewWindow_Click);
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.ShortcutKeyDisplayString = "Ctrl+O";
            this.Open.Size = new System.Drawing.Size(214, 22);
            this.Open.Text = "Открыть";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.ShortcutKeyDisplayString = "Ctrl+S";
            this.Save.Size = new System.Drawing.Size(214, 22);
            this.Save.Text = "Сохранить";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(214, 22);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Edit
            // 
            this.Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cancel,
            this.Copy,
            this.Insert,
            this.Delete,
            this.WYDall,
            this.DateAndTime});
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(59, 20);
            this.Edit.Text = "Правка";
            // 
            // Cancel
            // 
            this.Cancel.Name = "Cancel";
            this.Cancel.ShortcutKeyDisplayString = "Ctrl+Z";
            this.Cancel.Size = new System.Drawing.Size(190, 22);
            this.Cancel.Text = "Отменить";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Copy
            // 
            this.Copy.Name = "Copy";
            this.Copy.ShortcutKeyDisplayString = "Ctrl+C";
            this.Copy.Size = new System.Drawing.Size(190, 22);
            this.Copy.Text = "Копировать";
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Insert
            // 
            this.Insert.Name = "Insert";
            this.Insert.ShortcutKeyDisplayString = "Ctrl+V";
            this.Insert.Size = new System.Drawing.Size(190, 22);
            this.Insert.Text = "Вставить";
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.ShortcutKeyDisplayString = "Del";
            this.Delete.Size = new System.Drawing.Size(190, 22);
            this.Delete.Text = "Удалить";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // WYDall
            // 
            this.WYDall.Name = "WYDall";
            this.WYDall.ShortcutKeyDisplayString = "Ctrl+A";
            this.WYDall.Size = new System.Drawing.Size(190, 22);
            this.WYDall.Text = "Выделить все";
            this.WYDall.Click += new System.EventHandler(this.WYDall_Click);
            // 
            // DateAndTime
            // 
            this.DateAndTime.Name = "DateAndTime";
            this.DateAndTime.ShortcutKeyDisplayString = "F5";
            this.DateAndTime.Size = new System.Drawing.Size(190, 22);
            this.DateAndTime.Text = "Дата и время";
            this.DateAndTime.Click += new System.EventHandler(this.DateAndTime_Click);
            // 
            // Format
            // 
            this.Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Font});
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(62, 20);
            this.Format.Text = "Формат";
            // 
            // Font
            // 
            this.Font.Name = "Font";
            this.Font.Size = new System.Drawing.Size(180, 22);
            this.Font.Text = "Шрифт";
            this.Font.Click += new System.EventHandler(this.Font_Click);
            // 
            // View
            // 
            this.View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Strip});
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(39, 20);
            this.View.Text = "Вид";
            // 
            // Strip
            // 
            this.Strip.Checked = true;
            this.Strip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Strip.Name = "Strip";
            this.Strip.Size = new System.Drawing.Size(180, 22);
            this.Strip.Text = "Строка состояния";
            this.Strip.Click += new System.EventHandler(this.Strip_Click);
            // 
            // Spravka
            // 
            this.Spravka.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Progg});
            this.Spravka.Name = "Spravka";
            this.Spravka.Size = new System.Drawing.Size(65, 20);
            this.Spravka.Text = "Справка";
            // 
            // Progg
            // 
            this.Progg.Name = "Progg";
            this.Progg.Size = new System.Drawing.Size(180, 22);
            this.Progg.Text = "О программе";
            this.Progg.Click += new System.EventHandler(this.Progg_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(583, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(73, 19);
            this.toolStripStatusLabel1.Text = "Символы 0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(95, 19);
            this.toolStripStatusLabel2.Text = "Windows(CRLF)";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(42, 19);
            this.toolStripStatusLabel3.Text = "UTF-8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem File_;
        private System.Windows.Forms.ToolStripMenuItem NewFile;
        private System.Windows.Forms.ToolStripMenuItem NewWindow;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem Cancel;
        private System.Windows.Forms.ToolStripMenuItem Copy;
        private System.Windows.Forms.ToolStripMenuItem Insert;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem Format;
        private System.Windows.Forms.ToolStripMenuItem Font;
        private System.Windows.Forms.ToolStripMenuItem View;
        private System.Windows.Forms.ToolStripMenuItem Strip;
        private System.Windows.Forms.ToolStripMenuItem WYDall;
        private System.Windows.Forms.ToolStripMenuItem DateAndTime;
        private System.Windows.Forms.ToolStripMenuItem Spravka;
        private System.Windows.Forms.ToolStripMenuItem Progg;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

