using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_7_Auction_system
{
    class Item
    {
        private string description;
        private double reserveprice;
        private int bidderID;
        private double highestbid;

        public Item(string description, double reserveprice)
        {
            this.description = description;
            this.reserveprice = reserveprice;
        }

        public string Getdescription()
        {
            return description;
        }

        public double Getreserveprice()
        {
            return reserveprice;
        }

        public double Gethighestbid()
        {
            return highestbid;
        }

        public int GetbidderID()
        {
            return bidderID;
        }
        public bool Sethighestbid(int bidderID, double newbid)
        {
            if(newbid > highestbid && newbid > reserveprice)
            {
                highestbid = newbid;
                this.bidderID = bidderID;
                return true;
            }
            else
            {
                Console.WriteLine("That is lower than the highest bid");
                return false;
            }
        }

        public void SetbidderID(int newID)
        {
            bidderID = newID;
        }
    }
}
