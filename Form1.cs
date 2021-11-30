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
    public partial class Form1 : Form
    {
        private List<Plant> plantsList = new List<Plant>();

        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.plantsList.Count == 0)
            {
                txtOut.Text = "Пусто";
                return;
            }

            var plant = this.plantsList[0];
            this.plantsList.RemoveAt(0);

            txtOut.Text = plant.getInfo();

            ShowInfo();
        }
    }
}