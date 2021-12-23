using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13__1
{
    class Program
    {
        static void Main(string[] args)
        {
          
        }
    }
    class BuiLding
    {
        string address;
        double length;
        double width;
        double height;
        public string Address
        {
            set
            {

                address = value;
            }
            get
            {
                return address;
            }

        }
        public double Length

        {
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Длина здания не может быть меньше нуля");
                    Console.ReadKey();
                    return;
                }

            }
            get
            {
                return length;
            }
        }
        public double Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Ширина здания не может быть меньше нуля");
                    Console.ReadKey();
                    return;
                }
            }
            get
            {
                return width;
            }
        }
        public double Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Высота здания не может быть меньше нуля");
                    Console.ReadKey();
                    return;
                }
            }
            get
            {
                return height;
            }
        }
        public BuiLding(string address, double length, double width, double height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }
        public void Print()
        {
            Console.WriteLine("Адрес здания {0}, длина здания {1}, ширина здания {2}, высота здания {3}.", Address, Length, Width, Height);

        }
    }
    sealed class MultiBuilding : BuiLding
    {
        int floor;
        public int Floor
        {
            set
            {
                if (value > 0)
                {
                    floor = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Номер этажа должен быть больше нуля");
                    Console.ReadKey();
                    return;
                }
            }
            get
            {
                return floor;
            }


        }
        public MultiBuilding (string address, double length, double width, double height, int floor)
          : base (address, length, width, height)
        {
            Floor = floor;
        }
        public new void Print()
          
        {
            Console.WriteLine("Адрес здания {0}, длина здания {1}, ширина здания {2}, высота здания {3}, этажность здания {4}.", Address, Length, Width, Height, Floor);
        }
    }

}

