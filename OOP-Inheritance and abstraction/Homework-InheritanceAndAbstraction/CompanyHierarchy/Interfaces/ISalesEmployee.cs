using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Einumerable;

namespace CompanyHierarchy.Interfaces
{
   public interface ISalesEmployee
    {
       List<Sales> Sales { get; set; }
    }
}
