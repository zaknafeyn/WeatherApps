﻿using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using R = Weather.Android.Resource;

namespace Weather.Android.Activities.Experimental
{
    public class SettingsCardContentFragment : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(R.Layout.settings_option_item, null);
        }
    }
}