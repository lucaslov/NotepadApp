using NoteApp;

namespace NotepadApp
{
    public class NotesManager
    {
        private List<Note> notes { get; set; }

        public NotesManager()
        {
            notes = new List<Note>();
        }

        public void Add()
        {
            var note = GetNoteFromUser();
            notes.Add(note);
        }

        private Note GetNoteFromUser()
        {
            var note = new Note();

            Console.WriteLine("Podaj notatkę");
            Console.WriteLine("Podaj Id");
            note.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj Description");
            note.Description = Console.ReadLine();
            Console.WriteLine("Podaj Name");
            note.Name = Console.ReadLine();
            note.CreationDate = DateTime.Now;

            return note;
        }

        public void Update()
        {
            Console.WriteLine("Podaj ID notatki do aktualizacji");
            var id = int.Parse(Console.ReadLine());
            Note noteToUpdate = null;
            foreach (var note in notes)
            {
                if (note.Id == id)
                {
                    noteToUpdate = note;
                }
            }

            if (noteToUpdate is null)
            {
                Console.WriteLine($"Nie znaleziono notatki z ID: {id}");
                return;
            }

            Console.WriteLine("Podaj nowy tytuł");
            var title = Console.ReadLine();

            Console.WriteLine("Podaj nowy opis");
            var description = Console.ReadLine();

            noteToUpdate.Description = description;
            noteToUpdate.Name = title;
        }

        public void PrintNotes()
        {
            foreach (var n in notes)
            {
                Console.WriteLine($"Id: {n.Id}, Nazwa: {n.Name}, Opis: {n.Description}");
            }
        }

        public void Delete()
        {
            Console.WriteLine("Podaj ID notatki do usunięcia");
            var id = int.Parse(Console.ReadLine());
            Note noteToRemove = null;
            foreach (var note in notes)
            {
                if (note.Id == id)
                {
                    noteToRemove = note;
                }
            }

            if (noteToRemove is null)
            {
                Console.WriteLine($"Nie znaleziono notatki z ID: {id}");
                return;
            }

            notes.Remove(noteToRemove);
        }
    }
}
