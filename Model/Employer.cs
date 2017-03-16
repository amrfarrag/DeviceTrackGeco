using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Employer
    {
        public int EmployerID;
        public string Name;
        public int EmployerTitleID;
        public virtual EmployerTitle Title { get; set; }
        public virtual ICollection<EmployerProject> EmployerMovments { get; set; }
    }
}
