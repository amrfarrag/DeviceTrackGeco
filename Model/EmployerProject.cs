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
        public int EmployerProjectID { get; set; }
        public int EmployerID { get; set; }
        public int ProjectID { get; set; }
        public DateTime Date { get; set; }
        public EmployerState State { get; set; }
        public virtual Employer Employer { get; set; }
        public virtual Project Project { get; set; }
    }
}
