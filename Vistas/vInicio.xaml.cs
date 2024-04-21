namespace EVegaT2.Vistas;

public partial class vInicio : ContentPage
{
	public vInicio(string usuario)
	{
		InitializeComponent();
        DisplayAlert("Alerta", "Bienvenido "+ usuario, "Cerrar");
        lblUsuario.Text = "Usuario Conectado: "+usuario;
	}

    private void btnPickerest_Clicked(object sender, EventArgs e)
    {
		if(pkNombreEstudiantes.SelectedIndex == -1) 
		{
			DisplayAlert("Alerta", "No existe el Estudiante", "Cerrar");
		}
		else
		{
			string nombrest = pkNombreEstudiantes.Items[pkNombreEstudiantes.SelectedIndex].ToString();
            string fecha = dpFecha.Date.ToString();

            int notaseg1 = Convert.ToInt32(txtNotaSeg1.Text); //Funcion para convertir texto en enteros
            int notaex1 = Convert.ToInt32(txtNotaEx1.Text); //Funcion para convertir texto en enteros

            int notaseg2 = Convert.ToInt32(txtNotaSeg2.Text); //Funcion para convertir texto en enteros
            int notaex2 = Convert.ToInt32(txtNotaEx2.Text); //Funcion para convertir texto en enteros

            double seg1 = Math.Round(notaseg1 * 0.3,2); //Math.Round me permite redondear a dos decimales
            double ex1 = Math.Round(notaex1 * 0.2, 2);
            double parc1 = Math.Round(seg1 + ex1,2);

            double seg2 = Math.Round(notaseg2 * 0.3, 2);
            double ex2 = Math.Round(notaex2 * 0.2, 2);
            double parc2 = Math.Round(seg2 + ex2,2);

            double notaf = Math.Round(parc1 + parc2,2);

            string mensajeAR = (notaf >= 7) ? "Aprobado" : "Reprobado"; //Condicional para marcar mensaje de aprobado o reprobado

            DisplayAlert("Alerta", "El estudiante selecionado es: "+nombrest+
                "\nNota Seguimiento 1: "+seg1+"\nNota Examen 1: "+ex1+"\nNota Parcial 1: "+parc1+
                "\n---------------------------------------------"+
                "\nNota Seguimiento 2: "+seg2+"\nNota Examen 2: "+ex2+"\nNota Parcial 2: "+parc2+
                "\nNota Final: "+notaf+
                "\n---------------------------------------------"+
                "\n"+mensajeAR+
                "\n---------------------------------------------"+
                "\nFecha: "+fecha
                , "Cerrar");

            // Limpiar los datos ingresados
            txtNotaSeg1.Text = "";
            txtNotaEx1.Text = "";
            txtNotaSeg2.Text = "";
            txtNotaEx2.Text = "";
            dpFecha.Date = DateTime.Now; //Me permite restablecer los valores ingresados a 0
                                         
            pkNombreEstudiantes.SelectedIndex = -1; //Restablece el picker de los intems
        }
    }
}