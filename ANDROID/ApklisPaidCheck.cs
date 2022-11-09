using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ApklisPaymentCheck.CrossPlataform;
using ApklisPaymentCheck.Droid.CrossPlataform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(ApklisPaidCheck))]
namespace ApklisPaymentCheck.Droid.CrossPlataform
{
    public class ApklisPaidCheck : IApklisPaidCheck
    {
        private string APKLIS_PROVIDER = "content://cu.uci.android.apklis.payment.provider/app/";
        private string APKLIS_PAID = "paid";
        private string APKLIS_USER_NAME = "user_name";
        private bool paid = false;
        private string username = null;

        public ApklisPaidCheck()
        {

        }
        public (bool, string) GetPaidInfo(string pakageName)
        {
            Android.Net.Uri providerUri = Android.Net.Uri.Parse($"{APKLIS_PROVIDER}{pakageName}");
            var contentResolver = Application.Context.ContentResolver.AcquireContentProviderClient(providerUri);
            if (contentResolver != null)
            {
                var apklisdb = contentResolver.Query(providerUri, null, null, null, null);
                if (apklisdb.MoveToFirst())
                {
                    paid = apklisdb.GetInt(apklisdb.GetColumnIndex(APKLIS_PAID)) > 0;
                    username = apklisdb.GetString(apklisdb.GetColumnIndex(APKLIS_USER_NAME));
                }
                apklisdb.Close();
            }
            return (paid, username);
        }
    }
}