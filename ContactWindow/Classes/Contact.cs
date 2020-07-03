using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ContactWindow.Classes
{
    class Contact
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; } 

        public string Name { get; set; }
                
        public string Email { get; set; }

        public string Phone { get; set; }

    }
}
