namespace EVegaT2.Vistas;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
		string usuarior = txtUsuarioR.Text;
		string claver = txtClaveR.Text;

		Navigation.PushAsync(new IniGrid(usuarior, claver));
    }
}