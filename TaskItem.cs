// 'internal' limits access to only this project.
// 'public' allows any other projecet to use it.
// 'private' only this file / class can use it.
internal class TaskItem
{
    //  This is the constructor. The constructor name is always the same name as the class.
    //
    //  When we create a new instance of this class anywhere else in our code we call the constructor. This looks like:
    //
    //      var newTaskItem = new TaskItem();
    //
    //  In the case of this TaskItem class, the above will not work. We require the name and description to be set at the time we create it.
    //
    //  We have done this by defining a constructore that requires parameters '(string name, string description)' and then using 
    //  those parameters to set the properties 'Name = name; Description = description;'
    //
    //  When we create an instance of this TaskItem class with parameters, it will look like this:
    //
    //      var newTaskItem = new TaskItem(someName, someDescription);
    internal TaskItem(string name, string description)
    {
        Name = name;
        Description = description;
    }

    // These are the properties of our TaskItem. These can be identified by having either { get; } { set; } or { get; set; }.
    internal string Name { get; set; }
    internal string Description { get; set; }
}