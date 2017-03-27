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
        
        public List<Employer> GetEmployers()
        {
            List<Employer> emps = new List<Employer>();
            if (this.ProjectID == 0) return emps;
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<Model.Employer, Employer>());
            using(DAL.DeviceTractingContext ctx = new DAL.DeviceTractingContext())
            {

                emps = AutoMapper.Mapper.Map<List<Employer>>(from t in ctx.EmployerProjects
                                                         where t.State == EmployerState.Joined
                                                         && t.ProjectID == this.ProjectID 
                                                         select t.Employer);
            }
            return emps;
        }



    }
}
