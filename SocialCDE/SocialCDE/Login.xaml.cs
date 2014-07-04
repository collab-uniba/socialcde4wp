using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace SocialCDE
{
    public partial class Login : PhoneApplicationPage
    {
        public Login()
        {
            InitializeComponent();
        }

		string copytext;
	
		private string Copy (TextBox box)
			{
				copytext = box.Text.ToString();   //copy the text in the textbox
				box.Text="";                      //sets the text in empty
				return copytext;
			}
		
		private void ControlBox (TextBox box)
		{
			if (box.Text=="")                     //the entered text is empty
			{
				box.Text=copytext;                //resets the text in the last entered text
			}
		}

        private string CopyPsw (PasswordBox boxPsw)
		{
			copytext = boxPsw.Password.ToString();    //copy the password in the passwordbox
			boxPsw.Password="";                       //sets the password in empty
			return copytext;
		}
		
		private void ControlPswBox (PasswordBox boxPsw)
		{
			if (boxPsw.Password=="")                 //the entered password is empty
			{
				boxPsw.Password=copytext;            //resets the text in the last entered text
			}
		}
		
        private void SelectProxy(object sender, System.Windows.RoutedEventArgs e)
        {
        	Copy(EnterProxy);
        }

        private void ControlProxy(object sender, System.Windows.RoutedEventArgs e)
        {
        	ControlBox(EnterProxy);
        }

        private void SelectUsername(object sender, System.Windows.RoutedEventArgs e)
        {
        	Copy(EnterUsername);
        }

        private void ControlUsername(object sender, System.Windows.RoutedEventArgs e)
        {
        	ControlBox(EnterUsername);
        }
		
		private void SelectPsw(object sender, System.Windows.RoutedEventArgs e)
        {
        	CopyPsw(EnterPw);
        }

        private void ControlPsw(object sender, System.Windows.RoutedEventArgs e)
        {
        	ControlPswBox(EnterPw);
        }

    }
}
