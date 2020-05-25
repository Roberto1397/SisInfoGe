using System;
using Newtonsoft.Json;

namespace _38.FacebookApi
{
    //Ejemplo acceso API de Facebook

    class Program
    {
        static void Main(string[] args)
        {
            //token
            string fbtoken = "EAAD9arzXnwEBAKqZBOl1LZBTiawLGiAQtqYig6z6B0eBCjp9MuM5s6pm394afvZAKMu4k1OQ7Tucb53UNrQ1cd1ID1b0r0nIarftaxQTjfzF4Qr2I6xoyajEYh9baguI2aP0k94jQt9kMGLWzDH9LL4noCzk3JZANEH6RZBrOuvhyMLLkwZBJJ2e09aVkLRcwZD";
            string fbfields = "id,first_name,last_name,middle_name,name,name_format,picture,short_name,email";

            FacebookApi fb = new FacebookApi(fbtoken);
            
            string resultaddo = fb.ObtenerInfo(fbfields).Result;

            var res = JsonConvert.DeserializeObject(resultaddo);

            Console.WriteLine(res);
        }
    }
}
