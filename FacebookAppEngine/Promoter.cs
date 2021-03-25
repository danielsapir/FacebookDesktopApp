using System;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookAppEngine
{
    public abstract class Promoter
    {
          public User UserToPromote { get; set; }

          public Func<PostedItem, int> PostItemStatiticsCounter { get; set; }

          public Promoter(Func<PostedItem, int> i_StatisticsMethod)
          {
               PostItemStatiticsCounter = i_StatisticsMethod;
          }
   
        public abstract DateTime FindBestTimeToPost();

        protected int BestHourToPost(PostedItem[] i_ListOfLikedPostedItems)
        {
               int[] bucketOfLikesFor24Hrs = new int[24];
               int[] bucketOfPostedItemsFor24Hrs = new int[24];
               double[] bucketOfAvgLikesFor24Hrs = new double[24];

               bucketOfLikesFor24Hrs.Initialize();
               bucketOfPostedItemsFor24Hrs.Initialize();
               foreach (PostedItem postedItem in i_ListOfLikedPostedItems)
               {
                   try
                   {
                         ////We intended to make the statics on the likes but we dont have Permissions to do so
                         ////So we are using the comments number to make the statistics
                         ////The following line is here to show whats we really meant to do...
                         ////bucketOfLikesFor24Hrs[postedItem.CreatedTime.Value.Hour] += postedItem.LikedBy.Count;
                         bucketOfLikesFor24Hrs[postedItem.CreatedTime.Value.Hour] += PostItemStatiticsCounter(postedItem);
                         bucketOfPostedItemsFor24Hrs[postedItem.CreatedTime.Value.Hour]++;
                   }
                   catch(Exception)
                   { 
                   }
               }

               for (int i = 0; i < 24; i++)
               {
                   if (bucketOfPostedItemsFor24Hrs[i] != 0)
                   {
                       bucketOfAvgLikesFor24Hrs[i] = bucketOfLikesFor24Hrs[i] / bucketOfPostedItemsFor24Hrs[i];
                   }
               }

               return findBiggestCellIndex(bucketOfAvgLikesFor24Hrs);
        }

        private int findBiggestCellIndex(double[] i_Array)
        {
            int indexOfBiggestCell = 0;

            for (int i = 1; i < i_Array.Length; i++)
            {
                if (i_Array[indexOfBiggestCell] < i_Array[i])
                {
                    indexOfBiggestCell = i;
                }
            }

            return indexOfBiggestCell;
        }
    }
}
