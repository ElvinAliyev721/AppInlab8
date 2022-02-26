using System;
using System.Linq;

namespace Lab8
{
    
    //Enum 
    //parameters op named
    //params

    //try parse try catch 
    internal class Program
    {
        public enum UserRole:int
        {
            Admin=1,
            SuperAdmin=2,
            Member,
            Operator=100
        }
        static void Main(string[] args)
        {
            #region
            //foreach (WeekDays days in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine((int)days);
            //}
            //string[] dayss=Enum.GetNames(typeof(WeekDays));
            //foreach (var item in dayss)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine(Enum.GetName(typeof(WeekDays), 1));


            //string name = "Elvin";
            //string role;
            //if (name=="Elvin")
            //{
            //    role = Enum.GetName(typeof(WeekDays), 1);
            //}
            //else
            //{
            //    role = Enum.GetName(typeof(WeekDays), 2);
            //}
            //Console.WriteLine(role);
            #endregion



            #region App
            //string Role = "";
            //foreach (var item in Enum.GetValues(typeof(UserRole)))
            //{
            //    Console.WriteLine((int)item + " " + item);
            //}
            //Console.WriteLine("role daxil edin: ");
            //int userreqem = int.Parse(Console.ReadLine());
            //bool success = Enum.IsDefined(typeof(UserRole), userreqem);
            //if (success)
            //{
            //    switch (userreqem)
            //    {
            //        case (int)UserRole.Admin:
            //            Role = "Admin";
            //            break;
            //        case (int)UserRole.SuperAdmin:
            //            Role = "SuperAdmin";
            //            break;
            //        case (int)UserRole.Member:
            //            Role = "Member";
            //            break;
            //        case ((int)UserRole.Operator):
            //            Role = Enum.GetName(typeof(UserRole), (int)UserRole.Operator);
            //            break;
            //        default:
            //            Console.WriteLine("Error");
            //            break;
            //    }
            //    Console.WriteLine(Role);
            //}
            #endregion

            //int deyishen = 20;
            //string name = "Ali";
            //name.GetValue("Aliyev");


            //Console.WriteLine("mail daxil et : ");
            //string usermail=Console.ReadLine();
            //bool success=Extension.MailSucces(usermail);
            //Console.WriteLine(success);
             
            int[] vs = {12321,412214,11244 };
            int newitem=vs.FirstOrDefault();
            Console.WriteLine(newitem);

        }
        static public string Ert(string ad )
        {
            switch (ad)
            {
                case "Elvin":
                    return "Elvin";
                default:
                    return "Error";
            }
        }
        //say type name
        public static string Para(int a,int b=13,int c=0)
        {
            return "Al";
        }
    }
}
