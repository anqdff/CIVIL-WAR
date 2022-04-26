using System.ComponentModel.DataAnnotations;

namespace CIVIL_WAR
{
    public class ConnexionModel
    {
        [Required(ErrorMessage = "Veuillez entrez votre nom pour vous connecter")]
        public string? Nom { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis")]
        public string? Password { get; set; }
    }
}
