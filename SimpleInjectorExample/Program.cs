using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleInjector;

namespace SimpleInjectorExample
{
    static class Program
    {

        private static Container container;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BootStrap();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.GetInstance<Form1>());
        }

        private static void BootStrap()
        { 
            //Create a Container
            container = new Container();

            //Register Types
            container.Register<IDisplay, DisplayText>();

            //Verify container
            container.Verify();

            //Register the container class
            Program.container = container;

        }
    }
}
