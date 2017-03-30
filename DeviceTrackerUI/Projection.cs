using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceTrackerUI
{
  public  class DeviceTrackProjection
    {
                 public int ID { get; set; }
                                                               
                  public  string  ProjectName { get; set; }
                                                               
                 public string EmployerName { get; set; }
                                                               
                  public string Descripation { get; set; }
                                                               
                 public DateTime Date { get; set; }
                public bool IsOwned { get; set; }
    }
}
