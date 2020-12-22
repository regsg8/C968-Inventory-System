using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace RegGarrettInventorySystem
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product() { }
        public Product(int prodID, string name, int inStock, decimal price, int min, int max)
        {
            ProductID = prodID;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
        }
        //Associated Part methods
        public void AddAssociatedPart(Outsourced part) 
        {
            AssociatedParts.Add(part);
        }
        public void AddAssociatedPart(Inhouse part)
        {
            AssociatedParts.Add(part);
        }
        public bool RemoveAssociatedPart(int id)
        {
            bool found = false;
            foreach (Part part in AssociatedParts)
            {
                if (id == part.PartID)
                {
                    AssociatedParts.Remove(part);
                    found = true;
                }
            }
            if (found == false)
            {
                MessageBox.Show("Error: Associated part not removed.");
            }
            return found;
        }
        public Part LookupAssociatedPart (int id)
        {
            bool found = false;
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == id)
                {
                    found = true;
                    return part;
                }
            }
            if (found == false)
            {
                MessageBox.Show("Error: Associated part not found.");
            }
            Part partNotFound = new Outsourced();
            return partNotFound;
        }
    }
}
