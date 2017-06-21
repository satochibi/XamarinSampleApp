using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleApp
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            SampleButton1.Clicked += (sender, e) =>
            {
                DisplayAlert("通知", "タブ1のボタン1がタップされました", "OK");
            };

            SampleButton2.Clicked += (sender, e) =>
            {
                DisplayAlert("警告", "タブ1のボタン2がタップされました", "OK");
            };

            Authentication.Clicked += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(entryAccount.Text))
                {
                    if (!string.IsNullOrEmpty(entryPassword.Text))
                    {
                        DisplayAlert("通知", entryAccount.Text + "を認証しました。", "OK");
                    }
                    else
                    {
                        DisplayAlert("警告", "パスワードを入力して下さい。", "OK");
                    }
                }
                else
                {
                    DisplayAlert("警告", "アカウントを入力して下さい。", "OK");
                }
            };

            Clear.Clicked += (sender, e) =>
            {
                entryAccount.Text = "";
                entryPassword.Text = "";
            };


            searchBar.SearchButtonPressed += (sender, e) =>
            {
                lblResult.Text = "SampleApp Search!";
            };

            searchBar.TextChanged += (sender, e) =>
            {
                lblResult.Text = string.Empty;
            };


        }
    }
}
