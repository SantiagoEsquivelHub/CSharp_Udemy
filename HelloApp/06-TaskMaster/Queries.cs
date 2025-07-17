using System.ComponentModel.DataAnnotations.Schema;
using BetterConsoleTables;

namespace TaskMaster
{
    public class Queries(List<Task> _tasks)
    {
        private List<Task> Tasks = _tasks;

        public void ListTasks()
        {
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("-----Task list-----");

            if (_tasks.Count == 0)
            {
                WriteLine("No tasks found.");
                ResetColor();
                return;
            }

            Table table = new Table("Id", "Description", "Status");
            table.Config = TableConfiguration.Unicode();

            foreach (var task in _tasks)
            {
                table.AddRow(task.Id, task.Description, task.Completed ? "Completed" : "");
            }

            Write(table.ToString());
            ResetColor();
            ReadKey();
        }

        public List<Task> AddTask()
        {
            try
            {
                ResetColor();
                Clear();

                WriteLine("---Add task---");
                WriteLine("Enter task description to add: ");

                string? description = ReadLine()!;
                Task newTask = new(Utils.GenerateId(), description);
                Tasks.Add(newTask);

                ForegroundColor = ConsoleColor.Green;
                WriteLine("Task successfully added");
                ResetColor();
                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.Message);
                return Tasks;
            }
        }

        public List<Task> MarkAsCompleted()
        {
            try
            {
                ResetColor();
                Clear();

                WriteLine("---Mark task as completed---");
                WriteLine("Enter task ID to mark as completed: ");

                var id = ReadLine();

                Task task = Tasks.Find(task => task.Id == id)!;

                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Task not found with provided ID");
                    ResetColor();
                    return Tasks;
                }

                task.Completed = true;
                task.ModifiedAt = DateTime.Now;
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Task marked as completed successfully");
                ResetColor();

                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.Message);
                return Tasks;
            }
        }

        public List<Task> EditTask()
        {
            try
            {
                ResetColor();
                Clear();

                WriteLine("---Edit task---");
                WriteLine("Enter task ID to edit: ");

                var id = ReadLine();

                Task task = Tasks.Find(task => task.Id == id)!;

                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Task not found with provided ID");
                    ResetColor();
                    return Tasks;
                }

                WriteLine("Enter task description to edit: ");
                task.Description = ReadLine();
                task.ModifiedAt = DateTime.Now;
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Task successfully edited");
                ResetColor();
                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.Message);
                return Tasks;
            }
        }

        public List<Task> RemoveTask()
        {
            try
            {
                ResetColor();
                Clear();

                WriteLine("---Delete task---");
                WriteLine("Enter task ID to edit: ");

                var id = ReadLine();

                Task task = Tasks.Find(task => task.Id == id)!;

                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Task not found with provided ID");
                    ResetColor();
                    return Tasks;
                }

                Tasks.Remove(task);

                ForegroundColor = ConsoleColor.Green;
                WriteLine("Task successfully deleted");
                ResetColor();
                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.Message);
                return Tasks;
            }
        }
        public void TasksByState()
        {
            Clear();
            try
            {
                ResetColor();
                WriteLine("---Tasks by status ---");
                WriteLine("1. Completed");
                WriteLine("2. Pending");
                Write("Enter the task selection to display: ");

                var taskState = ReadLine();
                if (taskState != "1" && taskState != "2")
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Invalid option");
                    ResetColor();
                    return;
                }

                bool completed = taskState == "1";
                List<Task> filteredTasks = Tasks.Where(t => t.Completed == completed).ToList();

                if (filteredTasks.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No tasks were found with the requested status.");
                    ResetColor();
                    return;
                }

                ForegroundColor = completed ? ConsoleColor.Green : ConsoleColor.Red;
                Table table = new Table("Id", "Description", "State");

                foreach (var task in filteredTasks)
                {
                    table.AddRow(task.Id, task.Description, task.Completed ? "Completed" : "");
                }

                table.Config = TableConfiguration.Unicode();

                Write(table.ToString());
                ReadKey();
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.Message);
            }
        }

        public void TasksByDescription()
        {

            Clear();
            try
            {
                ResetColor();
                WriteLine("---Tasks by description---");
                Write("Enter the description of the tasks to search for: ");

                var description = ReadLine()!;
                List<Task> matchingTasks = Tasks.FindAll(t => t.Description?.Contains(description, StringComparison.OrdinalIgnoreCase) ?? false).ToList();

                if (matchingTasks.Count == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No tasks were found with the requested description.");
                    ResetColor();
                    return;
                }

                Table table = new Table("Id", "Description", "State");

                foreach (var task in matchingTasks)
                {
                    table.AddRow(task.Id, task.Description, task.Completed ? "Completed" : "");
                }

                table.Config = TableConfiguration.Unicode();

                Write(table.ToString());
                ReadKey();
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.Message);
            }

        }

    }
}