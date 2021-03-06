﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace miller0061072133
{
    public class CartItem
    {
        // setters and getters
        public string ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        // Constructors
        public CartItem()
        {
            Console.Write("Hello. This is the CartItems Class.");
        }

        public CartItem(string ID, string Name, string Image, string Description, double Price, int Quantity)
        {
            this.ID = ID;
            this.Name = Name;
            this.Image = Image;
            this.Description = Description;
            this.Price = Price;
            this.Quantity = Quantity;

        }

        // Private


        // Public
        public string GetName(){
            return this.Name;
        }

		public string GetID()
		{
			return this.ID;
		}

		public string GetImage()
		{
			return this.Image;
		}

		public string GetDescription()
		{
            return this.Description;
		}

        public double GetPrice()
		{
            return this.Price;
		}

		public int GetQuantity()
		{
            return this.Quantity;
		}

        public void SetQuantity(int qty)
        {
            this.Quantity = qty;
        }

    }
}