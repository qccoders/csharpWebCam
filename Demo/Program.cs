using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Touchless.Vision.Camera;

namespace Demo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
            var camera = CameraService.GetActiveCamera();
                
            // shows in the output window
            if(camera != null)
                Console.WriteLine($"{camera.Name} is on.");
            else
                Console.WriteLine($"No cameras are on.");
        }
    }
}
