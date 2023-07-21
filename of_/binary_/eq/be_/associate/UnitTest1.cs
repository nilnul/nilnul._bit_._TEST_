using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.bit;
using System;
using System.Diagnostics;

namespace nilnul._bit_._TEST_.of_.binary_.eq.be_.associate
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			//var x = new nilnul.bit.expr_.Var_sys("x");
			//var y = new nilnul.bit.expr_.Var_sys("y");
	var x = nilnul.bit.expr_._VarX.Of("x");

			var y = nilnul.bit.expr_._VarX.Of("y");
			var z = nilnul.bit.expr_._VarX.Of("z");

			var expr = new nilnul.bit.expr_.call_.binary_.Eq_generi(
				 new nilnul.bit.expr_.call_.binary_.Eq_generi(

					 new nilnul.bit.expr_.call_.binary_.Eq_generi(
					 x,y
					 )
					,
					 new nilnul.bit.expr_.Var2(
						z
					)
				)
				 ,
				 new nilnul.bit.expr_.call_.binary_.Eq_generi(
					 new nilnul.bit.expr_.Var2(
						x
					)
					,

					 new nilnul.bit.expr_.call_.binary_.Eq_generi(
					 y,z
					 )
				)



			);

			var truthTable = nilnul.bit.expr_.capsule.to_._CalibrateX._GetTruthTable_0capsule(expr);

			//var phrased= nilnul.

			var isTauto = nilnul.bit.expr_.closed.be_.Tauto_generi.Singleton.be(
						expr as ExprI_generi
				);


			Debug.WriteLine(isTauto);
			Debug.Assert(isTauto == true);
		}
	}
}
