using FacebookWrapper.ObjectModel;

namespace FacebookAppEngine
{
    public static class PromoterFactory
    {
        public enum ePromoterType
        {
            Status,
            Photo
        }

        public static Promoter PromoterCreator(ePromoterType i_PromoterOptionChoosed, User i_UserToPromote)
        {
            Promoter createdPromoter;

            switch (i_PromoterOptionChoosed)
            {
                case ePromoterType.Photo:
                    createdPromoter = new PhotoPromoter(i_UserToPromote, (postedItem) => postedItem.Comments.Count);
                    break;
                case ePromoterType.Status:
                    createdPromoter = new PostPromoter(i_UserToPromote, (postedItem) => postedItem.Comments.Count);
                    break;
                default:
                    createdPromoter = null;
                    break;
            }

            return createdPromoter;
        }
    }
}
