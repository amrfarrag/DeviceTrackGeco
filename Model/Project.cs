using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum ProjectState
    {
       Opening,Running,Closed,Closing
    }
    public class Project
    {
        public int ProjectID { get; set; }
        public DateTime StartDate { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ProjectState State { get; set; }
        public virtual ICollection<EmployerProject> EmploymentHistory { get; set; }
    }
}
