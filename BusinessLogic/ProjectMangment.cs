using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AutoMapper;
using DAL;
namespace BusinessLogic
{
    public  class ProjectMangment
    {
        public List<Project> GetProjects()
        {
            List<Project> projects = new List<Project>();
            using(DeviceTractingContext ctx=new DeviceTractingContext())
            {
                List<Model.Project> ProjectsModel = (from t in ctx.Projects select t).ToList<Model.Project>();
                Mapper.Initialize(cfg => cfg.CreateMap<Model.Project, Project>());
                foreach(Model.Project x in ProjectsModel)
                {
                    projects.Add(Mapper.Map<Project>(x));
                }
            }
            return projects;
        }
        

    }
}
