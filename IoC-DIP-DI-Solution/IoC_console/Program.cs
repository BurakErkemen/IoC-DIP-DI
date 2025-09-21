// See https://aka.ms/new-console-template for more information
using IoC_console;

//BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer(new DataAccessLayer());
BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer(new OracleDAL());

businessLogicLayer.ProcessData().ForEach(p => Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.Stock}"));



Console.ReadLine();