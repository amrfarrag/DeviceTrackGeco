using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BusinessLogic;

namespace BusinessLogic
{
    public class EmploymentManagement : IDisposable
    {
        private DeviceTractingContext ctx = null;
        private Employer temp = null;
        public EmploymentManagement()
        {
            ctx = new DeviceTractingContext();


        }
        public EmploymentManagement(Employer emp)
        {
            ctx = new DeviceTractingContext();
            this.temp = emp;

        }
        public List<EmployerTitle> GetTitles()
        {
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<Model.EmployerTitle, EmployerTitle>());

            return AutoMapper.Mapper.Map<List<EmployerTitle>>((from t in ctx.EmployerTitles select t).ToList<Model.EmployerTitle>());
        }
        public List<Project> GetProjects(Employer emp)
        {
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<Model.Project, Project>());
            return AutoMapper.Mapper.Map<List<Project>>((from t in ctx.EmployerProjects where
                                                         t.EmployerID == emp.EmployerID
                                                         select t.Project).ToList<Model.Project>());
        }
        public List<Project> GetCurrentProjects(Employer emp)
        {
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<Model.Project, Project>());
            return AutoMapper.Mapper.Map<List<Project>>((from t in ctx.EmployerProjects where
                                                         t.EmployerID == emp.EmployerID
                                                         && t.State == Model.EmployerState.Joined
                                                         select t.Project).ToList<Model.Project>());
        }
        public Project GetLastProject(Employer emp)
        {
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<Model.Project, Project>());
            return AutoMapper.Mapper.Map<Project>((from t in ctx.EmployerProjects where t.EmployerID == emp.EmployerID
                                                   select t.Project).First());
        }
        public void Save(Employer emp)
        {
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<Employer, Model.Employer>());
            Model.Employer saved = AutoMapper.Mapper.Map<Model.Employer>(emp);
            if (emp.EmployerID == 0) {
                ctx.Employers.Add(saved);
                
            }
            else {
                ctx.Entry(saved).State = System.Data.Entity.EntityState.Modified;
                 }
            ctx.SaveChanges();
            this.temp = emp;
            this.temp.EmployerID = saved.EmployerID;
        }
        public void Join(int id ,DateTime joindate)
        {
            //check if not joinind
            Model.EmployerProject ep = new Model.EmployerProject() { EmployerID = temp.EmployerID, Date = joindate, ProjectID = id, State = Model.EmployerState.Joined };
            ctx.EmployerProjects.Add(ep);
            ctx.SaveChanges();
        }
        public void Transfer(int id , DateTime transferdate)
        {
            Leave(id);
            Join(id, transferdate);
            
        }
        private void Leave(int id)
        {
            var te = from t in ctx.EmployerProjects
                     where t.EmployerID == temp.EmployerID
                     && t.State == Model.EmployerState.Joined
                     select t;
            foreach (Model.EmployerProject ep in te)
            {
                ep.State = Model.EmployerState.Leaved;
                ctx.Entry<Model.EmployerProject>(ep).State = System.Data.Entity.EntityState.Modified;

            }
        }
        public List<Employer> GetEmployers()
        {
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<Model.Employer, Employer>());
            return AutoMapper.Mapper.Map<List<Employer>>(from t in ctx.Employers select t);
        }
        public void Dispose()
        {
            ctx.Dispose();
            GC.SuppressFinalize(ctx);
        }
    }
}
