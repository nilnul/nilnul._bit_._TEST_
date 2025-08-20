using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.bit._test.expr.be.tauto
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Xor_Associative()
		{


			var x = nilnul.bit.var.NamingContext.Create1("x");

			var y = nilnul.bit.var.NamingContext.Create1("y");
			var z = nilnul.bit.var.NamingContext.Create1("z");

			var expr = nilnul.bit.expr.duo.Call.CreateEq(

				bit.expr.duo.Call.CreateNe(
					nilnul.bit.expr.duo.Call.CreateNe(x, y)
					,
						 z
				)
				,
				
				nilnul.bit.expr.duo.Call.CreateNe(
					x
				,
					nilnul.bit.expr.duo.Call.CreateNe(y, z)
				)

			)			
			;


			Debug.WriteLine(expr);


			var isTauto = nilnul.bit.expr.be.Tauto.Eval(expr);


			Assert.True(isTauto);


		}



	}
}
