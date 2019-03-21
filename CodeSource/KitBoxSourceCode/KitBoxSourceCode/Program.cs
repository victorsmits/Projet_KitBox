﻿using System;
using Oledb = SqlOledb.Oledb;
using System.Data.OleDb;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace KitBoxSourceCode
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Box box = new Box(10, 5, 20, "green");
            //Console.WriteLine(box.GetDetails());
            //Console.WriteLine(box.GetCompoments.Count);

            //DoubleDoors db = new DoubleDoors("green", "Glass");
            //BoxColor bc = new BoxColor("green");

            //db.AddBoxDecorator(box);
            //bc.AddBoxDecorator(db);

            //cabinet.AddStorageBox(box);
            //cabinet.AddStorageBox(db);
            //cabinet.AddStorageBox(bc);

            //Panel p = new Panel(12, 12, "green", 2);
            //Console.WriteLine(p.GetDetails());
            //Panel p2 = new Panel(12, 12, "green", 2);
            //Console.WriteLine(p2.GetDetails());


            Profile client = new Profile("Smits", "Victor");

            Cabinet cabinet = new Cabinet();
            Cart cart = new Cart();

            //CabinetFloor cabinetFloor = new CabinetFloor
            //(height: 10,
            //lenght: 5,
            //width: 20,
            //doorMat: "green",
            //panelCol: "green");

            cabinet.AddStorageBox(new CabinetFloor(10, 5, 20, "green", "green"));
            cabinet.AddAngles("black");
            Console.WriteLine("height = " + cabinet.GetCabinetHeight);
            Console.WriteLine("Price = " + cabinet.GetCabinetPrice);

            //Oledb.connection("/Users/victorsmits/Dropbox/ECAM/BAC3/Projet informatique/Projet_GL/Database/DB_Lespieces.accdb");

            cart.AddToCart(cabinet);
            cart.AddCartProfile(client);
            cart.GetProfile();

            Console.WriteLine(cart.ShowCart().ToString());
            Console.ReadKey();
        }
    }
}
