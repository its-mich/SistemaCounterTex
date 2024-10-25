using Microsoft.AspNetCore.Mvc;
using SistemaCounterTex.Models;

using SistemaCounterTex.Data;
using Microsoft.EntityFrameworkCore;
using SistemaCounterTex.ViewModels;

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace SistemaCounterTex.Controllers
{
    public class AccesoController : Controller
    {
        private readonly CounterTexDBContext _counterTexDBContext;
        public AccesoController(CounterTexDBContext counterTexDBContext)
        {
            _counterTexDBContext = counterTexDBContext;
        }

        [HttpGet]
        public IActionResult Registrarse()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registrarse(UsuarioVM modelo)
        {
            if (modelo.Clave != modelo.ConfirmarClave)
            {
                ViewData["Mensaje"] = "Las contraseñas no coinciden XD";
                return View();
            }

            Usuario usuario = new Usuario()
            {
                Correo = modelo.Correo,
                Clave = modelo.Clave
            };

            await _counterTexDBContext.Usuarios.AddAsync(usuario);
            await _counterTexDBContext.SaveChangesAsync();

            if (usuario.IdUsuario != 0) return RedirectToAction("Login", "Acceso");

            ViewData["Mensaje"] = "No se pudo crear el usuario, error fatal";
            return View();
        }


        [HttpGet]
        public IActionResult Login()
        {
            if(User.Identity!.IsAuthenticated) return RedirectToAction("Index", "Home");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM modelo)
        {
            Usuario? usuario_encontrado = await _counterTexDBContext.Usuarios
                                          .Where(u =>
                                            u.Correo == modelo.Correo &&
                                            u.Clave == modelo.Clave
                                          ).FirstOrDefaultAsync();

            if (usuario_encontrado == null)
            {
                ViewData["Mensaje"] = "No se encotraron coincidencias,XD";
                return View();
            }
            
            List<Claim> claims = new List<Claim>() 
            {
                new Claim(ClaimTypes.Name, usuario_encontrado.NombreCompleto)
            };

            ClaimsIdentity claimsidentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
            AuthenticationProperties properties = new AuthenticationProperties() 
            {
                AllowRefresh = true,
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsidentity),
                properties
                );
            return RedirectToAction("Index", "Home");
        }
    }
}
