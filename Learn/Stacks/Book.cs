using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learns.Stacks
{
    public class Book
    {
        public string Name {get; set;}
        public DateTime PublicateDay {get; set;}
   
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            Book other = (Book)obj;
            return this.Name == other.Name; 
        }

        public override int GetHashCode()
        {
            return Name != null ? Name.GetHashCode() : 0;
        }
    }
}
