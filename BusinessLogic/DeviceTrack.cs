using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
  
  public  class DeviceTrack
    {
        public int EmployerDeviceID { get; set; }
        public int DeviceID { get; set; }
        public int? EmployerID { get; set; }
        public int? ProjectID { get; set; }
        public string Description { get; set; }
        public DateTime AssignedDate { get; set; }
        public bool IsOwned { get; set; }
        public Project GetProject()
        {
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<Model.Project, Project>());
            Model.Project pr = null;
            using (DAL.DeviceTractingContext ctx = new DAL.DeviceTractingContext())
            {
                pr = (from t in ctx.Projects
                      where t.ProjectID == this.ProjectID
                      select t).FirstOrDefault();
            }
            return AutoMapper.Mapper.Map<Project>(pr);
        }
        public Employer GetEmployer()
        {
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<Model.Employer, Employer>());
            Model.Employer emp = null;
            using (DAL.DeviceTractingContext ctx = new DAL.DeviceTractingContext())
            {
                emp = (from t in ctx.Employers
                       where t.EmployerID == this.EmployerID
                       select t).FirstOrDefault();

            }
            return AutoMapper.Mapper.Map<Employer>(emp);
        }

    }
}
