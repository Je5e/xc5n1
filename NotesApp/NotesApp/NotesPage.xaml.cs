﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotesPage : ContentPage
    {
        public NotesPage()
        {
            InitializeComponent();
        }

        void OnNoteAddedClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NoteEntryPage());
        }
        void OnListViewItemSelected
            (object sender, SelectedItemChangedEventArgs e)
        {
            Note NoteSelected = (Note)e.SelectedItem;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            NoteDatabase dataBase = new NoteDatabase(Path.Combine
                (Environment.GetFolderPath
                (Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
           
            var NotesFromDB = dataBase.ReadNotes();
            listView.ItemsSource = NotesFromDB;
        }


    }
}