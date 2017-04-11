using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
namespace Intranet.Models
{
    public class CrearPerfilesViewModel
    {
        [Required]
        [Display(Name = "Perfil")]
        public string Perfil { get; set; }

    }
}