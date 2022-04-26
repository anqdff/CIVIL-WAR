using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CIVIL_WAR
{
    public class InscriptionModel
    {
        public int Id { get; set; }
        public string? Nom { get; set; }
       
        public string? Prenom { get; set; }
      
        public string? Mail { get; set; }
       
        public string? Password { get; set; }
        
    }
}
