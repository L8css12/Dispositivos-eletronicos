using Dispositivos_eletronicos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dispositivos_eletronicos.Controllers
{
    public class DispositivoController : Controller
    {
        public IActionResult Index()
        {

            List<DispositivoEletronico> dispositivos = new List<DispositivoEletronico>
            {
                new Computador {Marca = "Dell", Modelo = "Inspirion", AnoDeFabricacao = 2021, EhLaptop = true, MemoriaRam = 16, SistemaOperacional = "Windows 11" },
                new Computador {Marca = "HP", Modelo = "Pavilion", AnoDeFabricacao = 2019, MemoriaRam = 8, EhLaptop = false },
                new Smartphone {Marca = "Apple", Modelo = "Iphone 13", AnoDeFabricacao = 2022, Tem5G = true }

            };
            return View(dispositivos);
        }
    }
}
