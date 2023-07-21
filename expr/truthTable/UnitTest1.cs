using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace nilnul.bit._test.expr.truthTable
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Xor_truthTable()
		{
			/// if we run all tests, there might be remained names;
			///
			nilnul.obj.var.set.NamingContext.Instance.clean();

			nilnul.var.set.NamingContext_ofVarI.Instance.clean();


			var x = nilnul.bit.var.NamingContext.Create1("x");

			var y = nilnul.bit.var.NamingContext.Create1("y");
			var z = nilnul.bit.var.NamingContext.Create1("z");

			var expr = nilnul.bit.expr.duo.Call.CreateEq(

				bit.expr.duo.Call.CreateNe(
					nilnul.bit.expr.duo.Call.CreateMa(x, y)
					,
						 z
				)
				,

				nilnul.bit.expr.duo.Call.CreateNe(
					x
				,
					nilnul.bit.expr.duo.Call.CreateMa(y, z)
				)

			)
			;

			var truthTable = nilnul.bit.expr.TruthTableX.GetTruthTable(expr);

			var interpretations = truthTable.getInterpretatios().ToList();

			var isTauto = nilnul.bit.expr.be.Tauto.Eval(expr);

			Assert.False(isTauto);


		}
	}
}
