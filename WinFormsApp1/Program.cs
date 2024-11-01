namespace WinFormsApp1
{

    internal static class Program
    {
        /// <summary>
        
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            OgrenciSistem obs = new OgrenciSistem();
            //Application.Run(new OgrenciSistem());
            Application.Run(new MainMenu());


            

        }
    }
}