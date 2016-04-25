using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Interfaces
{
    public interface IPerson
    {
         string Id { get; set; }
         string LastName { get; set; }
         string FirstName { get; set; }
    }
}
