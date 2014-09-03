/*
 * Created by SharpDevelop.
 * User: basneu
 * Date: 05.06.2014
 * Time: 10:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DualImaging
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.trackBarklo = new System.Windows.Forms.TrackBar();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.trackBarkhi = new System.Windows.Forms.TrackBar();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.resultPictureBox = new System.Windows.Forms.PictureBox();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.Strip = new System.Windows.Forms.ToolStripStatusLabel();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarklo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarkhi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSize = true;
			this.groupBox1.Controls.Add(this.trackBarklo);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(252, 447);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Low Energy";
			// 
			// trackBarklo
			// 
			this.trackBarklo.Dock = System.Windows.Forms.DockStyle.Top;
			this.trackBarklo.Location = new System.Drawing.Point(3, 399);
			this.trackBarklo.Maximum = 100;
			this.trackBarklo.Minimum = 1;
			this.trackBarklo.Name = "trackBarklo";
			this.trackBarklo.Size = new System.Drawing.Size(246, 45);
			this.trackBarklo.TabIndex = 7;
			this.trackBarklo.Value = 1;
			this.trackBarklo.ValueChanged += new System.EventHandler(this.TrackBarkloValueChanged);
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Top;
			this.label5.Location = new System.Drawing.Point(3, 383);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(246, 16);
			this.label5.TabIndex = 6;
			this.label5.Text = "k_lo";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Location = new System.Drawing.Point(3, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(246, 367);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// groupBox2
			// 
			this.groupBox2.AutoSize = true;
			this.groupBox2.Controls.Add(this.trackBarkhi);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.pictureBox2);
			this.groupBox2.Location = new System.Drawing.Point(270, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(252, 447);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "High Energy";
			// 
			// trackBarkhi
			// 
			this.trackBarkhi.Dock = System.Windows.Forms.DockStyle.Top;
			this.trackBarkhi.Location = new System.Drawing.Point(3, 399);
			this.trackBarkhi.Maximum = 100;
			this.trackBarkhi.Minimum = 1;
			this.trackBarkhi.Name = "trackBarkhi";
			this.trackBarkhi.Size = new System.Drawing.Size(246, 45);
			this.trackBarkhi.TabIndex = 8;
			this.trackBarkhi.Value = 1;
			this.trackBarkhi.ValueChanged += new System.EventHandler(this.TrackBarkhiValueChanged);
			// 
			// label6
			// 
			this.label6.Dock = System.Windows.Forms.DockStyle.Top;
			this.label6.Location = new System.Drawing.Point(3, 383);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(246, 16);
			this.label6.TabIndex = 7;
			this.label6.Text = "k_hi";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox2.Location = new System.Drawing.Point(3, 16);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(246, 367);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.PictureBox2Click);
			// 
			// groupBox3
			// 
			this.groupBox3.AutoSize = true;
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Controls.Add(this.resultPictureBox);
			this.groupBox3.Location = new System.Drawing.Point(528, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(252, 447);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Result";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(171, 399);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "berechne";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.berechneBild);
			// 
			// resultPictureBox
			// 
			this.resultPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.resultPictureBox.Location = new System.Drawing.Point(3, 16);
			this.resultPictureBox.Name = "resultPictureBox";
			this.resultPictureBox.Size = new System.Drawing.Size(246, 367);
			this.resultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.resultPictureBox.TabIndex = 0;
			this.resultPictureBox.TabStop = false;
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.Strip});
			this.statusStrip.Location = new System.Drawing.Point(0, 479);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(793, 22);
			this.statusStrip.TabIndex = 3;
			this.statusStrip.Text = "statusStrip";
			// 
			// Strip
			// 
			this.Strip.Name = "Strip";
			this.Strip.Size = new System.Drawing.Size(118, 17);
			this.Strip.Text = "toolStripStatusLabel1";
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(793, 501);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "Basic Dual-Energy Radiography Calculations";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarklo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarkhi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ToolStripStatusLabel Strip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.PictureBox resultPictureBox;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TrackBar trackBarkhi;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TrackBar trackBarklo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
