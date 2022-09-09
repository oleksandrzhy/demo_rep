// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;

namespace Class
{
    public class Rectangle
    {
        private double sideA;
        private double sideB;
        public Rectangle()
        {
            sideA = 4;
            sideB = 3;
        }
        public Rectangle(double a, double b)
        {
            sideA = a;
            sideB = b;
        }
        public Rectangle(double a)
        {
            sideB = 5;
            sideA = a;
        }
        public double GetSideA()
        {
            return sideA;
        }
        public double GetSideB()
        {
            return sideB;
        }
        public double Area()
        {
            return sideA * sideB;
        }
        public double Perimeter()
        {
            return (sideA * 2) + (sideB * 2);
        }
        public bool IsSquare()
        {
            if (sideA == sideB)
            {
                return true;
            }
            return false;
        }
        public void ReplaceSides()
        {
            (sideA, sideB) = (sideB, sideA);
        }
    }
    public class ArrayRectangles
    {
        private readonly Rectangle[] rectangle_array;

        public ArrayRectangles(int n)
        {
            rectangle_array = new Rectangle[n];
        }
        public ArrayRectangles(params Rectangle[] array)
        {
            rectangle_array = array;
        }
        public bool AddRectangle(Rectangle rectangle)
        {
            for (int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i] == null)
                {
                    rectangle_array[i] = rectangle;
                    return true;
                }
            }
            return false;
        }
        public int NumberMaxArea()// to be done
        {
            double maxArea = rectangle_array[0].Area();
            int num = 0;
            for (int i = 1; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i] != null && maxArea < rectangle_array[i].Area())
                {
                    maxArea = rectangle_array[i].Area();
                    num = i;
                }
            }
            return num;
        }
        public int NumberMinPerimeter()
        {
            int num = 0;
            double minPerimeter = rectangle_array[0].Perimeter();
            for (int i = 1; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i] != null && minPerimeter > rectangle_array[i].Perimeter())
                {
                    minPerimeter = rectangle_array[i].Perimeter();
                    num = i;
                }
            }
            return num;
        }
        public int NumberSquare()
        {
            int num = 0;
            foreach (var rectangle in rectangle_array)
            {
                if (rectangle != null && rectangle.IsSquare())
                {
                    num++;
                }
            }
            return num;
        }
    }
}