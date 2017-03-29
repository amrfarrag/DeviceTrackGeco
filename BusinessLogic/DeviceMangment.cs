using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
  public  class DeviceMangment
    {
        DAL.DeviceTractingContext ctx = null;
        DeviceTrack dt = null;
        public DeviceMangment()
        {
             ctx = new DAL.DeviceTractingContext();
        }
        public void Transfer(DeviceTrack tr)
        {
            this.dt = tr;
            Save();
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<DeviceTrack, Model.EmployerDevice>().ForMember(m => m.Employer ,op => op.Ignore()).ForMember(x =>x.Project,opt =>opt.Ignore()));
            Model.EmployerDevice ed = AutoMapper.Mapper.Map<Model.EmployerDevice>(dt);
            ed.IsOwned = true;
            ctx.EmployerDevices.Add(ed);
            ctx.SaveChanges();
        }
        private void ClearOwnership()
        {
            List<Model.EmployerDevice> temp = (from t in ctx.EmployerDevices
                       where t.DeviceID == dt.DeviceID
                       && t.IsOwned == true
                       select t).ToList<Model.EmployerDevice>();
                foreach (Model.EmployerDevice x in temp)
                {
                    x.IsOwned = false;
                    ctx.Entry<Model.EmployerDevice>(x).State = System.Data.Entity.EntityState.Modified;

                }
                ctx.SaveChanges();
            
        }
        private void Save()
        {
            if (dt.DeviceID == 0)
            {
                Model.Device dv = new Model.Device() { Description = dt.Description, State = Model.DeviceState.New };
                ctx.Devices.Add(dv);
                ctx.SaveChanges();
                dt.DeviceID = dv.ID;
            }
            else {
                Model.Device dv = (from t in ctx.Devices where t.ID == dt.DeviceID select t).First();
                if (dt.ProjectID == 0)
                        {
                            dv.State = Model.DeviceState.Queued;

                        }
                else
                        {
                            dv.State = Model.DeviceState.Transfer;
                        }

            }
            ctx.SaveChanges();
            ClearOwnership();
        }
        public DeviceTrack GetCurrentPosition(Device dv)
        {
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<Model.EmployerDevice, DeviceTrack>());
            return AutoMapper.Mapper.Map<DeviceTrack>( 
                    (from t in ctx.EmployerDevices
                    where t.DeviceID == dv.ID && t.IsOwned == true
                    select t).First());
        }
        public List<DeviceTrack> GetAllWorking()
        {
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<Model.EmployerDevice, DeviceTrack>());
            return AutoMapper.Mapper.Map<List<DeviceTrack>>(from t in ctx.EmployerDevices where t.IsOwned
                                                            && t.ProjectID != null
                                                            select t );
        }
        public List<DeviceTrack> GetAllWorking(Project pr)
        {
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<Model.EmployerDevice, DeviceTrack>());
            return AutoMapper.Mapper.Map<List<DeviceTrack>>(from t in ctx.EmployerDevices
                                                            where t.ProjectID == pr.ProjectID
                                                            select t);
        }
        public List<DeviceTrack> GetAllWorking(Employer emp)
        {
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<Model.EmployerDevice, DeviceTrack>());
            return AutoMapper.Mapper.Map<List<DeviceTrack>>(from t in ctx.EmployerDevices
                                                            where t.EmployerID == emp.EmployerID
                                                            select t);
        }
        public Device GetDevice(int id)
        {
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<Model.Device, Device>());
            return AutoMapper.Mapper.Map<Device>((from t in ctx.Devices where t.ID == id select t).First());

        }
        public List<DeviceTrack> GetAllTracking(Device dev)
        {
            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<Model.EmployerDevice, DeviceTrack>());
            return AutoMapper.Mapper.Map<List<DeviceTrack>>(from t in ctx.EmployerDevices
                                                            where t.DeviceID == dev.ID
                                                            select t);
        }
    }
}
