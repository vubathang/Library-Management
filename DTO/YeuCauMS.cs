using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class YeuCauMS
    {
        private int idDG;
        private int idBook;
        private DateTime requestDate;
        private int quantity;

        public YeuCauMS()
        {
        }

        public YeuCauMS(int idDG, int idBook, DateTime requestDate, int quantity)
        {
            this.idDG = idDG;
            this.idBook = idBook;
            this.requestDate = requestDate;
            this.quantity = quantity;
        }

        public int IdDG { get => idDG; set => idDG = value; }
        public int IdBook { get => idBook; set => idBook = value; }
        public DateTime RequestDate { get => requestDate; set => requestDate = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
