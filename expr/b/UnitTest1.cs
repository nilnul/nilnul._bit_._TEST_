using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.bit._test.expr.stati.b
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Axiom()
		{
			/// if we run all tests, there might be remained names;
			///
			nilnul.obj.var.set.NamingContext.Instance.clean();

			nilnul.var.set.NamingContext_ofVarI.Instance.clean();

			nilnul.obj.var.NamingContext3.StaticContext.names.Clear();

			var x = nilnul.bit.var.stati.NamingContext.Create("x");

			var y = nilnul.bit.var.stati.NamingContext.Create("y");

			var expr = nilnul.bit.expr.stati.duo.Eq.Call(
					nilnul.bit.expr.stati.duo.Max.Create(x, y)
				,
					nilnul.bit.expr.stati.duo.Max.Create(y, x)


			);

			var axiom = nilnul.bit.expr.stati.b.Axiom.Eval(expr);


		}
	}
}
