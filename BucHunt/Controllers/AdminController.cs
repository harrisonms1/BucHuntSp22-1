using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using BucHunt.Models;
using BucHunt.Providers;
using BucHunt.Results;
namespace BucHunt.Controllers;

[Authorize]
[RoutePrefix("api/Account")]
public class AdminController : ApiController
{
    public ActionResult CreateLocation()
    {
        return View();
    }
}