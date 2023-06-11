using System;

namespace DTO
{
    public class PhieuMuon
    {
        private string nameBook;
        private string nameReader;
        private DateTime borrowDate;
        private DateTime returnDate;
        private int amount;
        private int deposit;
        private int refund;
        private string statusBook;
        private string statusPM;

        public PhieuMuon()
        {
        }

        public PhieuMuon(string nameBook, string nameReader, DateTime borrowDate, DateTime returnDate, int amount, int deposit, int refund, string statusBook, string statusPM)
        {
            this.nameBook = nameBook;
            this.nameReader = nameReader;
            this.borrowDate = borrowDate;
            this.returnDate = returnDate;
            this.amount = amount;
            this.deposit = deposit;
            this.refund = refund;
            this.statusBook = statusBook;
            this.statusPM = statusPM;
        }

        public string NameBook { get => nameBook; set => nameBook = value; }
        public string NameReader { get => nameReader; set => nameReader = value; }
        public DateTime BorrowDate { get => borrowDate; set => borrowDate = value; }
        public DateTime ReturnDate { get => returnDate; set => returnDate = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Deposit { get => deposit; set => deposit = value; }
        public int Refund { get => refund; set => refund = value; }
        public string StatusBook { get => statusBook; set => statusBook = value; }
        public string StatusPM { get => statusPM; set => statusPM = value; }
    }
}
