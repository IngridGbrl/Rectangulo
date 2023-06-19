namespace Rectangulo;
///<Summary>
///<Createddate>18/06/2023</Createddate>
///<Company>INDEL</Company>
///<Lastmodificationdate>19/06/2023</Lastmodificationdate>
///<Lastmodificationdescription>
/// cambio de formula para calcular el cuadrado y cubo de un número
///</Lastmodificationdescription>
///<Lastmodifierautor>Ingrid Gabriel</Lastmodifierautor>
///</Summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// Constructor de la clase
	/// </summary>

	public MainPage()
	{
		InitializeComponent();
	}

	/// <summary>
	/// en el evento se calculara el numero y los resultados se mostraran en sus respectivos entry
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
		if (!string.IsNullOrEmpty(h.Text) || (!string.IsNullOrEmpty(b.Text)))
		{
			double altura, basse, super, p;

			altura = Convert.ToDouble(h.Text);
			basse = Convert.ToDouble(b.Text);



			p= 2 * (basse + altura);

			super = basse * altura;

			perimetro.Text = p.ToString();
			superficie.Text = super.ToString();
		}

		else
		{
			DisplayAlert("ERROR", "Ocurrio un error al introducir dato requerido", "OK");
		}
    }
}

