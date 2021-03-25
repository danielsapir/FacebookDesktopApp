using System;
using System.Collections.Generic;
using FacebookAppEngine;

namespace FacebookAppUI
{
     public class ComboBoxFilterItem
     {
          public string FilterName { get; set; }
          
          public Func<LinkedList<StatusProxy>, LinkedList<StatusProxy>> CommandMethod { get; set; }

          public LinkedList<StatusProxy> Selected(LinkedList<StatusProxy> i_ListOfStatuses)
          {
               return CommandMethod.Invoke(i_ListOfStatuses);
          }
     }
}