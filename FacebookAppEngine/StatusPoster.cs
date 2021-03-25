using System;
using FacebookWrapper.ObjectModel;

namespace FacebookAppEngine
{
    public class StatusPoster : Poster
    {
          public string StatusText { get; set; }

          public StatusPoster(User i_NewLoggedUser) : base(i_NewLoggedUser)
          {
          }

          public StatusPoster(User i_NewLoggedUser, string i_StatusText) : base(i_NewLoggedUser)
          {
              StatusText = i_StatusText;
              LikesPromoter = new PostPromoter(i_NewLoggedUser, (postedItem) => postedItem.Comments.Count);
          }

          public override PostedItem Post()
          {
               StatusProxy postedStatus = new StatusProxy();
               postedStatus.CreatedTime = DateTime.Now;


               try
               {
                   UserToPost.PostStatus(StatusText);
               }
               catch(Exception) 
               { 
               }

               return postedStatus;
          }
    }
}
