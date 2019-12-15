using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Book
    {
        public string Author;
        public string Name;
        public string Price;

        public override string ToString()
        {
            return $"{this.Author} {this.Name} {this.Price}";
        }
    }
}
