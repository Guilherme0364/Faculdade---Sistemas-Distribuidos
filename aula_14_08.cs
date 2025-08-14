namespace prjPrioridade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Thread t1 = new Thread(Processo);
            Thread t2 = new Thread(Processo);
            Thread t3 = new Thread(Processo);

            t1.Name = "T1 Alto";
            t2.Name = "T2 Normal";
            t3.Name = "T3 Baixo";

            t1.Priority = ThreadPriority.Highest;
            t3.Priority = ThreadPriority.Lowest;

            t1.Start();
            t2.Start();
            t3.Start();

            Console.WriteLine($"\n Prioridade de T1: {t1.Priority}");
            Console.WriteLine($"\n Prioridade de T2: {t2.Priority}");
            Console.WriteLine($"\n Prioridade de T3: {t3.Priority}");
        }
            private static void Processo()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i} [{Thread.CurrentThread.Name}]\t");
            }
        }
    }
}
