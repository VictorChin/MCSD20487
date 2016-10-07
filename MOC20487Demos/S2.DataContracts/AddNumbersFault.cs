using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand
{
    // include any data you want to send to the client when
    // an exception occurs while calling AddNumbers
    public class AddNumbersFault
    {
        public int Level { get; set; }
        public string FavouriteColour { get; set; }
        public Numbers FavouriteNumbers { get; set; }
    }
}
