using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum OwnerType
    {
        Personal,Public
    }
    public enum DeviceType
    {
        Mobile,Fixed
    }
    public class Device
    {
        public int DeviceID { get; set; }
        public string Description { get; set; }
        public OwnerType Owenr { get; set; }
        public DeviceType Type { get; set; }
    }
}
