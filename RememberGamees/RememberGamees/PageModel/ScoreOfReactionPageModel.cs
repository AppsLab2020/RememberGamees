using Android;
using Android.OS;
using Android.Widget;
using RememberGamees.Data;
using RememberGamees.Pages;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Net;
using System.Text;
using Xamarin.Forms;

namespace RememberGamees.PageModel
{
    public class ScoreOfReactionPageModel
    {
        public int ID { get; set; }
        public string txtName { get; set; }
        public string txtNumber { get; set; }

        private Xamarin.Forms.ListView mListView;
        private BaseAdapter<Contact> mAdapter;
        private List<Contact> mContacts;

        public event EventHandler<ScoreOfReactionPageModel> OnCreateContact;

        public ScoreOfReactionPageModel(int id, string name, string number)
        {
            ID = id;
            txtName = name;
            txtNumber = number;
            NameValueCollection parameters = new NameValueCollection();

            parameters.Add("Name", txtName);
            parameters.Add("Number", txtNumber);

            mContacts = new List<Contact>();
        }

        void client_UploadValuesCompleted(object sender, UploadValuesCompletedEventArgs e)
        {

                string id = Encoding.UTF8.GetString(e.Result);
                int newID = 0;

                int.TryParse(id, out newID);

                if (OnCreateContact != null)
                {
                    //Broadcast event
                    OnCreateContact.Invoke(this, new ScoreOfReactionPageModel(newID, txtName, txtNumber));
                } 
        }

        public Command Button_Clicked => new Command(() =>
        {
            Application.Current.MainPage = new GamePage();
        });

        public Command Save => new Command(() =>
        {
            NameValueCollection parameters = new NameValueCollection();

            WebClient client = new WebClient();
            Uri uri = new Uri("http://192.168.31.56/CreateContact.php");
            client.UploadValuesCompleted += client_UploadValuesCompleted;
            client.UploadValuesAsync(uri, parameters);
        });

        void dialog_OnCreateContact(object sender, ScoreOfReactionPageModel e)
        {
            mContacts.Add(new Contact() { ID = e.ID, Name = e.txtName, Number = e.txtNumber });
            mAdapter.NotifyDataSetChanged();
        }
    }
}
