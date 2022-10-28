using DAL.Listados;
using Entities;
using System.Collections.ObjectModel;

namespace Ejercicio5;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		//Llamo a la lista de personas y se la mando al listView para que la muestre
		ObservableCollection<clsPersona> personas = new ObservableCollection<clsPersona>();
		var listadoPersonas = new listadoPersonas();
		//Relleno el ObservableCollection con los datos de la lista de clsPersona
		foreach(clsPersona persona in listadoPersonas.getListadoCompletoPersonas())
		{
			personas.Add(persona);
		}
		//Envio la ObservableCollection de clsPersona a la ListView 
		PersonasListView.ItemsSource = personas;
	}

}

