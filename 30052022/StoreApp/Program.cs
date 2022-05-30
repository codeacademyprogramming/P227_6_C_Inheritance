using System;

namespace StoreApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone(1500)
            {
                Brand = "Samsung",
                Camera = 14,
                Name = "Note20",
                SimCount = 2
            };

            phone.ShowInfo();

            Store elininMarketi = new Store(20);

            elininMarketi.AddPhone(new Phone(4000) { Name = "Xpreia", Brand = "Sony" });
        }
    }
}
