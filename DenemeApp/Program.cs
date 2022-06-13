using System.Collections.Generic;
using DenemeApp;

class Program
{
    static void Main(string[] args)
    {
        InMemoryUser _ınMemoryUser = new InMemoryUser();
        
        string choseProgram = "";
        while (choseProgram != "exit")
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)  \nProgramdan Çıkış için 'exit' giriniz");
            System.Console.WriteLine("*******************************************");
            System.Console.WriteLine("(1) Kayıt Ol");
            System.Console.WriteLine("(2) Giriş Yap");
            
            choseProgram = Console.ReadLine().ToLower();
            // System.Console.WriteLine("Seçilen Program: " + programDevam);


            switch (choseProgram)
            {
                case "1":
                    _ınMemoryUser.Program1();
                    break;
                case "2":
                    _ınMemoryUser.Program2();
                    break;
            }
        }    
    }
}       