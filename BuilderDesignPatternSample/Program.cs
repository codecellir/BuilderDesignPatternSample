// See https://aka.ms/new-console-template for more information
using BuilderDesignPatternSample;

Console.WriteLine("Hello, World!");

var order = OrderBuilder.Empty()
    .WithNumber(1)
    .WithCreatedOn(DateTime.Now)
    .WithAddress(a=> 
                a.Street("s1")
                .City("c1")
                .PostalCode("p1")
                .Country("co1")
                //.State("st1")
    )
    .Build();

Console.ReadKey();