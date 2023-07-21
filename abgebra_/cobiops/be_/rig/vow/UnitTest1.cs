using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.bit;
using System;
using System.Diagnostics;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace nilnul._bit_._TEST_.algebra_.cobiops.be_.rig
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{



				var x = nilnul.bit.expr_._VarX.Of("x");

				var y = nilnul.bit.expr_._VarX.Of("y");
				var z = nilnul.bit.expr_._VarX.Of("z");

			var expr = (new nilnul.bit.expr_.call_.binary_.Or1(
				x, y).ToOperand()&z)

				==
				(
				x.ToBitOperand()&z | y.ToBitOperand() &z
				)
				 
				;

					


				var isTauto = nilnul.bit.expr_.closed.be_.Tauto_generi.Singleton.be(
					expr as ExprI_generi
				);

				Debug.WriteLine(isTauto);
				Assert.IsTrue(isTauto == true);
			}
		}
	}
