﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionsExercice.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return "\nName: " 
                + Name
                + "\nPrice: "
                + Price; 
        }
    }
}