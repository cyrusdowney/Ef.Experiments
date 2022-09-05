// See https://aka.ms/new-console-template for more information
using Ef.Experiments.Concurrency.Data;
using Ef.Experiments.Concurrency.Models;



//Console.WriteLine("First Example!");
//var dbcontext = new PeopleConcurrencyContext();

//if (dbcontext.People.FirstOrDefault(p => p.Id == 1) == null)
//{   //load some data if it is not there
//    dbcontext.People.Add(new Person { FirstName = "John", LastName = "Doe" });
//    dbcontext.SaveChanges();
//}

////This line repersents get that returns the person to the UI.
//var person = dbcontext.People.FirstOrDefault(p => p.Id == 1);

////FIRST: Breakpoint here and run the update.
///*
//  update [PeopleConcurrency].[dbo].[People]
//  set FirstName = 'Other',
//	 LastName = 'User'

// */

////Those values come back and the process gets the values from the database an updates them
////with information from the UI
//var dbcontext2 = new PeopleConcurrencyContext();
//var person2 = dbcontext2.People.FirstOrDefault(p => p.Id == 1);
//person2.FirstName = "Updated";


//dbcontext2.People.Update(person2);

//dbcontext2.SaveChanges();


//Console.ReadLine();


Console.WriteLine("Second Example!");
var dbcontext = new PeopleConcurrencyContext();

if (dbcontext.PeopleConcurency.FirstOrDefault(p => p.Id == 1) == null)
{   //load some data if it is not there
    dbcontext.PeopleConcurency.Add(new PersonConcurency { FirstName = "John", LastName = "Doe" });
    dbcontext.SaveChanges();
}

//This line repersents get that returns the person to the UI.
var personConcurrnecy = dbcontext.PeopleConcurency.FirstOrDefault(p => p.Id == 1);
var timestamp = personConcurrnecy.Timestamp;


//You can update here
/*
update [PeopleConcurrency].[dbo].[PeopleConcurency]
set FirstName = 'Other2',
LastName = 'User2'
*/

//The time stamp is roundtripped AND not Touched by the UI.
var dbcontext2 = new PeopleConcurrencyContext();
var personConcurrnecy2 = dbcontext2.PeopleConcurency.FirstOrDefault(p => p.Id == 1);
personConcurrnecy2.FirstName = "Updated";
personConcurrnecy2.Timestamp = timestamp; //use the original untouched timestamp


//You can update here
/*
update [PeopleConcurrency].[dbo].[PeopleConcurency]
set FirstName = 'Other2',
LastName = 'User2'
*/


dbcontext2.PeopleConcurency.Update(personConcurrnecy2);
dbcontext2.SaveChanges();
Console.ReadLine();


