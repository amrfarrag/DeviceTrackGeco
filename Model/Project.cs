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
        public int ProjectID;
        public DateTime StartDate;
        public string Name;
        public string Location;
        public ProjectState State;
        public virtual ICollection<EmployerProject> EmploymentHistory { get; set; }
    }
}
