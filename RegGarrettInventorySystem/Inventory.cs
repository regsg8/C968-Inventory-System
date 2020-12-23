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
        public static void addProduct(Product prod)
        {
            Products.Add(prod);
        }
        public static bool removeProduct(int id)
        {
            bool found = false;
            for (int i = 0; i < Products.Count; i++)
            {
                if (id == Products[i].ProductID)
                {
                    if (Products[i].AssociatedParts.Count != 0)
                    {
                        MessageBox.Show($"{Products[i].Name} has associated parts.  You must remove all associated parts before deleting this product.");
                    }
                    else
                    {
                        MessageBox.Show($"{Products[i].Name} has been removed!");
                        Products.Remove(Products[i]);
                        found = true;
                    }
                }
            }
            return found;
        }
        public static Product lookupProduct(int id)
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
        public static void updateProduct(int id, Product prodUpdate)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if(Products[i].ProductID == id)
                {
                    Products.RemoveAt(i);
                    Products.Insert(i, prodUpdate);
                }
            }
        }

        //Part methods
        public static void addPart(Part part)
        {
            Parts.Add(part);
        }
        public static bool deletePart(int id)
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
        public static Part lookupPart(int id)
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
        public static void updatePart(int id, Inhouse partUpdate)
        {
            for (int i = 0; i < Parts.Count; i++)
            {
                if (Parts[i].PartID == id)
                {
                    Parts.RemoveAt(i);
                    Parts.Insert(i, partUpdate);
                    MessageBox.Show($"{partUpdate.Name} updated!");
                }
            }
        }
        public static void updatePart(int id, Outsourced partUpdate)
        {
            for (int i = 0; i < Parts.Count; i++)
            {
                if (Parts[i].PartID == id)
                {
                    Parts.RemoveAt(i);
                    Parts.Insert(i, partUpdate);
                    MessageBox.Show($"{partUpdate.Name} updated!");
                }
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
