using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica
{
    public class Authentication
    {
        
        public static Response Login(User user)
        {
            Response response = new Response();

            bool validarLogin = false;
            if (user.userName  == "Admin" && user.password == "password123*")
            {
                validarLogin = true;
            }

            if (validarLogin)
            {
                int num = int.Parse(user.text);
                if(num == null)
                {
                    for (int i = 0; i <= num; i++)
                    {
                        int numerico = user.text.PadRight(i, 0);
                    }
                }
                else
                {
                    for (int i = 0; i <= num; i++)
                    {
                        int letras = user.text.PadRight(i, " ");
                    }
                }

                
                
        }

    }
}
