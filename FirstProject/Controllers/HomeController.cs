﻿using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers;

public class HomeController : Controller
{

    public ViewResult Index()
    {
        int hour = DateTime.Now.Hour;
        string viewModle = hour < 12 ? "Good Morning" : "Good Afternoon";
        return View("MyView", viewModle);
    }


}
