using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCsharpGenT2
{
    internal class Account
    {
        public Dictionary<string, string> info;
        
        public Account() { 
        info=new Dictionary<string, string>();
           
        }

        public void AddInfo(string login, string pass)
        {
            info.Add(login, pass);
            
        }
        public void RemoveInfo (string login)
        {
            info.Remove(login);
        }
        public void RedInfo(string login,string new_login, string new_pass)
        {
            RemoveInfo(login);
            AddInfo(new_login, new_pass);
        }
        public string GetPassword(string login)
        {
            return info[login];
        }
    }

    public class Dictionary
    {
        public Dictionary<string, List<string>> dict;

        public Dictionary()
        {
            dict = new Dictionary<string, List<string>>();
        }

        public void AddWord(string w, string t)
        {
            dict.Add(w, new List<string> { t });
        }
        public void AddTranslate(string w, string t)
        {
            dict[w].Add(t);
        }
        public void Remove(string w)
        {
            dict.Remove(w);
        }
        public void RemoveTranslate(string w, string trans)
        {
            dict[w].Remove(trans);
        }
        public void EditWord(string w, string new_w, string new_trans)
        {
            Remove(w);
            AddWord(new_w, new_trans);
        }
        public void EditTranslate(string w, string trans, string new_trans)
        {
            RemoveTranslate(w, trans);
            AddTranslate(w, new_trans);
        }
        public List<string> FindTranslate(string w)
        {
            return dict[w];
        }
    }
     public class Person
    {
        public string Name { get; set; }
        public string Time { get; set; }
        public Person(string name)
        {
            Name = name;
            Time = null;
        }
        public Person(string name, string time): this(name)
        {
            Time = time;
        }
    }
    internal class CafeQueue
    {
        Queue<Person> persons;

        public CafeQueue()
        {
            persons = new Queue<Person>();
        }
        public void AddToQueue(Person p)
        {
            if (p.Time != null) {
                Console.WriteLine("Посетитель идет за столик по брони");
            }
            else
            {
                persons.Enqueue(p);
            }
           
        }
        public void FreeTable()
        {

            persons.Dequeue();
            Console.WriteLine("Посетитель идет за столик");

        }

        public void ShowQueue()
        {
            foreach(var person in persons)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
