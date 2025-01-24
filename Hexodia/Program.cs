namespace Hexodia
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /// <summary>
            /// Ensures that only a single instance of the application is running by using a named mutex.
            /// If the application is already running, displays a warning message and prevents the application from starting.
            /// </summary>
            bool isMutexCreated;
            using (Mutex mutex = new Mutex(true, "HexodiaMutex", out isMutexCreated))
            {
                // Check if the mutex was successfully created, indicating that the application is not already running.
                if (isMutexCreated)
                {
                    // The application is not already running, so proceed to start the application.
                    Application.EnableVisualStyles(); // Enables visual styles for the application.
                    Application.SetCompatibleTextRenderingDefault(false); // Sets the default rendering for text in controls.
                    Application.Run(new Hexodia());  // Start the application with the main form 'Hexodia'.
                }
                else
                {
                    // The application is already running, so show a message box to inform the user.
                    MessageBox.Show("The application is already running.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
    }
}