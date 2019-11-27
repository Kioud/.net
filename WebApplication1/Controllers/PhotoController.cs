using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace WebApplication1.Controllers
{
    public class PhotoController : Controller
    {
        public IActionResult Index()
        {
            List<Photo> galerie = new List<Photo>();
            try
            {
                using (var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\coir3\source\repos\WebApplication1\WebApplication1\Data.mdf;Integrated Security=True;Connect Timeout=30"))
                //connection.Dispose(); // j'ai fini libère tes ressources surtout les ressources mémoire
                {
                    connection.Open();

                    using (var requete = connection.CreateCommand())
                    {
                        requete.CommandText = "SELECT id, Titre, Url FROM photo";

                        using (var lecteur = requete.ExecuteReader())
                        {
                            while (lecteur.Read())
                            {
                                galerie.Add(new Photo(
                                    cle: lecteur.GetInt32(0),
                                    titre: lecteur.GetString(1),
                                    url: lecteur.GetString(2)
                                ));
                            }
                        }
                    }
                    //        {
                    //            new Photo(1, "PS4 Pro", "cdn.pocket-lint.com/r/s/970x/assets/images/138763-games-review-sony-ps4-pro-review-image1-gcolf3ytme.jpg"),
                    //            new Photo(2, "Xbox One", "pisces.bbystatic.com/image2/BestBuy_US/images/products/6344/6344118_sd.jpg"),
                    //            new Photo(3, "Xbox One S", "static.bhphoto.com/images/images2000x2000/1544031342_1430955.jpg")
                    //        };
                    //    public IActionResult Index()
                    //    {
                    //        
                    //        for (var i = 0; i < galerie.Count; i++)
                    //        {
                    //            galerie[i].AugmenterLesVues();
                    //        }
                    //        foreach (var photo in galerie)
                    //        {
                    //            photo.AugmenterLesVues();
                    //       }
                    return View(galerie);
                }
            }// appel du Dispose de connection
            catch (SqlException e)
            {
                return RedirectToAction("error", "Home");
            }
        }

       // public IActionResult Details(int id)
        //{
         //   var item = galerie.FirstOrDefault(x => x.Cle == id);


         //   return View(item);
        //}
    }
}
