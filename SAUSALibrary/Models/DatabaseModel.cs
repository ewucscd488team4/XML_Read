using System;
using System.Collections.Generic;
using System.Text;

namespace SAUSALibrary.Models
{
    public class DatabaseModel
    {
        public string Type { get; set; }
        public string Server { get; set; }
        public string Database { get; set; }
        public string UserID { get; set; }
        public string PassWord { get; set; }
    }
}
