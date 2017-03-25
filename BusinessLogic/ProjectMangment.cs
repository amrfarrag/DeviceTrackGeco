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
        public ProjectMangment()
        {
            
        }
        public List<Project> GetProjects()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Model.Project, Project>());
            List<Project> projects = new List<Project>();
            using(DeviceTractingContext ctx=new DeviceTractingContext())
            {
                List<Model.Project> ProjectsModel = (from t in ctx.Projects select t).ToList<Model.Project>();
                foreach(Model.Project x in ProjectsModel)
                {
                    projects.Add(Mapper.Map<Project>(x));
                }
            }
            return projects;
        }
        public void Save(Project pr)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Project, Model.Project>());
            using (DeviceTractingContext ctx =new DeviceTractingContext())
            {
                Model.Project temp = Mapper.Map<Model.Project>(pr);

                if (pr.ProjectID == 0)
                {
                    
                    ctx.Projects.Add(temp);
                    
                }
                else
                {
                    ctx.Entry<Model.Project>(temp).State = EntityState.Modified;

                }
                    ctx.SaveChanges();
                    
            }
        }

    }
}
