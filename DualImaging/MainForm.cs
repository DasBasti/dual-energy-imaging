/*
 * Created by Bastian Neumann <neumann.bastian@gmail.com>
 * Date: 03.09.2014
 * Time: 10:54
 * 
 * Dual Energy Image calculation. Click into the PictureBoxes to load 8bit indexed images or use the ones provided. 
 */
 
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace DualImaging
{
	/// <summary>
	/// Holds all the neccessary functions to see the effect of dual energy imaging
	/// </summary>
	public partial class MainForm : Form
	{
		private Bitmap e1;
		private Bitmap e2;
		
		public MainForm()
		{

			InitializeComponent();
			
			try // to load the two provided images and show them
			{
				e1 = new Bitmap("bild1.bmp");
				e2 = new Bitmap("bild2.bmp");
				pictureBox1.Image = e1;
				pictureBox2.Image = e2;
			}
			catch
			{
				
			}
			
		}
		/**
		 * Do dual energy calculations.
		 * 
		 * Images are read byte for byte and a result is calculated according to the formular:
		 * I = k_lo * I_lo + k_hi * I_hi.
		 * 
		 * 
		 * The result is mapped to values 0 ... 255 and the resulting image is shown.
		 */
		unsafe void berechneBild(object sender, EventArgs e)
		{
			if(pictureBox1.Image == null) {
				MessageBox.Show("low enegry picture not loaded");
				return;
			}
			
			if(pictureBox2.Image == null) {
				MessageBox.Show("high energy image not loaded");
				return;
			}
			
			// recalculation of the result
			
			Bitmap r = new Bitmap(e1.Width, e1.Height,PixelFormat.Format8bppIndexed); // Ergebnisbild

			BitmapData b1 = e1.LockBits(new Rectangle(0,0,e1.Width,e1.Height), ImageLockMode.ReadOnly, e1.PixelFormat);
			BitmapData b2 = e2.LockBits(new Rectangle(0,0,e2.Width,e2.Height), ImageLockMode.ReadOnly, e2.PixelFormat);
			BitmapData res = r.LockBits(new Rectangle(0,0,r.Width,r.Height), ImageLockMode.ReadOnly, r.PixelFormat);
	
			double[,] b = new double[e1.Width, e1.Height];
			int[,] i = new int[e1.Width, e1.Height];
			
			
			double khi = trackBarkhi.Value*0.01;
			double klo = trackBarklo.Value*0.01;
			
			// pointer to image memory
			byte * i1Scan = (byte*) b1.Scan0.ToPointer();
			byte * i2Scan = (byte*) b2.Scan0.ToPointer();
			byte * irScan = (byte*) res.Scan0.ToPointer();
			
			for (int x = 0; x < e1.Width; x++) for (int y = 0; y < e1.Height; y++)
			{
				byte in1 = *(i1Scan + y * b1.Stride + x);
				byte in2 = *(i2Scan + y * b2.Stride + x);
			
				b[x, y] = (klo * in1) - (khi * in2); // ier ein - anstatt + da (k_hi/k_lo) = - (µ_tlo/µ_thi)
			}
			
			// value mapping

			double max = b[0, 0];
			double min = b[0, 0];
			for (int x = 0; x < e1.Width; x++) for (int y = 0; y < e1.Height; y++)
			{
				if (b[x, y] > max) max = b[x, y];
				else if (b[x, y] < min) min = b[x, y];
			}
			
			for (int x = 0; x < e1.Width; x++) for (int y = 0; y < e1.Height; y++)
			{
				i[x, y] = (int)(map(b[x, y], min, max)+0.5);
			}
			
			// create resulting bitmap
			
			for (int x = 0; x < e1.Width; x++) for (int y = 0; y < e1.Height; y++)
			{
				byte* outd = (irScan + y * res.Stride + x);
				*outd=(byte)(i[x,y]);
			}
			
			e1.UnlockBits(b1);
			e2.UnlockBits(b2);
			r.UnlockBits(res);
			
			ColorPalette pal=r.Palette;
			for (int p=0;p<256;p++) pal.Entries[p]=Color.FromArgb(p,p,p); // greyscale 'colors'
			r.Palette=pal;

			resultPictureBox.Image = new Bitmap(r);
			Strip.Text = "k_hi/k_lo = "+(khi/klo).ToString();
		}
		
		/**
		 * Mapping function to scale values onto 0...255.
		 */
		double map(double x, double in_min, double in_max)
		{
			return (x - in_min) * 255 / (in_max - in_min);
		}

		/**
 		 * refresh GUI and recalculate.
 		 */
		void TrackBarkloValueChanged(object sender, EventArgs e)
		{
			label5.Text = "k_lo: "+(trackBarklo.Value*0.01).ToString();
			berechneBild(sender, e);
		}
		/**
		 * refresh GUI and recalculate.
		 */
		void TrackBarkhiValueChanged(object sender, EventArgs e)
		{
			label6.Text = "k_hi: "+(trackBarkhi.Value*0.01).ToString();
			berechneBild(sender, e);
		}

		/**
		 * Load picture for e1 (low enegery).
		 */
		void PictureBox1Click(object sender, EventArgs e)
		{
			openFileDialog.ShowDialog();
			try {
				
				e1 = new Bitmap(openFileDialog.FileName, true);
				pictureBox1.Image = e1;
				
			}
			catch {
				// Do nothing
			}

		}
		
		/**
		 *Load picture for e2 (high enegery).
		 */
		void PictureBox2Click(object sender, EventArgs e)
		{
			openFileDialog.ShowDialog();
			try {
				e2 = new Bitmap(openFileDialog.FileName, true);
				pictureBox2.Image = e2;

			}
			catch {
				// Do nothing
			}
		}
	}
}
