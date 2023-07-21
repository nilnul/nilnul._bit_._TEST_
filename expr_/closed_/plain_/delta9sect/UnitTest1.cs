using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.bit._test.expr_.closed_.plain_.delta9sect
{
	[TestClass]
	public class UnitTest1
	{

		[TestMethod]
		public void P__NotP_Q()
		{

			/// if we run all tests, there might be remained names;
			///
			nilnul.obj.var.set.NamingContext.Instance.clean();

			nilnul.var.set.NamingContext_ofVarI.Instance.clean();

			var x = nilnul.bit.var.NamingContext.CreateAs_Var2_("p");

			var y = nilnul.bit.var.NamingContext.CreateAs_Var2_("q");

			var z = nilnul.bit.var.NamingContext.Create1("z");

			var expr = 	bit.expr.duo.Call.CreateImply(
					x
					,
					bit.expr.duo.Call.CreateImply(
						bit.expr.Call.CreateNeg(
							x
						)
						,
						y
					)
				)
				
			;	/// x ^    !x ->y

			Debug.WriteLine(expr);

			var truthTable = nilnul.bit.expr.TruthTableX.GetTruthTable(expr);




			var isTauto = nilnul.bit.expr.be.Tauto.Eval(expr);


			Assert.True(isTauto);

			nilnul.bit.expr.tauto.infer.P__NotP_Q.Assert(x, y);


		}



	}
}
