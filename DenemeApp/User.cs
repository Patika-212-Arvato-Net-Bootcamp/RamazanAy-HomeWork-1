using DenemeApp;

namespace DenemeApp;

   public class User
    {
        public  string Identity { get; set; }
        public  string Name { get; set; }
        public  string Soyad { get; set; }

        public User(string name, string soyad,string identity)
        {
            Name = name;
            Soyad = soyad;
            Identity = identity;
        }

        public User()
        {
            
        }

        
    }
    