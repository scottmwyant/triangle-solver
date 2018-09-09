﻿using System;
using System.Windows.Forms;

namespace TrigSolver.WinForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            View view = new View();
            Application.Run(view);



            //// The data has to be generated by the view and passed to the controller
            //Data data = new Data()
            //{
            //    AngA = Math.PI / 180 * 90,
            //    AngB = 0,
            //    AngC = 0,
            //    LenA = 12,
            //    LenB = 10,
            //    LenC = 0

            //};

            //// The controller will construct a DataSet and run validation
            //DataSet dataSet = new DataSet(data);

            //bool valid = Validation.Test(dataSet);

            //Console.WriteLine("Validation = " + valid.ToString());
            //if (valid)
            //{
            //    Data ans = dataSet.Solve();
            //    Console.WriteLine("AngA = " + ans.AngA);
            //    Console.WriteLine("AngB = " + ans.AngB);
            //    Console.WriteLine("AngC = " + ans.AngC);
            //    Console.WriteLine("LenA = " + ans.LenA);
            //    Console.WriteLine("LenB = " + ans.LenB);
            //    Console.WriteLine("LenC = " + ans.LenC);
            //}
            //else
            //{
            //    Console.WriteLine(Validation.ErrorMessage);
            //}

            //Console.WriteLine("Press any key to exit...");
            //Console.ReadLine();
        }
    }
}