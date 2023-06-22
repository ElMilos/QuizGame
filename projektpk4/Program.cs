namespace projektpk4
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {




            Thread thread1 = new Thread(() => ApplicationConfiguration.Initialize());
            thread1.Start();

            Thread thread2 = new Thread(Ranking_Controls.load_ranking);
            thread2.Start();

            Thread thread3 = new Thread(() =>
            {
                Application.Run(new menu());
            });
            thread3.Start();



            thread1.Join();
            thread2.Join();
            thread3.Join();



        }
    }
}