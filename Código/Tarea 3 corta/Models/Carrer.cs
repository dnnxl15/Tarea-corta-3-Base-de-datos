using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea_3_corta.Models
{
    public class Carrer
    {
        private String name;
        private String ubication;
        private String asistant;
        private int identificator;

        public Carrer(String name, String ubication, String asistant, int identificator)
        {
            setName(name);
            setUbication(ubication);
            setAsistant(asistant);
            setIdentificator(identificator);
        }

        public String getName()
        {
            return name;
        }

        public void setName(String pName)
        {
            name = pName;
        }

        public String getUbication()
        {
            return ubication;
        }

        public void setUbication(String pUbication)
        {
            ubication = pUbication;
        }

        public String getAsistant()
        {
            return asistant;
        }

        public void setAsistant(String pAsistant)
        {
            asistant = pAsistant;
        }

        public int getIdentificator()
        {
            return identificator;
        }

        public void setIdentificator(int pIdentificator)
        {
            identificator = pIdentificator;
        }
        
    }
}