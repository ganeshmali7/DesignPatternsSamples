using System;

namespace DesignPatternsSamples.SOLID
{
    /* SRP Followed - Task diveded in multiple classes so one class handle single responsibility
    (means there is no means that one class should has one method there is means that one class
    should have single task as name of the class)*/
    public static class SRP_Followed
    {
        public static void Run()
        {
            var r = new Report();
            r.Text = "Hi";
            var p = new ReportPrinter();
            p.Print(r);
            var s = new ReportSaver();
            s.Save(r);
        }
        class Report 
        { 
            public string Text; 
        }
        class ReportPrinter 
        {
            public void Print(Report r)
            {
                Console.WriteLine(r.Text);
            }
        }
        class ReportSaver
        {
            public void Save(Report r)
            {
                Console.WriteLine("Saved");
            }
        }
    }
}
