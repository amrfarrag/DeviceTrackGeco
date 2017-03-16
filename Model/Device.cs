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
        public int DeviceID;
        public string Description;
        public OwnerType Owenr;
        public DeviceType Type;
    }
}
