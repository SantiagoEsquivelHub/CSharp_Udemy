using TaskMaster;
namespace TaskMaster
{

    partial class Program
    {
        static FileActions<Task> fileActions = new("./06-TaskMaster/tasks.json");
        static List<Task> tasks = fileActions.ReadFile();
        static Queries queries = new(tasks);

        public static void TaskMaster()
        {
            bool exit = false;
            while (!exit)
            {
                ForegroundColor = ConsoleColor.White;
                WriteLine("------Task Menu------");
                WriteLine("\n1. List tasks");
                WriteLine("2. Add task");
                WriteLine("3. Mark task as completed");
                WriteLine("4. Edit task");
                WriteLine("5. Remove task");
                WriteLine("6. Query tasks by status");
                WriteLine("7. Query task by description");
                WriteLine("8. Exit");
                Write("\nSelect an option: ");

                switch (ReadLine())
                {
                    case "1":
                        queries.ListTasks();
                        break;
                    case "2":
                        AddTask();
                        break;
                    case "3":
                        MarkAsCompleted();
                        break;
                    case "4":
                        EditTask();
                        break;
                    case "5":
                        RemoveTask();
                        break;
                    case "6":
                        queries.TasksByState();
                        break;
                    case "7":
                        queries.TasksByDescription();
                        break;
                    case "8":
                        exit = true;
                        Clear();
                        break;
                    default:
                        Clear();
                        WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        public static void AddTask()
        {
            try
            {
                var tasks = queries.AddTask();
                fileActions.WriteFile(tasks);
            }
            catch (Exception ex)
            {
                WriteLine($"An error occurred while adding task: {ex}");
            }
        }

        public static void MarkAsCompleted()
        {
            try
            {
                var tasks = queries.MarkAsCompleted();
                fileActions.WriteFile(tasks);
            }
            catch (Exception ex)
            {
                WriteLine($"An error occurred while marking task as completed: {ex}");
            }
        }

        private static void EditTask()
        {
            try
            {
                var tasks = queries.EditTask();
                fileActions.WriteFile(tasks);
            }
            catch (Exception ex)
            {
                WriteLine($"An error occurred while editing task: {ex}");
            }
        }

        private static void RemoveTask()
        {
            try
            {
                var tasks = queries.RemoveTask();
                fileActions.WriteFile(tasks);
            }
            catch (Exception ex)
            {
                WriteLine($"An error occurred while removing task: {ex}");
            }
        }
    }
}
