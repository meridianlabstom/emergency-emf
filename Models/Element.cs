using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace edxl_cap_v1_2.Models
{
    public class Element
    {
        [Key]
        public int ElementIndex { get; set; }
        public string ElementName { get; set; }
        public static Boolean Required { get; set; }
        public static Boolean Conditional { get; set; }
        public static Boolean Repeatable { get; set; }
        public static int DataCategory_Id { get; set; }
        public static string Datatype { get; set; }
        public static int DatatypeSize { get; set; }

        public DataCategory DataCategory { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
