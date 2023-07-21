using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Diagnostics;

namespace nilnul._bit_._TEST_.op_.binary.re_.distributive
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var biops = nilnul.bit.op_.binary.Sortie.OfAll();

			var bits = nilnul.bit.Sortie.OfAll();

			//var cos = nilnul.bit.co.Sortie.All;
			var cos = nilnul.bit.op_.binary.co.Sortie.All;

			var table = new DataTable()
			{

			};

			var cols = new[] {
					new DataColumn("additionOp")
					,
					new DataColumn("multi")
					,
					new DataColumn("leftDistributive")
					,
					new DataColumn("rightDistributive")
					,
					new DataColumn("distributive")


			};
			table.Columns.AddRange(cols);

			foreach (var coOps in cos.ee)
			{
				var r = table.NewRow();
				var leftUnardFor0 = nilnul.bit.op_.binary.re_._distributive.LeftDistributive.Singleton.re(
						coOps
				);

				var rightDistr = nilnul.bit.op_.binary.re_._distributive.RightDistributive.Singleton.re(
						coOps
				);

				var distr = leftUnardFor0 && rightDistr;

				



				r.ItemArray = new object[] {
					coOps.Item1
					,
					coOps.Item2
					,
					leftUnardFor0
					,
					rightDistr
					,
					distr
					



				};

				table.Rows.Add(r);


			}
			var view = new DataView(table);
			view.Sort= "distributive desc, leftDistributive desc, rightDistributive desc";

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
				nilnul.obj.tups_.table.phrase_._CelSepByTabX.Lines(view.ToTable())
			);

			var container = System.IO.Path.GetDirectoryName(csv);
			Process.Start(container);


			Process.Start(csv);

		}
	}
}
