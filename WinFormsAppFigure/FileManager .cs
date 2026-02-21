using System;
using System.IO;
using System.Windows.Forms;
using System.Text;

namespace WinFormsAppFigure
{
    internal class FileManager
    {
        public string CurrentFilePath { get; private set; } = "";
        private readonly string baseDir = Application.StartupPath;
        private readonly string dataFile = "данные.txt";

        // Сохранение размеров фигуры
        public void SaveFileElements(RectangleOrParallelepiped fig, string path)
        {
            try
            {
                using (var writer = new StreamWriter(path, false, Encoding.UTF8))
                {
                    if (fig.GetHeight() == 0)
                        writer.WriteLine($"{fig.GetWidth():F2} {fig.GetLength():F2}");
                    else
                        writer.WriteLine($"{fig.GetWidth():F2} {fig.GetLength():F2} {fig.GetHeight():F2}");
                }
                MessageBox.Show($"Сохранено в {Path.GetFileName(path)}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        // Сохранение результатов расчётов
        public void SaveFileSolution(RectangleOrParallelepiped fig, string path)
        {
            try
            {
                using (var writer = new StreamWriter(path, false, Encoding.UTF8))
                {
                    if (fig.GetHeight() == 0)
                        writer.WriteLine($"{fig.GetTwodPerimeter():F2} {fig.GetTwodArea():F2}");
                    else
                        writer.WriteLine($"{fig.GetTreedPerimeter():F2} {fig.GetTreedVolume():F2}");
                }
                MessageBox.Show($"Сохранено в {Path.GetFileName(path)}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        // Загрузка размеров из данные.txt в фигуру и контролы
        public bool LoadElements(RectangleOrParallelepiped fig, TextBox tbLength, TextBox tbWidth, TextBox tbHeight)
        {
            string path = Path.Combine(baseDir, dataFile);
            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show("Файл данные.txt не найден");
                    return false;
                }

                string[] lines = File.ReadAllLines(path, Encoding.UTF8);
                if (lines.Length == 0) return false;

                string line = lines[0].Trim();
                string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length >= 2)
                {
                    double w = double.Parse(parts[0]);
                    double l = double.Parse(parts[1]);

                    fig.SetFigW(w);
                    fig.SetFigL(l);
                    tbWidth.Text = parts[0];
                    tbLength.Text = parts[1];

                    if (parts.Length == 3)
                    {
                        double h = double.Parse(parts[2]);
                        fig.SetFigH(h);
                        tbHeight.Text = parts[2];
                    }
                    else
                    {
                        fig.SetFigH(0);
                        tbHeight.Clear();
                    }

                    MessageBox.Show("Размеры загружены из данные.txt");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}");
            }
            return false;
        }
    }
}
