using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public enum State
    {
        New, Queued, Transfer, Ended
    }
    public class Device
    {
        public int ID { get; set; }
        public string Description { get; set; }
    }
}
