using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D; 
using System.IO;


namespace WindowsFormsApplication2
{
    public partial class LWP05Main : Form
    {
        String Title; 
        public LWP05Main()
        {
            InitializeComponent();

            /* Инициализируем массив элементов для checkedListBox1 */
            String[] CheckItems = { "Непрозрачность окна в %", "Овальное окно" };
            checkedListBox1.Items.AddRange(CheckItems);
            /* Устанавливаем режим выбора 'ktvtynf с двойного нажатия на одинарный */
            checkedListBox1.CheckOnClick = true;
            NumericAplha.Value = 100; // Начальное значение
            progressBar1.Maximum = 60; // Граница индикаторы выполнения
            Title = this.Text; // Сохраняем первоначальный заголовок

        }

        private void файлToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TimerOneSecond.Start(); // Запускаем таймер
            TimerOneSecond.Tick += new EventHandler(TimerOneSecond_Tick); // Прошла секунда: генерируем событие "один такт" таймера
            StatusProgressBar.Maximum = 100; // Устанавливаем максимум для индикатора
            StatusProgressBar.Value = 100; // Переводим текущее значение на максимум

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            StatusLabel.Text = файлToolStripMenuItem.Text + " (" + файлToolStripMenuItem.ShortcutKeyDisplayString + ")"; 
        }

        private void LWP05Main_MouseEnter(object sender, EventArgs e)
        {
            StatusLabel.Text = "";
            StatusProgressBar.Value = 0;
        }

