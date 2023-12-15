using System;

class Program
{
    static void Main(string[] args)
    {
        ToDoList toDoList = new ToDoList();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("John Paul's To-Do List Application");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Display Tasks");
            Console.WriteLine("3. Complete Task");
            Console.WriteLine("4. Remove Task");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice:");

            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int menuChoice))
            {
                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("Enter task name:");
                        string taskName = Console.ReadLine();
                        toDoList.AddTask(taskName);
                        break;
                    case 2:
                        toDoList.DisplayTasks();
                        break;
                    case 3:
                        Console.WriteLine("Enter task number to mark as complete:");
                        if (int.TryParse(Console.ReadLine(), out int completeIndex))
                        {
                            toDoList.CompleteTask(completeIndex);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter task number to remove:");
                        if (int.TryParse(Console.ReadLine(), out int removeIndex))
                        {
                            toDoList.RemoveTask(removeIndex);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                        }
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}

class ToDoList
{
    private string[] tasks = new string[10];
    private int taskCount = 0;

    public void AddTask(string task)
    {
        if (taskCount < tasks.Length)
        {
            tasks[taskCount] = task;
            taskCount++;
            Console.WriteLine("Task added successfully.");
        }
        else
        {
            Console.WriteLine("Task list is full. Cannot add more tasks.");
        }
    }

    public void DisplayTasks()
    {
        if (taskCount == 0)
        {
            Console.WriteLine("No tasks added yet.");
        }
        else
        {
            Console.WriteLine("Tasks:");
            for (int i = 0; i < taskCount; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }

    public void CompleteTask(int index)
    {
        if (index >= 1 && index <= taskCount)
        {
            Console.WriteLine($"Task '{tasks[index - 1]}' marked as complete.");
           
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }

    public void RemoveTask(int index)
    {
        if (index >= 1 && index <= taskCount)
        {
            Console.WriteLine($"Task '{tasks[index - 1]}' removed successfully.");
            for (int i = index - 1; i < taskCount - 1; i++)
            {
                tasks[i] = tasks[i + 1];
            }
            taskCount--;
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
}