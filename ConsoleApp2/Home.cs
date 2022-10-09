using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Home
    {
        public Basement basement { get; set; }
        public Wall[] walls { get; set; }
        public Door door { get; set; }
        public Window[] windows { get; set; }
        public Roof roof { get; set; }
    }

    class Basement : IParts
    {
        public int Area { get; set; }
        public void Build(Home home)
        {
            Console.WriteLine("Enter the basement area");
            int area = int.Parse(Console.ReadLine());
            home.basement = new Basement() { Area = area };
        }
    }

    class Wall : IParts
    {
        public int High { get; set; }
        public void Build(Home home)
        {
            Console.WriteLine("Enter the high of walls");
            int high = int.Parse(Console.ReadLine());
            home.walls = new Wall[]
           {
               new Wall(){ High = high},
               new Wall(){ High = high},
               new Wall(){ High = high},
               new Wall(){ High = high},
           };
        }
    }

    class Door : IParts
    {
        public int High { get; set; }
        public void Build(Home home)
        {
            Console.WriteLine("Enter the high of the door");
            int high = int.Parse(Console.ReadLine());
            home.door = new Door() { High = high };
        }
    }

    class Window : IParts
    {
        public int High { get; set; }
        public void Build(Home home)
        {
            Console.WriteLine("Enter the high of the window");
            int high = int.Parse(Console.ReadLine());
            home.windows = new Window[4]
            {
               new Window(){ High = high},
               new Window(){ High = high},
               new Window(){ High = high},
               new Window(){ High = high},
            };
        }

    }

    class Roof : IParts
    {
        public int area { get; set; }
        public void Build(Home home)
        {
            Console.WriteLine("Enter the roof area");
            int arearoof = int.Parse(Console.ReadLine());
            home.roof = new Roof() { area = arearoof };
        }
    }

}