        private void выходToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = ""; 
        }

        private void TimerOneSecond_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button NewButton = new System.Windows.Forms.Button(); // Создаём кнопку
            NewButton.Location = new System.Drawing.Point(30, 85); // Устанавливаем необходимые свойства
            NewButton.Name = "NewButton"; // Устанавливаем имя кнопки
            NewButton.Size = new System.Drawing.Size(237, 23); // Устанавливаем размер кнопки
            NewButton.TabIndex = 0; // Порядок переключение по клавише Tab
            NewButton.Text = "NewButton"; // Устанавливаем текст на кнопке
            NewButton.UseVisualStyleBackColor = true; // Устанавливаем способ отрисовки (стандартный)
            NewButton.Click += new System.EventHandler(NewButton_Click); // button1_Click - функция обработчик события нажатия на кнопку
            Controls.Add(NewButton); // Добавляем на форму
            NewButton.BringToFront(); // Помещаем элемент на передний план
            button2.Enabled = true; // Включаем кнопку Удалить

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            /* Получаем доступ к элементу управления по его имени */
            (Controls["NewButton"] as Button).Text = "Ура, заработало!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controls.Remove((Controls["NewButton"] as Button)); // Удаляем с формы кнопку NewButton
            //(Controls["NewButton"] as Button).Dispose(); // Освобождаем ресурсы занятые кнопкой
            Controls.Remove(button4);
            button4.Dispose();
            button2.Enabled = false; // Выключаем кнопку после завершения операций уничтожения кнопок


        }

        private void button3_Click(object sender, EventArgs e)
        {
            StatusProgressBar.Value = 0; // Сбрасываем индикатор при нажатии
            StatusProgressBar.Step = 34; // Задаём шаг для индикатора (делим на 3 части 100)
            TextBox[] TB = new TextBox[Convert.ToInt32(NumericButtons.Value)]; // Объявляем массив элементов управления по числву выбранному в NumericButtons

            for (int i = 0; i < TB.Length; i++) // Организуем цикл по числу элементов массива
            {
                StatusProgressBar.PerformStep(); // Увеличиваем значение индикатора
                TB[i] = new System.Windows.Forms.TextBox(); // Создаём элемент i
                TB[i].Location = new System.Drawing.Point(365 + i * 80, 62); // Позиция элемента i
                TB[i].Name = "textBox" + i.ToString(); // Заполняем элемент i
                TB[i].Size = new System.Drawing.Size(75, 23);
                TB[i].TabIndex = i;
                TB[i].Text = "textBox" + i.ToString();
                Controls.Add(TB[i]);
                TB[i].BringToFront();
                StatusLabel.Text = "Массив элементов управлений успешно создан (" + StatusProgressBar.Value + "%)"; // выводим текст в строку состояния
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Contains("Непрозрачность окна в %") == true) // Если элемент выделен
            {
                this.Opacity = Convert.ToDouble(NumericAplha.Value) / 100; // Прозрачность: значение NumericAplha / 100 (0 - полна прозрачность, 1 - полная непрозрачность)
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorSelect.ShowDialog(); // Показываем окно выбора цвета (Windows)
            this.BackColor = ColorSelect.Color; // Устанавливаем в качестве текущего для фона формы
            StatusLabel.Text = "Выбан цвет: " + ColorSelect.Color;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Empty;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                FontSelect.ShowDialog();
                this.Font = FontSelect.Font;
                StatusLabel.Text = "Выбран шрифт: " + FontSelect.Font.ToString();
            }
            catch
            {
                // Ловим ошибку: шрифт не TrueType
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Font = DefaultFont;
            StatusLabel.Text = "Выбран первоначальный шрифт: " + DefaultFont.Name;

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GraphicsPath G = new GraphicsPath(); // Создаём новый графический элемент
            Rectangle Rect = new Rectangle(0, 0, this.Width, this.Height); // Создаём прямоугольник

            if (checkedListBox1.CheckedItems.Contains("Непрозрачность окна в %") == true) // Если элемент выделен
            {
                this.Opacity = Convert.ToDouble(NumericAplha.Value) / 100; // Прозрачонть: значение NumericAplha / 100 (0 - полна прозрачность, 1 - полная непрозрачность)
            }

            if (checkedListBox1.CheckedItems.Contains("Овальное окно") == true)
            {
                G.AddEllipse(0, 0, this.Width, this.Height); // Добавляем эллипс покрывающий всю форму в графический элемент
                this.Region = new System.Drawing.Region(G); // Создаём объект нового региона и меняем регион формы на эллепис
            }
            else
            {
                G.AddRectangle(Rect); // Добавляем прямоугольник
                this.Region = new System.Drawing.Region(G); // Выбираем прямоугольник
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SelectBrowser.ShowDialog();
            textBox1.Text = SelectBrowser.SelectedPath; // Заносим значение пути в textBox1

        }

        private void TimerOneMinute_Tick(object sender, EventArgs e)
        {
            Byte Seconds = Convert.ToByte(DateTime.Now.Second);
            progressBar1.Value = Seconds;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            ColorSelect.ShowDialog();
            richTextBox1.SelectionColor = ColorSelect.Color;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                FontSelect.ShowDialog();
                richTextBox1.SelectionFont = FontSelect.Font; // Меняем шрифт выделенного текста richTextBox1
            }
            catch
            {
                // Ловим ошибку: шрифт не TrueType
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            ColorSelect.ShowDialog();
            richTextBox1.SelectionBackColor = ColorSelect.Color; 
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy(); 
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Focus(); // Фокус на элемент
            richTextBox1.SelectAll(); 

        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear(); 

        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создаём строковую переменную для хранения имени сохранённого файла
            String FileSavedAs;
            // Создаём поток в памяти 
            MemoryStream MStream = new MemoryStream();
            // Cоздаём поток для файл 
            Stream FStream;

            if (FileSave.ShowDialog() == DialogResult.OK) // По завершении диалога и нажатии кнопки ОК...
            {
                // Связываем поток с именем существующего файла, если файла нет, то создаём новый файл 
                FStream = FileSave.OpenFile();
                // Меняем положение в потоке
                MStream.Position = 0;
                // Сохраняем в поток содержимое richTextBox1 (сохраняем форматированный текст)
                richTextBox1.SaveFile(MStream, RichTextBoxStreamType.RichText);
                // Записываем информацию в файл 
                MStream.WriteTo(FStream);
                // Закрываем поток и высвобождаем память
                FStream.Close();
                FileSavedAs = FileSave.FileName;
                this.Text = Title + " :: " + FileSavedAs; // После сохранения укажем сохранённый файл в заголовке
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveQuestion(); 
        }

        void SaveQuestion()
        {
            DialogResult Result = MessageBox.Show("Сохранить изменения в документе?", Title + " :: Сохранение изменений", MessageBoxButtons.YesNo);

            switch (Result) // Оператор переключения switch, получает значения Result результата выполнения диалога
            {
                case DialogResult.Yes:
                    {
                        сохранитьКакToolStripMenuItem_Click(null, null); // Генерируем событие нажатия кнопки Сохранить как...
                        Close();
                        break;
                    }
                case DialogResult.No: { Close(); return; }
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Открываем диалог открытия файла
                FileOpen.ShowDialog();
                // Создаём поток для содержимого файла
                Stream FStream = FileOpen.OpenFile();
                // Загружаем файл (открываем форматированный текст)   
                richTextBox1.LoadFile(FStream, RichTextBoxStreamType.RichText);
                // Закрываем поток и высвобождаем память
                FStream.Close();
                this.Text = Title + " :: " + FileOpen.FileName;
            }
            catch
            {
                // Ловим ошибку: файл не найден
            }

        }

        private void открытьToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            StatusLabel.Text = открытьToolStripMenuItem.Text + " (" + открытьToolStripMenuItem.ShortcutKeyDisplayString + ")";
        }

        private void сохранитьКакToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            StatusLabel.Text = сохранитьКакToolStripMenuItem.Text + " (" + сохранитьКакToolStripMenuItem.ShortcutKeyDisplayString + ")";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveQuestion();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                checkBox1.Checked = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                maskedTextBox1.Visible = false;
                dateTimePicker1.Visible = false;
                // Открываем диалог открытия файла
                FileOpen.FileName = "Изображение";
                FileOpen.ShowDialog();
                String ImageName = FileOpen.FileName;
                // Создаём поток для содержимого файла
                Stream FStream = FileOpen.OpenFile();
                // Загружаем файл (открываем форматированный текст)   
                pictureBox1.Image = Image.FromFile(ImageName);
                // Закрываем поток и высвобождаем память
                FStream.Close();
                this.Text = Title + " :: " + FileOpen.FileName;
            }
            catch
            {
                // Ловим ошибку: файл не найден
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
            }
            else
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                maskedTextBox1.Visible = false;
                dateTimePicker1.Visible = false;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Visible = true;
            dateTimePicker1.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Visible = false;
            dateTimePicker1.Visible = true;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

            if (pictureBox1.Image != null)
                Hint.SetToolTip(pictureBox1, "Размер изображения: " + "\nШирина: " + pictureBox1.Image.PhysicalDimension.Width + "\nВысота: " + pictureBox1.Image.PhysicalDimension.Height);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            LWP05Clock Form = new LWP05Clock();
            Form.ShowDialog();

        }


    }
}
