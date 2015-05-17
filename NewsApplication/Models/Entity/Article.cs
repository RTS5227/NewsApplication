using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsApplication.Models.Entity
{
    public class Article
    {
        [HiddenInput(DisplayValue = false)]
        public int ID { get; set; }

        [UIHint("Thumbnail")]
        public string Thumbnail { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        [AllowHtml]
        [UIHint("Content")]
        public string Content { get; set; }
        [HiddenInput(DisplayValue = false)]
        public int View { get; set; }
        [HiddenInput(DisplayValue = false)]
        public DateTime CreateAt { get; set; }
        [UIHint("DDState")]
        public int StateID { get; set; }
        public State State { get; set; }
        [UIHint("DDCategory")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }

    public enum CEnum
    {
        Category,
        State
    }

    public class State
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}