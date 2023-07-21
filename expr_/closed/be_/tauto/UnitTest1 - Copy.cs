using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using V2 = nilnul.bit.Var2;

namespace nilnul.bit._test.expr.be_.contingent
{
	[TestClass]
	public class UnitTest11
	{
		[TestMethod]
		public void notTauto()
		{

			var x = nilnul.bit.expr_._VarX.Of("x");

			var y = nilnul.bit.expr_._VarX.Of("y");
			var z = nilnul.bit.expr_._VarX.Of("z");

			var expr = new nilnul.bit.expr_.call_.binary_.Eq_generi(

				new nilnul.bit.expr_.call_.binary_.Ne(
					new nilnul.bit.expr_.call_.binary_.Eq_generi(
						x
						,
						y
					)
					,

					new nilnul.bit.expr_.call_.binary_.Eq_generi(
						x
						,
						z
					)
				)
				,

				
					new nilnul.bit.expr_.call_.binary_.Ne(
						y
						,
						z
					)
				

			);


			var isTauto = nilnul.bit.expr_.closed.be_.Tauto_generi.Singleton.be(
				expr as ExprI_generi
			);

			Debug.WriteLine(isTauto);
			Debug.Assert(isTauto == true);
		}
	}
}
