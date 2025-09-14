public class Journal
{
    public List<Entry> entries = new List<Entry>();

    // add new entries to the journal
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No Journal Entries Yet!");
        }
        else
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry.Display());
            }
        }
    }

    // Save to file

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Date} | {entry.Prompt} | {entry.Response}");
            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }

    // Read from file

    public void LoadFromFIle(string Filename)
    {
        if (!File.Exists(Filename))
        {
            Console.WriteLine("File not found");
            return;
        }
        entries.Clear();

        string[] lines = File.ReadAllLines(Filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                entries.Add(entry);
            }
        }
        Console.WriteLine($"Journal loaded from {Filename}");
    }
}