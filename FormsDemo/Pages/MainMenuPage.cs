using System;
using Xamarin.Forms;

namespace FormsDemo
{
	public class MainMenuPage : ContentPage
	{
		public MainMenuPage ()
		{
			Title = "Xamarin Rules!";
			Content = new StackLayout {
				Children = {
					new Label {
						XAlign = TextAlignment.Center,
						Text = "Forms Fucking Demo"
					},
					new Button {
						Text = "Tomar Fotografia",
						Command = new Command (() => Navigation.PushModalAsync (new CameraPage (), true))
					},
					new Button {
						Text = "Abrir Mapa",
						Command = new Command(() => Navigation.PushModalAsync (new MapPage(), true))
					}
				}
			};
		}
	}
}

