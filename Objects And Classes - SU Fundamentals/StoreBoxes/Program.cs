using System;
using System.Linq;
using System.Collections.Generic;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split();
            List<Box> boxes = new List<Box>();

            while (input[0] != "end")
            {
                Item item = new Item();
                item.Name = input[1];
                item.Price = Convert.ToDouble(input[3]);

                Box box = new Box();
                box.SerialNumber = input[0];
                box.Item = item;
                box.ItemQuantity = Convert.ToDouble(input[2]);

                box.RriceOfBox = (decimal) (box.Item.Price * box.ItemQuantity);

                boxes.Add(box);

                input = Console.ReadLine().Trim().Split();
            }

            boxes = boxes.OrderBy(x => x.RriceOfBox).Reverse().ToList();

            foreach (Box box in boxes)
            {        
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.RriceOfBox:f2}");
            }
        }
    }
    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public double ItemQuantity { get; set; }
        public decimal RriceOfBox { get; set; }
    }
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
