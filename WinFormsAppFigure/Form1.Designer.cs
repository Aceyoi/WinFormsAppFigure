namespace WinFormsAppFigure
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttoncalculate = new Button();
            textBoxwidth = new TextBox();
            textBoxheight = new TextBox();
            textBoxlength = new TextBox();
            labelwidth = new Label();
            labelheight = new Label();
            labellength = new Label();
            textBoxperimeter = new TextBox();
            labelperimeter = new Label();
            ButtonFillRectangle = new Button();
            ButtonFillingParallelepiped = new Button();
            buttoncleaning = new Button();
            textBoxsquare = new TextBox();
            labelsquare = new Label();
            menuStrip1 = new MenuStrip();
            сохранитьОтветToolStripMenuItem = new ToolStripMenuItem();
            файлToolStripMenuItem1 = new ToolStripMenuItem();
            сохранитьДанныеToolStripMenuItem1 = new ToolStripMenuItem();
            сохранитьОтветToolStripMenuItem1 = new ToolStripMenuItem();
            загрузитьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            файлToolStripMenuItem = new ToolStripMenuItem();
            сохранитьДанныеToolStripMenuItem = new ToolStripMenuItem();
            заToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem1 = new ToolStripMenuItem();
            labelError = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttoncalculate
            // 
            buttoncalculate.Location = new Point(12, 239);
            buttoncalculate.Name = "buttoncalculate";
            buttoncalculate.Size = new Size(144, 23);
            buttoncalculate.TabIndex = 0;
            buttoncalculate.Text = "Вычислить";
            buttoncalculate.UseVisualStyleBackColor = true;
            buttoncalculate.Click += button1_Click;
            // 
            // textBoxwidth
            // 
            textBoxwidth.Location = new Point(12, 152);
            textBoxwidth.Name = "textBoxwidth";
            textBoxwidth.Size = new Size(100, 23);
            textBoxwidth.TabIndex = 1;
            // 
            // textBoxheight
            // 
            textBoxheight.Location = new Point(12, 181);
            textBoxheight.Name = "textBoxheight";
            textBoxheight.Size = new Size(100, 23);
            textBoxheight.TabIndex = 2;
            // 
            // textBoxlength
            // 
            textBoxlength.Location = new Point(12, 210);
            textBoxlength.Name = "textBoxlength";
            textBoxlength.Size = new Size(100, 23);
            textBoxlength.TabIndex = 3;
            // 
            // labelwidth
            // 
            labelwidth.AutoSize = true;
            labelwidth.Location = new Point(118, 155);
            labelwidth.Name = "labelwidth";
            labelwidth.Size = new Size(52, 15);
            labelwidth.TabIndex = 4;
            labelwidth.Text = "Ширина";
            // 
            // labelheight
            // 
            labelheight.AutoSize = true;
            labelheight.Location = new Point(118, 189);
            labelheight.Name = "labelheight";
            labelheight.Size = new Size(47, 15);
            labelheight.TabIndex = 5;
            labelheight.Text = "Высота";
            // 
            // labellength
            // 
            labellength.AutoSize = true;
            labellength.Location = new Point(118, 218);
            labellength.Name = "labellength";
            labellength.Size = new Size(42, 15);
            labellength.TabIndex = 6;
            labellength.Text = "Длина";
            // 
            // textBoxperimeter
            // 
            textBoxperimeter.Location = new Point(118, 300);
            textBoxperimeter.Name = "textBoxperimeter";
            textBoxperimeter.Size = new Size(100, 23);
            textBoxperimeter.TabIndex = 7;
            // 
            // labelperimeter
            // 
            labelperimeter.AutoSize = true;
            labelperimeter.Location = new Point(12, 303);
            labelperimeter.Name = "labelperimeter";
            labelperimeter.Size = new Size(63, 15);
            labelperimeter.TabIndex = 8;
            labelperimeter.Text = "Периметр";
            // 
            // ButtonFillRectangle
            // 
            ButtonFillRectangle.Location = new Point(12, 52);
            ButtonFillRectangle.Name = "ButtonFillRectangle";
            ButtonFillRectangle.Size = new Size(188, 23);
            ButtonFillRectangle.TabIndex = 9;
            ButtonFillRectangle.Text = "Данные для прямоугольника";
            ButtonFillRectangle.UseVisualStyleBackColor = true;
            ButtonFillRectangle.Click += button2_Click;
            // 
            // ButtonFillingParallelepiped
            // 
            ButtonFillingParallelepiped.Location = new Point(12, 81);
            ButtonFillingParallelepiped.Name = "ButtonFillingParallelepiped";
            ButtonFillingParallelepiped.Size = new Size(188, 23);
            ButtonFillingParallelepiped.TabIndex = 10;
            ButtonFillingParallelepiped.Text = "Данные для параллелепипеда";
            ButtonFillingParallelepiped.UseVisualStyleBackColor = true;
            ButtonFillingParallelepiped.Click += button3_Click;
            // 
            // buttoncleaning
            // 
            buttoncleaning.Location = new Point(12, 110);
            buttoncleaning.Name = "buttoncleaning";
            buttoncleaning.Size = new Size(188, 23);
            buttoncleaning.TabIndex = 11;
            buttoncleaning.Text = "Очистка";
            buttoncleaning.UseVisualStyleBackColor = true;
            buttoncleaning.Click += button4_Click;
            // 
            // textBoxsquare
            // 
            textBoxsquare.Location = new Point(118, 329);
            textBoxsquare.Name = "textBoxsquare";
            textBoxsquare.Size = new Size(100, 23);
            textBoxsquare.TabIndex = 12;
            // 
            // labelsquare
            // 
            labelsquare.AutoSize = true;
            labelsquare.Location = new Point(12, 332);
            labelsquare.Name = "labelsquare";
            labelsquare.Size = new Size(102, 15);
            labelsquare.TabIndex = 13;
            labelsquare.Text = "Площадь/Объем";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { сохранитьОтветToolStripMenuItem, файлToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(276, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // сохранитьОтветToolStripMenuItem
            // 
            сохранитьОтветToolStripMenuItem.Name = "сохранитьОтветToolStripMenuItem";
            сохранитьОтветToolStripMenuItem.Size = new Size(12, 20);
            // 
            // файлToolStripMenuItem1
            // 
            файлToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { сохранитьДанныеToolStripMenuItem1, сохранитьОтветToolStripMenuItem1, загрузитьToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            файлToolStripMenuItem1.Size = new Size(48, 20);
            файлToolStripMenuItem1.Text = "Файл";
            // 
            // сохранитьДанныеToolStripMenuItem1
            // 
            сохранитьДанныеToolStripMenuItem1.Name = "сохранитьДанныеToolStripMenuItem1";
            сохранитьДанныеToolStripMenuItem1.Size = new Size(176, 22);
            сохранитьДанныеToolStripMenuItem1.Text = "Сохранить данные";
            сохранитьДанныеToolStripMenuItem1.Click += сохранитьДанныеToolStripMenuItem1_Click;
            // 
            // сохранитьОтветToolStripMenuItem1
            // 
            сохранитьОтветToolStripMenuItem1.Name = "сохранитьОтветToolStripMenuItem1";
            сохранитьОтветToolStripMenuItem1.Size = new Size(176, 22);
            сохранитьОтветToolStripMenuItem1.Text = "Сохранить ответ";
            сохранитьОтветToolStripMenuItem1.Click += сохранитьОтветToolStripMenuItem1_Click;
            // 
            // загрузитьToolStripMenuItem
            // 
            загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            загрузитьToolStripMenuItem.Size = new Size(176, 22);
            загрузитьToolStripMenuItem.Text = "Загрузить";
            загрузитьToolStripMenuItem.Click += загрузитьToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(176, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(180, 22);
            файлToolStripMenuItem.Text = "Сохранить ответ";
            // 
            // сохранитьДанныеToolStripMenuItem
            // 
            сохранитьДанныеToolStripMenuItem.Name = "сохранитьДанныеToolStripMenuItem";
            сохранитьДанныеToolStripMenuItem.Size = new Size(180, 22);
            сохранитьДанныеToolStripMenuItem.Text = "Сохранить данные";
            // 
            // заToolStripMenuItem
            // 
            заToolStripMenuItem.Name = "заToolStripMenuItem";
            заToolStripMenuItem.Size = new Size(180, 22);
            заToolStripMenuItem.Text = "Загрузить";
            // 
            // выходToolStripMenuItem1
            // 
            выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            выходToolStripMenuItem1.Size = new Size(180, 22);
            выходToolStripMenuItem1.Text = "Выход";
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(12, 274);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 15);
            labelError.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 450);
            Controls.Add(labelError);
            Controls.Add(menuStrip1);
            Controls.Add(labelsquare);
            Controls.Add(textBoxsquare);
            Controls.Add(buttoncleaning);
            Controls.Add(ButtonFillingParallelepiped);
            Controls.Add(ButtonFillRectangle);
            Controls.Add(labelperimeter);
            Controls.Add(textBoxperimeter);
            Controls.Add(labellength);
            Controls.Add(labelheight);
            Controls.Add(labelwidth);
            Controls.Add(textBoxlength);
            Controls.Add(textBoxheight);
            Controls.Add(textBoxwidth);
            Controls.Add(buttoncalculate);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "RectangleOrParallelepiped";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttoncalculate;
        private TextBox textBoxwidth;
        private TextBox textBoxheight;
        private TextBox textBoxlength;
        private Label labelwidth;
        private Label labelheight;
        private Label labellength;
        private TextBox textBoxperimeter;
        private Label labelperimeter;
        private Button ButtonFillRectangle;
        private Button ButtonFillingParallelepiped;
        private Button buttoncleaning;
        private TextBox textBoxsquare;
        private Label labelsquare;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem сохранитьОтветToolStripMenuItem;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранитьДанныеToolStripMenuItem;
        private ToolStripMenuItem заToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem1;
        private ToolStripMenuItem файлToolStripMenuItem1;
        private ToolStripMenuItem сохранитьДанныеToolStripMenuItem1;
        private ToolStripMenuItem сохранитьОтветToolStripMenuItem1;
        private ToolStripMenuItem загрузитьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Label labelError;
    }
}
