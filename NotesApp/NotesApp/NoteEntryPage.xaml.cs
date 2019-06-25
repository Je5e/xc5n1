using NotesApp.Models;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoteEntryPage : ContentPage
    {
        public NoteEntryPage()
        {
            InitializeComponent();
        }

        // Controlador de evento Clicked del button Save
        void OnSaveButtonClicked(object sender, EventArgs e)
        {
            Note nuevaNota = new Note();
            nuevaNota.Text = EditorNote.Text;
            nuevaNota.Date = DateTime.UtcNow;
           
            // Guardarlo en la base de datos. CrearNote este método.
            NoteDatabase DataBase = new NoteDatabase
                (Path.Combine
                (Environment.GetFolderPath
                (Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
            DataBase.ReadNotes();
            int Result = DataBase.CreatetNote(nuevaNota);

            if (Result == 1)
            {
                DisplayAlert
                    ("Aviso", $"Registro ingreado con éxito. ID:{nuevaNota.ID}", "ok");
            }
        }
        void OnDeleteButtonClicked(object sender, EventArgs e)
        {

        }
    }
}