using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Windows.Forms;
using FacebookAppEngine;
using FacebookAppUI;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public partial class FacebookForm : Form
    {
        private string m_PhotoFilePath;
        private bool m_TextboxFilled = false;
        private bool m_IsLoggedIn = false;
        private DateTime m_TimeWhenPostIsPosted;
        private DateTime m_BestToPostAStatus;
        private DateTime m_BestToPostAPhoto;

          public FacebookForm()
          {
               InitializeComponent();
               addFiltersToFiltersComboBox();
               comboBoxFilter.DisplayMember = "FilterName";
          }

          private void addFiltersToFiltersComboBox()
          {
               comboBoxFilter.Items.Add(new ComboBoxFilterItem() { FilterName = "All", CommandMethod = (PostedStatuses) => PostedStatuses });
               comboBoxFilter.Items.Add(new ComboBoxFilterItem() { FilterName = "More Than 20 chars", CommandMethod = Poster.MoreThanTwentyCharsFilter });
               comboBoxFilter.Items.Add(new ComboBoxFilterItem() { FilterName = "Post This Hour", CommandMethod = Poster.PostedThisHour });
               comboBoxFilter.Items.Add(new ComboBoxFilterItem() { FilterName = "Up to 20 chars", CommandMethod = Poster.UptoTwentyCharsFilter });
          }

          private void buttonLoginLogout_Click(object sender, EventArgs e)
        {
            if (!m_IsLoggedIn)
            {
                loginToUser(checkBoxRememberMe.Checked);
            }
            else
            {
                logoutUser();
            }

            componentsEnableDisable();
        }

        private void componentsEnableDisable()
        {
            panelCheckIns.Enabled = m_IsLoggedIn;
            panelEvents.Enabled = m_IsLoggedIn;
            panelFriendsNames.Enabled = m_IsLoggedIn;
            panelLikedPages.Enabled = m_IsLoggedIn;
            labelUserName.Visible = m_IsLoggedIn;
            groupBoxPostPoptions.Enabled = m_IsLoggedIn;
            checkBoxRememberMe.Enabled = !m_IsLoggedIn;
        }

        private void logoutUser()
        {
            pictureBoxBackground.Image = null;
            pictureBoxProfile.Image = null;
            groupBoxTimeToPost.Enabled = false;
            m_IsLoggedIn = false;
            buttonLoginLogout.Text = "Login";
            buttonLoginLogout.BackColor = Color.DodgerBlue;
            FBEngine.Instance.LogoutUser();
            buttonPost.Enabled = false;
        }

        private void loginToUser(bool i_IsRememberd)
        {
            try
            {
                FBEngine.Instance.LoginUser(i_IsRememberd);
                pictureBoxProfile.LoadAsync(FBEngine.Instance.FetchUserProfilePictureURL());
                pictureBoxBackground.LoadAsync(FBEngine.Instance.FetchUserCoverPhotoURL());
                labelUserName.Text = FBEngine.Instance.LoggedInUser.Name;
                FBEngine.Instance.SavedAppSettings.RememberMe = checkBoxRememberMe.Checked;
                m_IsLoggedIn = true;
                buttonLoginLogout.Text = "Logout";
                buttonLoginLogout.BackColor = Color.Red;
            }
            catch (Exception)
            {
                MessageBox.Show("Login failed, Please try again later. Sorry for inconvinience", "LOGIN FAILED", MessageBoxButtons.OK);
                this.Close();
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if(FBEngine.Instance.SavedAppSettings.RememberMe)
            {
                loginToUser(FBEngine.Instance.SavedAppSettings.RememberMe);
                componentsEnableDisable();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            FBEngine.Instance.LogoutUser();
        }

        private void radioButtonPhoto_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxTimeToPost.Enabled = true;
            buttonSelectPhoto.Enabled = radioButtonPhoto.Checked;

            radioButtonPostAtBestTime.Enabled = m_BestToPostAPhoto != DateTime.MinValue;
        }

        private void radioButtonStatus_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxTimeToPost.Enabled = true;
            richTextBoxStatus.Enabled = true;
            if(m_TextboxFilled)
            {
                buttonPost.Enabled = true;
            }

            radioButtonPostAtBestTime.Enabled = m_BestToPostAStatus != DateTime.MinValue;
        }

        private void buttonSelectPhoto_Click(object sender, EventArgs e)
        {
            DialogResult openFileDailogResult = openFileDialogPhoto.ShowDialog();
            
            if(openFileDailogResult == DialogResult.OK)
            {
                m_PhotoFilePath = openFileDialogPhoto.FileName;
            }

            buttonPost.Enabled = openFileDailogResult == DialogResult.OK;
        }

        private void radioButtonPostByDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerPost.Enabled = radioButtonPostByDate.Checked;
        }

        private void richTextBoxStatus_Enter(object sender, EventArgs e)
        {
            if(!m_TextboxFilled)
            {
                richTextBoxStatus.Text = string.Empty;
            }
        }

        private void richTextBoxStatus_Leave(object sender, EventArgs e)
        {
            m_TextboxFilled = richTextBoxStatus.Text != string.Empty;
            if (!m_TextboxFilled)
            {
                richTextBoxStatus.Text = "What's on your mind?";
            }

            buttonPost.Enabled = m_TextboxFilled;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
               string textForStatusOrPhotoPath = getStringByRadioButtonChoice();
               Poster poster;

               if(radioButtonPostNow.Checked)
               {
                       FBEngine.Instance.Post(textForStatusOrPhotoPath, DateTime.Now.AddDays(-1), getPostOptionByRadioChoice());
                       labelTimeLeftToPost.Text = "Posted!";
               }
               else if(radioButtonPostByDate.Checked)
               {
                    poster = FBEngine.Instance.Post(textForStatusOrPhotoPath, dateTimePickerPost.Value, getPostOptionByRadioChoice());
                    m_TimeWhenPostIsPosted = dateTimePickerPost.Value;
                    timerTimeLeftToPostToBePosted.Start();
                    if (poster != null)
                    {
                         poster.PostTimerNotifier.AfterPost += PostTimerNotifier_AfterPost;
                    }
               }
               else
               {
                    poster = FBEngine.Instance.PostInBestTime(textForStatusOrPhotoPath, getPostOptionByRadioChoice());
                    m_TimeWhenPostIsPosted = FBEngine.Instance.GetBestTimeToPost(getPromtingOptionByRadioChoice());
                    if(m_TimeWhenPostIsPosted < DateTime.Now)
                    {
                         m_TimeWhenPostIsPosted = m_TimeWhenPostIsPosted.AddDays(1);
                    }

                    timerTimeLeftToPostToBePosted.Start();
                    if (poster != null)
                    {
                         poster.PostTimerNotifier.AfterPost += PostTimerNotifier_AfterPost;
                    }
               }
        }

        private void PostTimerNotifier_AfterPost()
        {
             labelTimeLeftToPost.Invoke(new Action(() => labelTimeLeftToPost.Text = "Posted!"));
        }

        private PromoterFactory.ePromoterType getPromtingOptionByRadioChoice()
        {
            PromoterFactory.ePromoterType choosenOption;

            if (radioButtonStatus.Checked)
            {
                choosenOption = PromoterFactory.ePromoterType.Status;
            }
            else
            {
                choosenOption = PromoterFactory.ePromoterType.Photo;
            }

            return choosenOption;
        }

        private string getStringByRadioButtonChoice()
        {
            string textForStatusOrPhotoPath = string.Empty;

            switch (getPostOptionByRadioChoice())
            {
                case Poster.ePostOptions.Photo:
                    textForStatusOrPhotoPath = m_PhotoFilePath;
                    break;
                case Poster.ePostOptions.Status:
                    textForStatusOrPhotoPath = richTextBoxStatus.Text;
                    break;
            }

            return textForStatusOrPhotoPath;
        }

        private Poster.ePostOptions getPostOptionByRadioChoice()
        {
            Poster.ePostOptions choosenOption;

            if(radioButtonStatus.Checked)
            {
                choosenOption = Poster.ePostOptions.Status;
            }
            else
            {
                choosenOption = Poster.ePostOptions.Photo;
            }

            return choosenOption;
        }

        private void timerTimeLeftToPostToBePosted_Tick(object sender, EventArgs e)
        {
            double hoursLeftTillPostIsPosted = (m_TimeWhenPostIsPosted - DateTime.Now).TotalHours;

            if(hoursLeftTillPostIsPosted > 0)
            {
                labelTimeLeftToPost.Text = string.Format("Post will be published in:{0:0.00} hours", hoursLeftTillPostIsPosted);
            }
            else
            {
                timerTimeLeftToPostToBePosted.Stop();
            }
        }

        private void buttonFetchChekins_Click(object sender, EventArgs e)
        {
            panelCheckInData.Visible = true;
            photoBindingAdapterBindingSource.DataSource = FBEngine.Instance.FetchAllCheckinsPlaces();
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            foreach (string eventName in FBEngine.Instance.FetchAllEventsNames())
            {
                listBoxEvents.Items.Add(eventName);
            }
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            panelFriendData.Visible = true;
            userBindingSource.DataSource = FBEngine.Instance.LoggedInUser.Friends;
        }

        private void buttonFetchLikedPages_Click(object sender, EventArgs e)
        {
            foreach (string likedPageName in FBEngine.Instance.FetchAllLikedPagesNames())
            {
                listBoxLikedPages.Items.Add(likedPageName);
            }
        }

        private void buttonGetBestTime_Click(object sender, EventArgs e)
        {
            labelBestTimeToPost.ForeColor = Color.Green;
            labelBestTimeToPost.Visible = true;
            labelBestTimeToPost.Text = "It might take few moments...";
            buttonGetBestTime.Enabled = false;

            new Thread(FindBestTimeToPost).Start();
        }
        
        public void FindBestTimeToPost()
        {
            PromoterFactory.ePromoterType optionChoosed = 
                radioButtonPhoto.Checked ? PromoterFactory.ePromoterType.Photo : PromoterFactory.ePromoterType.Status;
            int bestHourToPost = 0;
            string bestTimeToPostText = null;

            try
            {
                bestTimeToPostText = bestTimeToPostIdentifierAndStringMaking(optionChoosed, ref bestHourToPost);
            }
            catch
            {
                labelBestTimeToPost.Text = "Please login first!";
            }
            
            labelBestTimeToPost.Invoke(new Action(() =>
            {
                labelBestTimeToPost.Text = bestTimeToPostText;
                radioButtonPostAtBestTime.Enabled = true;
                buttonGetBestTime.Enabled = true;
            }));
        }

        private string bestTimeToPostIdentifierAndStringMaking(PromoterFactory.ePromoterType i_OptionChoosed, ref int o_BestHourToPost)
        {
            string bestTimeToPostText;

            switch (i_OptionChoosed)
            {
                case PromoterFactory.ePromoterType.Photo:
                    m_BestToPostAPhoto = FBEngine.Instance.GetBestTimeToPost(i_OptionChoosed);
                    o_BestHourToPost = m_BestToPostAPhoto.Hour;
                    break;
                case PromoterFactory.ePromoterType.Status:
                    m_BestToPostAStatus = FBEngine.Instance.GetBestTimeToPost(i_OptionChoosed);
                    o_BestHourToPost = m_BestToPostAStatus.Hour;
                    break;
            }

            bestTimeToPostText = string.Format("The best time to post {0}:\n{1}:00:00", i_OptionChoosed.ToString(), o_BestHourToPost);

            return bestTimeToPostText;
        }

          private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
          {
               addStatusesToFlowPane((comboBoxFilter.SelectedItem as ComboBoxFilterItem).Selected(FBEngine.Instance.PostedStatuses));
          }

          private void addStatusesToFlowPane(LinkedList<StatusProxy> i_ListOfStatuses)
          {
               int i = 0;

               flowLayoutPanelPostedStatuses.Controls.Clear();
               foreach (StatusProxy status in i_ListOfStatuses)
               {
                    PostedStatus postedStatus = new PostedStatus() { StausOfForm = status };
                    postedStatus.Tag = i;
                    postedStatus.Visible = true;
                    flowLayoutPanelPostedStatuses.Controls.Add(postedStatus);
                    i++;
               }
          }
     }
}
