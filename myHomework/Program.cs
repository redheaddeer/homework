﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myHomework
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Homework());
            Task12.Task();
            Task132.Task();
            Task141.Task();
            Task142.Task();
            Task143.Task();
            Task251.Task();
            Task252.Task();
            Task253.Task();
            Task433.Task();
            Task521.Task();
            Task522.Task();
        }
    }
}
