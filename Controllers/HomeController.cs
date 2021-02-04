using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using COPC_Wiki.Models;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using GraphQL;
using System.Text.Json;


namespace COPC_Wiki.Controllers
{
    public class HomeController : Controller
    {
        private string Baseurl = "http://localhost:7331/graphql";
        GraphQuery query = GraphQuery.Instance();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<ActionResult> Article(string SlugQuery)
        {
            using var graphQLClient = new GraphQLHttpClient(Baseurl, new NewtonsoftJsonSerializer());

            var graphQLResponse = await graphQLClient.SendQueryAsync<Models.Articles>(query.getArticleById(SlugQuery));

          
            //Console.WriteLine(SlugQuery);
            //Console.WriteLine("raw response:");
            //Console.WriteLine(JsonSerializer.Serialize(graphQLResponse, new JsonSerializerOptions { WriteIndented = true }));
            
            return View(graphQLResponse.Data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
