using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form : System.Windows.Forms.Form
    {
        // Хранит список растений
        private List<Plant> plantsList = new List<Plant>();

        public Form()
        {
            InitializeComponent();
            ShowInfo();
        }

        // Формирует очередь
        private void Line()
        {
            if (this.plantsList.Count == 0)
            {
                pictureBox1.ImageLocation = "";
                pictureBox2.ImageLocation = "";
                txtLine1.Text = "Пусто";
                txtLine2.Text = "Пусто";
                return;
            }
            else if (this.plantsList.Count == 1)
            {
                pictureBox1.ImageLocation = "";
                pictureBox2.ImageLocation = this.plantsList[0].ImageLink;
                txtLine1.Text = this.plantsList[0].getInfo();
                txtLine2.Text = "Пусто";
                return;
            }
            else if (this.plantsList.Count >= 2)
            {
                pictureBox1.ImageLocation = this.plantsList[1].ImageLink;
                pictureBox2.ImageLocation = this.plantsList[0].ImageLink;
                txtLine1.Text = this.plantsList[0].getInfo();
                txtLine2.Text = this.plantsList[1].getInfo();
                return;
            }
        }

        // Чистит очередь
        private void Clear()
        {
            txtOut.Text = "";
            txtLine1.Text = "";
            txtLine2.Text = "";
            pictureBox3.ImageLocation = "";
        }

        // Перезаписывает список
        private void Refill()
        {
            this.plantsList.Clear();
            var rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.plantsList.Add(Flower.Generate());
                        break;

                    case 1:
                        this.plantsList.Add(Bush.Generate());
                        break;

                    case 2:
                        this.plantsList.Add(Tree.Generate());
                        break;
                }
            }
            ShowInfo();
        }

        // Обработчик нажатия кнопки перезаписи
        private void btnRefill_Click(object sender, EventArgs e)
        {
            Clear();
            Refill();
            Line();
        }

        // Выводит информацию о полученном заказе
        private void ShowInfo()
        {
            int flowersCount = 0;
            int bushesCount = 0;
            int treesCount = 0;

            foreach (var plant in this.plantsList)
            {
                if (plant is Flower)
                {
                    flowersCount += 1;
                }
                else if (plant is Bush)
                {
                    bushesCount += 1;
                }
                else if (plant is Tree)
                {
                    treesCount += 1;
                }

                txtInfo.Text = "Цвет\tКуст\tДерев";
                txtInfo.Text += "\n";
                txtInfo.Text += String.Format("{0}\t{1}\t{2}", flowersCount, bushesCount, treesCount);
            }
        }

        // Загружает форму и вызывает другие методы необходимые по умолчанию
        private void Form1_Load(object sender, EventArgs e)
        {
            Refill();
            Line();
        }

        // Обработчик нажатия кнопки взятия объекта
        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.plantsList.Count == 0)
            {
                pictureBox3.ImageLocation = "";
                txtOut.Text = "Пусто";
                return;
            }

            var plant = this.plantsList[0];
            this.plantsList.RemoveAt(0);

            pictureBox3.ImageLocation = plant.ImageLink;
            txtOut.Text = plant.getInfo();

            ShowInfo();
            Line();
        }
    }
}