using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using V2 = nilnul.bit.Var2;

namespace nilnul.bit._test._expr_.expr_.call_.duo_.equiv.be_.notTauto
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void notTauto()
		{

			var x = new V2();
			var y = new Var2();
			var z = new V2();
			nilnul.bit.expr_.call_.binary_.eq.be_.tauto.anto.Vow.Singleton.vow(
				nilnul.bit.expr_.call_.Duo1.CreateImply(
					nilnul.bit.expr_.call_.Duo1.CreateMa(x,y),z
				)
				,
				nilnul.bit.expr_.call_.Duo1.CreateImply(
					x
					,
					nilnul.bit.expr_.call_.Duo1.CreateImply(y,z)
				)

			);
		}
	}
}
