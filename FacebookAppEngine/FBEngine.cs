using System;
using System.Collections.Generic;
using System.Linq;
using FacebookAppEngine;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookAppEngine
{
     public sealed class FBEngine
     {
          private static volatile FBEngine s_Instance;


          // $G$ CSS-999 (-3) this member should be readonly
        private static object s_LockObjForInstance = new object();

          private FBEngine()
          {
               SavedAppSettings = AppSettings.GetLastAppSettingsOrDefault();
               UserLoginResult = null;
               LoggedInUser = null;
               FacebookService.s_CollectionLimit = 50;
          }

          public static FBEngine Instance
          {
              get
              {
                  if (s_Instance == null)
                  {
                      lock (s_LockObjForInstance)
                      {
                          if (s_Instance == null)
                          {
                              s_Instance = new FBEngine();
                          }
                      }
                  }

                  return s_Instance;
              }
          }

          public LoginResult UserLoginResult { get; set; }

          public User LoggedInUser { get; private set; }

          public AppSettings SavedAppSettings { get; set; }

          public LinkedList<StatusProxy> PostedStatuses { get; set; }

          public void LoginUser(bool i_IsNeedToRemember)
          {
               if (SavedAppSettings.RememberMe)
               {
                   UserLoginResult = FacebookService.Connect(SavedAppSettings.AccessToken);
               }
               else
               {
                   UserLoginResult = FacebookService.Login(
                       "316345936393858",
                       "user_birthday",
                       "user_friends",
                       "user_hometown",
                       "user_likes",
                       "user_photos",
                       "user_posts",
                       "user_videos",
                       "user_link");
               }
               
               LoggedInUser = UserLoginResult.LoggedInUser;
               SavedAppSettings.RememberMe = i_IsNeedToRemember;
               SavedAppSettings.AccessToken = UserLoginResult.AccessToken;
               PostedStatuses = new LinkedList<StatusProxy>();
          }

          public void LogoutUser()
          {
              if(UserLoginResult != null)
              {
                  SavedAppSettings.AccessToken = UserLoginResult.AccessToken;
                  SavedAppSettings.SaveSettingsToFile();
                  LoggedInUser = null;
                  UserLoginResult = null;

              }
          }

          public string FetchUserProfilePictureURL()
          {
              string profilePictureURL = null;
              if (LoggedInUser != null)
              {
                  profilePictureURL = LoggedInUser.PictureNormalURL;
              }
              else
              {
                  throw new UserNotLoggedInException();
              }

              return profilePictureURL;
          }


          // $G$ CSS-999 (-5) You should have used constants instead of spesific text\numbers in the code.
        public string FetchUserCoverPhotoURL()
          {
              string coverPictureURL = null;
              if (LoggedInUser != null)
              {
                  foreach (Album albumOfUser in LoggedInUser.Albums)
                  {
                      if (albumOfUser.Name == "תמונות נושא" || albumOfUser.Name.ToLower() == "cover photos")
                      {
                          coverPictureURL = albumOfUser.Photos.First().PictureNormalURL;
                      }
                  }
              }
              else
              {
                  throw new UserNotLoggedInException();
              }

              return coverPictureURL;
          }

          public List<PhotoBindingAdapter> FetchAllCheckinsPlaces()
          {
              List<PhotoBindingAdapter> allCheckinPlaces = new List<PhotoBindingAdapter>();

              foreach(Photo photo in LoggedInUser.PhotosTaggedIn)
              {
                  try
                  {
                      if (photo.Place != null)
                      {
                          allCheckinPlaces.Add(new PhotoBindingAdapter(photo));
                      }
                  }
                  catch (Exception) 
                  { 
                  }
              }

              return allCheckinPlaces;
          }

          public List<string> FetchAllEventsNames()
          {
              List<string> allEventsNames = new List<string>();

              foreach (Event userEvent in LoggedInUser.Events)
              {
                  allEventsNames.Add(userEvent.Name);
              }

              return allEventsNames;
          }

          public List<string> FetchAllLikedPagesNames()
          {
              List<string> allLikedPagesNames = new List<string>();

              try
              {
                  foreach (Page likedPage in LoggedInUser.LikedPages)
                  {
                      allLikedPagesNames.Add(likedPage.Name);
                  }
              }
              catch(Exception) 
              { 
              }

              return allLikedPagesNames;
          }

          public Poster Post(string i_TextOrFilePath, DateTime i_TimeToPost, Poster.ePostOptions i_PostOption)
          {
              Poster poster;

              createPosterByPostOption(i_TextOrFilePath, i_PostOption, out poster);
              if (poster != null)
              {
                  if (i_TimeToPost < DateTime.Now)
                  {
                         PostedItem postedItem = poster.Post();
                         if (postedItem is StatusProxy)
                         {
                              PostedStatuses.AddLast(postedItem as StatusProxy);
                         }
                  }
                  else
                  {
                      poster.PostInSelectedTime(i_TimeToPost);
                  }
              }

                 return poster;
          }

          public Poster PostInBestTime(string i_TextOrFilePath, Poster.ePostOptions i_PostOption)
          {
              Poster poster;

              createPosterByPostOption(i_TextOrFilePath, i_PostOption, out poster);
              poster.PostInBestTime();

                 return poster;
          }

          private void createPosterByPostOption(string i_TextOrFilePath, Poster.ePostOptions i_PostOption, out Poster o_Poster)
          {
              switch (i_PostOption)
              {
                  case Poster.ePostOptions.Photo:
                      o_Poster = new PhotoPoster(LoggedInUser, i_TextOrFilePath);
                      break;
                  case Poster.ePostOptions.Status:
                      o_Poster = new StatusPoster(LoggedInUser, i_TextOrFilePath);
                      break;
                  default:
                      o_Poster = null;
                      break;
              }
          }

          public DateTime GetBestTimeToPost(PromoterFactory.ePromoterType i_PostOption)
          {
              Promoter promoter;
              promoter = PromoterFactory.PromoterCreator(i_PostOption, LoggedInUser);

              return promoter.FindBestTimeToPost();
          }
     }
}
