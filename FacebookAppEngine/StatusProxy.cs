using System;
using FacebookWrapper.ObjectModel;

namespace FacebookAppEngine
{
     public class StatusProxy : Status
     {
          public new DateTime CreatedTime { get; set; }
     }
}
