using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using GraphQL;
using System.Linq;
using System.Text.Json;

namespace COPC_Wiki.Controllers
{

 public class NavigationViewComponent : ViewComponent
    {
        //string Baseurl = "https://dev.manage.palmcoast.gov/graphql";
        string Baseurl = "http://localhost:7331/graphql";
        COPC_Wiki.Models.GraphQuery query = COPC_Wiki.Models.GraphQuery.Instance();

        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            using var graphQLClient = new GraphQLHttpClient(Baseurl, new NewtonsoftJsonSerializer());

            var graphQLResponse = await graphQLClient.SendQueryAsync<COPC_Wiki.Models.WikiPages>(query.getWikiPages());
           
            //Console.WriteLine("raw response:");
            //Console.WriteLine(JsonSerializer.Serialize(graphQLResponse, new JsonSerializerOptions { WriteIndented = true }));
            return View("Navigation" , graphQLResponse.Data);
        }
    }

}