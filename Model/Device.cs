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
    public enum DeviceState
    {

        New, Queued, Ended

    }
    public class Device
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public OwnerType Owenr { get; set; }
        public DeviceType Type { get; set; }
        public DeviceState State { get; set; }
    }
}
