using System;
using System.Windows.Forms;
using DotNetEnv;

/// <summary>
/// >Sophie Delahunt
/// December 6, 2025
/// Personal Project - Hymmnos Reader
/// </summary>

namespace HymmnosReader
{
    /// <summary>
    /// Provides functionality for the application.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Env.Load();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HymmnosReaderInterface());
        }
    }
}
