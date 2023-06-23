namespace _6._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = " ";
            List<Box> dataBase = new List<Box>();
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> data = input
                    .Split()
                    .ToList();
                int serialNumber = int.Parse(data[0]);
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

                Box box = new Box(serialNumber, itemName, itemQuantity, itemPrice);
                dataBase.Add(box);
                dataBase = dataBase.OrderByDescending(x => x.BoxPrice).ToList();
            }
            foreach (Box box in dataBase)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            }
        }
    }
    public class Item
    {
        public Item(string name, decimal price) 
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    public class Box
    {
        public Box(int serialNumber,string name, int itemQuantity, decimal price)
        {
            SerialNumber = serialNumber;
            ItemQuantity = itemQuantity;
            Item = new Item(name, price);
            BoxPrice = price * itemQuantity;
        }

        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal BoxPrice { get; set; }
    }
}