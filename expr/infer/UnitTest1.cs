using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.bit._test.expr.infer
{
	[TestClass]
	public class UnitTest1
	{



		[TestMethod]
		public void Infers_Assert()
		{



			new nilnul.bit.expr.infer.P__Q_P().assert();

			new nilnul.bit.expr.infer.P__Q_R___P_Q__P_R().assert();
			new nilnul.bit.expr.infer.P__Q_n_P__notQ___notP().assert();

		}

		[TestMethod]
		public void ModusPolens()
		{



			new nilnul.bit.expr.infer.deduce.ModusPonens().assert();

			

		}




	}
}
