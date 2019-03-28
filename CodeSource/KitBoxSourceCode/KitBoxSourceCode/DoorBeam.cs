using System;
using SqlOledb;

namespace KitBoxSourceCode
{
    public class DoorBeam : GenericComponent
    {
        public DoorBeam(int len, int qty) : base(len, qty)
        {
            // oledb stock ref fct len
            stockRef = Oledb.SqlRequest("SELECT Référence FROM Piece WHERE Référence LIKE 'TRF%' AND largeur = " + len.ToString());
            // oledb book fct len et qty
            Oledb.UpdateReservation(quantity, stockRef);
            SetPrice();
            SetStock();
        }

        public override string GetDetails()
        {
            return "\"DoorBeam\" : {\"Length\": " + length
            + ", \"Stockref\": \"" + stockRef + "\",\"Remaining Stock\":" + stock;
        }
    }
}
