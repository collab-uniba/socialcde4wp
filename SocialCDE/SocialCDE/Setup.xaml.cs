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
    public partial class Setup : PhoneApplicationPage
    {
        public Setup()
        {
            InitializeComponent();
        }
		
		string copytext;
		
        private string CopyPsw (PasswordBox boxPsw)
		{
			copytext = boxPsw.Password.ToString();      //copy the password in the passwordbox
			boxPsw.Password="";                         //sets the password in empty
			return copytext;
		}
		
		private void ControlPswBox (PasswordBox boxPsw)
		{
			if (boxPsw.Password=="")                   //the entered password is empty
			{
				boxPsw.Password=copytext;              //resets the text in the last entered text
			}
		}
		
        private void SelectOldPsw(object sender, System.Windows.RoutedEventArgs e)
        {
        	CopyPsw(EnterOldPsw);
        }

        private void ControlOldPsw(object sender, System.Windows.RoutedEventArgs e)
        {
        	ControlPswBox(EnterOldPsw);
        }

        private void SelectNewPsw(object sender, System.Windows.RoutedEventArgs e)
        {
        	CopyPsw(EnterNewPsw);
        }

        private void ControlNewPsw(object sender, System.Windows.RoutedEventArgs e)
        {
        	ControlPswBox(EnterNewPsw);
        }

        private void SelectConfirmPsw(object sender, System.Windows.RoutedEventArgs e)
        {
        	CopyPsw(EnterConfirmPsw);
        }

        private void ControlConfirmPsw(object sender, System.Windows.RoutedEventArgs e)
        {
        	ControlPswBox(EnterConfirmPsw);
        }

    }
}
