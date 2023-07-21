using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.bit._test.expr.stati
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void MaxCommutiative()
		{

			/// if we run all tests, there might be remained names;
			///
			nilnul.obj.var.set.NamingContext.Instance.clean();

			nilnul.var.set.NamingContext_ofVarI.Instance.clean();


			var x =  nilnul.bit.var.stati.NamingContext.Create("x");

			var y = nilnul.bit.var.stati.NamingContext.Create("y");

			var expr = nilnul.bit.expr.stati.duo.Eq.Call(
					nilnul.bit.expr.stati.duo.Max.Create(x, y)
				, 
					nilnul.bit.expr.stati.duo.Max.Create(y, x)

				
			);

			var str = expr.ToString();




		}
	}
}
