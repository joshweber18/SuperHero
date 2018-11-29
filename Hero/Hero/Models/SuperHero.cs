using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Hero.Models
{
    public class SuperHero
    {
        [Key]
        public int SuperHeroID { get; set; }
        public string SuperHeroName { get; set; }
        public string AlterEgo { get; set; }
        public string PrimarySuperHeroAbility { get; set; }
        public string SecondarySuperHeroAbility { get; set; }
        public string CatchPhrase { get; set; }
    }
}