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


           // idk po co to xD chyba coœ sprawdza³em Quiz_Controls b = new Quiz_Controls();



            ApplicationConfiguration.Initialize();
            
            Application.Run(new Form1());



        }
    }
}