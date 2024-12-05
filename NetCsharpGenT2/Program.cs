// See https://aka.ms/new-console-template for more information
using NetCsharpGenT2;

//task1

//Account account = new Account();
//account.AddInfo("Alex333", "12345678");
//account.AddInfo("Oleg22", "1234");
//account.AddInfo("Dima3456", "67899");
//foreach(var item in account.info)
//{
//    Console.WriteLine(item.Key +" - "+item.Value);
//}
//Console.WriteLine();

//account.RemoveInfo("Alex333");

//foreach (var item in account.info)
//{
//    Console.WriteLine(item.Key + " - " + item.Value);
//}
//Console.WriteLine();

//account.RedInfo("Oleg22", "Oleg333", "Ol12345678");
//foreach (var item in account.info)
//{
//    Console.WriteLine(item.Key + " - " + item.Value);
//}
//Console.WriteLine();

//Console.WriteLine(account.GetPassword("Oleg333"));


//task2

//Dictionary d1 = new Dictionary();
//d1.AddWord("beautiful", "belle");
//d1.AddWord("clever", "intelligent");
//d1.AddWord("mad", "furieux");
//foreach (var item in d1.dict)
//{
//    Console.Write(item.Key + " - " + string.Join(", ", item.Value));

//}
//d1.AddTranslate("beautiful", "superbe");
//foreach (var item in d1.dict)
//{
//    Console.Write(item.Key + " - "+string.Join(", ", item.Value));
   
//}
//Console.WriteLine();
//d1.Remove("mad");
//foreach (var item in d1.dict)
//{
//    Console.Write(item.Key + " - " + string.Join(", ", item.Value));

//}
//d1.RemoveTranslate("clever", "intelligent");
//foreach (var item in d1.dict)
//{
//    Console.Write(item.Key + " - " + string.Join(", ", item.Value));

//}
//d1.EditWord("clever", "clever", "intelligent");
//foreach (var item in d1.dict)
//{
//    Console.Write(item.Key + " - " + string.Join(", ", item.Value));

//}

//d1.EditTranslate("beautiful", "belle", "magnifique");
//foreach (var item in d1.dict)
//{
//    Console.Write(item.Key + " - " + string.Join(", ", item.Value));

//}

//d1.FindTranslate("clever");
//task3
Person p1 = new Person("Alex");
Person p2 = new Person("Luis");
Person p3 = new Person("Olga", "12:30");
CafeQueue cq1 = new CafeQueue();
cq1.AddToQueue(p1);
cq1.AddToQueue(p2);
cq1.ShowQueue();
Console.WriteLine();
cq1.AddToQueue(p3);
cq1.ShowQueue();
Console.WriteLine();
cq1.FreeTable();
cq1.ShowQueue();
Console.WriteLine();
