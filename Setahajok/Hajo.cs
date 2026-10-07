using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setahajok
{
    internal class Hajo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int MaxPassengers { get; set; }
        public  int DailyPrice { get; set; }
        public Hajo(string line)
        {
            string[] splittedLines=line.Split(',');
            Id = int.Parse(splittedLines[0]);
            Name = splittedLines[1];
            Type = splittedLines[2];
            MaxPassengers = int.Parse(splittedLines[3]);
            DailyPrice = int.Parse(splittedLines[4]);
        }
        public override string ToString() 
        {
            return $"{Id},{Name},{Type},{MaxPassengers},{DailyPrice}";
        }
        public int PriceOfBoat(int days)
        {
            return days * DailyPrice;
        }
    }
}
