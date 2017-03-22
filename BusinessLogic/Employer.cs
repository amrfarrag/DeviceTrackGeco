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
        //public virtual EmployerTitle Title { get; set; }
        //public virtual ICollection<EmployerProject> EmployerMovments { get; set; }
    }
}
