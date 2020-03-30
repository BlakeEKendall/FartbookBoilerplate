using System;
using System.Collections.Generic;
using System.Text;

namespace Fartbook.Objects
{
    public class FartType
    {
        public int FartTypeID { get; set; }
        public bool EmbarassesRecipient { get; set; }
        public bool EmbarassesGiver { get; set; }
        public int Count { get; set; }
        public string Title { get; set; }
        // TODO: Add functionality to describe types of farts
        //public string Description { get; set; }
    }
}
