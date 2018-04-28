using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Tarea_3_corta.Models;

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
            Connection objectConnection = new Connection("tareacorta3.database.windows.net", "Danny", "TareaCorta3");
            ViewBag.collectionCarrer = objectConnection.getCarrer(""); 
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
            string password = Request.Form["password"];
            int identificatorNumber = 0;
            try
            {
                identificatorNumber = Int32.Parse(identificator);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            // Conexion
            try
            {
                Connection objectConnection = new Connection("tareacorta3.database.windows.net", "Danny", "TareaCorta3");
                objectConnection.registerCarrer(nombre, ubication, encargado, identificatorNumber, password);
            }
            catch(SqlException e)
            {

            }
            
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
            string password = Request.Form["passwordUpdate"];
            int identificatorNumber = 0;
            try
            {
                identificatorNumber = Int32.Parse(identificator);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            Connection objectConnection = new Connection("tareacorta3.database.windows.net", "Danny", "TareaCorta3");
            objectConnection.updateCarrer(nombre, ubication, encargado, identificatorNumber, password);


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
            int identificatorNumber = 0;
            string password = Request.Form["passwordDelete"].ToString();


            try
            {
                identificatorNumber = Int32.Parse(identificator);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            Connection objectConnection = new Connection("tareacorta3.database.windows.net", "Danny", "TareaCorta3");
            objectConnection.deleteCarrer(identificatorNumber, password);


            // Conexion

            Create();
        }
    }
}
