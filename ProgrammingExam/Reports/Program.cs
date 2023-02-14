
using System;
using Microsoft.EntityFrameworkCore;
using Reports;
using static System.Net.Mime.MediaTypeNames;

using var context = new ProgramminClassesContext();
foreach (var customer in context.Customers)
{
    Console.WriteLine($"{customer.FirstName} {customer.LastName} (Company Name: {customer.CompanyName}) (ID: {customer.CustomerId})");
}



var me = new Customer
{
    FirstName = "Zhanarys",
    LastName = "Maliik",
    PasswordHash = "qwertyas1234",
    PasswordSalt = "51C00"
};

context.Customers.Add(me);
context.SaveChanges();


Console.WriteLine("Updated table");

foreach (var customer in context.Customers)
{
    Console.WriteLine($"{customer.FirstName} {customer.LastName} (Company Name: {customer.CompanyName}) (ID: {customer.CustomerId})");
}
