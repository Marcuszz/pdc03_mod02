﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pdc03_mod2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class activity2 : ContentPage
	{
		public activity2 ()
		{
			InitializeComponent ();
		}

		void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
		{
			valuelabel.Text = args.NewValue.ToString ("F3");
		}
	}
}