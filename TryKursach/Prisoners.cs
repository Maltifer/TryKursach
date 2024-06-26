﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Collections;

namespace TryKursach
{
    public class Prisoners:IEnumerable
    {

        public string PrisonersListLocation = "prisoners.json";
        public string txtLocation = "selectedPrisoners.txt";

        public Random randGen = new Random();

        public List<Prisoner> selectedPrisoners;

        public List<Prisoner> prisoners = new List<Prisoner>();


        public Cells cells;

        public List<Convoy> convoys = new List<Convoy>();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return prisoners.GetEnumerator();
        }

        public void Create()
        {
            int length = 10;
            for (int i = 0; i < length; i++)
            {                
                Add(new Prisoner(generateId(), randGen));
            }
        }


        

        public void SaveIntxt(string info)
        {
            using (TextWriter writer = new StreamWriter(File.Create(txtLocation)))
            {
                writer.WriteLine(info);
            }
        }

        public void Save()
        {
            using (TextWriter writer = new StreamWriter(File.Create(PrisonersListLocation)))
            {
                writer.WriteLine(JsonConvert.SerializeObject(prisoners));
            }
        }        

        public void Load()
        {
            if (File.Exists(PrisonersListLocation))
            {
                using (TextReader reader = new StreamReader(File.OpenRead(PrisonersListLocation)))
                {
                    prisoners = JsonConvert.DeserializeObject<List<Prisoner>>(reader.ReadLine());                    
                }
            }
            selectedPrisoners = prisoners;
            cells = new Cells(100, prisoners);
        }




        private int generateId()
        {
            int r = randGen.Next(1, 10000);
            if (prisoners.Exists(x => x.Id == r))
            {
                return generateId();
            }
            else return r;
        }


        


        public void Add(Prisoner p)
        {
            p.Id = generateId();
            if (p.Cell == -1)
            {
                cells.Insert(p);
            }
            else if (p.Cell < 0 || p.Cell > cells.cells.Count)
            {
                throw new ArgumentException("This cell is full");
            }            
            else
            {
                cells.Insert(p, p.Cell);
            }
            
            prisoners.Add(p);
        }





        public void Replace(int id, Prisoner newP)
        {
            int index = prisoners.FindIndex(p => p.Id == id);
            newP.Id = prisoners[index].Id;
            prisoners[index] = newP;
        }







        public void Remove(int id)
        {
            cells.RemovePrisoner(id);
            prisoners.RemoveAll(x => x.Id == id);            
        }


        public string FormStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Prisoners: " + selectedPrisoners.Count);
            sb.AppendLine("5 Most popular articles: " +
                    selectedPrisoners
                        .OrderByDescending(x=> selectedPrisoners
                        .FindAll(p=>p.Article == x.Article)
                        .Count)
                        .GroupBy(x=>x.Article)
                        .Select(g => g.First())
                        .Take(5)
                        .Select(x=>x.Article.ToString())
                        .Aggregate((i,j)=> i + " " + j)
                );
            sb.AppendLine("Найстаріший в'язень: " + selectedPrisoners
                    .OrderByDescending(x => x.Age).First().Id);

            sb.AppendLine("Наймолодший в'язень: " + selectedPrisoners
                    .OrderBy(x => x.Age).First().Id);

            sb.AppendLine("Будуть відпущені цього місяця:");
            foreach(Prisoner p in selectedPrisoners.Where(p=>p.SentenceDaysLeft < 30 && p.SentenceDaysLeft >=0).OrderBy(p=>p.SentenceDaysLeft))
            {
                sb.AppendLine(p.FirstName + " " + p.SecondName + " " + p.WillBeFreeDate.ToString("yy/mm/dd"));
            }


