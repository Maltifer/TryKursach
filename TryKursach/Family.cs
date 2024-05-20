using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TryKursach.Prisoner;
using System.Xml.Linq;
using System.Xml;

namespace TryKursach
{
    public class Relative
    {
        public int Id;
        public int uniqueId;
        public string FirstName;
        public string SecondName;
        public string Patronymic;
        public string Relation;

        private List<string> MaleFnames = new List<string>()
        {
            "Андрій",
            "Петро",
            "Іван",
            "Євген",
            "Микита"
        };        
        private List<string> FemaleFnames = new List<string>()
        {
            "Ганна",
            "Влада",
            "Інна",
            // "Олег",
            "Ольга",
            "Таїсія"
        };
        private List<string> MaleSnames = new List<string>()
        {
            "Іванів",
            "Пахомів",
            "Альтшуллер",
            "Геростратів",
            "Кортесів"
        };
        private List<string> FemaleSnames = new List<string>()
        {
            "Іванова",
            "Пахомівна",
            "Васильєва",
            "Петрова",
            "Кортесова"
        };
        private List<string> MalePnames = new List<string>()
        {
            "Іванович",
            "Петрович",
            "Андрійович",
            "Варравович",
            "Кузьмич"
        };        
        private List<string> FemalePnames = new List<string>()
        {
            "Іванівна",
            "Петрівна",
            "Андріївна",
            "Варравівна",
            "Никитишна"
        };        
        private List<string> MaleRnames = new List<string>()
        {
            "Батько",
            "Дядько",
            "Брат",
            "Син",
            "Дідусь"
        };        
        private List<string> FemaleRnames = new List<string>()
        {
            "Мати",
            "Тітка",
            "Сестра",
            "Донька",
            "Бабуся"
        };
        public Relative() { }
        public Relative(int id, Random rnd, int gender)
        {
            if (gender == 1)
            {
                Id = id;

                FirstName = MaleFnames[rnd.Next(MaleFnames.Count())];

                SecondName = MaleSnames[rnd.Next(MaleSnames.Count())];

                Patronymic = MalePnames[rnd.Next(MalePnames.Count())];

                Relation = MaleRnames[rnd.Next(MaleRnames.Count())];
            }
            else
            {
                Id = id;

                FirstName = FemaleFnames[rnd.Next(FemaleFnames.Count())];

                SecondName = FemaleSnames[rnd.Next(FemaleSnames.Count())];

                Patronymic = FemalePnames[rnd.Next(FemalePnames.Count())];

                Relation = FemaleRnames[rnd.Next(FemaleRnames.Count())];
            }
        }

        public Relative(
        string firstName,
        string secondName,
        string patronimyc,
        string ID,
        string relation
        )
        {
            if (firstName.Length == 0)
            {
                throw new ArgumentException("firstName is too short!");
            }
            if (secondName.Length == 0)
            {
                throw new ArgumentException("secondName is too short!");
            }
            if (patronimyc.Length == 0)
            {
                throw new ArgumentException("patronimyc is too short!");
            }                
            if (Id > 0)
            {
                throw new ArgumentException("Id is too short!");
            }                
            if (relation.Length == 0)
            {
                throw new ArgumentException("relation is too short!");
            }

            FirstName = firstName;
            SecondName = secondName;
            Patronymic = patronimyc;
            Relation = relation;
            this.Id = int.Parse(ID);
        }
    }
    public class Family : IEnumerable
    {
        public string FamilyListLocation = "Family.json";

        public Random randGen = new Random();

        public List<Relative> selectedFamily;

        public List<Relative> family = new List<Relative>();

        public Prisoners MyPrisoners;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return family.GetEnumerator();
        }

        public Family(Prisoners p)
        {
            MyPrisoners = p;
        }
        public void Save()
        {
            using (TextWriter writer = new StreamWriter(File.Create(FamilyListLocation)))
            {
                writer.WriteLine(JsonConvert.SerializeObject(family));
            }
        }

        public void Load()
        {
            if (File.Exists(FamilyListLocation))
            {
                using (TextReader reader = new StreamReader(File.OpenRead(FamilyListLocation)))
                {
                    family = JsonConvert.DeserializeObject<List<Relative>>(reader.ReadLine());
                }
            }
            selectedFamily = family;
        }
        private int generateGender()
        {
            int r = randGen.Next(1, 3);
            return r;
        }
        public void Create()
        {
            int length = 10;
            for (int i = 0; i < length; i++)
            {
                Add(new Relative(MyPrisoners.prisoners[randGen.Next(MyPrisoners.prisoners.Count)].Id, randGen, generateGender()));
            }
        }        
        public void CreateFixed(int ID)
        {
            int length = 3;
            for (int i = 0; i < length; i++)
            {
                Add(new Relative(ID, randGen, generateGender()));
            }
        }

        private int generateId()
        {
            int r = randGen.Next(1, 10000);
            if (family.Exists(x => x.Id == r))
            {
                return generateId();
            }
            else return r;
        }
        public void Add(Relative r)
        {
            r.uniqueId = generateId();
            if (MyPrisoners.prisoners.Exists(x => x.Id == r.Id))
            {
                family.Add(r);
            }
            else 
            {
                throw new ArgumentException("There is no prisoner with such Id");
            }

        }
        public void Replace(int uniqueID, Relative newR)
        {
            //int index = family.FindIndex(p => p.Id == id);
            //newP.Id = family[pos];
            //family[pos] = newP;
            int index = family.FindIndex(p => p.uniqueId == uniqueID);
            newR.uniqueId = family[index].uniqueId;
            family[index] = newR;
        }
        public void Remove(int uniqueID)
        {
            family.RemoveAll(x => x.uniqueId == uniqueID);

        }

        public List<Relative> SearchBy(Func<Relative, string> f, string pattern, bool strict)
        {
            if (strict)
            {
                selectedFamily = family.Where(x => f(x).ToLower() == pattern.ToLower()).ToList();
            }
            else
            {
                selectedFamily = family.Where(x => f(x).ToLower().Contains(pattern.ToLower())).ToList();
            }

            return selectedFamily;
        }


        public List<Relative> OrderBy(Func<Relative, string> f, bool ascending)
        {
            if (ascending)
            {
                selectedFamily = family.OrderBy(x => TryParse(f(x))).ToList();
            }
            else
            {
                selectedFamily = family.OrderByDescending(x => TryParse(f(x))).ToList();
            }

            return selectedFamily;
        }

        public dynamic TryParse(string s)
        {
            int res;

            if (int.TryParse(s, out res))
            {
                return res;
            }
            else
            {
                return s;
            }

        }

        public void Clear()
        {
            while (family.Count != 0)
            {
                Remove(family[0].uniqueId);
            }
            selectedFamily = family;
        }
    }
}
