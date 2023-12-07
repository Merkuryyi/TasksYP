using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Task
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Deadline { get; set; }
}

public class TaskManager
{
    private List<Task> tasks;

    public TaskManager()
    {
        tasks = new List<Task>();
        LoadTasks("tasks.json");
    }

    public void LoadTasks(string filePath)
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            tasks = JsonSerializer.Deserialize<List<Task>>(json);
        }
    }

    public void SaveTasks(string filePath)
    {
        string json = JsonSerializer.Serialize(tasks, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }

    public void AddTask(string title, string description, DateTime deadline)
    {
        Task newTask = new Task {Title = title, Description = description, Deadline = deadline};
        tasks.Add(newTask);
        SaveTasks("tasks.json");
    }

    public void RemoveTask(int index)
    {
        if (index >= 0 && index < tasks.Count)
        {
            tasks.RemoveAt(index);
            SaveTasks("tasks.json");
        }
        else
        {
            Console.WriteLine("Некорректный номер задачи.");
        }
    }

    public void EditTask(int index, string newTitle, string newDescription, DateTime newDeadline)
    {
        if (index >= 0 && index < tasks.Count)
        {
            tasks[index].Title = newTitle;
            tasks[index].Description = newDescription;
            tasks[index].Deadline = newDeadline;
            SaveTasks("tasks.json");
        }
        else
        {
            Console.WriteLine("Некорректный номер задачи.");
        }
    }

    public void ShowToday()
    {
        DateTime today = DateTime.Today;
        Console.WriteLine("Задачи на сегодня:");
        foreach (var task in tasks)
        {
            if (task.Deadline.Date == today)
            {
                Console.WriteLine($"- {task.Title}");
            }
        }
    }

    public void ShowAllTasks()
    {
        Console.WriteLine("Список всех задач:");
        foreach (var task in tasks)
        {
            Console.WriteLine($"- {task.Title}");
        }
    }

    public void ShowUpcomingTasks()
    {
        DateTime today = DateTime.Today;
        Console.WriteLine("Предстоящие задачи:");
        foreach (var task in tasks)
        {
            if (task.Deadline.Date > today)
            {
                Console.WriteLine($"- {task.Title}");
            }
        }
    }

    public void ShowPastTasks()
    {
        DateTime today = DateTime.Today;
        Console.WriteLine("Прошедшие задачи:");
        foreach (var task in tasks)
        {
            if (task.Deadline.Date < today)
            {
                Console.WriteLine($"- {task.Title}");
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        TaskManager taskManager = new TaskManager();

        while (true)
        {
            Console.WriteLine("Введите команду (добавить, удалить, редактировать, задачи на сегодня, все задачи, предстоящие, прошедшие, выход):");
            string input = Console.ReadLine();

            switch (input)
            {
                case "добавить":
                    Console.Write("Введите название задачи: ");
                    string title = Console.ReadLine();
                    Console.Write("Введите описание задачи: ");
                    string description = Console.ReadLine();
                    Console.Write("Введите дату дедлайна (гггг-мм-дд): ");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime deadline))
                    {
                        taskManager.AddTask(title, description, deadline);
                    }
                    else
                    {
                        Console.WriteLine("Некорректный формат даты.");
                    }
                    break;
                case "удалить":
                    Console.Write("Введите номер задачи для удаления: ");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        taskManager.RemoveTask(index);
                    }
                    else
                    {
                        Console.WriteLine("Некорректный номер.");
                    }
                    break;
                case "редактировать":
                    Console.Write("Введите номер задачи для редактирования: ");
                    if (int.TryParse(Console.ReadLine(), out int editIndex))
                    {
                        Console.Write("Введите новое название задачи: ");
                        string newTitle = Console.ReadLine();
                        Console.Write("Введите новое описание задачи: ");
                        string newDescription = Console.ReadLine();
                        Console.Write("Введите новую дату дедлайна (гггг-мм-дд): ");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime newDeadline))
                        {
                            taskManager.EditTask(editIndex, newTitle, newDescription, newDeadline);
                        }
                        else
                        {
                            Console.WriteLine("Некорректный формат даты.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректный номер.");
                    }
                    break;
                case "задачи на сегодня":
                    taskManager.ShowToday();
                    break;
                case "все задачи":
                    taskManager.ShowAllTasks();
                    break;
                case "предстоящие":
                    taskManager.ShowUpcomingTasks();
                    break;
                case "прошедшие":
                    taskManager.ShowPastTasks();
                    break;
                case "выход":
                    return;
                default:
                    Console.WriteLine("Неправильная команда. Попробуйте еще раз.");
                    break;
            }
        }
    }
}
