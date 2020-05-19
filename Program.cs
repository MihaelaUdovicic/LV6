using System;
using System.IO;

namespace LV6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ////zad 1
            //Note note1 = new Note("aaa", "a");
            //Note note2 = new Note("sss", "s");
            //Note note3 = new Note("ddd", "d");
            //Notebook notebook = new Notebook();
            //notebook.AddNote(note1);
            //notebook.AddNote(note2);
            //notebook.AddNote(note3);
            //IAbstractIterator iterator = notebook.GetIterator();
            //for (int i = 0; i < notebook.Count; i++)
            //{
            //    iterator.Current.Show();  //current je u roditeljskoj klasi, moram zbog Show metode
            //    iterator.Next();
            //}

            ////2 zad
            //Product product1 = new Product("a", 1.1);
            //Product product2 = new Product("s", 2.2);
            //Product product3 = new Product("d", 3.3);
            //Box box = new Box();
            //box.AddProduct(product1);
            //box.AddProduct(product2);
            //box.AddProduct(product3);
            //IAbstractIterator2 iterator2 = box.GetIterator();
            //for(int i = 0; i < box.Count; i++)
            //{
            //    Console.WriteLine(iterator2.Current.ToString());
            //    iterator2.Next();
            //}

            //3. zad
            //var date = new DateTime(2020, 5, 20, 13, 5, 2); //godina,mjesec,dan,sat,minuta,sekunda

            //ToDoItem item = new ToDoItem("asdf", "jkl", date);
            //Console.WriteLine(item.ToString());
            //CareTaker careTaker = new CareTaker();
            //careTaker.PushStack(item.StoreState());
            //item.Rename("Naslov");
            //item.ChangeTask("citat");
            //Console.WriteLine(item.ToString());
            //item.RestoreState(careTaker.PopStack());
            //Console.WriteLine(item.ToString());

            ////4.zad
            //BankAccount account = new BankAccount("Biljeznica", "mojaKuca 16", 100000);
            //Console.WriteLine(account.OwnerName + ", " + account.OwnerAddress + ", " + account.Balance);
            //MementoBank memento = account.StoreState();
            //account.ChangeOwnerAddress("novi studentski dom");
            //account.UpdateBalance(9000);
            //Console.WriteLine(account.OwnerName + ", " + account.OwnerAddress + ", " + account.Balance);
            //account.RestoreState(memento);
            //Console.WriteLine(account.OwnerName + ", " + account.OwnerAddress + ", " + account.Balance);

            ////5. zad
            //AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            //FileLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, @"d:\Mihaela\logFile.txt");
            //logger.SetNextLogger(fileLogger);
            //fileLogger.Log("Upozorenje!", MessageType.WARNING);
            //fileLogger.Log("Info!", MessageType.INFO);
            //fileLogger.Log("Pogreška!", MessageType.ERROR);

            ////6. zad
            StringChecker digit = new StringDigitChecker();
            StringChecker lenght = new StringLengthChecker();
            StringChecker lower = new StringLowerCaseChecker();
            StringChecker upper = new StringUpperCaseChecker();
            //string stringToCheck1 = "Neki string 6";
            //string stringToCheck2 = "st";
            //digit.SetNext(lower);
            //lower.SetNext(upper);
            //upper.SetNext(lenght);                               //ulancano
            //Console.WriteLine(digit.Check(stringToCheck1));
            //Console.WriteLine(digit.Check(stringToCheck2));

            //7. zad
            //string lozinka = "Lozinka1234";
            //PasswordValidator validator = new PasswordValidator(digit);
            //validator.addLink(lenght);
            //validator.addLink(lower);
            //validator.addLink(upper);
            //Console.WriteLine(validator.CheckPassword(lozinka));

            ////8. zad
            //WeatherObserver thermostat1 = new HomeThermostat();
            //WeatherObserver thermostat2 = new HomeThermostat();
            //thermostat1.Update(20);
            //thermostat2.Update(14);
            WeatherStation station = new WeatherStation(20);
            //station.AddObserver(thermostat1);
            //station.AddObserver(thermostat2);
            //station.RemoveObserver(thermostat1);
            //station.SetTemperature(18);
            //thermostat2.Update(9);
            //thermostat2.Update(30);

            WeatherObserver auto = new Auto(100.00, 90.00, "ljetne");
            station.AddObserver(auto);
            station.SetTemperature(30);
            Console.WriteLine(auto.ToString());





        }
    }
}
