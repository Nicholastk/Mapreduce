using MapReduceFilterExample;
using System.Reflection;


List<Employee> lista = new List<Employee>();
var lines = File.ReadAllLines(@"Employees.txt"); 


foreach (var line in lines)
{
    if (!string.IsNullOrEmpty(line))
    {
        var x = line.Split(";");

        lista.Add(new Employee((x[0]), (x[1]), decimal.Parse(x[2])));
    }
    
}


foreach (var item in lista)
{
    Console.WriteLine(item);
}



Console.Write("MapReduce");

var mapreduce = lista.OrderBy(x => x.Estado).GroupBy(x => x.Estado).Select(x => // mapreduce 
 new
 {
     x.Key,
     Total = x.Sum(x => x.Salario)
 });



foreach (var item in mapreduce)
{
    Console.WriteLine(item);
}



