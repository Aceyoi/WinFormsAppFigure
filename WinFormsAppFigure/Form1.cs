using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsAppFigure
{
    public partial class Form1 : Form
    {
        private RectangleOrParallelepiped currentFigure;
        private FileManager Manager;

        public Form1()
        {
            InitializeComponent();
            currentFigure = new RectangleOrParallelepiped();
            Manager = new FileManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double l = double.Parse(textBox1.Text);
                double w = double.Parse(textBox2.Text);

                currentFigure.SetFigL(l);
                currentFigure.SetFigW(w);

                if (!string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    double h = double.Parse(textBox3.Text);
                    currentFigure.SetFigH(h);

                    double surfaceArea = 2 * (l * w + l * h + w * h);
                    textBox4.Text = surfaceArea.ToString("F2");

                    textBox5.Text = (l * w * h).ToString("F2");
                    label5.Text = "Объём";
                }
                else
                {
                    double perimeter = 2 * (l + w);
                    double area = l * w;
                    textBox4.Text = area.ToString("F2");
                    textBox5.Text = area.ToString("F2");
                    label5.Text = "Площадь";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введи числа правильно");
            }
        }

        private void button2_Click(object sender, EventArgs e) // Квадрат
        {
            ClearAll();
            textBox1.Text = "5";
            textBox2.Text = "5";
        }

        private void button3_Click(object sender, EventArgs e) // Куб
        {
            ClearAll();
            textBox1.Text = "5";
            textBox2.Text = "5";
            textBox3.Text = "5";
        }

        private void button4_Click(object sender, EventArgs e) // Очистить
        {
            ClearAll();
        }

        private void ClearAll()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            label5.Text = "Площадь/Объем";
        }

        // Обработка кнопки выхода
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Обработка кнопки сохранения данных в файл
        private void сохранитьДанныеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Указывает на путь и название будущего файла
            string path = Path.Combine(Application.StartupPath, "данные.txt");
            Manager.SaveFileElements(currentFigure, path);
        }

        // Обработка кнопки сохранения результата в файл
        private void сохранитьОтветToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Указывает на путь и название будущего файла
            string path = Path.Combine(Application.StartupPath, "результаты.txt");
            Manager.SaveFileSolution(currentFigure, path);
        }

        // Обработка кнопки загрузки данных из файла
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager.LoadElements(currentFigure, textBox1, textBox2, textBox3);
        }
    }
}
