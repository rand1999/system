using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp2
{

    public enum city
    {
        riyadh, dammam//////////////////
    }

    class Company
    {

        public string name;
        public string year;/////////////////
        public city city;


        /*public void companylist()
        {

            
            var company = new List<Company>()

            {
              
            new Company() { name="elm",year="1986",city=city.riyadh},
            new Company() { name="aramco",year="1933",city=city.dammam}
    };
            foreach (var C in company)
            {
                C.name = Console.ReadLine();
                object i = "  elm compiny started on " + C.year + "\tin" + "\t" + city.riyadh;

                if (C.name == "elm")
                {
                    Console.WriteLine(i);
                }

                else 
                {
                    object i2 = "aramco compiny started on "+ C.year + "\tin" + "\t" + city.dammam;
                    Console.WriteLine(i2);

                }
            }
            }*/

        public void companyarray()
        {

            string[] array1=new string [2];

            int[] array2 = { 1933, 1986 }; // كيف ادخل الenim,[SIZE.bager]



            foreach (var a in array1)
            {
                array1[0] = Console.ReadLine();
                if (array1[0] == "elm")
                {
                    Console.WriteLine("elm compiny started on " + array2[1] + "\tin" + "\t"+ city.riyadh);
                }
                else if (array1[0] == "aramco")
                {

                    Console.WriteLine("aramco compiny started on " + array2[0] + "\tin" +"\t"+ city.dammam);

                }
            }


        }
    }
}




