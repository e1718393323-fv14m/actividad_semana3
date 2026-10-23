namespace fvelezS3.Views;

public partial class vPrincipal : ContentPage
{
	public vPrincipal(string usuario)
	{
		InitializeComponent();

		DisplayAlert("Bienvenido", usuario, "Cerrar");
		lblUsuario.Text = "Usuario Conectado " + usuario;
	}
}