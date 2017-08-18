using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LinqTutorial
{
    public static class PropertyList
    {
        /*
         * Typ Objekt wird übergeben zB. eine Klasse mit Properties.
         */ 
        public static List<String> PropertyCheck(Object obj)
        {
            List<string> results = new List<string>();
            results.Clear();

            // Alle Properties werden geholt und in einem Feld abgelegt
            PropertyInfo[] pInfos = obj.GetType().GetProperties();
            string strCheck;

            /*
             * In der Schleife werden die Property-Werte geholt und zu
             * einem String gecastet. Die Stringvariable sorgt dafür das
             * nur Properties mit Inhalt in die Namensliste aufgenommen werden.
             */
            foreach (PropertyInfo pInfo in pInfos)
            {
                    var propVal = pInfo.GetValue(obj, null);
                    strCheck = Convert.ToString(propVal);
   
                    if (strCheck!="")
                    {
                    results.Add(pInfo.Name);
                    }
            }
            // Rückgabe der Namensliste die Werte besitzen.
            return results;
        }

    }
}
