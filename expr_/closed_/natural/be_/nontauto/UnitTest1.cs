using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.bit._test.expr_.nontauto
{
	[TestClass]
	public class UnitTest1
	{

	

		[TestMethod]
		public void P__n__P_imply_Q___eq___Q()
		{

			/// if we run all tests, there might be remained names;
			///
			nilnul.obj.var.set.NamingContext.Instance.clean();

			nilnul.var.set.NamingContext_ofVarI.Instance.clean();

			var x = nilnul.bit.var.NamingContext.CreateAs_Var2_("p");

			var y = nilnul.bit.var.NamingContext.CreateAs_Var2_("q");

			var expr = 	bit.expr.duo.Call.CreateEq(


					nilnul.bit.expr.duo.Call.CreateMi(
						x,

						nilnul.bit.expr.duo.Call.CreateImply(x,y)
					)
					,
					y
				)
				
			;

			Debug.WriteLine(expr);

			var truthTable = nilnul.bit.expr.TruthTableX.GetTruthTable(expr);




			var isTauto = nilnul.bit.expr.be.Tauto.Eval(expr);


			Assert.False(isTauto);



		}

	

		[TestMethod]
		public void Tauto_Assert()
		{



			new nilnul.bit.expr.ident.Exportation().assert();

			


		}


	}
}
