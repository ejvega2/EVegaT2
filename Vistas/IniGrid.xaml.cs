namespace EVegaT2.Vistas;

public partial class IniGrid : ContentPage
{
	string usuario1;
	string clave1;
	public IniGrid()
	{
		InitializeComponent();
	}
	public IniGrid(string usuarior, string claver) {
		InitializeComponent();
		usuario1 = usuarior;
		clave1 = claver;
	}

    private void btnIngreso_Clicked(object sender, EventArgs e)
    {

		if(txtUsuario.Text == usuario1 & txtPassword.Text == clave1) {
			Navigation.PushAsync(new vInicio(usuario1));
		}else
		{
			DisplayAlert("Alerta", "Usuario/Contraseña es incorrecto", "Cerrar");
		}
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Registro());
    }
}