using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface IBorrowable
    {
        DateTime BorrowDate { get; set; }       //Fecha de Préstamo
        string Borrower { get; set; }           //Prestatario (persona que toma algo a préstamo)
        int CheckOutDurationInDays { get; set; }//Día de salida (préstamo)
        void CheckIn();                         //Día de entrada (devolución)
        void CheckOut();                        //Día de salida (préstamo)
        DateTime GetDueDate();                  //Fecha de vencimiento

    }
}
