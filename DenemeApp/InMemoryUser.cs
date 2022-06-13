using System.Net.Mime;

namespace DenemeApp;

public class InMemoryUser
{
    List<User> _users = new List<User>();
    InMemoryProduct _ınMemoryProduct = new InMemoryProduct();
    
    public InMemoryUser()
    { 
        _users.Add(new User("Ramazan","Ay","1"));
        _users.Add(new User("Ali","Ay","3"));
        _users.Add(new User("Emirhan","Ay","2"));
    }

    private string choseProduct;
    public void Program1()
    {
        User user = new();
        Console.WriteLine("(1) Kayıt Ol" );
        Console.WriteLine("Lütfen İsminiz giriniz : ");
        user.Name = Console.ReadLine();
        Console.WriteLine("Lütfen Soyadınızı giriniz : ");
        user.Soyad = Console.ReadLine();
        Console.WriteLine("Lütfen Tcnizi giriniz : ");
        user.Identity = Console.ReadLine();
        for (int i = 0; i < _users.Count ; i++)
        {
            User tempUser = _users[i]; //TC BURADA KONTROL EDİLİYOR
            if (tempUser.Identity == user.Identity)
            {
                Console.WriteLine("Bu tc kimlik numarası ile zaten kullanıcı var \n uygulamadan çıkışınız yapılıyor.");
                Environment.Exit(0);
            }
        }
        Console.WriteLine("Başarıyla Kayıt oldun  " +   user.Name);
        Console.WriteLine("Bir ürün seçin =>");
        for (int i = 0; i <_ınMemoryProduct._products.Count ; i++)
        {
            Product tempProduct = _ınMemoryProduct._products[i];
            Console.WriteLine(i+"- "+tempProduct.ProductName);
        }
        choseProduct = Console.ReadLine();
        switch (choseProduct)
        {
            case "0":
                Console.WriteLine("Iphone 12 Siparişin başarıyla oluşturuldu"+" " + user.Name);
                break;
            case "1":
                Console.WriteLine("Ipad Siparişin başarıyla oluşturuldu"+" " + user.Name);
                break;
            case "2":
                Console.WriteLine("MacBook Siparişin başarıyla oluşturuldu"+" " + user.Name);
                break;
            case "3":
                Console.WriteLine("AirPods Siparişin başarıyla oluşturuldu"+" " + user.Name);
                break;
            default:
                Console.WriteLine("Hata ! Çıkış Yapılıyor ");
                Environment.Exit(0);
                break;
                    
        }
        
        
        
        
        
        //lİSTEYE BURADA EKLENİYOR
        _users.Add(user);
        
    }

    public void Program2()
    {
        User user = new User();
        Console.WriteLine("Tc numaranızı giriniz : ");
        user.Identity = Console.ReadLine();
        for (int i = 0; i < _users.Count; i++)
        {
            User tempUser2 = _users[i];
            if (tempUser2.Identity == user.Identity)
            {
                Console.WriteLine("Başarıyla giriş yaptınız ");
            }
            else
            {
                Console.WriteLine("Başarısız Giriş Kayıt Olabilirsiniz \n uygulamadan çıkışınız yapılıyor.");
                Environment.Exit(1);
            }
            Console.WriteLine("Bir ürün seçin =>");
            for (int ı = 0; ı <_ınMemoryProduct._products.Count ; ı++)
            {
                Product tempProduct = _ınMemoryProduct._products[ı];
                Console.WriteLine(ı+"- "+tempProduct.ProductName);
            }
            choseProduct = Console.ReadLine();
            switch (choseProduct)
            {
                case "0":
                    Console.WriteLine("Iphone 12 Siparişin başarıyla oluşturuldu"+" " + user.Name);
                    break;
                case "1":
                    Console.WriteLine("Ipad Siparişin başarıyla oluşturuldu"+" " + user.Name);
                    break;
                case "2":
                    Console.WriteLine("MacBook Siparişin başarıyla oluşturuldu"+" " + user.Name);
                    break;
                case "3":
                    Console.WriteLine("AirPods Siparişin başarıyla oluşturuldu"+" " + user.Name);
                    break;
                default:
                    Console.WriteLine("Hata ! Çıkış Yapılıyor ");
                    Environment.Exit(0);
                    break;
                    
            }
        }
        
    }
}