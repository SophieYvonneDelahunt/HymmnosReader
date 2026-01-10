using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HymmnosReaderInterface());
        }
    }
}
