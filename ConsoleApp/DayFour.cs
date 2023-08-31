
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class DayFour
    {
        /*
        public void GetManufacture()
        {
            foreach(var item in manufactures())
            {
                Console.WriteLine($"{item.id}. {item.name} is manufactured in {item.country}");
            }
        }
      */
        public void example1()
        {
            foreach(var item in manufactures())
            {
                var isManufacturedIn = item.country switch
                {
                    Country.Germany=> "wird in Deutschland hergestellt",
                    Country.Itali=> "è prodotto in italia",
                    Country.France=> " est fabriqué en france",
                    Country.China=> "中国制造",
                    Country.UnitedKingdom=>"is manufactured in united kingdom",
                    _=>""
                };
                Console.WriteLine($"{item.id}. {item.name }"+isManufacturedIn);
            }
        }
        private List<Manufacture> manufactures()
        {
            return new List<Manufacture>
            {
                new Manufacture(1,"BMW",Country.Germany),
                new Manufacture(2,"Ferrari",Country.Itali),
                new Manufacture(3,"NETA",Country.China),
                new Manufacture(4,"Bugatti",Country.France),
                new Manufacture(5,"Jaguar",Country.UnitedKingdom)
                


            };
        }
    }


/*
 public class DayFour
{
    public void Example1()
    {
        foreach (Manufacturer manufacturer in GetManufacturers())
        {
            var isManufacturedIn = manufacturer.country switch
            {
                Country.Germany => "wird in Deutschland hergestellt",
                Country.Italy => "è prodotta in Italia",
                Country.France => "est fabriqué en France",
                Country.China => "中國製造",
                Country.UnitedKingdom => "is manufactured in United Kingdom",

                _=> ""
            };

            Console.WriteLine($"{manufacturer.Id}. {manufacturer.name} {isManufacturedIn}.");
        }
    }

/*

    private List<Manufacturer> GetManufacturers() =>
        new List<Manufacturer>()
        {
            new Manufacturer(1, "BMW", Country.Germany),
            new Manufacturer(2, "Lamborghini", Country.Italy),
            new Manufacturer(3, "Vespa", Country.Italy),
            new Manufacturer(4, "Bugatti", Country.France),
            new Manufacturer(5, "BYD", Country.China),
            new Manufacturer(6, "Ford", Country.UnitedKingdom),
            new Manufacturer(7, "Cadillac", Country.UnitedKingdom),
            new Manufacturer(8, "McLaren", Country.UnitedKingdom)
        };
*/
}
