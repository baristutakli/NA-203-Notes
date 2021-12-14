using System;
using CustomProject.ORM;
using CustomProject.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomProject.View
{
    class Program
    {
        static void Main(string[] args)
        {
            // ESKİ KULLANIM

            //CategoriesORM orm = new CategoriesORM();
            //List<Categories> kategoriler = orm.Select();
            //foreach (var item in kategoriler)
            //{
            //    Console.WriteLine(item.CategoryID + "   " + item.CategoryName);
            //}

            // ESKİ KULLANIM
            //ShippersORM sorm = new ShippersORM();
            //List<Shippers> sihppersList = sorm.Select();
            //foreach (var item in sihppersList)
            //{
            //    Console.WriteLine($"ID: {item.ShipperID} Name: {item.CompanyName}   Phone: {item.Phone}");
            //}

            //YENİ KULLANIM

            //List<Shippers> sihppersList = ShippersORM.Current.Select();
            //foreach (var item in sihppersList)
            //{
            //    Console.WriteLine($"ID: {item.ShipperID} Name: {item.CompanyName}   Phone: {item.Phone}");
            //}

            //Categories ctg = new Categories();
            //ctg.CategoryName = "Foods";
            //ctg.Description = "Food Category Details";
            //ctg.Picture = null;
            //CategoriesORM.Current.Insert(ctg);

            //Shippers sh = new Shippers();
            //sh.CompanyName = "ASD";
            //sh.Phone = "123123";
            //ShippersORM.Current.Insert(sh);




            // UPDATE

            //List<Shippers> sihppersList = ShippersORM.Current.Select();
            //foreach (var item in sihppersList)
            //{
            //    Console.WriteLine($"ID: {item.ShipperID} Name: {item.CompanyName}   Phone: {item.Phone}");
            //}
            //Console.WriteLine("Düzenlemek istediğiniz ID yi yukarıdan seçip klavyeden giriniz.");
            //int upid = Convert.ToInt32(Console.ReadLine());


            //Shippers sh = ShippersORM.Current.Select(upid);
            //Console.WriteLine(sh.CompanyName);
            //Console.WriteLine(sh.Phone);

            //sh.CompanyName = "SİVAS TAŞIMACILIK NAKLİYAT";
            //ShippersORM.Current.Update(sh);

            //sihppersList = ShippersORM.Current.Select();
            //foreach (var item in sihppersList)
            //{
            //    Console.WriteLine($"ID: {item.ShipperID} Name: {item.CompanyName}   Phone: {item.Phone}");
            //}







            // DELETE

            List<Shippers> sihppersList = ShippersORM.Current.Select();
            foreach (var item in sihppersList)
            {
                Console.WriteLine($"ID: {item.ShipperID} Name: {item.CompanyName}   Phone: {item.Phone}");
            }
            Console.WriteLine("Silmek istediğiniz ID yi yukarıdan seçip klavyeden giriniz.");
            int delid = Convert.ToInt32(Console.ReadLine());

            Shippers shd = ShippersORM.Current.Select(delid);
            ShippersORM.Current.Delete(shd);

            sihppersList = ShippersORM.Current.Select();
            foreach (var item in sihppersList)
            {
                Console.WriteLine($"ID: {item.ShipperID} Name: {item.CompanyName}   Phone: {item.Phone}");
            }

















            //List<string> isimler = new List<string>() { "Nevruz", "Selin", "Barış", "Yusuf", "Buğra", "Sena", "Rumeysa", "İclal", "Oğuzhan", "Furkan", "Fatih", "Güven Barış", "Engin Can", "Mustafa", "Bilgihan" };

            //List<string> siralama = new List<string>();
            //Random rnd = new Random();
            //int elemanSayisi = isimler.Count();

            //for (int i = 0; i < elemanSayisi; i++)
            //{
            //    int s = rnd.Next(0, (elemanSayisi));

            //    if (!siralama.Contains(isimler[s]))
            //        siralama.Add(isimler[s]);
            //    else
            //        i = i - 1;
            //}


            //foreach (var talihsiz in siralama)
            //{
            //    Console.WriteLine(talihsiz);
            //}












        }
    }
}
