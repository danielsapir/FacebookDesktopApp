using System;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FacebookAppEngine
{
    public class PhotoPromoter : Promoter
    {
        public PhotoPromoter(User i_UserToPromote, Func<PostedItem, int> i_StatisticsMethod) : base(i_StatisticsMethod)
        {
            UserToPromote = i_UserToPromote;
        }

        public override DateTime FindBestTimeToPost()
        {
            int bestHourToPost;

            if (UserToPromote != null)
            { 
                bestHourToPost = BestHourToPost(UserToPromote.PhotosTaggedIn.ToArray());
            }
            else
            {
                throw new UserNotLoggedInException();
            }

            return new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, bestHourToPost, 0, 0);
        }
    }
}
