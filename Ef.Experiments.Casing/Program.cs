// See https://aka.ms/new-console-template for more information
using Ef.Experiments.Casing.Data;
using Ef.Experiments.Casing.Models;

Console.WriteLine("Hello, World!");


var dbcontext = new PeopleContext();



dbcontext.People.Add(new Person { firstName = "John", lastName = "Doe" });
dbcontext.SaveChanges();