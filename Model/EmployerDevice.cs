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
        public int EmployerDeviceID;
        public int EmployerID;
        public int ProjectID;
        public int 
        public DeviceState State;
        public virtual Employer Employer { get; set; }
        public virtual Project Project { get; set; }

    }
}
