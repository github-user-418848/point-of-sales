/*
 * Date: 6/2/2020
 * Time: 7:38 PM
 *
 * +-----------------+
 * |  Hello friend   |
 * +-----------------+
 *    \                     
 *     \   ,__,             
 *      \  (oo)____  
 *         (__)    )\
 *            ||--|| *
 */
using System;
using System.Windows.Forms;

namespace point_of_sales_v3
{
	internal sealed class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
