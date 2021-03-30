using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libray.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Writer Writer { get; set; }
        public Publisher Publisher { get; set; }
        public int Pages { get; set; }
        public Languages Language { get; set; }
        public LibraryBranch LibraryBranch { get; set; }
        public DateTime RegisteryDate { get; set; }
        public DateTime RecycledDate { get; set; }
    }
}
