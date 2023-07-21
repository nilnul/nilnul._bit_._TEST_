using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace nilnul._bit_._TEST_.op_.binary_.ne.cumulator_.oneAsUnard.be_.unard
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var op = nilnul.bit.op_.binary_.Ne.Singleton;
			var leftUnardBe = nilnul.bit.op_.binary.cumulator.be_.LeftUnard.Singleton;
			var rightUnardBe = nilnul.bit.op_.binary.cumulator.be_.RightUnard.Singleton;
			var unardBe = nilnul.bit.op_.binary.cumulator.be_.Unard.Singleton;


			var cumulatorForNil = new nilnul.bit.op_.binary.Cumulator(false, op);

			var cumulatorForOne = new nilnul.bit.op_.binary.Cumulator(true, op);

			var t =
				(leftUnardBe.be(cumulatorForNil)
				, rightUnardBe.be(cumulatorForNil)
				,
unardBe.be(cumulatorForNil)

,
leftUnardBe.be(cumulatorForOne)
,
rightUnardBe.be(cumulatorForOne)
,
unardBe.be(cumulatorForOne)




					);





			Debug.WriteLine(
				$"-------------------------------"
			);

			Debug.WriteLine(
				"-------------cumulatorForNil--------------------"
			);

			Debug.WriteLine(
				t.Item1
			); ;

			Debug.WriteLine(
				t.Item2
			); ;

			Debug.WriteLine(
				t.Item3
			); ;
			Debug.WriteLine(
				"-------------cumulatorForone--------------------"
			);

			Debug.WriteLine(
				t.Item4
			); ;

			Debug.WriteLine(
				t.Item5
			); ;

			Debug.WriteLine(
				t.Item6
			); ;


		}

	}

}
