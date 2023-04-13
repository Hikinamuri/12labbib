using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12labbib
{
    public class User 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Surname { get; set; }
        public string Profile { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<Sales> Books { get; set; }
        public User(){ 
            Books = new List<Sales>(); 
        }
    }
}
