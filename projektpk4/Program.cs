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

            ApplicationConfiguration.Initialize();



            Thread thread1 = new Thread(Ranking_Controls.load_ranking);
            thread1.Start();

            Thread thread2 = new Thread(() =>
            {
                Application.Run(new menu());
            });
            thread2.Start();

            thread1.Join();
            thread2.Join();

            // Ranking_Controls.load_ranking();
            //Application.Run(new menu());


        }
    }
}