using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Developer<T>:List<T> where T:Project
    {
    }
}
