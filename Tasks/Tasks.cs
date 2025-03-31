using System;
class Tasks
{
    private List<string> listTasks = new List<string>();

    public void AddTask()
    {
        Console.WriteLine();
        Console.WriteLine("Escreva sua tarefa: ");
        string? task = Console.ReadLine()?.Trim();

        if (string.IsNullOrEmpty(task))
        {
            Console.WriteLine("A tarefa não pode estar vazia!");
            return;
        }

        listTasks.Add(task);
        Console.WriteLine("✅ Tarefa adicionada com sucesso!\n");
        Console.WriteLine();

        ShowTasks();
    }

    public void ShowTasks()
    {
        Console.WriteLine();

        if (listTasks.Count == 0)
        {
            Console.WriteLine("A lista ainda está vazia. \n");
            return;
        }

        Console.WriteLine("📋 Lista de Tarefas:");
        for (int i = 0; i < listTasks.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {listTasks[i]}");
        }

        Console.WriteLine();
    }

    public void RemoveTask()
    {
        if (listTasks.Count == 0)
        {
            Console.WriteLine("Não há tarefas na lista");
            return;
        }

        ShowTasks();

        Console.Write("Digite o índice do item que deseja excluir: ");
        string? input = Console.ReadLine()?.Trim();

        if (int.TryParse(input, out int indexDelete))
        {
            if (indexDelete < 1 || indexDelete > listTasks.Count)
            {
                Console.WriteLine("❌ Índice inválido! Escolha um número válido.\n");
                return;
            }

            Console.WriteLine($"Tarefa removida com sucesso: {listTasks[indexDelete - 1]}");
            listTasks.RemoveAt(indexDelete - 1);
        }
        else
        {
            Console.WriteLine("❌ Entrada inválida! Digite um número válido.");
        }

    }

}