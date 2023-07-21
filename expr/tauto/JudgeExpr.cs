using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using V = nilnul.bit.VarI1;
using E = nilnul.bit.ExprI_membered;


namespace nilnul.bit._test.expr.tauto
{
	[TestClass]
	public class JudgeExpr_testClass
	{

		[TestMethod]
		public void ExprNotIdent()
		{
			
			var expr = 	bit.expr.eg.One_le_Q__xor__One_le_notQ.Singleton;

			Debug.WriteLine(expr);

			var truthTable = nilnul.bit.expr.TruthTableX.GetTruthTable(expr);



			var isTauto = nilnul.bit.expr.be.Tauto.Eval(expr);


			Assert.True(isTauto);




		}

		[TestMethod]
		public void IsTauto()
		{

			//TestExpr(nilnul.bit.expr.eg.WolframAxiom.Singleton);

			TestExpr(nilnul.bit.expr.eg.NandAssociative.Singleton);



		}


		public void TestExpr(E e) {

			Debug.WriteLine(e);

			var truthTable = nilnul.bit.expr.TruthTableX.GetTruthTable(e);



			var isTauto = nilnul.bit.expr.be.Tauto.Eval(e);


			Assert.True(isTauto);


		}




		


	}
}
