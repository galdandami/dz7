using System;

class Song
{
    string name;
    string author;
    Song prev;

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetAuthor(string author)
    {
        this.author = author;
    }

    public void SetPrev(Song prev)
    {
        this.prev = prev;
    }

    public void Print()
    {
        Console.WriteLine($"Название: {name}, Исполнитель: {author}");
    }

    public string Title()
    {
        return $"{name} — {author}";
    }

    public override bool Equals(object d)
    {
        if (d == null || !(d is Song))
            return false;

        Song other = (Song)d;
        return this.name == other.name && this.author == other.author;
    }

    public override int GetHashCode()
    {
        return (name?.GetHashCode() ?? 0) ^ (author?.GetHashCode() ?? 0);
    }
}

class Program
{
    static void Main()
    {
        Song song1 = new Song();
        song1.SetName("Группа крови");
        song1.SetAuthor("Кино");

        Song song2 = new Song();
        song2.SetName("Фантом");
        song2.SetAuthor("Гражданская оборона");

        Song song3 = new Song();
        song3.SetName("Бесполезно");
        song3.SetAuthor("Валентин Стрыкало");

        Song song4 = new Song();
        song4.SetName("Выхода нет");
        song4.SetAuthor("Сплин");

        song2.SetPrev(song1);
        song3.SetPrev(song2);
        song4.SetPrev(song3);

        var songs = new System.Collections.Generic.List<Song> { song1, song2, song3, song4 };

        Console.WriteLine("Список песен:");
        foreach (Song s in songs)
        {
            s.Print();
        }

        Console.WriteLine();
        Console.WriteLine($"Сравнение \"{song1.Title()}\" и \"{song2.Title()}\":");
        if (song1.Equals(song2))
            Console.WriteLine("Песни совпадают.");
        else
            Console.WriteLine("Песни различаются.");
    }
}