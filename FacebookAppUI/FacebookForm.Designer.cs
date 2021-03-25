namespace FacebookApp
{
    partial class FacebookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
               this.components = new System.ComponentModel.Container();
               System.Windows.Forms.Label imageNormalLabel;
               System.Windows.Forms.Label createdTimeLabel;
               System.Windows.Forms.Label cityLabel;
               System.Windows.Forms.Label countryLabel;
               System.Windows.Forms.Label nameLabel;
               System.Windows.Forms.Label birthdayLabel;
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacebookForm));
               this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
               this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
               this.buttonLoginLogout = new System.Windows.Forms.Button();
               this.labelUserName = new System.Windows.Forms.Label();
               this.buttonPost = new System.Windows.Forms.Button();
               this.radioButtonStatus = new System.Windows.Forms.RadioButton();
               this.radioButtonPhoto = new System.Windows.Forms.RadioButton();
               this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
               this.buttonSelectPhoto = new System.Windows.Forms.Button();
               this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
               this.dateTimePickerPost = new System.Windows.Forms.DateTimePicker();
               this.radioButtonPostByDate = new System.Windows.Forms.RadioButton();
               this.groupBoxPostPoptions = new System.Windows.Forms.GroupBox();
               this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
               this.radioButtonPostAtBestTime = new System.Windows.Forms.RadioButton();
               this.labelBestTimeToPost = new System.Windows.Forms.Label();
               this.radioButtonPostNow = new System.Windows.Forms.RadioButton();
               this.groupBoxTimeToPost = new System.Windows.Forms.GroupBox();
               this.buttonGetBestTime = new System.Windows.Forms.Button();
               this.timerTimeLeftToPostToBePosted = new System.Windows.Forms.Timer(this.components);
               this.labelTimeLeftToPost = new System.Windows.Forms.Label();
               this.panelCheckIns = new System.Windows.Forms.Panel();
               this.listBoxCheckins = new System.Windows.Forms.ListBox();
               this.photoBindingAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.buttonFetchPhotoChekins = new System.Windows.Forms.Button();
               this.panelEvents = new System.Windows.Forms.Panel();
               this.listBoxEvents = new System.Windows.Forms.ListBox();
               this.buttonFetchEvents = new System.Windows.Forms.Button();
               this.panelFriendsNames = new System.Windows.Forms.Panel();
               this.listBoxFriendsNames = new System.Windows.Forms.ListBox();
               this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.buttonFetchFriendsNames = new System.Windows.Forms.Button();
               this.panelLikedPages = new System.Windows.Forms.Panel();
               this.listBoxLikedPages = new System.Windows.Forms.ListBox();
               this.buttonFetchLikedPages = new System.Windows.Forms.Button();
               this.toolTipBestTimeToPost = new System.Windows.Forms.ToolTip(this.components);
               this.panelFriendData = new System.Windows.Forms.Panel();
               this.birthdayTextBox = new System.Windows.Forms.TextBox();
               this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
               this.nameTextBox = new System.Windows.Forms.TextBox();
               this.panelCheckInData = new System.Windows.Forms.Panel();
               this.countryTextBox = new System.Windows.Forms.TextBox();
               this.cityTextBox = new System.Windows.Forms.TextBox();
               this.createdTimeTextBox = new System.Windows.Forms.TextBox();
               this.imageNormalPictureBox1 = new System.Windows.Forms.PictureBox();
               this.label1 = new System.Windows.Forms.Label();
               this.comboBoxFilter = new System.Windows.Forms.ComboBox();
               this.label2 = new System.Windows.Forms.Label();
               this.flowLayoutPanelPostedStatuses = new System.Windows.Forms.FlowLayoutPanel();
               imageNormalLabel = new System.Windows.Forms.Label();
               createdTimeLabel = new System.Windows.Forms.Label();
               cityLabel = new System.Windows.Forms.Label();
               countryLabel = new System.Windows.Forms.Label();
               nameLabel = new System.Windows.Forms.Label();
               birthdayLabel = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
               this.groupBoxPostPoptions.SuspendLayout();
               this.groupBoxTimeToPost.SuspendLayout();
               this.panelCheckIns.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.photoBindingAdapterBindingSource)).BeginInit();
               this.panelEvents.SuspendLayout();
               this.panelFriendsNames.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
               this.panelLikedPages.SuspendLayout();
               this.panelFriendData.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
               this.panelCheckInData.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // imageNormalLabel
               // 
               imageNormalLabel.AutoSize = true;
               imageNormalLabel.Location = new System.Drawing.Point(9, 3);
               imageNormalLabel.Name = "imageNormalLabel";
               imageNormalLabel.Size = new System.Drawing.Size(0, 13);
               imageNormalLabel.TabIndex = 4;
               // 
               // createdTimeLabel
               // 
               createdTimeLabel.AutoSize = true;
               createdTimeLabel.Location = new System.Drawing.Point(3, 149);
               createdTimeLabel.Name = "createdTimeLabel";
               createdTimeLabel.Size = new System.Drawing.Size(62, 13);
               createdTimeLabel.TabIndex = 5;
               createdTimeLabel.Text = "Created on:";
               // 
               // cityLabel
               // 
               cityLabel.AutoSize = true;
               cityLabel.Location = new System.Drawing.Point(3, 95);
               cityLabel.Name = "cityLabel";
               cityLabel.Size = new System.Drawing.Size(27, 13);
               cityLabel.TabIndex = 6;
               cityLabel.Text = "City:";
               // 
               // countryLabel
               // 
               countryLabel.AutoSize = true;
               countryLabel.Location = new System.Drawing.Point(3, 123);
               countryLabel.Name = "countryLabel";
               countryLabel.Size = new System.Drawing.Size(46, 13);
               countryLabel.TabIndex = 7;
               countryLabel.Text = "Country:";
               // 
               // nameLabel
               // 
               nameLabel.AutoSize = true;
               nameLabel.Location = new System.Drawing.Point(3, 129);
               nameLabel.Name = "nameLabel";
               nameLabel.Size = new System.Drawing.Size(38, 13);
               nameLabel.TabIndex = 10;
               nameLabel.Text = "Name:";
               // 
               // birthdayLabel
               // 
               birthdayLabel.AutoSize = true;
               birthdayLabel.Location = new System.Drawing.Point(0, 155);
               birthdayLabel.Name = "birthdayLabel";
               birthdayLabel.Size = new System.Drawing.Size(48, 13);
               birthdayLabel.TabIndex = 4;
               birthdayLabel.Text = "Birthday:";
               // 
               // pictureBoxBackground
               // 
               this.pictureBoxBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
               this.pictureBoxBackground.Location = new System.Drawing.Point(12, 12);
               this.pictureBoxBackground.Name = "pictureBoxBackground";
               this.pictureBoxBackground.Size = new System.Drawing.Size(421, 207);
               this.pictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBoxBackground.TabIndex = 0;
               this.pictureBoxBackground.TabStop = false;
               this.pictureBoxBackground.UseWaitCursor = true;
               // 
               // pictureBoxProfile
               // 
               this.pictureBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.pictureBoxProfile.Location = new System.Drawing.Point(12, 89);
               this.pictureBoxProfile.Name = "pictureBoxProfile";
               this.pictureBoxProfile.Size = new System.Drawing.Size(130, 130);
               this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBoxProfile.TabIndex = 1;
               this.pictureBoxProfile.TabStop = false;
               // 
               // buttonLoginLogout
               // 
               this.buttonLoginLogout.BackColor = System.Drawing.Color.DodgerBlue;
               this.buttonLoginLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.buttonLoginLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
               this.buttonLoginLogout.Location = new System.Drawing.Point(438, 10);
               this.buttonLoginLogout.Name = "buttonLoginLogout";
               this.buttonLoginLogout.Size = new System.Drawing.Size(141, 47);
               this.buttonLoginLogout.TabIndex = 0;
               this.buttonLoginLogout.Text = "Login";
               this.buttonLoginLogout.UseVisualStyleBackColor = false;
               this.buttonLoginLogout.Click += new System.EventHandler(this.buttonLoginLogout_Click);
               // 
               // labelUserName
               // 
               this.labelUserName.AutoSize = true;
               this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.labelUserName.Location = new System.Drawing.Point(148, 188);
               this.labelUserName.Name = "labelUserName";
               this.labelUserName.Size = new System.Drawing.Size(224, 31);
               this.labelUserName.TabIndex = 7;
               this.labelUserName.Text = "User Name Label";
               this.labelUserName.Visible = false;
               // 
               // buttonPost
               // 
               this.buttonPost.Enabled = false;
               this.buttonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.buttonPost.Location = new System.Drawing.Point(438, 85);
               this.buttonPost.Name = "buttonPost";
               this.buttonPost.Size = new System.Drawing.Size(141, 42);
               this.buttonPost.TabIndex = 6;
               this.buttonPost.Text = "Post";
               this.buttonPost.UseVisualStyleBackColor = true;
               this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
               // 
               // radioButtonStatus
               // 
               this.radioButtonStatus.AutoSize = true;
               this.radioButtonStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.radioButtonStatus.Location = new System.Drawing.Point(6, 16);
               this.radioButtonStatus.Name = "radioButtonStatus";
               this.radioButtonStatus.Size = new System.Drawing.Size(66, 21);
               this.radioButtonStatus.TabIndex = 0;
               this.radioButtonStatus.TabStop = true;
               this.radioButtonStatus.Text = "Status";
               this.radioButtonStatus.UseVisualStyleBackColor = true;
               this.radioButtonStatus.CheckedChanged += new System.EventHandler(this.radioButtonStatus_CheckedChanged);
               // 
               // radioButtonPhoto
               // 
               this.radioButtonPhoto.AutoSize = true;
               this.radioButtonPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.radioButtonPhoto.Location = new System.Drawing.Point(5, 43);
               this.radioButtonPhoto.Name = "radioButtonPhoto";
               this.radioButtonPhoto.Size = new System.Drawing.Size(63, 21);
               this.radioButtonPhoto.TabIndex = 1;
               this.radioButtonPhoto.TabStop = true;
               this.radioButtonPhoto.Text = "Photo";
               this.radioButtonPhoto.UseVisualStyleBackColor = true;
               this.radioButtonPhoto.CheckedChanged += new System.EventHandler(this.radioButtonPhoto_CheckedChanged);
               // 
               // openFileDialogPhoto
               // 
               this.openFileDialogPhoto.FileName = "openFileDialogPhoto";
               this.openFileDialogPhoto.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
               // 
               // buttonSelectPhoto
               // 
               this.buttonSelectPhoto.Enabled = false;
               this.buttonSelectPhoto.Location = new System.Drawing.Point(6, 61);
               this.buttonSelectPhoto.Name = "buttonSelectPhoto";
               this.buttonSelectPhoto.Size = new System.Drawing.Size(126, 23);
               this.buttonSelectPhoto.TabIndex = 2;
               this.buttonSelectPhoto.Text = "SelectPhoto";
               this.buttonSelectPhoto.UseVisualStyleBackColor = true;
               this.buttonSelectPhoto.Click += new System.EventHandler(this.buttonSelectPhoto_Click);
               // 
               // richTextBoxStatus
               // 
               this.richTextBoxStatus.Enabled = false;
               this.richTextBoxStatus.Location = new System.Drawing.Point(585, 10);
               this.richTextBoxStatus.Name = "richTextBoxStatus";
               this.richTextBoxStatus.Size = new System.Drawing.Size(403, 209);
               this.richTextBoxStatus.TabIndex = 5;
               this.richTextBoxStatus.Text = "What\'s on your mind?";
               this.richTextBoxStatus.Enter += new System.EventHandler(this.richTextBoxStatus_Enter);
               this.richTextBoxStatus.Leave += new System.EventHandler(this.richTextBoxStatus_Leave);
               // 
               // dateTimePickerPost
               // 
               this.dateTimePickerPost.CustomFormat = "MMMMdd, yyyy  |  HH:mm";
               this.dateTimePickerPost.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
               this.dateTimePickerPost.Location = new System.Drawing.Point(6, 46);
               this.dateTimePickerPost.MinDate = new System.DateTime(2020, 8, 14, 0, 0, 0, 0);
               this.dateTimePickerPost.Name = "dateTimePickerPost";
               this.dateTimePickerPost.Size = new System.Drawing.Size(200, 20);
               this.dateTimePickerPost.TabIndex = 1;
               // 
               // radioButtonPostByDate
               // 
               this.radioButtonPostByDate.AutoSize = true;
               this.radioButtonPostByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.radioButtonPostByDate.Location = new System.Drawing.Point(6, 19);
               this.radioButtonPostByDate.Name = "radioButtonPostByDate";
               this.radioButtonPostByDate.Size = new System.Drawing.Size(171, 24);
               this.radioButtonPostByDate.TabIndex = 0;
               this.radioButtonPostByDate.TabStop = true;
               this.radioButtonPostByDate.Text = "Choose date to post";
               this.radioButtonPostByDate.UseVisualStyleBackColor = true;
               this.radioButtonPostByDate.CheckedChanged += new System.EventHandler(this.radioButtonPostByDate_CheckedChanged);
               // 
               // groupBoxPostPoptions
               // 
               this.groupBoxPostPoptions.Controls.Add(this.buttonSelectPhoto);
               this.groupBoxPostPoptions.Controls.Add(this.radioButtonStatus);
               this.groupBoxPostPoptions.Controls.Add(this.radioButtonPhoto);
               this.groupBoxPostPoptions.Enabled = false;
               this.groupBoxPostPoptions.Location = new System.Drawing.Point(438, 131);
               this.groupBoxPostPoptions.Name = "groupBoxPostPoptions";
               this.groupBoxPostPoptions.Size = new System.Drawing.Size(141, 90);
               this.groupBoxPostPoptions.TabIndex = 2;
               this.groupBoxPostPoptions.TabStop = false;
               this.groupBoxPostPoptions.Text = "Choose type of post";
               // 
               // checkBoxRememberMe
               // 
               this.checkBoxRememberMe.AutoSize = true;
               this.checkBoxRememberMe.Location = new System.Drawing.Point(438, 63);
               this.checkBoxRememberMe.Name = "checkBoxRememberMe";
               this.checkBoxRememberMe.Size = new System.Drawing.Size(94, 17);
               this.checkBoxRememberMe.TabIndex = 1;
               this.checkBoxRememberMe.Text = "Remember me";
               this.checkBoxRememberMe.UseVisualStyleBackColor = true;
               // 
               // radioButtonPostAtBestTime
               // 
               this.radioButtonPostAtBestTime.AutoSize = true;
               this.radioButtonPostAtBestTime.Enabled = false;
               this.radioButtonPostAtBestTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.radioButtonPostAtBestTime.Location = new System.Drawing.Point(6, 72);
               this.radioButtonPostAtBestTime.Name = "radioButtonPostAtBestTime";
               this.radioButtonPostAtBestTime.Size = new System.Drawing.Size(177, 24);
               this.radioButtonPostAtBestTime.TabIndex = 2;
               this.radioButtonPostAtBestTime.TabStop = true;
               this.radioButtonPostAtBestTime.Text = "Post on the best time";
               this.radioButtonPostAtBestTime.UseVisualStyleBackColor = true;
               // 
               // labelBestTimeToPost
               // 
               this.labelBestTimeToPost.AutoSize = true;
               this.labelBestTimeToPost.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.labelBestTimeToPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
               this.labelBestTimeToPost.Location = new System.Drawing.Point(6, 118);
               this.labelBestTimeToPost.Name = "labelBestTimeToPost";
               this.labelBestTimeToPost.Size = new System.Drawing.Size(160, 15);
               this.labelBestTimeToPost.TabIndex = 3;
               this.labelBestTimeToPost.Text = "It might take few moments...";
               this.labelBestTimeToPost.Visible = false;
               // 
               // radioButtonPostNow
               // 
               this.radioButtonPostNow.AutoSize = true;
               this.radioButtonPostNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.radioButtonPostNow.Location = new System.Drawing.Point(6, 153);
               this.radioButtonPostNow.Name = "radioButtonPostNow";
               this.radioButtonPostNow.Size = new System.Drawing.Size(92, 24);
               this.radioButtonPostNow.TabIndex = 4;
               this.radioButtonPostNow.TabStop = true;
               this.radioButtonPostNow.Text = "Post now";
               this.radioButtonPostNow.UseVisualStyleBackColor = true;
               // 
               // groupBoxTimeToPost
               // 
               this.groupBoxTimeToPost.Controls.Add(this.buttonGetBestTime);
               this.groupBoxTimeToPost.Controls.Add(this.radioButtonPostByDate);
               this.groupBoxTimeToPost.Controls.Add(this.radioButtonPostNow);
               this.groupBoxTimeToPost.Controls.Add(this.dateTimePickerPost);
               this.groupBoxTimeToPost.Controls.Add(this.labelBestTimeToPost);
               this.groupBoxTimeToPost.Controls.Add(this.radioButtonPostAtBestTime);
               this.groupBoxTimeToPost.Enabled = false;
               this.groupBoxTimeToPost.Location = new System.Drawing.Point(994, 12);
               this.groupBoxTimeToPost.Name = "groupBoxTimeToPost";
               this.groupBoxTimeToPost.Size = new System.Drawing.Size(215, 183);
               this.groupBoxTimeToPost.TabIndex = 3;
               this.groupBoxTimeToPost.TabStop = false;
               this.groupBoxTimeToPost.Text = "Choose time to post";
               // 
               // buttonGetBestTime
               // 
               this.buttonGetBestTime.Location = new System.Drawing.Point(6, 92);
               this.buttonGetBestTime.Name = "buttonGetBestTime";
               this.buttonGetBestTime.Size = new System.Drawing.Size(200, 23);
               this.buttonGetBestTime.TabIndex = 5;
               this.buttonGetBestTime.Text = "Press here to get the best time to post";
               this.toolTipBestTimeToPost.SetToolTip(this.buttonGetBestTime, "Be aware that this action might take time! It requires a lot of graph api fetchin" +
        "g!");
               this.buttonGetBestTime.UseVisualStyleBackColor = true;
               this.buttonGetBestTime.Click += new System.EventHandler(this.buttonGetBestTime_Click);
               // 
               // timerTimeLeftToPostToBePosted
               // 
               this.timerTimeLeftToPostToBePosted.Interval = 1000;
               this.timerTimeLeftToPostToBePosted.Tick += new System.EventHandler(this.timerTimeLeftToPostToBePosted_Tick);
               // 
               // labelTimeLeftToPost
               // 
               this.labelTimeLeftToPost.AutoSize = true;
               this.labelTimeLeftToPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.labelTimeLeftToPost.ForeColor = System.Drawing.SystemColors.MenuHighlight;
               this.labelTimeLeftToPost.Location = new System.Drawing.Point(997, 195);
               this.labelTimeLeftToPost.Name = "labelTimeLeftToPost";
               this.labelTimeLeftToPost.Size = new System.Drawing.Size(0, 15);
               this.labelTimeLeftToPost.TabIndex = 4;
               // 
               // panelCheckIns
               // 
               this.panelCheckIns.Controls.Add(this.listBoxCheckins);
               this.panelCheckIns.Controls.Add(this.buttonFetchPhotoChekins);
               this.panelCheckIns.Enabled = false;
               this.panelCheckIns.Location = new System.Drawing.Point(13, 226);
               this.panelCheckIns.Name = "panelCheckIns";
               this.panelCheckIns.Size = new System.Drawing.Size(290, 336);
               this.panelCheckIns.TabIndex = 17;
               // 
               // listBoxCheckins
               // 
               this.listBoxCheckins.DataSource = this.photoBindingAdapterBindingSource;
               this.listBoxCheckins.DisplayMember = "FullLocation";
               this.listBoxCheckins.Dock = System.Windows.Forms.DockStyle.Fill;
               this.listBoxCheckins.FormattingEnabled = true;
               this.listBoxCheckins.Location = new System.Drawing.Point(0, 23);
               this.listBoxCheckins.Name = "listBoxCheckins";
               this.listBoxCheckins.Size = new System.Drawing.Size(290, 313);
               this.listBoxCheckins.TabIndex = 1;
               // 
               // photoBindingAdapterBindingSource
               // 
               this.photoBindingAdapterBindingSource.DataSource = typeof(FacebookAppEngine.PhotoBindingAdapter);
               // 
               // buttonFetchPhotoChekins
               // 
               this.buttonFetchPhotoChekins.Dock = System.Windows.Forms.DockStyle.Top;
               this.buttonFetchPhotoChekins.Location = new System.Drawing.Point(0, 0);
               this.buttonFetchPhotoChekins.Name = "buttonFetchPhotoChekins";
               this.buttonFetchPhotoChekins.Size = new System.Drawing.Size(290, 23);
               this.buttonFetchPhotoChekins.TabIndex = 0;
               this.buttonFetchPhotoChekins.Text = "Fetch all photos checkins";
               this.buttonFetchPhotoChekins.UseVisualStyleBackColor = true;
               this.buttonFetchPhotoChekins.Click += new System.EventHandler(this.buttonFetchChekins_Click);
               // 
               // panelEvents
               // 
               this.panelEvents.Controls.Add(this.listBoxEvents);
               this.panelEvents.Controls.Add(this.buttonFetchEvents);
               this.panelEvents.Enabled = false;
               this.panelEvents.Location = new System.Drawing.Point(309, 227);
               this.panelEvents.Name = "panelEvents";
               this.panelEvents.Size = new System.Drawing.Size(290, 336);
               this.panelEvents.TabIndex = 17;
               // 
               // listBoxEvents
               // 
               this.listBoxEvents.Dock = System.Windows.Forms.DockStyle.Fill;
               this.listBoxEvents.FormattingEnabled = true;
               this.listBoxEvents.Location = new System.Drawing.Point(0, 23);
               this.listBoxEvents.Name = "listBoxEvents";
               this.listBoxEvents.Size = new System.Drawing.Size(290, 313);
               this.listBoxEvents.TabIndex = 1;
               // 
               // buttonFetchEvents
               // 
               this.buttonFetchEvents.Dock = System.Windows.Forms.DockStyle.Top;
               this.buttonFetchEvents.Location = new System.Drawing.Point(0, 0);
               this.buttonFetchEvents.Name = "buttonFetchEvents";
               this.buttonFetchEvents.Size = new System.Drawing.Size(290, 23);
               this.buttonFetchEvents.TabIndex = 0;
               this.buttonFetchEvents.Text = "Fetch all events";
               this.buttonFetchEvents.UseVisualStyleBackColor = true;
               this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
               // 
               // panelFriendsNames
               // 
               this.panelFriendsNames.Controls.Add(this.listBoxFriendsNames);
               this.panelFriendsNames.Controls.Add(this.buttonFetchFriendsNames);
               this.panelFriendsNames.Enabled = false;
               this.panelFriendsNames.Location = new System.Drawing.Point(605, 227);
               this.panelFriendsNames.Name = "panelFriendsNames";
               this.panelFriendsNames.Size = new System.Drawing.Size(290, 336);
               this.panelFriendsNames.TabIndex = 17;
               // 
               // listBoxFriendsNames
               // 
               this.listBoxFriendsNames.DataSource = this.userBindingSource;
               this.listBoxFriendsNames.DisplayMember = "Name";
               this.listBoxFriendsNames.Dock = System.Windows.Forms.DockStyle.Fill;
               this.listBoxFriendsNames.FormattingEnabled = true;
               this.listBoxFriendsNames.Location = new System.Drawing.Point(0, 23);
               this.listBoxFriendsNames.Name = "listBoxFriendsNames";
               this.listBoxFriendsNames.Size = new System.Drawing.Size(290, 313);
               this.listBoxFriendsNames.TabIndex = 1;
               // 
               // userBindingSource
               // 
               this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
               // 
               // buttonFetchFriendsNames
               // 
               this.buttonFetchFriendsNames.Dock = System.Windows.Forms.DockStyle.Top;
               this.buttonFetchFriendsNames.Location = new System.Drawing.Point(0, 0);
               this.buttonFetchFriendsNames.Name = "buttonFetchFriendsNames";
               this.buttonFetchFriendsNames.Size = new System.Drawing.Size(290, 23);
               this.buttonFetchFriendsNames.TabIndex = 0;
               this.buttonFetchFriendsNames.Text = "Fetch all friends names";
               this.buttonFetchFriendsNames.UseVisualStyleBackColor = true;
               this.buttonFetchFriendsNames.Click += new System.EventHandler(this.buttonFetchFriends_Click);
               // 
               // panelLikedPages
               // 
               this.panelLikedPages.Controls.Add(this.listBoxLikedPages);
               this.panelLikedPages.Controls.Add(this.buttonFetchLikedPages);
               this.panelLikedPages.Enabled = false;
               this.panelLikedPages.Location = new System.Drawing.Point(901, 227);
               this.panelLikedPages.Name = "panelLikedPages";
               this.panelLikedPages.Size = new System.Drawing.Size(290, 336);
               this.panelLikedPages.TabIndex = 17;
               // 
               // listBoxLikedPages
               // 
               this.listBoxLikedPages.Dock = System.Windows.Forms.DockStyle.Fill;
               this.listBoxLikedPages.FormattingEnabled = true;
               this.listBoxLikedPages.Location = new System.Drawing.Point(0, 23);
               this.listBoxLikedPages.Name = "listBoxLikedPages";
               this.listBoxLikedPages.Size = new System.Drawing.Size(290, 313);
               this.listBoxLikedPages.TabIndex = 1;
               // 
               // buttonFetchLikedPages
               // 
               this.buttonFetchLikedPages.Dock = System.Windows.Forms.DockStyle.Top;
               this.buttonFetchLikedPages.Location = new System.Drawing.Point(0, 0);
               this.buttonFetchLikedPages.Name = "buttonFetchLikedPages";
               this.buttonFetchLikedPages.Size = new System.Drawing.Size(290, 23);
               this.buttonFetchLikedPages.TabIndex = 0;
               this.buttonFetchLikedPages.Text = "Fetch all liked pages";
               this.buttonFetchLikedPages.UseVisualStyleBackColor = true;
               this.buttonFetchLikedPages.Click += new System.EventHandler(this.buttonFetchLikedPages_Click);
               // 
               // panelFriendData
               // 
               this.panelFriendData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.panelFriendData.Controls.Add(birthdayLabel);
               this.panelFriendData.Controls.Add(this.birthdayTextBox);
               this.panelFriendData.Controls.Add(this.imageNormalPictureBox);
               this.panelFriendData.Controls.Add(nameLabel);
               this.panelFriendData.Controls.Add(this.nameTextBox);
               this.panelFriendData.Controls.Add(imageNormalLabel);
               this.panelFriendData.Location = new System.Drawing.Point(605, 569);
               this.panelFriendData.Name = "panelFriendData";
               this.panelFriendData.Size = new System.Drawing.Size(290, 179);
               this.panelFriendData.TabIndex = 18;
               this.panelFriendData.Visible = false;
               // 
               // birthdayTextBox
               // 
               this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
               this.birthdayTextBox.Location = new System.Drawing.Point(54, 152);
               this.birthdayTextBox.Name = "birthdayTextBox";
               this.birthdayTextBox.ReadOnly = true;
               this.birthdayTextBox.Size = new System.Drawing.Size(216, 20);
               this.birthdayTextBox.TabIndex = 5;
               // 
               // imageNormalPictureBox
               // 
               this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
               this.imageNormalPictureBox.Location = new System.Drawing.Point(3, 3);
               this.imageNormalPictureBox.Name = "imageNormalPictureBox";
               this.imageNormalPictureBox.Size = new System.Drawing.Size(117, 117);
               this.imageNormalPictureBox.TabIndex = 9;
               this.imageNormalPictureBox.TabStop = false;
               // 
               // nameTextBox
               // 
               this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
               this.nameTextBox.Location = new System.Drawing.Point(54, 126);
               this.nameTextBox.Name = "nameTextBox";
               this.nameTextBox.ReadOnly = true;
               this.nameTextBox.Size = new System.Drawing.Size(216, 20);
               this.nameTextBox.TabIndex = 11;
               // 
               // panelCheckInData
               // 
               this.panelCheckInData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.panelCheckInData.Controls.Add(countryLabel);
               this.panelCheckInData.Controls.Add(this.countryTextBox);
               this.panelCheckInData.Controls.Add(cityLabel);
               this.panelCheckInData.Controls.Add(this.cityTextBox);
               this.panelCheckInData.Controls.Add(createdTimeLabel);
               this.panelCheckInData.Controls.Add(this.createdTimeTextBox);
               this.panelCheckInData.Controls.Add(this.imageNormalPictureBox1);
               this.panelCheckInData.Location = new System.Drawing.Point(13, 572);
               this.panelCheckInData.Name = "panelCheckInData";
               this.panelCheckInData.Size = new System.Drawing.Size(295, 176);
               this.panelCheckInData.TabIndex = 19;
               this.panelCheckInData.Visible = false;
               // 
               // countryTextBox
               // 
               this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoBindingAdapterBindingSource, "PhotoAdoptee.Place.Location.Country", true));
               this.countryTextBox.Location = new System.Drawing.Point(82, 119);
               this.countryTextBox.Name = "countryTextBox";
               this.countryTextBox.ReadOnly = true;
               this.countryTextBox.Size = new System.Drawing.Size(191, 20);
               this.countryTextBox.TabIndex = 8;
               // 
               // cityTextBox
               // 
               this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoBindingAdapterBindingSource, "PhotoAdoptee.Place.Location.City", true));
               this.cityTextBox.Location = new System.Drawing.Point(82, 94);
               this.cityTextBox.Name = "cityTextBox";
               this.cityTextBox.ReadOnly = true;
               this.cityTextBox.Size = new System.Drawing.Size(191, 20);
               this.cityTextBox.TabIndex = 7;
               // 
               // createdTimeTextBox
               // 
               this.createdTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoBindingAdapterBindingSource, "PhotoAdoptee.CreatedTime", true));
               this.createdTimeTextBox.Location = new System.Drawing.Point(82, 146);
               this.createdTimeTextBox.Name = "createdTimeTextBox";
               this.createdTimeTextBox.ReadOnly = true;
               this.createdTimeTextBox.Size = new System.Drawing.Size(191, 20);
               this.createdTimeTextBox.TabIndex = 6;
               // 
               // imageNormalPictureBox1
               // 
               this.imageNormalPictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photoBindingAdapterBindingSource, "PhotoAdoptee.ImageNormal", true));
               this.imageNormalPictureBox1.Location = new System.Drawing.Point(3, 3);
               this.imageNormalPictureBox1.Name = "imageNormalPictureBox1";
               this.imageNormalPictureBox1.Size = new System.Drawing.Size(85, 85);
               this.imageNormalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.imageNormalPictureBox1.TabIndex = 1;
               this.imageNormalPictureBox1.TabStop = false;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(1216, 13);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(225, 13);
               this.label1.TabIndex = 21;
               this.label1.Text = "Statuses Posted With Facebook Desktop App";
               // 
               // comboBoxFilter
               // 
               this.comboBoxFilter.FormattingEnabled = true;
               this.comboBoxFilter.Location = new System.Drawing.Point(1215, 57);
               this.comboBoxFilter.Name = "comboBoxFilter";
               this.comboBoxFilter.Size = new System.Drawing.Size(223, 21);
               this.comboBoxFilter.TabIndex = 22;
               this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.label2.Location = new System.Drawing.Point(1216, 44);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(81, 13);
               this.label2.TabIndex = 23;
               this.label2.Text = "Choose A Filter:";
               // 
               // flowLayoutPanelPostedStatuses
               // 
               this.flowLayoutPanelPostedStatuses.AutoScroll = true;
               this.flowLayoutPanelPostedStatuses.Location = new System.Drawing.Point(1215, 85);
               this.flowLayoutPanelPostedStatuses.Name = "flowLayoutPanelPostedStatuses";
               this.flowLayoutPanelPostedStatuses.Size = new System.Drawing.Size(223, 478);
               this.flowLayoutPanelPostedStatuses.TabIndex = 24;
               // 
               // FacebookForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoSize = true;
               this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.ClientSize = new System.Drawing.Size(1442, 768);
               this.Controls.Add(this.flowLayoutPanelPostedStatuses);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.comboBoxFilter);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.panelCheckInData);
               this.Controls.Add(this.panelFriendData);
               this.Controls.Add(this.panelLikedPages);
               this.Controls.Add(this.panelFriendsNames);
               this.Controls.Add(this.panelEvents);
               this.Controls.Add(this.panelCheckIns);
               this.Controls.Add(this.labelTimeLeftToPost);
               this.Controls.Add(this.groupBoxTimeToPost);
               this.Controls.Add(this.checkBoxRememberMe);
               this.Controls.Add(this.groupBoxPostPoptions);
               this.Controls.Add(this.richTextBoxStatus);
               this.Controls.Add(this.buttonPost);
               this.Controls.Add(this.labelUserName);
               this.Controls.Add(this.buttonLoginLogout);
               this.Controls.Add(this.pictureBoxProfile);
               this.Controls.Add(this.pictureBoxBackground);
               this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MaximizeBox = false;
               this.Name = "FacebookForm";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Facebook desktop app";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
               this.groupBoxPostPoptions.ResumeLayout(false);
               this.groupBoxPostPoptions.PerformLayout();
               this.groupBoxTimeToPost.ResumeLayout(false);
               this.groupBoxTimeToPost.PerformLayout();
               this.panelCheckIns.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.photoBindingAdapterBindingSource)).EndInit();
               this.panelEvents.ResumeLayout(false);
               this.panelFriendsNames.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
               this.panelLikedPages.ResumeLayout(false);
               this.panelFriendData.ResumeLayout(false);
               this.panelFriendData.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
               this.panelCheckInData.ResumeLayout(false);
               this.panelCheckInData.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonLoginLogout;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.RadioButton radioButtonStatus;
        private System.Windows.Forms.RadioButton radioButtonPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
        private System.Windows.Forms.Button buttonSelectPhoto;
        private System.Windows.Forms.RichTextBox richTextBoxStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerPost;
        private System.Windows.Forms.RadioButton radioButtonPostByDate;
        private System.Windows.Forms.GroupBox groupBoxPostPoptions;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.RadioButton radioButtonPostAtBestTime;
        private System.Windows.Forms.Label labelBestTimeToPost;
        private System.Windows.Forms.RadioButton radioButtonPostNow;
        private System.Windows.Forms.GroupBox groupBoxTimeToPost;
        private System.Windows.Forms.Timer timerTimeLeftToPostToBePosted;
        private System.Windows.Forms.Label labelTimeLeftToPost;
        private System.Windows.Forms.Panel panelCheckIns;
        private System.Windows.Forms.Panel panelEvents;
        private System.Windows.Forms.Panel panelFriendsNames;
        private System.Windows.Forms.Panel panelLikedPages;
        private System.Windows.Forms.ListBox listBoxCheckins;
        private System.Windows.Forms.Button buttonFetchPhotoChekins;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.ListBox listBoxFriendsNames;
        private System.Windows.Forms.Button buttonFetchFriendsNames;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Button buttonFetchLikedPages;
        private System.Windows.Forms.Button buttonGetBestTime;
        private System.Windows.Forms.ToolTip toolTipBestTimeToPost;
        private System.Windows.Forms.Panel panelFriendData;
        private System.Windows.Forms.Panel panelCheckInData;
        private System.Windows.Forms.BindingSource photoBindingAdapterBindingSource;
        private System.Windows.Forms.TextBox createdTimeTextBox;
        private System.Windows.Forms.PictureBox imageNormalPictureBox1;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.TextBox nameTextBox;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.ComboBox comboBoxFilter;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPostedStatuses;
     }
}

