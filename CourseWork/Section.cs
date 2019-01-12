using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class Section
    {
        public Section()
        {
            Words = new List<Word>();
        }
        public List<Word> Words { get; set; }
        public string nameSection;
        protected Random random = new Random();

        public Word RandomWord(List<Word> words)
        {
            int numberRandom = random.Next(0, words.Count);
            return words[numberRandom];
        }

        public List<Word> AddWord(string piece1, string piece2)
        {
            Word word = new Word() { Piece1 = piece1, Piece2 = piece2 };
            Words.Add(word);
            return Words;
        }

        public List<Word> DeleteWord(string piece1, string piece2)
        {
            Word word = new Word() { Piece1 = piece1, Piece2 = piece2 };
            Words.Remove(Words.Find(u => (u.Piece1 == word.Piece1) && (u.Piece2 == word.Piece2)));
            return Words;
        }
    }
}
