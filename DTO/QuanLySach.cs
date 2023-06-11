using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuanLySach
    {
        
        private string Title;
        private string Author;
        private string Publisher;
        private DateTime PublicationYear;
        private string Catagory;
        private int Quantity;

        public QuanLySach() { }


        public QuanLySach(string title, string author, string publisher, DateTime publicationYear, string catagory, int quantity)
        {

            Title1 = title;
            Author1 = author;
            Publisher1 = publisher;
            PublicationYear1 = publicationYear;
            Catagory1 = catagory;
            Quantity1 = quantity;
        }

        public string Title1 { get => Title; set => Title = value; }
        public string Author1 { get => Author; set => Author = value; }
        public string Publisher1 { get => Publisher; set => Publisher = value; }
        public DateTime PublicationYear1 { get => PublicationYear; set => PublicationYear = value; }
        public string Catagory1 { get => Catagory; set => Catagory = value; }
        public int Quantity1 { get => Quantity; set => Quantity = value; }
    }      
       
    
}
