using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture15_10._03._2021
{
    public partial class Shop
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Category { get; set; }

        public virtual Item Item { get; set; }
    }
}
