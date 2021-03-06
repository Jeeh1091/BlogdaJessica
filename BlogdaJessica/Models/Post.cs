﻿using System;
using System.Collections.Generic;
//Limitar quantidade de carecteres
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogdaJessica.Models
{
    public class Post
    {
        public int Id { get; set; }
        //Limitar quantidade de carecteres
        [Required]
        [StringLength(500)]

        public string Title { get; set;}

        public DateTime DateAdded { get; set; }

        public DateTime? DateUpdated { get; set; }
        [Required]
        [StringLength(8000)]

        public string PostingBody { get; set; }


    }
}