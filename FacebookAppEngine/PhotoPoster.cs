using System;
using FacebookAppEngine;
using FacebookWrapper.ObjectModel;

namespace FacebookAppEngine
{
    public class PhotoPoster : Poster
    {
        public string PhotoPath { get; set; }

        public PhotoPoster(User i_NewLoggedUser, string i_PhotoPath) : base(i_NewLoggedUser)
        {
            PhotoPath = i_PhotoPath;
            LikesPromoter = new PhotoPromoter(i_NewLoggedUser, (postedItem) => postedItem.Comments.Count);
        }

        public override PostedItem Post()
        {
               Photo postedPhoto = new Photo();

               try
               {
                   UserToPost.PostPhoto(PhotoPath);
               }
               catch (Exception) 
               { 
               }

               return postedPhoto;
        }
    }
}
