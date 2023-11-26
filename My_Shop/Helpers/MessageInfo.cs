using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Shop.Helpers
{
    public static class MessageInfo
    {
        public const string ShowNoProductFoundMessage = "No product with such name was found";

        public const string ShowNeedAdminPassMessage = "Please enter ADMIN password into entry field";

        public const string ShowNoSuchAmountMessage = "No such amount of this product on storage ";

        public const string WarningNotCorrectInputMessage =
            "Please enter correct product" +
            " code and qty into the CODE entry";

        public const string ShowSuccessBuyMessage = "Greatings, your buy operation is succesful";

        public const string WarnToFillAdminCorrectlyMessage =
            "Not correctly filled all entry fields (missed info / " +
            "incorrect price or quantity). Please recheck";
        public static string ShowWarnAboutProductDelete(params string[] input) =>
            $" Warning! You want to delete product :" +
            $"CODE - {input[0]}, Name - {input[1]}, Price - {input[2]}, Quantity - {input[3]}";

        public static string ShowWarnAboutProductAdd(params string[] input) =>
            $"You want to add to the storage product :" +
            $"CODE - {input[0]}, Name - {input[1]}, Price - {input[2]}, Quantity - {input[3]}";

        public const string ShowSuccesMessage = "Operation successed";

        public const string ShowFailMessage = "Operation failed";
    }
}
