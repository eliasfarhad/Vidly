using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    // this controller is a very simple class that explains from the Controller class. And here we have an action called Index which returns
    // ActionResult. I am going to change the name of the action from Index() to Random().
    //
    public class MoviesController : Controller
    {
        // Get: Movies/Random                           // previously: GET: Movies
        public ActionResult Random()                    // previously: public ActionResult Index()
        {
            var movie = new Movie() {Name = "Shrek!"};   // see (1) and (2)
            return View(movie);                               // see (3)
        }
    }
}


/*
  (1) Now with this method I'm going to create an instance of our movie model. Now because I'm using Resharper, Resharper automatically resolves the namespace
      for this class. If you are nt using Resarper, you need to manually type 'using Vidly.Models'

  (2) In real world application we often get a model from a database but for now to keep things simple lets just focus on the core building blocks of MVC apps.

  (3) Now here you can see that we are returning a 'View()' and the reason this is red is because Resharper is telling me this that this View file does not exist
      in the application. So in the Solution Explorer under Views, look inside Movies folder, we don't have a View called Random. So right click on Movies, add
      Views, name this Random. You can check the Options: Create as a partial view. The partial view is not a complete page, it's like a widget that we can reuse on
      different views. But we are not interested in that, so leave that unchecked.

      Then we have a checkbox for selecting the layout for this view. A layout is like a template or a master page. We want all the views in our application to have
      the same look and feel. So lets check the layout. Click on ..., by default our MVC project has a layout under Views->Shared called _Layout.cshtml. So select it and Add
      the View.

    (After the Random.cshtml)
    I want to put this movie model in our View() so that we can render it again.
    (go to Random.cshtml in the header section)
 */