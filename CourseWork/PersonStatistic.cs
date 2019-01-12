using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class PersonStatistic
    {
        public PersonStatistic()
        {
            DateStatistics = new DateTime();
            StatisticsMode1s = new List<StatisticsMode1>();
            StatisticsMode2s = new List<StatisticsMode2>();
        }
        
        public List<StatisticsMode1> StatisticsMode1s { get; set; }
        public List<StatisticsMode2> StatisticsMode2s { get; set; }
        public DateTime DateStatistics { get; set; }
    }
}
