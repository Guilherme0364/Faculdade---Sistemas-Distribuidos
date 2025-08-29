namespace _prjNumCores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCores = Environment.ProcessorCount;
            Console.WriteLine($"A maquina atual possui {numCores} núcleos lógicos");

            for ( int i = 0; i < numCores; i++)
            {
                var fluxo = new Thread(Processo);
                fluxo.Start();
            }
        }
        private static void Processo(object ordem)
        {
            Console.WriteLine($"Executado pela Thread {ordem} [{Thread.CurrentThread.ManagedThreadId}]");
        }
    }
}
