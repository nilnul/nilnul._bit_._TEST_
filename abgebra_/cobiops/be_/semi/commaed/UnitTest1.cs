using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Diagnostics;

namespace nilnul._bit_._TEST_.algebra_.cobiops.be_.semi.commaed
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var biops = nilnul.bit.op_.binary.Sortie.OfAll();

			var bits = nilnul.bit.Sortie.OfAll();

			var bitCos = nilnul.bit.co.Sortie.All;
			var cos = nilnul.bit.op_.binary.co.Sortie.All;



			var table = new DataTable()
			{

			};

			var colName4annillator = "annillator";
			var colName4commutative4add = "commutable4add";

			var colName4isMonoid4add = "isMonoid4add";

			var colName4isMonoid4mul = "isMonoid4mul";

			var cols = new[] {
					new DataColumn("add")
					,

					new DataColumn(colName4isMonoid4add)
				,
					new DataColumn("nil")
					,
					new DataColumn("negable")
					,

					new DataColumn("mul")
				,
					new DataColumn(colName4isMonoid4mul)
					,
					new DataColumn("one")
					,
					new DataColumn(colName4commutative4add)
					,
					new DataColumn(colName4annillator)
					//,
					//new DataColumn("distributive")


			};
			table.Columns.AddRange(cols);

			foreach (var coOps in cos.ee)
			{
				//is semiring?

				var isSemiring = nilnul.bit.op_.binary.re_.Semiring.Singleton.re(
					coOps
				);
				if (!isSemiring)
				{
					continue;
				}

				foreach (var bitCo in bitCos.ee)
				{

					var isMonoid4add = bit.op_.binary.cumulator.be_.Unard.Singleton.be(
						bitCo.Item1, coOps.Item1
					);

					var isMonoid4mul = bit.op_.binary.cumulator.be_.Unard.Singleton.be(
						bitCo.Item2, coOps.Item2
					);


					var isCommutative4add = bit.op_.binary.be_.Commutable.Singleton.be(
						coOps.Item1
					);

					var isNilTheAnnillator = bit.op_.binary.cumulator.be_.Nard.Singleton.be(
						bitCo.Item1, coOps.Item2
					);


					table.Rows.Add(
						coOps.Item1
						,
						isMonoid4add
						,
						bitCo.Item1

						,
						coOps.Item2
						,
						isMonoid4mul
						,
						bitCo.Item2
						,
						isCommutative4add
						,
						isNilTheAnnillator

					);




				}




			}
			var view =
				table.DefaultView;

			//new DataView(table);
			view.Sort = $"{colName4isMonoid4add},{colName4isMonoid4mul},{colName4annillator}, {colName4commutative4add} desc";

			var tmp = System.IO.Path.GetTempPath();


			var csv = (
				System.IO.Path.Combine(
					tmp
					,
					Guid.NewGuid().ToString() + ".csv"
				)
			);

			System.IO.File.WriteAllLines(
				csv,
				nilnul.obj.tups_.table._PhraseX.Lines(view.ToTable())
			);

			var container = System.IO.Path.GetDirectoryName(csv);
			Process.Start(container);


			Process.Start(csv);
		}
	}
}
