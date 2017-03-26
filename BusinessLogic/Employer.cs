using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
  public  class Employer
    {
        public int EmployerID { get; set; }
        public string Name { get; set; }
        public int EmployerTitleID { get; set; }
        public Project GetCurrentProject()
        {
            Project pr = null;
            if (EmployerID == 0) return pr;
            EmploymentManagement emang = new EmploymentManagement();
           return emang.GetLastProject(this);

        }
        //public virtual ICollection<EmployerProject> EmployerMovments { get; set; }
    }
}
