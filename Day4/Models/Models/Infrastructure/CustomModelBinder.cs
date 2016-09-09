using Models.Models;
using System;
using System.Globalization;
using System.Web.Mvc;

namespace Models.Infrastructure
{
    public class CustomModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            Person personModel = (Person)bindingContext.Model ?? new Person();

            personModel.FirstName = GetValue(bindingContext, "FirstName");
            personModel.LastName = GetValue(bindingContext, "LastName");
            personModel.Role = GetRole(bindingContext);
            personModel.HomeAddress = GetAddress(bindingContext);
            personModel.BirthDate = DateTime.ParseExact(GetValue(bindingContext, "BirthDate"), "dd(yyyy)MM", CultureInfo.InvariantCulture);
            return personModel;
        }

        private Role GetRole(ModelBindingContext bindingContext)
        {
            var role = GetValue(bindingContext, "Role");
            if (role == "Admin")
                return Role.Admin;
            else if (role == "User")
                return Role.User;
            else
                return Role.Guest;
        }

        private Address GetAddress(ModelBindingContext context)
        {
            Address address = new Address();
            address.City = GetValue(context, "City");
            address.Country = GetValue(context, "Country");
            address.Line1 = GetValue(context, "Line1");
            address.Line2 = GetValue(context, "Line2");
            address.PostalCode = GetValue(context, "PostalCode");
            return address;
        }

        private string GetValue(ModelBindingContext context, string name)
        {
            ValueProviderResult result = context.ValueProvider.GetValue(name);

            if (result == null || result.ToString().Contains("PO BOX"))
            {
                return "<Not Specified>";
            }
            if (name == "PostalCode" && result.ToString().Length <= 6)
            {
                return "<Not Specified>";
            }
            if (name == "Line2" && result.AttemptedValue == "")
            {
                return "<Not Specified>";
            }
            return result.AttemptedValue;
        }
    }
}