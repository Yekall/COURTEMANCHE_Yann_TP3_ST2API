using System.Collections.Generic;

namespace ApiControler
{
    public class ListW
    {
        public double dt { get; set; }
        public Main main { get; set; }

        public List<Weather> weather { get; set; }
    }
}