﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.Content;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using CustomTabbedPage.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(CustomTabbedPage.Controls.CustomTabbedPage), typeof(CustomTabbedPageRenderer))]
namespace CustomTabbedPage.Droid.Renderers
{
    public class CustomTabbedPageRenderer : TabbedPageRenderer
    {
        private bool _isConfigured = false;
        private ViewPager _pager;
        private TabLayout _layout;

        public CustomTabbedPageRenderer(Context context) : base(context) { }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            _pager = (ViewPager)ViewGroup.GetChildAt(0);
            _layout = (TabLayout)ViewGroup.GetChildAt(1);

            var control = (CustomTabbedPage.Controls.CustomTabbedPage)sender;
            Android.Graphics.Color selectedColor;
            Android.Graphics.Color unselectedColor;
            if (control != null)
            {
                selectedColor = control.SelectedIconColor.ToAndroid();
                unselectedColor = control.UnselectedIconColor.ToAndroid();
            }
            else
            {
                selectedColor = new Android.Graphics.Color(ContextCompat.GetColor(Context, Resource.Color.tabBarSelected));
                unselectedColor = new Android.Graphics.Color(ContextCompat.GetColor(Context, Resource.Color.tabBarUnselected));
            }

            for (int i = 0; i < _layout.TabCount; i++)
            {
                var tab = _layout.GetTabAt(i);
                var icon = tab.Icon;
                if (icon != null)
                {
                    var color = tab.IsSelected ? selectedColor : unselectedColor;
                    icon = Android.Support.V4.Graphics.Drawable.DrawableCompat.Wrap(icon);
                    icon.SetColorFilter(color, PorterDuff.Mode.SrcIn);
                }
            }
        }
    }
}