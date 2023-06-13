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

           // Ranking_Controls.load_ranking();

            Application.Run(new menu());



        }
    }
}