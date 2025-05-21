using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextLibrary
{
    public class Text : ICaseTransformer
    {
        private List<TextLine> lines = new List<TextLine>();

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
            lines.RemoveAll(line => line.Contains(substring));
        }

        public void Clear()
        {
            lines.Clear();
        }

        public int LongestLineLength()
        {
            return lines.Any() ? lines.Max(line => line.Length) : 0;
        }

        public void CapitalizeFirstLetters()
        {
            foreach (var line in lines)
            {
                line.CapitalizeFirstLetters();
            }
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, lines);
        }
    }
}