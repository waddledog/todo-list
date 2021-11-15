
// Create a new empty list which we will use to store all of the tasks.
var tasklist = new List<TaskItem>();

// Since this is a 'long-running' program, we're going to put it in a 'while loop' that will always evaluate to true.
var running = true;
while (running)
{
    // Clearing the console at the start of each loop give a UI type feel to the console.
    Console.Clear();

    // Print out the header. Check out the new file 'UI.cs' to see how this works.
    UI.WriteHeader();

    // For every item in our task list, print out the item name.
    foreach (var item in tasklist)
    {
        Console.WriteLine(item.Name);
    }

    // TODO: Refactor this code in the UI class.
    Console.WriteLine();
    Console.WriteLine("what do you want to do?");
    Console.WriteLine("\t1 - create task"); // *\t* = tab/ 4 spaces 
    Console.WriteLine();

    // Read the options input from the user. Check out the new file 'UI.cs' to see how this works.
    var input = UI.ReadOptionInput();

    // Do different things depending on the option provided by the user.
    if (input == "1") // == is actually equals (an equality operator, result is always true or fasle)
    {
        // Ask the user for the name of the task.
        Console.Write("name: ");
        var name = Console.ReadLine();

        // Ask the user for a description of the task.
        Console.Write("description: ");
        var desrcription = Console.ReadLine();

        // Create the task using our custom defined TaskItem object. This object requires us provide it's name and description parameter.
        var task = new TaskItem(name, desrcription);

        // Add the newly created task to our task list.
        tasklist.Add(task);
    }
    // If the option that was input from the user was not valid, write an invalid input message.
    else
    {
        // TODO: Refactor this code in to the UI class.
        Console.WriteLine("invalid input. Press any key to continue");
        Console.ReadKey();
    }

    // We probably don't need this any more now we have user input pausing our loop.
    System.Threading.Thread.Sleep(500); // ToDo: Delete this line.
}