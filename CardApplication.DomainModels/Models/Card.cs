using System;
using System.Collections.Generic;
using System.Text;

namespace CardApplication.DataAccess.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Holder { get; set; }
        public string CardNumber { get; set; }
        public int CVC { get; set; }
        public int Balance { get; set; }
        public DateTime ExpDate { get; set; }
    }
}
