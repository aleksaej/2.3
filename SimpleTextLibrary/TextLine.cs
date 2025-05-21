using System;

namespace SimpleTextLibrary
{
    public class TextLine
    {
        private string content;

        public TextLine(string text)
        {
            content = text;
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
                var w = words[i];
                if (w.Length > 0)
                    words[i] = char.ToUpper(w[0]) + w.Substring(1);
            }
            content = string.Join(' ', words);
        }

        public override string ToString() => content;
    }
}
