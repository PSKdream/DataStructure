using Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets
{
    public class LinkedSet : LinkedHeaderCollection, Set
    {
        public new void add(object e)
        {
            if (!base.contains(e))
                base.add(e);
        }
    }
}
