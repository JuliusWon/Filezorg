using System;
using System.Diagnostics;
using System.IO;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
namespace FileOrgCrontab
{
    internal class Program
    {
        private string directoryName;
        //string platform =  "linux";
        private string username = Environment.UserName;
        private DateTime currentDate = DateTime.Now;
        private string path;
        private string firstDayOfWeek = "Monday";
        public static void Main(string[] args)
        {
            Program pg = new Program();
            //foreach (string curArg in args)
            //{
                //Console.WriteLine(curArg);   
            //}

            if (args.Length > 0)
            {
                if (args[0] == "-day-of-week")
                {
                    pg.firstDayOfWeek = args[1];
                }

                if (args[0] == "-help")
                {
                    Console.Title = "FileOrg Help";
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("FileOrg Help:");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(
                        "-day-of-week [day] will set the day of the week the folder will be created. Days must start with a capital letter");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(
                        "-path [path] will set the path for the folder to be created. EG: /home/nowsuiluj/Work/FileOrg/");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("--help will display this text, but you probably figured that out.");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("For any issues put them on the github");
                }

                if (args[0] == "-path")
                {
                    pg.path = args[1];
                }
            }

            if (args.Length > 2)
            {
                if (args[2] == "-path")
                {
                    pg.path = args[3];
                }
                if (args[2] == "-day-of-week")
                {
                    pg.firstDayOfWeek = args[3];
                }
            }

            pg.TriggerOnCrontab();
        }

        void TriggerOnCrontab()
        {
            //path = "/home/" + username + "/FileOrg/";
            directoryName = currentDate.Date.ToShortDateString().Replace("/","-");
            if (currentDate.Date.DayOfWeek.ToString() == firstDayOfWeek && !Directory.Exists(path+directoryName+"/"))
            {
                MKDir();   
            }
        }
        void MKDir()
        {
            if(Directory.Exists(path)) 
            { 
                Directory.CreateDirectory(path+directoryName+"/");
            }
            else { 
                Directory.CreateDirectory(path+"/FileOrg/");
                MKDir();
            }
        }
    }
}
