using System;

namespace CompanyHierarchy.Interfaces
{
    interface ICustomer:IPerson
    {
         decimal NetPerchaseAmount { get; set; }
    }
}
