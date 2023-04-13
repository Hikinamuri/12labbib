using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12labbib
{
    public class Sales 
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Client { get; set; }
        public int Tovar { get; set; }
        public int Number { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
