using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        //Instanciar os clientes
        Cliente cliente1 = new(01, "João", "123.456.789-00", "jao@jao", "Rex");
        Cliente cliente2 = new(02, "Maria", "987.654.321-00", "maria@maria", "Felix");
        Cliente cliente3 = new(03, "Pedro", "111.222.333-00", "pedro@pedro", "Luna");
        Cliente cliente4 = new(04, "Ana", "444.555.666-00", "ana@ana", "Max");
        Cliente cliente5 = new(05, "Carlos", "777.888.999-00", "carlos@carlos", "Toby");

        //Lista de clientes
        List<Cliente> listaClientes = new();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;


        //Instanciar os fornecedores
        Fornecerdor fornecedor1 = new(01, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecerdor fornecedor2 = new(02, "Ctrl Alt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
        Fornecerdor fornecedor3 = new(03, "BootsPet INC", "40.810.224/0001-83", "boots.pet@gatomania.us");
        Fornecerdor fornecedor4 = new(04, "Tik Tok Dogs", "87.945.350/0001-09", "noisnamidia@tiktokdogs.uk");
        Fornecerdor fornecedor5 = new(05, "Bifinho Forever", "18.760.614/0001-37", "contato@bff.us");

        //Lista de fornecedores
        List<Fornecerdor> listaFornecedores = new();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
