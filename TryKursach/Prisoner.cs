using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TryKursach
{
    public class Prisoner
    {
        public int Id;

        public string FirstName;
        public string SecondName;
        public string Patronymic;
        public DateTime Birthday;
        public int Age
        {
            get
            {
                return (DateTime.Now - Birthday).Days / 365;
            }
        }


        //-----------------------

        public int Article;
        public int Cell;

        public struct sentence
        {
            public sentence(int years, int months)
            {
                Years = years;
                Months = months;
            }
            public int Years;
            public int Months;
        }

        public sentence Sentence;
        public DateTime Imprisoned;

        public int SentenceDaysLeft
        {
            get
            {
                DateTime willBeFree = Imprisoned.AddYears(Sentence.Years).AddMonths(Sentence.Months);
                return (willBeFree - DateTime.Now).Days;
            }
        }

        public DateTime WillBeFreeDate
        {
            get
            {
                return Imprisoned.AddYears(Sentence.Years).AddMonths(Sentence.Months);
            }
        }

        public string Hierarchy;

        public string Personality;
        //-----------------------


        public Prisoner() { }




        private List<string> Fnames = new List<string>()
        {
            "Іван",
            "Петро",
            "Андрій",
            "Пахом",
            "Сергій"
        };
        private List<string> Snames = new List<string>()
        {
            "Іванів",
            "Пахомів",
            "Альтшуллер",
            "Геростратів",
            "Кортесів"
        };
        private List<string> Pnames = new List<string>()
        {
            "Іванович",
            "Петрович",
            "Андрійович",
            "Варравович",
            "Кузьмич"
        };
        private List<string> Hnames = new List<string>()
        {
            "Пахом",
            "Мужик",
            "Шістка",
            "Блатний",
            "Півень"
        };        
        private List<string> PersonalityNames = new List<string>()
        {
            "Психопат",
            "Шизоїд",
            "Істерик",
            "Нарцис",
            "Депресивний",
            "Маньяк",
            "Параноїк",
            "Мазохіст"
        };

        //**********************

        public Prisoner(int id, Random rnd)
        {
            Id = id;
            FirstName = Fnames[rnd.Next(Fnames.Count())];
            SecondName = Snames[rnd.Next(Snames.Count())];
            Patronymic = Pnames[rnd.Next(Pnames.Count())];
            Birthday = new DateTime(rnd.Next(1900, 2000), rnd.Next(2, 11), 1);
            Article = rnd.Next(300);
            //Cell = rnd.Next(1000);
            Cell = -1;
            Imprisoned = new DateTime(rnd.Next(2000, 2016), rnd.Next(1, 12), 1);

            Sentence = new sentence(0,0);
            while (Imprisoned.Year + Sentence.Years < DateTime.Now.Year)
                Sentence = new sentence(rnd.Next(0, 25), rnd.Next(0, 12));

            Hierarchy = Hnames[rnd.Next(Hnames.Count())];
            Personality = PersonalityNames[rnd.Next(PersonalityNames.Count())];

        }


        //Add checks for fields
        public Prisoner(
                string firstName,
                string secondName,
                string patronimyc,
                DateTime birthday,

                string article,
                string cell,
                string sentenceYears,
                string sentenceMonths,
                DateTime imprisonedDate,
                string hierarchy,
                string personality
            )
        {
            if(firstName.Length == 0)
            {
                throw new ArgumentException("Name is too short!");
            }
            if (secondName.Length == 0)
            {
                throw new ArgumentException("Name is too short!");
            }
            if (patronimyc.Length == 0)
            {
                throw new ArgumentException("Name is too short!");
            }

            FirstName = firstName;
            SecondName = secondName;
            Patronymic = patronimyc;
            Birthday = birthday;

            Article = int.Parse(article);
            Cell = int.Parse(cell);


            if(int.Parse(sentenceMonths) < 0 || int.Parse(sentenceMonths) > 12)
            {
                throw new ArgumentException("incorrect sentence months");
            }
            Sentence = new sentence(int.Parse(sentenceYears), int.Parse(sentenceMonths));
            Imprisoned = imprisonedDate;
            Hierarchy = hierarchy;
            Personality = personality;
        }

        



    }    
}
