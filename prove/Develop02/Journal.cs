public class Journal
{
    public List<Entry> _entries;
    
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void AddEntry(Entry newEntry)
    {
        // Check if newEntry is not null
        if (newEntry != null)
        {
            // Check if _entries is null, if yes, Initialize it
            _entries = _entries ?? new List<Entry>();
    
            // Add the newEntry to the _entries list
            _entries.Add(newEntry);
        }
        else
        {
            Console.WriteLine("Invalid Entry: Entry cannot be null");
        }
    }

    public void SaveToFile(string file)
    {
        // Check if _entries is not null
        if (_entries != null)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"Date: {entry._date}");
                    writer.WriteLine($"Prompt: {entry._promptText}");
                    writer.WriteLine($"Entry: {entry._entryTextl}");
                    writer.WriteLine(); // This is for making a separate line after each entry
                }
            }
        }
        else
        {
            Console.WriteLine("No entries to save");
        }
    }

    public void ReadFromFile(string file)
    {
        _entries = new List<Entry>();
    
        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            int partIndex = 0;
        
            Entry entry = new Entry();

            while ((line = reader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    if (!string.IsNullOrWhiteSpace(entry._date) || !string.IsNullOrWhiteSpace(entry._promptText) || !string.IsNullOrWhiteSpace(entry._entryTextl))
                    {
                        // Add to the list
                        AddEntry(entry);
                    }

                    // Reset entry and part index
                    entry = new Entry();
                    partIndex = 0;
                }
                else
                {
                    string value = line.Substring(line.IndexOf(":") + 2);
                    switch (partIndex)
                    {
                        case 0:
                            entry._date = value;
                            break;
                        case 1:
                            entry._promptText = value;
                            break;
                        case 2:
                            entry._entryTextl = value;
                            break;
                    }
                    partIndex++;
                }
            }
        
            // Add the last entry
            if (!string.IsNullOrWhiteSpace(entry._date) || !string.IsNullOrWhiteSpace(entry._promptText) || !string.IsNullOrWhiteSpace(entry._entryTextl))
            {
                // Add to the list
                AddEntry(entry);
            }
        }
    }
}