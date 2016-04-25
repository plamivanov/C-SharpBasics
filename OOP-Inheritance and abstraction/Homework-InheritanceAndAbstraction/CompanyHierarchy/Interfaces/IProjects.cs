using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Einumerable;


namespace CompanyHierarchy.Interfaces
{
    public interface IProjects
    {
        string ProjectName { get; set; }
        DateTime ProjectStartDate { get; set; }
        string Details { get; set; }
        State OpenClosed { get; set; }
    }
}
