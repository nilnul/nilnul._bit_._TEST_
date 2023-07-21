using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Collections.Generic;

namespace nilnul.bit._test.proof
{
	[TestClass]
	public class UnitTest1
	{



		[TestMethod]
		public void Proof()
		{


			/*

			公理模式：
L1:
			(A->(B->A))
L2:
			(A->(B->C))->((A->B)->(A->C))
L3:
			(A->B)->(~B->~A)
推理规则MP：由A和A->B可得B

证明(p->(~p->q)):
(1)(p->(~q->p))
      L1 A = p，B = q
  (2)((~q->p)->(~p->q))
      L3 A = ~q，B = p
  (3)((~q->p)->(~p->q))->(p->((~q->p)->(~p->q)))
      L1 A = ((~q->p)->(~p->q))，B = p
  (4)(p->((~q->p)->(~p->q))
		(2)，(3) MP
  (5)(p->((~q->p)->(~p->q)))->((p->(~q->p))->(p->(~p->q)))
        L2 A = p，B = (~q->p)，C = (~p->q)
  (6)((p->(~q->p))->(p->(~p->q)))
		(4)，(5) MP
  (7)(p->(~p->q))
		(1)，(6) MP
  得证
  

	*/

			/// if we run all tests, there might be remained names;
			///
			nilnul.obj.var.set.NamingContext.Instance.clean();

			nilnul.var.set.NamingContext_ofVarI.Instance.clean();



			var x = nilnul.bit.var.NamingContext.CreateAs_Var2_("p");

			var y = nilnul.bit.var.NamingContext.CreateAs_Var2_("q");

			var sys = new nilnul.bit.Sys();
			sys.assumptions = new bit.expr.Set();
			sys.assumptions.add(y);




			var expr = bit.expr.duo.Call.CreateMi(
					x
					,
					bit.expr.duo.Call.CreateMa(
						y
						,
						bit.expr.Call.CreateNeg(y)
					)
				)
			; // x & y|y



			Debug.WriteLine(expr);

			var proof = new nilnul.bit.Proof();
			var rules = new List<_proof.RuleI>();
			//rules.Add(

				
			//);

			var truthTable = nilnul.bit.expr.TruthTableX.GetTruthTable(expr);




			var isTauto = nilnul.bit.expr.be.Tauto.Eval(expr);


			Assert.False(isTauto);



		}

		



	}
}
