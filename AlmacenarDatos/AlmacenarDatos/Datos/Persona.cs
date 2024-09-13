using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlmacenarDatos.Datos
{
    internal class Persona
    {
        //Arreglos 
        private string[] names = new string[25];
        private string[] lastNames = new string[25];

        public void AddName(string name, int pos)
        { 
            names[pos] = name; 
        }
        public void AddlastName(string lastName, int pos)
        {
            lastNames[pos] = lastName;
        }
            public string[] GetNames()
        {
            return names;
        }
        public string[] GetlastNames()
        {
            return lastNames;
        }
    }
}
