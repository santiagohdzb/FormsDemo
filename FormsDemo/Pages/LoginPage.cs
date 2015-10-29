using System;
using Xamarin.Forms;

namespace FormsDemo
{
	public class LoginPage : ContentPage
	{
		Entry user;
		Entry pass;

		public LoginPage ()
		{
			user = new Entry {
				Placeholder = "Usuario"
			};
			pass = new Entry {
				IsPassword = true,
				Placeholder = "****"
			};

			Content = new StackLayout {
				Children = {
					new Label {
						Text = "Usuario"
					},
					user,
					new Label {
						Text = "Contraseña"
					},
					pass,
					new Button {
						Text = "Ingresar",
						Command = new Command (Acceder)
					}
				}	
			};


		}

		void Acceder() {
			var correct = user.Text.Trim () == "santiago" && pass.Text.Trim () == "password";
			if (correct) {
				Navigation.PushModalAsync (new MainMenuPage (), true);
			} else {
				DialogService.ShowError ("Credenciales incorrectas");
			}
		}
	}
}

