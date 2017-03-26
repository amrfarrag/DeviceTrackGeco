using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL;
namespace BusinessLogic
{
    public  class ProjectMangment :IDisposable
    {
        DeviceTractingContext ctx = null;
        public ProjectMangment()
        {
            ctx = new DeviceTractingContext();
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<Model.Project, Project>());
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<Project, Model.Project>());

        }

        public void Dispose()
        {
            ctx.Dispose();
            GC.SuppressFinalize(ctx);
        }

        public List<Project> GetProjects()
        {
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<Model.Project, Project>());

            return AutoMapper.Mapper.Map<List<Project>>((from t in ctx.Projects select t).ToList<Model.Project>());
        }
        public void Save(Project pr)
        {
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<Project, Model.Project>());

            Model.Project temp =AutoMapper.Mapper.Map<Model.Project>(pr);

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
