using System;
using System.Collections.Generic;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace FacebookAppEngine
{
    public abstract class Poster
    {
          [Flags]
          public enum ePostOptions
          {
              Status,
              Photo
          }

          public User UserToPost { get; set; }

          public Promoter LikesPromoter { get; set; }
          
          public PostTimer PostTimerNotifier { get; set; }

          protected Poster(User i_NewLoggedUser)
          {
               UserToPost = i_NewLoggedUser;
          }

          public static LinkedList<StatusProxy> MoreThanTwentyCharsFilter(LinkedList<StatusProxy> i_ListOfStatuses)
          {
               LinkedList<StatusProxy> filterdStatuses = new LinkedList<StatusProxy>();

               foreach (StatusProxy status in i_ListOfStatuses)
               {
                    if (status.Message.Length > 20)
                    {
                         filterdStatuses.AddLast(status);
                    }
               }

               return filterdStatuses;
          }

          public static LinkedList<StatusProxy> PostedThisHour(LinkedList<StatusProxy> i_ListOfStatuses)
          {
               LinkedList<StatusProxy> filterdStatuses = new LinkedList<StatusProxy>();

               foreach (StatusProxy status in i_ListOfStatuses)
               {
                    if ((status as StatusProxy).CreatedTime.Hour == DateTime.Now.Hour)
                    {
                         filterdStatuses.AddLast(status);
                    }
               }

               return filterdStatuses;
          }

          public static LinkedList<StatusProxy> UptoTwentyCharsFilter(LinkedList<StatusProxy> i_ListOfStatuses)
          {
               LinkedList<StatusProxy> filterdStatuses = new LinkedList<StatusProxy>();

               foreach (StatusProxy status in i_ListOfStatuses)
               {
                    if (status.Message.Length <= 20)
                    {
                         filterdStatuses.AddLast(status);
                    }
               }

               return filterdStatuses;
          }

          public virtual void PostInBestTime()
          {
              DateTime bestTimeToPost = LikesPromoter.FindBestTimeToPost();
              
              if(bestTimeToPost < DateTime.Now)
              {
                  bestTimeToPost = bestTimeToPost.AddDays(1);
              }

              PostInSelectedTime(bestTimeToPost);
          }

          public virtual void PostInSelectedTime(DateTime i_TimeToPost)
          {
               PostTimerNotifier = new PostTimer(i_TimeToPost);
               PostTimerNotifier.TimeToPost += PostTimerNotifier_TimeToPost;
          }

          private void PostTimerNotifier_TimeToPost()
          {
               try
               {
                    this.Post();
               }
               catch (Exception)
               {
               }
          }

          public abstract PostedItem Post();
     }
}
