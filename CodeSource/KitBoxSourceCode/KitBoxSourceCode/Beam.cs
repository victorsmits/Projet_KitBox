using System;
using SqlOledb;

namespace KitBoxSourceCode
{
    public class Beam : GenericComponent
    {
        private int beamNumber;
        private int stock;
        private static int beamNum = 0;

        public Beam(int len, int qty) : base(len, qty)
        {
            length = len;
            quantity = qty;

            // oledb stock ref fct len

            switch (qty)
            {
                case 2:
                    stockRef = Oledb.SqlRequest("SELECT Référence FROM Piece WHERE Référence LIKE 'TRR%' AND largeur LIKE '" + len.ToString() + "'");
                    break;
                case 4:
                    stockRef = Oledb.SqlRequest("SELECT Référence FROM Piece WHERE Référence LIKE 'TRG%' AND profondeur LIKE '" + len.ToString() + "'");
                    break;
            }

            beamNum++;
            beamNumber = beamNum;

            // oledb book beam fct len & qty
            Oledb.UpdateReservation(quantity, stockRef);
            SetPrice();

            stock = Oledb.GetDBStock(stockRef);
        }

        public override string GetDetails()
        {
            return "\"Beam " + beamNumber + "\" : { \"Length\": " + length
            + ", \"Stockref\" : \"" + stockRef + "\", \"Remaining Stock\":" + stock;
        }
    }
}
