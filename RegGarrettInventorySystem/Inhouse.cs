using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegGarrettInventorySystem
{
    class Inhouse : Part
    {
        public int MachineID { get; set; }
        public Inhouse() { }
        public Inhouse(int partID, string name, int inStock, decimal price, int min, int max)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
        }
        public Inhouse(int partID, string name, int inStock, decimal price, int min, int max, int machine)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
            MachineID = machine;
        }
    }
}
