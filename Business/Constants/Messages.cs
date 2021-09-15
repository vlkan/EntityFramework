using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product Added";
        public static string ProductNameInvalid = "Product Name Invalid";
        public static string MaintenenceTime = "System in Maintenance";
        public static string ProductsListed = "Products Listed";
        public static string ProductCountOfCategoryError ="Maximum 15 products in same category";
        public static string SameNameError = "Please change the name. This product already exist.";
        public static string CategoryLimitExceded = "Category Limit Exceded";
        public static string AuthorizationDenied = "No Auth";
    }
}
