using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace BusinessLogic
{
    public class Project
    {
        public int ProjectID { get; set; }
        public DateTime StartDate { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        
        public void AddEmployer(Employer emp)
        {

        }
        public void RemoveEmployer(Employer emp)
        {

        }
        public void DeleteEmployer(Employer emp) {

        }
        public void CloseProject()
        {

        }


    }
}
