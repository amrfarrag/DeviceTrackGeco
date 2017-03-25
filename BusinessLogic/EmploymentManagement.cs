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
        public EmploymentManagement()
        {
            ctx = new DeviceTractingContext();
        }
        public List<EmployerTitle> GetTitles()
        {
            List<EmployerTitle> ret = new List<EmployerTitle>();
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<Model.EmployerTitle, EmployerTitle>());
            List<Model.EmployerTitle> titles = (from t in ctx.EmployerTitles select t).ToList<Model.EmployerTitle>();
            foreach(Model.EmployerTitle t in titles)
            {
                ret.Add(AutoMapper.Mapper.Map<EmployerTitle>(t));
            }
            return ret;
        }
        public List<Project> GetProjects(Employer emp)
        {

        }
        public List<Project> GetHistory()
        {

        }
        public Project GetLastProject()
        {

        }
        public void Dispose()
        {
            ctx.Dispose();
            GC.SuppressFinalize(ctx);
        }
    }
}
