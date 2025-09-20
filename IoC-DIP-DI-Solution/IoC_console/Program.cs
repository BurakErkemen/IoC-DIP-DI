// See https://aka.ms/new-console-template for more information
using IoC_console;

Console.WriteLine("Hello, World!");

BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer();

businessLogicLayer.ProcessData().ForEach(p => Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.Stock}"));



Console.ReadLine();