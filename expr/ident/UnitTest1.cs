using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.bit._test.expr.ident
{
	[TestClass]
	public class UnitTest1
	{



		[TestMethod]
		public void Idents_AssertExpr()
		{





			var x = nilnul.bit.var.NamingContext.CreateAs_Var2_("p");


			var expr = bit.expr.duo.Call.CreateEq(
					nilnul.bit.expr.duo.Call.CreateImply(1, x)
					
					,
					bit.expr.duo.Call.CreateEq(

							1
							, x
					)
				)

			;

			Debug.WriteLine(expr);

			var truthTable = nilnul.bit.expr.TruthTableX.GetTruthTable(expr);


			var isTauto = nilnul.bit.expr.be.Tauto.Eval(expr);


			Assert.True(isTauto);



		}

		[TestMethod]
		public void Idents_Assert()
		{




			new nilnul.bit.expr.ident.unary.P__P_1();
			new nilnul.bit.expr.ident.unary.One_imply_P__P().assert();
			new nilnul.bit.expr.ident.unary.One_eq_P__P().assert();
			new nilnul.bit.expr.ident.unary.One_imply_P__1_eq_P().assert();


		}




	}
}
