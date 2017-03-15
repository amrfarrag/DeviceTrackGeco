using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum EmployerState
    {
        Joined,Leaved
    }
   public class EmployerProject
    {
        public int EmployerProjectID;
        public int EmployerID;
        public int ProjectID;
        public EmployerState State;
        public virtual Employer Employer { get; set; }
        public virtual Project Project { get; set; }
    }
}
