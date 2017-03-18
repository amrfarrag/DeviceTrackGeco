using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum DeviceState
    {

        New,Transfered,Queued,Ended

    }
   public class EmployerDevice
    {
        public int EmployerDeviceID { get; set; }
        public int EmployerID { get; set; }
        public int ProjectID { get; set; }
        public int EmployerDeviceDescriptionID { get; set; }
        public DeviceState State { get; set; }
        public virtual Employer Employer { get; set; }
        public virtual Project Project { get; set; }
        public virtual EmployerDeviceDescription Description { get; set; }

    }
}
