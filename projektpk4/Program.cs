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

            // Czytnik.Czytaj();

            Quiz_Controls b = new Quiz_Controls();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());


        }
    }
}