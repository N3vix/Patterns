﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure figure = new Rectangle(30, 40);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            figure = new Circle(30);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            Console.Read();
        }
    }

    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }

    class Rectangle : IFigure
    {
        int width;
        int height;
        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public IFigure Clone()
        {
            return this.MemberwiseClone() as IFigure;
        }
        public void GetInfo()
        {
            Console.WriteLine("height {0} and width {1}", height, width);
        }
    }

    class Circle : IFigure
    {
        int radius;
        public Circle(int r)
        {
            radius = r;
        }

        public IFigure Clone()
        {
            return this.MemberwiseClone() as IFigure;
        }
        public void GetInfo()
        {
            Console.WriteLine("radius {0}", radius);
        }
    }
}
