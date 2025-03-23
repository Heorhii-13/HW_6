using System;

// Завдання 1: Клас "П'єса"
class Play
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }

    public Play(string title, string author, string genre, int year)
    {
        Title = title;
        Author = author;
        Genre = genre;
        Year = year;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"П'єса: {Title}, Автор: {Author}, Жанр: {Genre}, Рік: {Year}");
    }

    ~Play()
    {
        Console.WriteLine($"П'єса {Title} знищена");
    }
}

class Program
{
    static void Main()
    {
        // Тестування класу "П'єса"
        Play play = new Play("Гамлет", "Вільям Шекспір", "Трагедія", 1601);
        play.ShowInfo();
    }
}