using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public interface ICaseTransformer
    {
        void CapitalizeFirstLetters();
    }

    public class TextLine
    {
        private string content;

        public TextLine(string line)
        {
            content = line;
        }

        public string Content => content;

        public bool Contains(string substring)
        {
            return content.Contains(substring, StringComparison.OrdinalIgnoreCase);
        }

        public int Length => content.Length;

        public void CapitalizeFirstLetters()
        {
            var words = content.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                if (word.Length > 0)
                {
                    words[i] = char.ToUpper(word[0]) + word.Substring(1);
                }
            }
            content = string.Join(' ', words);
        }

        public override string ToString()
        {
            return content;
        }
    }

    public class Text : ICaseTransformer
    {
        private List<TextLine> lines;

        public Text()
        {
            lines = new List<TextLine>();
        }

        public void AddLine(string line)
        {
            lines.Add(new TextLine(line));
        }

        public void RemoveLineAt(int index)
        {
            if (index >= 0 && index < lines.Count)
                lines.RemoveAt(index);
        }

        public void RemoveLinesContaining(string substring)
        {
            lines = lines.Where(line => !line.Contains(substring)).ToList();
        }

        public void Clear()
        {
            lines.Clear();
        }

        public int LongestLineLength()
        {
            return lines.Any() ? lines.Max(line => line.Length) : 0;
        }
    }
}
