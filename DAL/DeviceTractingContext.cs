using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.Entity;

namespace DAL
{
    public class DeviceTractingContext :DbContext

    {
        public DeviceTractingContext() : base("DeviceTractingDB")
        {

        }
            public DbSet<EmployerTitle> EmployerTitles { get; set; }

            public DbSet<Project> Projects { get; set; }
             public DbSet<EmployerDevice> EmployerDevices { get; set; }
             public DbSet<Device> Devices { get; set; }
             public DbSet<Employer> Employers { get; set; }
             public DbSet<EmployerDeviceDescription> EmployerDeviceDescriptions { get; set; }
             public DbSet<EmployerProject> EmployerProjects { get; set; }



    }
}
