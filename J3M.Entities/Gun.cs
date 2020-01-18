using System;
using System.Collections.Generic;

namespace J3M.Entities
{
    public class Gun
    {
        public int NumpadNo { get; set; }
        public string Name { get; set; }
        public IEnumerable<Point> Values { get; set; }
        public int OrderNo { get; set; }
        public int WaitTime { get; set; }

    }
}
