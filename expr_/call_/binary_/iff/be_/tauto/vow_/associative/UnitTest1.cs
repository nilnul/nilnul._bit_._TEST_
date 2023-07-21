using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.bit._test._expr_.expr_.call_.duo_.equiv.be_.tauto.vow_.associative
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void nandIsNotAssociative()
		{
			/// if we run all tests, there might be remained names;
			///
			nilnul.obj.var.set.NamingContext.Instance.clean();
			var x = nilnul.obj.var.set.NamingContext.Instance.createVar<Var2>("x");

			var y = nilnul.obj.var.set.NamingContext.Instance.createVar<Var2>("y");
			var z = nilnul.obj.var.set.NamingContext.Instance.createVar<Var2>("z");



			var nandAssociativeExpr = nilnul.bit.expr_.call_.duo_.equiv_.Associative.Create(
				bit.combine_.Nand.Singleton
				,
				x
				,
				y
				, 
				z
			);

			nilnul.bit.expr.be_.tauto.anto.Vow.Singleton.vow(nandAssociativeExpr);



		}
	}
}
