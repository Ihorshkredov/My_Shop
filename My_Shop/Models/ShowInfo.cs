using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Shop.Models
{
	public static class ShowInfo
	{
		public static string ShowNoProductFound() =>
			"No product with such name was found";

		public static string ShowNeedAdminPass() =>
			"Please enter ADMIN password into entry field";

		public static string ShowNoSuchAmount() =>
			"No such amount of this product on storage ";

		public static string WarningNotCorrectInput() => 
			"Please enter correct product" +
			" code and qty into the CODE entry";
		public static string ShowSuccessBuy() =>
			"Greatings, your buy operation is succesful";

		public static string WarnToFillAdminCorrectly() =>
			"Not correctly filled all entry fields (missed info / " +
			"incorrect price or quantity). Please recheck";
		public static string WarnAboutProductDelete(params string[] input) =>
			$" Warning! You want to delete product :" +
			$"CODE - {input[0]}, Name - {input[1]}, Price - {input[2]}, Quantity - {input[3]}";

		public static string WarnAboutProductAdd(params string[] input) =>
			$"You want to add to the storage product :" +
			$"CODE - {input[0]}, Name - {input[1]}, Price - {input[2]}, Quantity - {input[3]}";

		public static string ShowSucces() => "Operation successed";

		public static string ShowFail() => "Operation failed";
	}
}
