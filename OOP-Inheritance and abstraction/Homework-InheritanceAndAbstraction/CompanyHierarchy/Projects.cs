using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Einumerable;
using CompanyHierarchy.Interfaces;
namespace CompanyHierarchy
{
   public class Projects:IProjects
    {
       private string projectName;
       private DateTime projectStartDate;
       private string details;
       private State openClosed;

       public Projects(string projectName,DateTime projectStartDate,string details,State openClosed)
       {
           this.ProjectName = projectName;
           this.ProjectStartDate = projectStartDate;
           this.Details = details;
           this.OpenClosed = openClosed;
       }
       public string ProjectName { get; set; }
       public DateTime ProjectStartDate { get; set; }
       public string Details { get; set; }
       public State OpenClosed { get; set; }

       public void CloseProject()
       {
           if (this.OpenClosed== State.Open)
           {
               this.OpenClosed= State.Closed;
           }
       }

       public override string ToString()
       {
           return this.ProjectName+" "+this.ProjectStartDate.ToString("yyyy-MM-dd")+" "+this.Details+" "+this.OpenClosed;
       }

    }
}
