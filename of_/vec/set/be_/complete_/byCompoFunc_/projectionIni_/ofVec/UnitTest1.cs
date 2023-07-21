using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul._bit_._TEST_.op.set.be_.complete_.byCompoFunc_.projectionIni_.ofVec
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var builder = new nilnul.bit.op.set.be_.complete_.byCompoFunc_.ofVec_.ProjectionIni(
				nilnul.bit.op_.unary_.Not1.Singleton
				,
				nilnul.bit.op_.binary_.Le.Singleton
			);
			var computed=builder.compute();
			Debug.Assert(
				computed
			);

			assertComplet(
				bit.op_.binary_.Nand.Singleton
			);

			assertComplet(
				bit.op_.binary_.Nor.Singleton
			);

			assertIncomplete(
				bit.op_.binary_.Le.Singleton
				,
				bit.op_.nary_.One.Singleton
			);


			assertComplet(
				bit.op_.binary_.Le.Singleton
				,
				bit.op_.nary_.Nil.Singleton
			);


			assertIncomplete(
				bit.op_.binary_.Le.Singleton

			);



		}

		void assertInCompletes() {

			assertComplet(
				bit.op_.binary_.Le.Singleton
				,
				bit.op_.nary_.One.Singleton
			);

		}

		public void assertComplet(params bit.OpI2[] ops) {
			var builder = new nilnul.bit.op.set.be_.complete_.byCompoFunc_.AssumeArityNonpoly(
				ops
			);
			var computed=builder.compute();
			Debug.Assert(
				computed
			);

		}

		public void assertIncomplete(params bit.OpI2[] ops) {
			var builder = new nilnul.bit.op.set.be_.complete_.byCompoFunc_.AssumeArityNonpoly(
				ops
			);
			var computed=builder.compute();
			Debug.Assert(
				!computed
			);

		}


	}
}
