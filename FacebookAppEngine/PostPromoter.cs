using System;
using System.Linq;
using FacebookAppEngine;
using FacebookWrapper.ObjectModel;

namespace FacebookAppEngine
{
    public class PostPromoter : Promoter
    {
        public PostPromoter(User i_UsertToPromote, Func<PostedItem, int> i_StatisticsMethod) : base(i_StatisticsMethod)
        {
            UserToPromote = i_UsertToPromote;
        }

        public override DateTime FindBestTimeToPost()
        {
            int bestHourToPost;

            if (UserToPromote != null)
            {
                bestHourToPost = BestHourToPost(UserToPromote.Statuses.ToArray());
            }
            else
            {
                throw new UserNotLoggedInException();
            }

            DateTime tommorow = DateTime.Today.AddDays(1);
            return new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, bestHourToPost, 0, 0);
        }
    }
}
