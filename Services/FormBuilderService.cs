using System;
using System.Collections.Generic;
using DynamicForm.Models;

namespace DynamicForm.Services
{
    public class FormBuilderService: IFormBuilder
    {
        public String prepareForm(List<Form> forms)
        {
            String htmlForm = @"<form>";
            foreach (var form in forms)
            {
                htmlForm += generateFormElement(form);
            }

            htmlForm += @"<button type=""button"" class=""btn btn-success"">Save</button>";
            htmlForm += "</form>";
            return htmlForm;
        }

        public String generateFormElement(Form form)
        {
            string html = "";
            switch(form.type)
            {
                case "text":
                    html = generateInput(form);
                    break;
                case "radio":
                    html = generateRadio(form);
                    break;
                case "checkbox":
                    html = generateCheckBox(form);
                    break;
                case "select":
                    html = generateSelect(form);
                    break;
            }

            return html;
        }

        public String generateInput(Form form)
        {
            string input =  @"<div class=""form-group"">
                        <label for= ""label"">{0}:</label>   
                         <input type=""text"" class=""form-control""></div>";
            return String.Format(input, form.label);
        }
        public String generateRadio(Form form)
        {
            string radio = @"<div class=""form-group"">
                        <label for= """">" + form.label + ":</label>"; ;
            foreach(var option in form.options)
            {
                radio += String.Format(@"<div class=""radio"">
                            <label><input type=""radio"" name=""name"">{0}</label></div>", option);
            }
            radio += "</div>";
            return radio;
        }
        public String generateCheckBox(Form form)
        {
            string checkbox = @"<div class=""form-group"">
                        <label for= """">"+form.label+":</label>";
            foreach (var option in form.options)
            {
                checkbox += String.Format(@"<div class=""checkbox"">
                            <label><input type=""checkbox"" value=""{0}"">{1}</label></div>", option, option);
            }
            checkbox += "</div>";
            return checkbox;
        }

        public String generateSelect(Form form)
        {
            string select = String.Format(@"<div class=""form-group""><label for=""sel1"">{0}:</label><select class=""form-control"">", form.label);

            foreach (var option in form.options)
            {
                select += String.Format(@"<option>"+option+"</option>");
            }
            select += "</select></div >";
            return select;
        }

    }
}
