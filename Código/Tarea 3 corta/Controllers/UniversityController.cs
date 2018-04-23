using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tarea_3_corta.Controllers
{
    public class UniversityController : Controller
    {


        /**
        * Method main window carrer
        * Author: Danny Xie Li
        * Description: Main window.
        * Created: 19/04/18
        * Last modification: 22/04/18
        */
        public ActionResult Create()
        {
            //ViewBag.collectionCarrer = 
            return View();
        }

        /**
        * Method save carrer
        * Author: Danny Xie Li
        * Description: Save carrer to the database.
        * Created: 19/04/18
        * Last modification: 22/04/18
        */
        [HttpPost]
        public void SaveCarrer()
        {
            string identificator = Request.Form["identificator"].ToString();
            string nombre = Request.Form["nombre"];
            string encargado = Request.Form["encargado"];
            string ubication = Request.Form["ubication"];
            try
            {
                int identificatorNumber = Int32.Parse(identificator);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            // Conexion


            Create();
        }

        /**
          * Method edit carrer
          * Author: Danny Xie Li
          * Description: Edit carrer in the database.
          * Created: 19/04/18
          * Last modification: 22/04/18
        */
        [HttpPost]
        public void EditCarrer()
        {
            string identificator = Request.Form["identificatorUpdate"].ToString();
            string nombre = Request.Form["nombreUpdate"];
            string encargado = Request.Form["encargadoUpdate"];
            string ubication = Request.Form["ubicationUpdate"];
            try
            {
                int identificatorNumber = Int32.Parse(identificator);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            // Conexion


            Create();
        }

        /**
        * Method delete carrer
        * Author: Danny Xie Li
        * Description: Delete carrer in the database.
        * Created: 19/04/18
        * Last modification: 22/04/18
        */
        [HttpPost]
        public void DeleteCarrer()
        {
            string identificator = Request.Form["identificatorDelete"].ToString();
            try
            {
                int identificatorNumber = Int32.Parse(identificator);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }


            // Conexion

            Create();
        }
    }
}
