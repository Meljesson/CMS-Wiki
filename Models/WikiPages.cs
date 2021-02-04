using System;
using System.Collections.Generic;

namespace COPC_Wiki.Models{

    public class WikiPages 
    {
        public wikiPages[] wikiPages {get; set;}
    }
    public class wikiPages
    {
        public int Id {get; set;}
            
        public string Topic {get; set;}

        public string Slug {get; set;}

        public DateTime published_at {get; set;}

        public DateTime created_at {get; set;}

        public DateTime updated_at {get; set;}

        public Subsection[] Subheading{get; set;}
    }
    public class Subsection
    {
        public int Id {get; set;}
        public string Topic {get; set;}
        public Article[] Articles {get; set;}

    }
    public class Articles
    {
        public Article wikiArticle {get;set;}
        public Article[] wikiArticles {get;set;}       
    }
    public class Article
    {
        public int Id {get; set;}
        public string Slug {get; set;}
        public string Title {get; set;}
        public string content {get; set;}
    }
}