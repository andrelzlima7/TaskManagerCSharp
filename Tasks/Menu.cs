using System;

class Menu
{
    Tasks tasks = new Tasks();
    public void ToExecute()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1 - Adicionar Tarefa");
            Console.WriteLine("2 - Mostrar Tarefas");
            Console.WriteLine("3 - Remover Tarefa");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");

            string? option = Console.ReadLine();
            Console.WriteLine();

            switch (option)
            {
                case "1":
                    Console.Clear();
                    tasks.AddTask();
                    break;
                case "2":
                    Console.Clear();
                    tasks.ShowTasks();
                    break;
                case "3":
                    Console.Clear();
                    tasks.RemoveTask();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("🚀 Saindo do programa...");
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("❌ Opção inválida. Tente novamente!\n");
                    break;
            }
        }
    }
}
