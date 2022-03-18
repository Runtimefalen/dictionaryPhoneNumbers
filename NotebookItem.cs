using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookApp
{
    public class NotebookItem
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string PhoneNumber { get; set; }
        public string FIO
        { 
            get
            {
                return $"{LastName} {FirstName[0]}. {MiddleName[0]}.";
            } 
        }
    }
}
