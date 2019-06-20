using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace NotesApp.Models
{
   public class NoteDatabase
    {
        // Crear la base de datos.
        readonly SQLiteConnection Database;

        // Escribir datos a la base de datos.
        // Leer datos desde la base de datos.
        // Actualizar datos de la bd.
        // Eliminar registros de la bd.

        // El constructor de la clase NoteDatabase
        public NoteDatabase(string dbPath)
        {
            // Creando la base de datos. 
            Database = new SQLiteConnection(dbPath);

            // Creamos una tabla llamada Note, en la bd
            Database.CreateTable<Note>();

        }

        // CRUD
        // Para agregar una nueva entidad a la bd.
        // Lo hacemos con un método.
        public int CreatetNote(Note noteToInsert)
        {
            int Resultado = 0; // ?
             Resultado = Database.Insert(noteToInsert);
            return Resultado;
        }

        // Para leer todos los registros de la tabla T_Notes
        public List<Note> ReadNotes()
        {
            return Database.Table<Note>().ToList(); // select * from T_Notes
        }

        // Para eliminar un registro de la bd
        public int DeleteNote(Note noteToDelete)
        {
            return Database.Delete(noteToDelete);
        }

        // Para actualizar un registro de la bd
        public int UpdateNote(Note noteToUpdate)
        {
            return Database.Update(noteToUpdate);
        }

        // Para leer una entidad de la bd.
        public Note ReadNote(int ID)
        {   // select * from T_Notes where ID==@ID
            return Database.Table<Note>()
                .Where(n => n.ID == ID).FirstOrDefault(); // select * from T_Clientes where IDCLIENTE=1
        }

        
    }
}
