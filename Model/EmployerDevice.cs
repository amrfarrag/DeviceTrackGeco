using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

   public class EmployerDevice
    {
        public int EmployerDeviceID { get; set; }
        public int DeviceID { get; set; }
        public int? EmployerID { get; set; }
        public int? ProjectID { get; set; }
        public string Description { get; set; }
        public DateTime AssignedDate { get; set; }
        public bool IsOwned { get; set; }
        public virtual Employer Employer { get; set; }
        public virtual Project Project { get; set; }
        public virtual Device Device { get; set; }


    }
}
