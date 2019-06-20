using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using NotesApp.Models;

namespace NotesApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // variable de tipo entera
            int A;
            // Declarar variable de mis propios tipos.
            NoteDatabase dataBase = new NoteDatabase("");
            // Utilizar Dot Notation para acceder a los miembros de un tipo.
            dataBase.CreatetNote(new Note());
            


        }
    }
}
