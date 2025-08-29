namespace prjTravamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    internal class TrabalhoTravado()
    {
        Thread fluxo1, fluxo2;
        object RecursoA = new object();
        object RecursoB = new object();
        string saida;

        public void iniciaFluxos()
        {
            fluxo1 = new Thread(Procedimento1);
            fluxo2 = new Thread(Procedimento2);

            fluxo1.Start();
            fluxo2.Start();
        }

        public string retornaResultado()
        {
            fluxo1.Join();
            fluxo2.Join();
            return saida; 
        }

        public void Procedimento1()
        {
            Thread.Sleep(100);
            lock (RecursoA)
            {
                saida += "T1#";
            }
        }

        public void Procedimento2()
        {
            Thread.Sleep(100);
            lock (RecursoB)
            {
                saida += "T1#";
            }
        }
    }

}
