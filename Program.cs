
var tasklist= new List<TaskItem>();
var running = true;

while (running) 
{
    Console.Clear();
    Console.WriteLine("--------");
    Console.WriteLine("To do");
    Console.WriteLine("--------");
    Console.WriteLine();

    foreach(var item in tasklist)
    {
        Console.WriteLine(item.Name);
    }

    Console.WriteLine();
    Console.WriteLine("what do you want to do?");
    Console.WriteLine("\t1 - create task"); // *\t* = tab/ 4 spaces 
    Console.WriteLine();
    Console.Write("option: ");

    var input = Console.ReadLine();

    if (input == "1") //== is actually equals  (an equality operator, result is always true or fasle)
    {
        Console.Write("name: ");
        var name = Console.ReadLine();
        Console.Write("description: ");
        var desrcription = Console.ReadLine();
        var task = new TaskItem(name, desrcription);

        tasklist.Add(task);

    
    }
    else
     {
         Console.WriteLine("invalid input. Press any key to continue");
         Console.ReadKey();
    }


    System.Threading.Thread.Sleep(500);
}