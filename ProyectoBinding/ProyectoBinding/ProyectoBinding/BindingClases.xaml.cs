using ProyectoBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoBinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
	public partial class BindingClases : ContentPage
	{
        public Persona person;
        public BindingClases ()
		{
			InitializeComponent ();
            this.person = new Persona();
            person.Nombre = "Alex Sandro";
            person.Edad = 35;
            person.Imagen = "http://www.juventus.com/media/images/news-images/2018-19/giocatori/sandro01.jpg";
            this.BindingContext = person;
        
		}
	}
}