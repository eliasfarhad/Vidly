using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    // this class is a plain old CLR object or POCO which represents the state and behavior of our application in terms of problem domain
    // In this case it doesn't have any brhavior or logic, it just have a couple of properties which we use for representing state.
    public class Movie
    {
        // we will give it a couple of properties
        public int ID { get; set; }                      // type prop + tab to create this code snippet
        public string Name { get; set; }
    }
    // Now lets say we want to create a page where we randomly pick a movie and render its details. Assuming that this page would be under
    // /mpvies/random, We need to create a controller called Movies controller with an action called random. So in Solution Explorer right
    // click on Controllers, add controller. Here we have some templates and most of them are used for auto generatinf some code called
    // scaffolding. But you are not going to use them, because I want you learn how to create a controller from scratch. So select the 
    // first one (MVC 5 Controller - Empty), we will name it MoviesController
    //     /movies/random



}
