using System;

namespace Assignment_7_Auction_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Item[] items = new Item[5];

            items[0] = new Item("Mobile Phone", 5000);
            items[1] = new Item("Walkie Talkie", 1000);
            items[2] = new Item("Headphones", 500);
            items[3] = new Item("Earphones", 500);
            items[4] = new Item("Screen Protector", 200);



            for(int i = 1; i < items.Length; i++)
            {
                if(items[i] != null)
                {
                    Console.WriteLine("Description: " + items[i].Getdescription() + "  Reserve Price: " + items[i].Getreserveprice());
                }
            }

            static void BidOnItem(int bidderID, double newbid, string item)
            {
                
            }
            
        }
    }
}
