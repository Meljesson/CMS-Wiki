using System;
using GraphQL;


namespace COPC_Wiki.Models
{

    public class GraphQuery
    {
        
        private static  GraphQuery instance = null;
       
        private static readonly object padlock = new object();
        
        private GraphQuery()
        {

        }

        public static GraphQuery Instance()
        {
            lock (padlock)
            {
                if(instance == null)
                {
                    instance = new GraphQuery();
                }
                return instance;
            }
            
        }

        public GraphQLRequest getDepartments()
        {

            var departmentRequest = new GraphQLRequest
            {
                Query = @"
                    query{
                        departments
                        {
                            id
                            Name
                            subjects{
                                id
                                Title
                                articles
                                {
                                    id
                                    Title
                                }
                            }
                        }
                    }
                "
                
            };
            return departmentRequest;
        }


        public GraphQLRequest getDepartmentById(int _id)
        {

            string _query = @"query {department(id: ";
            string _querystring = _query + _id + @" ) 
            {
                id
                Name
                subjects
                {
                    id
                    Title
                    articles
                    {
                        id
                        Title
                        content
                    }
                }
             
              }
            }";
            var departmentRequest = new GraphQLRequest
            {
                Query = _querystring
                
            };
           

            return departmentRequest;
        }

         public GraphQLRequest getArticleById(string Slug)
         {
            
            var Request = new GraphQLRequest
            {
                Query = @"query getArticle($_Slug: String)
                {
                    wikiArticles(where: {Slug : $_Slug})
                    {
                        id
                        Title
                        Slug
                        Content
                    }
                }", 
                OperationName = "getArticle",
                Variables = new {
                    _Slug = Slug
                }
                
            };
            return Request;
            
         }

        public GraphQLRequest getWikiPages()
        {
            var wikiRequest = new GraphQLRequest
            {
                Query = @"
                    query{
                        wikiPages{
                            id
                            Topic
                            Slug
                            Subheading
                            {
                                 ... on ComponentWikiNavigation
                                {
                                    id
                                    Topic
                                    Articles
                                    {
                                        id
                                        Slug
                                        Title
                                        Content
                                    }
                                } 
                            }
                        }
                    }
                "
                

                
            };
            
            return wikiRequest;
        }

    }

    

}