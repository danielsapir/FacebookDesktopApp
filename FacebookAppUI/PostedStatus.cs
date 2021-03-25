using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookAppEngine;

namespace FacebookAppUI
{
     public partial class PostedStatus : UserControl
     {
          public PostedStatus()
          {
               InitializeComponent();
          }

          private StatusProxy m_StatusOfForm;

          public StatusProxy StausOfForm
          {
               get
               {
                    return m_StatusOfForm;
               }

               set
               {
                    m_StatusOfForm = value;
                    textBoxStatusText.Text = m_StatusOfForm.Message;
                    if (m_StatusOfForm.CreatedTime != null)
                    {
                         textBoxDate.Text = m_StatusOfForm.CreatedTime.ToString();
                    }
                    else
                    {
                         textBoxDate.Visible = false;
                    }
               }
          }
     }
}
