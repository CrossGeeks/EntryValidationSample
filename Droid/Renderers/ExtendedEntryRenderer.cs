using System;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Support.V4.Content;
using EntryValidationBorder;
using EntryValidationBorder.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryRenderer))]
namespace EntryValidationBorder.Droid.Renderers
{
	public class ExtendedEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control == null || e.NewElement == null) return;

			UpdateBorders();
		}

		protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (Control == null) return;

            if(e.PropertyName == ExtendedEntry.IsBorderErrorVisibleProperty.PropertyName)
			    UpdateBorders();
		}

		void UpdateBorders()
		{
            GradientDrawable shape = new GradientDrawable();
            shape.SetShape(ShapeType.Rectangle);
			shape.SetCornerRadius(0);
			
            if (((ExtendedEntry)this.Element).IsBorderErrorVisible){
                shape.SetStroke(3, ((ExtendedEntry)this.Element).BorderErrorColor.ToAndroid());
			}
            else{
                shape.SetStroke(3, Android.Graphics.Color.LightGray);
				this.Control.SetBackground(shape);
            }

            this.Control.SetBackground(shape);
		}

	}
}