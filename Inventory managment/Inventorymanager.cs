using ObjectOriented.InventoryManagement;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedProgramming.InventoryManagement
{
    public class InventoryManager
    {
        public void DisplayData(string filepath)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    Inventorymodel jsonObjectArray = JsonConvert.DeserializeObject<Inventorymodel>(jsonData);

                    Console.WriteLine("Name\tWeight\tRate\tAmount");

                    List<Rice> rice = jsonObjectArray.RiceList;
                    foreach (var item in rice)
                    {
                        Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t" + "{3}", item.Name, item.Weight, item.PricePerkg, item.Weight * item.PricePerkg);
                    }
                    List<Wheat> wheat = jsonObjectArray.WheatList;
                    foreach (var item in wheat)
                    {
                        Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t" + "{3}", item.Name, item.Weight, item.PricePerkg, item.Weight * item.PricePerkg);
                    }
                    List<Pulses> pulses = jsonObjectArray.PulsesList;
                    foreach (var item in pulses)
                    {
                        Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t" + "{3}", item.Name, item.Weight, item.PricePerkg, item.Weight * item.PricePerkg);
                    }
                }
                else
                {
                    Console.WriteLine("\nSpecified file path does not exist");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}