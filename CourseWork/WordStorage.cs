using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class WordStorage
    {
       public WordStorage()
        {
            Words = new List<Word>();
        }
        List<Word> Words { get; set; }
        public string nameSection;
        public void AddWord(string piece1, string piece2)
        {
            Word word = new Word() { Piece1 = piece1, Piece2 = piece2 };
            Words.Add(word);
        }

        public void DeletWord(string piece1, string piece2)
        {
            Word word = new Word() { Piece1 = piece1, Piece2 = piece2 };
            Words.Remove(word);
        }

        public void EditWord(Word word ,string piece1, string piece2)
        {
            word.Piece1 = piece1;
            word.Piece2 = piece2;
            
        }
        public bool WordInLibrary(Word word)
        {
            if (Words.Contains(word))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
