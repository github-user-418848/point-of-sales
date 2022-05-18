/*
 * Date: 6/3/2020
 * Time: 2:55 PM
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
using System.Drawing;
using System.Windows.Forms;

namespace point_of_sales_v3
{
	public class BtnCustom: Button
	{
		public BtnCustom(Image img, ContentAlignment imgalign, Padding pad, Size size, string text, ContentAlignment textalign)
		{
			FlatAppearance.BorderColor = Color.LightGray;
			FlatStyle = FlatStyle.Flat;
			Font = new Font("Calibri", 12, FontStyle.Bold);
			Image = img;
			ImageAlign = imgalign;
			Margin = pad;
			Size = size;
			Text = text;
			TextAlign = textalign;
		}
	}
	
	public class BtnMenu: RadioButton {
		public BtnMenu(Image img, ContentAlignment imgalign, Padding pad, Size size, string text, ContentAlignment textalign)
		{
			Appearance = Appearance.Button;
			FlatAppearance.CheckedBackColor = Color.FromArgb(72, 54, 34);
			FlatStyle = FlatStyle.Flat;
			Font = new Font("Calibri", 12, FontStyle.Bold);
			ForeColor = Color.White;
			Image = img;
			ImageAlign = imgalign;
			Margin = pad;
			Size = size;
			Text = text;
			TextAlign = textalign;
			this.MouseEnter += BtnMenu_MouseEnter;
			this.MouseLeave += BtnMenu_MouseLeave;
		}

		void BtnMenu_MouseEnter(object sender, EventArgs e)
		{
			ForeColor = Color.FromArgb(255, 140, 34);
		}

		void BtnMenu_MouseLeave(object sender, EventArgs e)
		{
			ForeColor = Color.White;
		}
	}
		
	public class RBtnCustom: RadioButton {
		public RBtnCustom(Image img, ContentAlignment imgalign, Padding pad, Size size, string text, ContentAlignment textalign) {
			Appearance = Appearance.Button;
			FlatAppearance.CheckedBackColor = Color.Silver;
			FlatAppearance.BorderColor = Color.LightGray;
			FlatStyle = FlatStyle.Flat;
			Font = new Font("Calibri", 12, FontStyle.Bold);
			Image = img;
			ImageAlign = imgalign;
			Margin = pad;
			Size = size;
			Text = text;
			TextAlign = textalign;
		}
	}
}
