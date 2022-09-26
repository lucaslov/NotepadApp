using NotepadApp;

var noteManager = new NotesManager();

bool isRunning = true;

while (isRunning)
{
    Console.WriteLine("Wybierz opcję. 0 - zakończ działanie programu, 1 dodaj notatkę, 2 - usuń notatkę, 3 - edytuj notatkę, 4 - wyświetl wszystkie notatki.");

    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 0:
            isRunning = false;
            Console.WriteLine("Koniec wykonywania programu.");
            break;
        case 1:
            noteManager.Add();
            break;
        case 2:
            noteManager.Delete();
            break;
        case 3:
            noteManager.Update();
            break;
        case 4:
            noteManager.PrintNotes();
            break;
    }
}