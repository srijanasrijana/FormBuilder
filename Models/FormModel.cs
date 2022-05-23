using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DynamicForm.Models
{
    public class FormModel
    {
        [Required]
        public List<Form> form { get; set; }
    }

    public class Form
    {
        [Required]
        public string type { get; set; }
        [Required]
        public string label { get; set; }
        public List<string>? options { get; set; }

    }
}
