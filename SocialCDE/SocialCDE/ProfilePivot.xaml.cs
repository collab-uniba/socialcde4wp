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
using System.Windows.Media.Imaging;

namespace SocialCDE
{
    public partial class ProfilePivot : PhoneApplicationPage
    {
        public ProfilePivot()
        {
            InitializeComponent();
        }
		
		Uri uri = new Uri("Green.png", UriKind.Relative);
		Uri uri2 = new Uri("Red.png", UriKind.Relative);
		int flagCodePlex=0;
		int flagCollabTFS=0;
		int flagFacebook=0;
		int flagGitHub=0;
		int flagLinkedIn=0;
		int flagStatusNetCollab=0;
		int flagTFSPucrs=0;
		int flagTwitter=0;
		int flagYammer=0;
		string copytext;
        
		private void Change (ref int flag, Image image)
		{
			if (flag==0)
			{
				image.Source = new BitmapImage(uri);  //change in green
				flag=1;
			}
			else
			{
				image.Source = new BitmapImage(uri2);  //change in red
				flag=0;
			}
		}
		
		private string Copy (TextBox box)
			{
				copytext = box.Text.ToString();  //copy the text in the textbox
				box.Text="";                     //sets the text in empty
				return copytext;
			}
		
		private void ControlBox (TextBox box)
		{
			if (box.Text=="")                  //the entered text is empty
			{
				box.Text=copytext;             //resets the text in the last entered text
			}
		}

		private void CCodePlex(object sender, System.Windows.RoutedEventArgs e)
        {
        	Change(ref flagCodePlex, RCodePlex);
		}

        private void CCollabTFS(object sender, System.Windows.RoutedEventArgs e)
        {
			Change(ref flagCollabTFS, RCollabTFS);
		}

        private void CFacebook(object sender, System.Windows.RoutedEventArgs e)
        {
        	Change(ref flagFacebook, RFacebook);
		}

        private void CGitHub(object sender, System.Windows.RoutedEventArgs e)
        {
			Change(ref flagGitHub, RGitHub);
		}

        private void CLinkedIn(object sender, System.Windows.RoutedEventArgs e)
        {
        	Change(ref flagLinkedIn, RLinkedIn);
		}

        private void CStatusNetCollab(object sender, System.Windows.RoutedEventArgs e)
        {
			Change(ref flagStatusNetCollab, RStatusNetCollab);
		}

        private void CTFSPucrs(object sender, System.Windows.RoutedEventArgs e)
        {
        	Change (ref flagTFSPucrs, RTFSPucrs);
		}

        private void CTwitter(object sender, System.Windows.RoutedEventArgs e)
        {
			Change(ref flagTwitter, RTwitter);
		}

        private void CYammer(object sender, System.Windows.RoutedEventArgs e)
        {
			Change(ref flagYammer, RYammer);
        }
	
        private void SelectPostHTL(object sender, System.Windows.RoutedEventArgs e)
        {
        	Copy(YourPostHTL);
        }

        private void ControlPostHTL(object sender, System.Windows.RoutedEventArgs e)
        {
        	ControlBox(YourPostHTL);
        }

        private void SelectPostITL(object sender, System.Windows.RoutedEventArgs e)
        {
        	Copy(YourPostITL);
        }

        private void ControlPostITL(object sender, System.Windows.RoutedEventArgs e)
        {
        	ControlBox(YourPostITL);
        }
		
    }
}
