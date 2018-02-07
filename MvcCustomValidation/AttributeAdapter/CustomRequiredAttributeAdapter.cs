using MvcCustomValidation.Properties;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcCustomValidation.AttributeAdapter
{
    public class CustomRequiredAttributeAdapter : RequiredAttributeAdapter
    {
        public CustomRequiredAttributeAdapter(ModelMetadata metadata, ControllerContext context, RequiredAttribute attribute) : base(metadata, context, attribute)
        {            
            attribute.ErrorMessageResourceType = typeof(Resources); // リソースファイルを指定            
            attribute.ErrorMessageResourceName = "PropertyValueRequired"; // リソースファイルに記述した名前を指定
            attribute.ErrorMessage = null;
        }
    }
}