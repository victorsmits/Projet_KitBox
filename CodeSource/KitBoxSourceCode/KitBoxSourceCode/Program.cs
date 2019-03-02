using System;
using System.Drawing;

namespace KitBoxSourceCode
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Box box = new Box(10, 5, 20);
            Console.WriteLine(box.GetCompoments.Count);

            DoubleDoors db = new DoubleDoors("green", "Glass");
            BoxColor bc = new BoxColor("green");

            Cabinet cabinet = new Cabinet();

            db.AddBoxDecorator(box);
            bc.AddBoxDecorator(db);

            cabinet.AddStorageBox(box);
            cabinet.AddStorageBox(db);
            cabinet.AddStorageBox(bc);

            Console.WriteLine(cabinet.GetTotalHieght());
            Console.WriteLine(cabinet.GetCabinetPrice());
        }
    }
}
