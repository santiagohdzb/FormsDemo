using Xamarin.Forms;
using System.IO;

namespace FormsDemo
{
	public class DisplayPicturePage : ContentPage
	{
		StackLayout mainLayout;

		public DisplayPicturePage (byte[] image)
		{
			mainLayout = new StackLayout () {
				Padding = new Thickness (0),
				Children = {
					new Image {
						Source = ImageSource.FromStream(() => new MemoryStream(image)),
						Aspect = Aspect.AspectFill
					}
				}
			};

			Content = mainLayout;
		}
	}
}