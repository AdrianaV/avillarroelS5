using avillarroelS5.Models;
using avillarroelS5.Utils;

namespace avillarroelS5.Views;

public partial class vHome : ContentPage
{
	
	public vHome()
	{
		InitializeComponent();
	}

    private void btnInsertar_Clicked(object sender, EventArgs e)
    {
        status.Text = "";
        App.personrepo.AddNewPerson(txtNombre.Text);
        status.Text = App.personrepo.StatusMessage;
    }

    private void btnListar_Clicked(object sender, EventArgs e)
    {
        status.Text = "";
        List<Person> people = App.personrepo.GetAllPeople();
        ListarPersonas.ItemsSource = people;
    }
}