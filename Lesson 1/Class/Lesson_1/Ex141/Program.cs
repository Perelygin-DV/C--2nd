using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex141
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = ApiGetAddress.Get();

            //Получение номера дома
            //int n = address.city.street.house.N;

            //int n = address?.city?.street?.house?.N ?? -2;



            //Nullable<int> n = address?.city?.street?.house?.N;
            //int? n = address?.city?.street?.house?.N;
            int n = address?.city?.street?.house?.N ?? -2;

           

            Console.WriteLine(n);


            #region Пример 1

            //if (address != null)
            //{
            //    if (address.city != null)
            //    {
            //        if (address.city.street != null)
            //        {
            //            if (address.city.street.house != null)
            //            {
            //                n = address.city.street.house.N;
            //            }
            //            else { n = -2; }
            //        }
            //        else { n = -2; }
            //    }
            //    else { n = -2; }
            //}
            //else { n = -2; }

            //Console.WriteLine(n == -2 ? "Адреса нет" : n.ToString());
            #endregion

        }
    }
}
