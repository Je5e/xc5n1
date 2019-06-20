using SQLite;
using System;

namespace NotesApp.Models
{
    [Table("T_Notes")]
    public class Note
    {
        // Una clase tiene miembros, y uno ellos
        // son propiedades.
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
