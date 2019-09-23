namespace ScoreCalculator
{
	partial class Main
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.numericUpDownTotal = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownCorrect = new System.Windows.Forms.NumericUpDown();
			this.labelTotal = new System.Windows.Forms.Label();
			this.labelO = new System.Windows.Forms.Label();
			this.labelX = new System.Windows.Forms.Label();
			this.labelAvg = new System.Windows.Forms.Label();
			this.textBoxTotal = new System.Windows.Forms.TextBox();
			this.textBoxO = new System.Windows.Forms.TextBox();
			this.textBoxX = new System.Windows.Forms.TextBox();
			this.textBoxAvg = new System.Windows.Forms.TextBox();
			this.labelControl1 = new System.Windows.Forms.Label();
			this.labelControl2 = new System.Windows.Forms.Label();
			this.buttonClear = new System.Windows.Forms.Button();
			this.labelCopyright = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCorrect)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDownTotal
			// 
			this.numericUpDownTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.numericUpDownTotal.Cursor = System.Windows.Forms.Cursors.Default;
			this.numericUpDownTotal.Location = new System.Drawing.Point(53, 23);
			this.numericUpDownTotal.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numericUpDownTotal.Name = "numericUpDownTotal";
			this.numericUpDownTotal.Size = new System.Drawing.Size(72, 21);
			this.numericUpDownTotal.TabIndex = 0;
			this.numericUpDownTotal.ValueChanged += new System.EventHandler(this.NumericUpDownTotal_ValueChanged);
			this.numericUpDownTotal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NumericUpDownTotal_KeyUp);
			// 
			// numericUpDownCorrect
			// 
			this.numericUpDownCorrect.Cursor = System.Windows.Forms.Cursors.Default;
			this.numericUpDownCorrect.Location = new System.Drawing.Point(183, 23);
			this.numericUpDownCorrect.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numericUpDownCorrect.Name = "numericUpDownCorrect";
			this.numericUpDownCorrect.Size = new System.Drawing.Size(72, 21);
			this.numericUpDownCorrect.TabIndex = 1;
			this.numericUpDownCorrect.ValueChanged += new System.EventHandler(this.NumericUpDownCorrect_ValueChanged);
			this.numericUpDownCorrect.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NumericUpDownCorrect_KeyUp);
			// 
			// labelTotal
			// 
			this.labelTotal.AutoSize = true;
			this.labelTotal.Location = new System.Drawing.Point(147, 83);
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.Size = new System.Drawing.Size(29, 12);
			this.labelTotal.TabIndex = 2;
			this.labelTotal.Text = "총합";
			// 
			// labelO
			// 
			this.labelO.AutoSize = true;
			this.labelO.Location = new System.Drawing.Point(17, 83);
			this.labelO.Name = "labelO";
			this.labelO.Size = new System.Drawing.Size(29, 12);
			this.labelO.TabIndex = 3;
			this.labelO.Text = "정답";
			// 
			// labelX
			// 
			this.labelX.AutoSize = true;
			this.labelX.Location = new System.Drawing.Point(17, 110);
			this.labelX.Name = "labelX";
			this.labelX.Size = new System.Drawing.Size(29, 12);
			this.labelX.TabIndex = 4;
			this.labelX.Text = "오답";
			// 
			// labelAvg
			// 
			this.labelAvg.AutoSize = true;
			this.labelAvg.Location = new System.Drawing.Point(147, 110);
			this.labelAvg.Name = "labelAvg";
			this.labelAvg.Size = new System.Drawing.Size(29, 12);
			this.labelAvg.TabIndex = 5;
			this.labelAvg.Text = "평균";
			// 
			// textBoxTotal
			// 
			this.textBoxTotal.Location = new System.Drawing.Point(183, 80);
			this.textBoxTotal.Name = "textBoxTotal";
			this.textBoxTotal.ReadOnly = true;
			this.textBoxTotal.Size = new System.Drawing.Size(72, 21);
			this.textBoxTotal.TabIndex = 6;
			// 
			// textBoxO
			// 
			this.textBoxO.Location = new System.Drawing.Point(53, 80);
			this.textBoxO.Name = "textBoxO";
			this.textBoxO.ReadOnly = true;
			this.textBoxO.Size = new System.Drawing.Size(72, 21);
			this.textBoxO.TabIndex = 7;
			// 
			// textBoxX
			// 
			this.textBoxX.Location = new System.Drawing.Point(53, 107);
			this.textBoxX.Name = "textBoxX";
			this.textBoxX.ReadOnly = true;
			this.textBoxX.Size = new System.Drawing.Size(72, 21);
			this.textBoxX.TabIndex = 8;
			// 
			// textBoxAvg
			// 
			this.textBoxAvg.Location = new System.Drawing.Point(183, 107);
			this.textBoxAvg.Name = "textBoxAvg";
			this.textBoxAvg.ReadOnly = true;
			this.textBoxAvg.Size = new System.Drawing.Size(72, 21);
			this.textBoxAvg.TabIndex = 9;
			// 
			// labelControl1
			// 
			this.labelControl1.AutoSize = true;
			this.labelControl1.Location = new System.Drawing.Point(17, 25);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(29, 12);
			this.labelControl1.TabIndex = 10;
			this.labelControl1.Text = "총합";
			// 
			// labelControl2
			// 
			this.labelControl2.AutoSize = true;
			this.labelControl2.Location = new System.Drawing.Point(147, 25);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(29, 12);
			this.labelControl2.TabIndex = 11;
			this.labelControl2.Text = "정답";
			// 
			// buttonClear
			// 
			this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonClear.Location = new System.Drawing.Point(101, 151);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 23);
			this.buttonClear.TabIndex = 12;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
			// 
			// labelCopyright
			// 
			this.labelCopyright.AutoSize = true;
			this.labelCopyright.Location = new System.Drawing.Point(12, 186);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new System.Drawing.Size(259, 12);
			this.labelCopyright.TabIndex = 13;
			this.labelCopyright.Text = "Copyright (C) 2019. RWB. All Rights Reserve.";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(279, 206);
			this.Controls.Add(this.labelCopyright);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.textBoxAvg);
			this.Controls.Add(this.textBoxX);
			this.Controls.Add(this.textBoxO);
			this.Controls.Add(this.textBoxTotal);
			this.Controls.Add(this.labelAvg);
			this.Controls.Add(this.labelX);
			this.Controls.Add(this.labelO);
			this.Controls.Add(this.labelTotal);
			this.Controls.Add(this.numericUpDownCorrect);
			this.Controls.Add(this.numericUpDownTotal);
			this.Name = "Main";
			this.Text = "Score Calculator";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCorrect)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numericUpDownTotal;
		private System.Windows.Forms.NumericUpDown numericUpDownCorrect;
		private System.Windows.Forms.Label labelTotal;
		private System.Windows.Forms.Label labelO;
		private System.Windows.Forms.Label labelX;
		private System.Windows.Forms.Label labelAvg;
		private System.Windows.Forms.TextBox textBoxTotal;
		private System.Windows.Forms.TextBox textBoxO;
		private System.Windows.Forms.TextBox textBoxX;
		private System.Windows.Forms.TextBox textBoxAvg;
		private System.Windows.Forms.Label labelControl1;
		private System.Windows.Forms.Label labelControl2;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Label labelCopyright;
	}
}

