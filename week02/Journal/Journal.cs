using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("Entry added successfully!");
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty. Write some entries first!");
            return;
        }

        Console.WriteLine("----Your Journal Entries----");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._promptText},{entry._date},{entry._entryText}");
            }

            System.Console.WriteLine($"File '{file}' saved successfully.");
        }
    }

    public void LoadFromFile(string file)
    {
        
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry loadedEntry = new Entry();
            loadedEntry._date = parts[0];
            loadedEntry._promptText = parts[1];
            loadedEntry._entryText = parts[2];
            _entries.Add(loadedEntry);
            
        }
    }
}