using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.bit._test._expr_.expr_.call_.duo_.equiv.be_.tauto.vow
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void nandIsNotCommutative()
		{
			var x = nilnul.obj.var.set.NamingContext.Instance.createVar<Var2>("x");

			var y = nilnul.obj.var.set.NamingContext.Instance.createVar<Var2>("y");



			var nandCommutativeExpr = nilnul.bit.expr_.call_.Duo1.CreateEq(
					new nilnul.bit.expr_.call_.Duo1(
						bit.combine_.Nand.Singleton
						,
						x,
						y

					)
					,
					new nilnul.bit.expr_.call_.Duo1(
						bit.combine_.Nand.Singleton
						,
						y,
						x

					)
			);

			nilnul.bit.expr_.call_.duo_.equiv.be_.tauto.Vow.Singleton.vow(nandCommutativeExpr);



		}
	}
}
