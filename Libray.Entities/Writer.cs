using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libray.Entities
{
    public class Writer
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public List<Book> Books { get; set; }
    }
}
