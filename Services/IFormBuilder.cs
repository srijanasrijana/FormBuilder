using System;
using System.Collections.Generic;
using DynamicForm.Models;

namespace DynamicForm.Services
{
    public interface IFormBuilder
    {
        public String prepareForm(List<Form> forms);
        public String generateFormElement(Form form);
        public String generateInput(Form form);
        public String generateRadio(Form form);
        public String generateCheckBox(Form form);
        public String generateSelect(Form form);

    }
}
