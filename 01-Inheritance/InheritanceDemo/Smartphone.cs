using System.Collections.Generic;

namespace InheritanceDemo
{
    //Class Smartphone is child from Class Phone, or Class Phone is parent of Class Smartphone
    public class Smartphone : Cellphone
    {
        public List<string> Apps { get; set; }
        
        public void ConnectToInternet()
        {

        }
    }
}