            return sb.ToString();
        }
        /*private string FortxtSave()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Prisoners: " + selectedPrisoners.Count);
            sb.AppendLine("5 Most popular articles: " +
                    selectedPrisoners
                        .OrderByDescending(x=> selectedPrisoners
                        .FindAll(p=>p.Article == x.Article)
                        .Count)
                        .GroupBy(x=>x.Article)
                        .Select(g => g.First())
                        .Take(5)
                        .Select(x=>x.Article.ToString())
                        .Aggregate((i,j)=> i + " " + j)
                );
            sb.AppendLine("Самый старый заключенный: " + selectedPrisoners
                    .OrderByDescending(x => x.Age).First().Id);

            sb.AppendLine("Самый молодой заключенный: " + selectedPrisoners
                    .OrderBy(x => x.Age).First().Id);

            sb.AppendLine("Будут отпущены в этом месяце:");
            foreach(Prisoner p in selectedPrisoners.Where(p=>p.SentenceDaysLeft < 30 && p.SentenceDaysLeft >=0).OrderBy(p=>p.SentenceDaysLeft))
            {
                sb.AppendLine(p.FirstName + " " + p.SecondName + " " + p.WillBeFreeDate.ToString("yy/mm/dd"));
            }
            foreach(Prisoner p in selectedPrisoners)
            {
                sb.AppendLine("///////////////////////////////////");
                sb.AppendLine("Айді: " + p.Id.ToString());
                sb.AppendLine("Ім'я: " + p.FirstName);
                sb.AppendLine("Ім'я: " + p.SecondName);
                sb.AppendLine("Ім'я: " + p.Patronymic);
                sb.AppendLine("Ім'я: " + p.Patronymic);
                sb.AppendLine("///////////////////////////////////");
            }

            return sb.ToString();
        }*/


        public List<Prisoner> SaveBy(Func<Prisoner, string> f, string pattern, bool strict)
        {
            if (strict)
            {
                selectedPrisoners = prisoners.Where(x => f(x).ToLower() == pattern.ToLower()).ToList();
            }
            else
            {
                selectedPrisoners = prisoners.Where(x => f(x).ToLower().Contains(pattern.ToLower())).ToList();
            }

            return selectedPrisoners;
        }
        public List<Prisoner> SearchBy(Func<Prisoner, string> f, string pattern, bool strict)
        {
            if (strict)
            {
                selectedPrisoners = prisoners.Where(x => f(x).ToLower() == pattern.ToLower()).ToList();
            }
            else
            {
                selectedPrisoners = prisoners.Where(x => f(x).ToLower().Contains(pattern.ToLower())).ToList();
            }

            return selectedPrisoners;
        }


        public List<Prisoner> OrderBy(Func<Prisoner, string> f, bool ascending)
        {
            if (ascending)
            {
                selectedPrisoners = prisoners.OrderBy(x => TryParse(f(x))).ToList();
            }
            else
            {
                selectedPrisoners = prisoners.OrderByDescending(x => TryParse(f(x))).ToList();
            }
            
            return selectedPrisoners;
        }
        
        public dynamic TryParse(string s)
        {
            int res;

            if(int.TryParse(s,out res))
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
            while (prisoners.Count != 0)
            {
                Remove(prisoners[0].Id);
            }
            selectedPrisoners = prisoners;
        }






        public void Convoy(int prisonerId, string cellId, string convoyersNum, string duration)
        {

            int cid = int.Parse(cellId);
            if (cells.cells[cid].IsFull)
            {
                throw new ArgumentException("selected cell is already full");
            }

            Prisoner p = prisoners[prisoners.FindIndex(x => x.Id == prisonerId)];

            ///////////////
            convoys.Add(new Convoy()
            {
                Convoyed = p,
                SourceCell = p.Cell,
                DestinationCell = cid,

                ConvoyersRequired = int.Parse(convoyersNum),

                StartedAt = DateTime.Now,
                MDuration = int.Parse(duration)
            });
            ////////////
            
            p.Cell = cells.Insert(p, cid).Id;
            cells.RemovePrisoner(prisonerId);

            
        }


    }
        


}
