using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsAppFigure
{
    public partial class Form1 : Form// Добавить на диаграмму
    {
        // Ссылка на обьект фигуры
        private RectangleOrParallelepiped currentFigure;
        private FileManager Manager;

        public Form1()
        {
            InitializeComponent();

            // Экземпляр класса фигуры
            currentFigure = new RectangleOrParallelepiped();

            Manager = new FileManager();

            RectangleOrParallelepiped.Test();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                labelError.Text = "";

                double l = double.Parse(textBoxlength.Text);
                double w = double.Parse(textBoxwidth.Text);
                // WFAF очень старый, WPF MAUI
                currentFigure.SetFigL(l);
                currentFigure.SetFigW(w);

                if (!string.IsNullOrWhiteSpace(textBoxheight.Text))
                {

                    double h = double.Parse(textBoxheight.Text);
                    currentFigure.SetFigH(h);

                    textBoxperimeter.Text = currentFigure.GetTwodPerimeter().ToString("F2");

                    textBoxsquare.Text = currentFigure.GetTreedVolume().ToString("F2");

                    labelsquare.Text = "Объём";
                }
                else
                {
                    textBoxperimeter.Text = currentFigure.GetTwodPerimeter().ToString("F2");

                    textBoxsquare.Text = currentFigure.GetTwodArea().ToString("F2");

                    labelsquare.Text = "Площадь";
                }
            }
            catch (FormatException)
            {
                //MessageBox.Show("Введи числа правильно");// менее навязчивое
                labelError.Text = "Ошибка: Введи числа правильно";

            }

            catch (ArgumentException ex)
            {
                labelError.Text = $"Ошибка: {ex.Message}";
            }
        }

        private void button2_Click(object sender, EventArgs e) // Квадрат
        {
            ClearAll();
            textBoxwidth.Text = "5";
            textBoxlength.Text = "5";
        }

        private void button3_Click(object sender, EventArgs e) // Куб
        {
            ClearAll();
            textBoxwidth.Text = "5";
            textBoxheight.Text = "5";
            textBoxlength.Text = "5";
        }

        private void button4_Click(object sender, EventArgs e) // Очистить
        {
            ClearAll();
        }

        private void ClearAll()
        {
            textBoxwidth.Clear();
            textBoxheight.Clear();
            textBoxlength.Clear();
            textBoxperimeter.Clear();
            textBoxsquare.Clear();
            labelsquare.Text = "Площадь/Объем";
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
            Manager.LoadElements(currentFigure, textBoxwidth, textBoxheight, textBoxlength);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
