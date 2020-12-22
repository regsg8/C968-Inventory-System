using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace RegGarrettInventorySystem
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> Parts = new BindingList<Part>();
        public static Inhouse sampleInsource = new Inhouse();

        //Product methods
        public static void AddProduct(Product prod)
        {
            Products.Add(prod);
        }
        public static bool RemoveProduct(int id)
        {
            bool found = false;
            foreach (Product prod in Products)
            {
                if (id == prod.ProductID)
                {
                    MessageBox.Show($"{prod.Name} has been removed!");
                    Products.Remove(prod);
                    found = true;
                }
            }
            if (found == false)
            {
                MessageBox.Show("Error: Product not removed.");
            }
            return found;
        }
        public static Product LookupProduct(int id)
        {
            bool found = false;
            foreach (Product prod in Products)
            {
                if (prod.ProductID == id)
                {
                    found = true;
                    return prod;
                }
            }
            if (found == false)
            {
                MessageBox.Show("Error: Product not found.");
            }
            Product prodNotFound = new Product();
            return prodNotFound;
        }
        public static void UpdateProduct(int id, Product prodUpdate)
        {
            bool found = false;
            foreach (Product prod in Products)
            {
                if (prod.ProductID == id)
                {
                    prod.Name = prodUpdate.Name;
                    prod.Price = prodUpdate.Price;
                    prod.InStock = prodUpdate.InStock;
                    prod.Min = prodUpdate.Min;
                    prod.Max = prodUpdate.Max;
                    found = true;
                    MessageBox.Show($"{prod.Name} updated!");
                }
            }
            if (found == false)
            {
                MessageBox.Show("Error: Product not updated.");
            }
        }

        //Part methods
        public static void AddPart(Part part)
        {
            Parts.Add(part);
        }
        public static bool DeletePart(int id)
        {
            bool found = false;
            foreach (Part part in Parts)
            {
                if (id == part.PartID)
                {
                    MessageBox.Show($"{part.Name} has been removed!");
                    Parts.Remove(part);
                    found = true;
                    return found;
                }
            }
            if (found == false)
            {
                MessageBox.Show("Error: Part not removed.");
            }
            return found;
        }
        public static Part LookupPart(int id)
        {
            bool found = false;
            foreach (Part part in Parts)
            {
                if (part.PartID == id)
                {
                    found = true;
                    return part;
                }
            }
            if (found == false)
            {
                MessageBox.Show("Error: Part not found.");
            }
            Part partNotFound = new Outsourced();
            return partNotFound;
        }
        public static void UpdatePart(int id, Part partUpdate)
        {
            bool found = false;
            foreach (Part part in Parts)
            {
                if (part.PartID == id)
                {
                    part.Name = partUpdate.Name;
                    part.Price = partUpdate.Price;
                    part.InStock = partUpdate.InStock;
                    part.Min = partUpdate.Min;
                    part.Max = partUpdate.Max;
                    found = true;
                    MessageBox.Show($"{part.Name} updated!");
                }
            }
            if (found == false)
            {
                MessageBox.Show("Error: Part not updated.");
            }
        }

        //Populate data grid
        public static void populateMainScreenDGV()
        {
            if (Products.Count == 0)
            {
                //Create products and add to list
                Product loadProd1 = new Product(11, "Purple Bike", 12, 80, 1, 40);
                Product loadProd2 = new Product(12, "Green Bike", 10, 60, 1, 60);
                Product loadProd3 = new Product(13, "Orange Bike", 12, 70, 1, 50);

                Products.Add(loadProd1);
                Products.Add(loadProd2);
                Products.Add(loadProd3);

                //Create parts and add to list
                Part loadPart1 = new Inhouse(101, "Handlebars", 24, 5, 6, 80, 201);
                Part loadPart2 = new Inhouse(102, "Bike Chain", 15, 3, 6, 80, 301);
                Part loadPart3 = new Outsourced(103, "Bike Frame", 26, 20, 6, 80, "Bicycle Etc.");
                Part loadPart4 = new Outsourced(104, "Bike Tire", 49, 9, 12, 160, "Spokes and Wheels LLC");

                Parts.Add(loadPart1);
                Parts.Add(loadPart2);
                Parts.Add(loadPart3);
                Parts.Add(loadPart4);

                //Associate parts with products
                loadProd1.AssociatedParts.Add(loadPart1);
                loadProd1.AssociatedParts.Add(loadPart2);
                loadProd1.AssociatedParts.Add(loadPart3);
                loadProd1.AssociatedParts.Add(loadPart4);
                loadProd2.AssociatedParts.Add(loadPart1);
                loadProd2.AssociatedParts.Add(loadPart2);
                loadProd2.AssociatedParts.Add(loadPart3);
                loadProd2.AssociatedParts.Add(loadPart4);
                loadProd3.AssociatedParts.Add(loadPart1);
                loadProd3.AssociatedParts.Add(loadPart2);
                loadProd3.AssociatedParts.Add(loadPart3);
                loadProd3.AssociatedParts.Add(loadPart4);
            }
        }
    }
}
