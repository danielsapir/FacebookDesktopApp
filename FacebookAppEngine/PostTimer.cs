using System;
using System.Threading;

namespace FacebookAppEngine
{
     public class PostTimer
     {
          public event Action TimeToPost;

          public event Action AfterPost;

          private Timer m_Timer = null;

          public PostTimer(DateTime i_TimeToPost)
          {
               long timeLeftToPost = (long)(i_TimeToPost - DateTime.Now).TotalMilliseconds;
               m_Timer = new Timer(onTimeToPost, this, timeLeftToPost, Timeout.Infinite);
          }

          // $G$ CSS-999 (-3) symbols are not spaced properly
        // $G$ CSS-999 (-3) you should check if TimeToPost != null before invoking
        private void onTimeToPost(object i_PostTimer)
          {
               TimeToPost.Invoke();
               onAfterPost();
          }

        // $G$ CSS-999 (-3) you should check if onAfterPost != null before invoking
        private void onAfterPost()
          {
               AfterPost.Invoke();
               m_Timer = null;
          }

          public bool IsTimerDone()
          {
               return m_Timer == null;
          }
     }
}
