using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Plant
    {
        public int Height = 0;
        public static Random rnd = new Random();
        public string ImageLink = "";

        public virtual String getInfo()
        {
            var str = String.Format("\nВысота: {0}", this.Height);
            return str;
        }
    }

    //Цвета цветков
    public enum FlowerColor
    { orange, blue, red, yellow, white };

    //Типы цветков
    public enum FlowerType
    { tubular, bell_shaped, star_shaped, globular };

    //Класс цветка
    public class Flower : Plant
    {
        public int PetalCount = 0;
        public FlowerColor Color = FlowerColor.blue;
        public FlowerType Type = FlowerType.tubular;

        public override string getInfo()
        {
            var str = "Цветок";
            str += base.getInfo();
            str += String.Format("\nКоличество лепестков: {0}", this.PetalCount);
            str += String.Format("\nЦвет: {0}", ConvertColor(this.Color));
            str += String.Format("\nТип цветка: {0}", ConvertType(this.Type));
            return str;
        }

        private string ConvertColor(FlowerColor color)
        {
            string col = "";

            switch (color)
            {
                case FlowerColor.orange:
                    col = "оранжевый";
                    break;

                case FlowerColor.blue:
                    col = "синий";
                    break;

                case FlowerColor.red:
                    col = "красный";
                    break;

                case FlowerColor.yellow:
                    col = "желтый";
                    break;

                case FlowerColor.white:
                    col = "белый";
                    break;

                default:
                    break;
            }

            return col;
        }

        private string ConvertType(FlowerType type)
        {
            string ty = "";

            switch (type)
            {
                case FlowerType.tubular:
                    ty = "трубчатый";
                    break;

                case FlowerType.bell_shaped:
                    ty = "колокольчатый";
                    break;

                case FlowerType.star_shaped:
                    ty = "звёздный";
                    break;

                case FlowerType.globular:
                    ty = "сферический";
                    break;

                default:
                    break;
            }

            return ty;
        }

        public static Flower Generate()
        {
            return new Flower
            {
                Height = rnd.Next() % 30,
                PetalCount = rnd.Next() % 15,
                Color = (FlowerColor)rnd.Next(5),
                Type = (FlowerType)rnd.Next(4),
                ImageLink = "https://images.unsplash.com/photo-1560790671-b76ca4de55ef?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=734&q=80"
            };
        }
    }

    //Класс куста
    public class Bush : Plant
    {
        public bool FlowerPresence = false;
        public int BranchCount = 0;

        public override string getInfo()
        {
            var str = "Куст";
            str += base.getInfo();
            str += String.Format("\nНаличие цветков: {0}", ConvertPresence(this.FlowerPresence));
            str += String.Format("\nКоличество веток: {0}", this.BranchCount);
            return str;
        }

        private string ConvertPresence(bool presence)
        {
            if (presence)
            {
                return "да";
            }
            else
            {
                return "нет";
            }
        }

        public static Bush Generate()
        {
            return new Bush
            {
                Height = 30 + rnd.Next(100),
                FlowerPresence = rnd.Next(2) == 0,
                BranchCount = 10 + rnd.Next(30),
                ImageLink = "https://images.unsplash.com/photo-1595251742237-3f6a7ee4131d?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
            };
        }
    }

    //Типы деревьев
    public enum TreeType
    { coniferous, leaf };

    //Класс дерева
    public class Tree : Plant
    {
        public TreeType type = TreeType.leaf;
        public int Radius = 0;

        public override string getInfo()
        {
            var str = "Дерево";
            str += base.getInfo();
            str += String.Format("\nТип дерева: {0}", ConvertType(this.type));
            str += String.Format("\nРадиус ствола: {0}", this.Radius);
            return str;
        }

        private string ConvertType(TreeType type)
        {
            switch (type)
            {
                case TreeType.coniferous:
                    return "хвойное";

                case TreeType.leaf:
                    return "лиственное";
            }
            return "";
        }

        public static Tree Generate()
        {
            return new Tree
            {
                Height = 100 + rnd.Next(1000),
                type = (TreeType)rnd.Next(2),
                Radius = 5 + rnd.Next(50),
                ImageLink = "https://images.unsplash.com/photo-1437964706703-40b90bdf563b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1074&q=80"
            };
        }
    }
}