using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicForm.Models;
using DynamicForm.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DynamicForm.Controllers
{
    public class FormController : Controller
    {
        private readonly IFormBuilder _formBuilderService;
        public FormController(IFormBuilder formBuilderService)
        {
            _formBuilderService = formBuilderService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GenerateForm([FromBody] FormModel formModel)
        {
            return Ok(new { Status = true, HtmlForm = _formBuilderService.prepareForm(formModel.form) });
        }
    }
}
