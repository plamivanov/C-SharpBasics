using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Einumerable;
using CompanyHierarchy.Interfaces;
namespace CompanyHierarchy
{
    public class Developer:RegularEmployee,IDeveloper
    {
        private List<Projects> projects;
        public Developer(string id,string firstName,string lastName,decimal salary,Departments department,List<Projects>projects)
            :base(id,firstName,lastName,salary,department)
        {
            this.Projects = projects;
        }
        public List<Projects> Projects { get; set; }

        public override string ToString()
        {
            string g = "";
            foreach (var item in this.Projects)
            {
                g += item.ProjectName + " " + item.ProjectStartDate.ToString("dd-MM-yyyy") + " " + item.Details + " " + item.OpenClosed + "\n";
            }
            return base.ToString()+"\n"+g;
        }
    }
}
