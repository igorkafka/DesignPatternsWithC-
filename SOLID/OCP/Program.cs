﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OCP
{
    public enum Color
    {
        Red, Green, Blue
    }
    public enum Size
    {
        Small, Medium, Large, Yuge
    }
    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;
        public Product(string name, Color color, Size size)
        {
            this.Name = name;
            this.Color = color; 
            this.Size = size;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
