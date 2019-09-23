using System;
using System.Windows.Forms;

// 정보처리기사 채점용 계산기
namespace ScoreCalculator
{
    // Main Form Class
	public partial class Main : Form
	{
		private int totalNum = 0;
		private int correctNum = 0;
		private int X = 0;
		private double average = 0;

        // Form Initialize
		public Main()
		{
			InitializeComponent();
		}

        // 총합 갯수 증감
		private void NumericUpDownTotal_ValueChanged(object sender, EventArgs e)
		{
			totalNum = Convert.ToInt32(numericUpDownTotal.Value);
			textBoxTotal.Text = totalNum.ToString();

			Calculate();
		}

        // 정답 갯수 증감
		private void NumericUpDownCorrect_ValueChanged(object sender, EventArgs e)
		{
			correctNum = Convert.ToInt32(numericUpDownCorrect.Value);
			textBoxO.Text = correctNum.ToString();

			Calculate();
		}

        // 총합 갯수 입력
		private void NumericUpDownTotal_KeyUp(object sender, KeyEventArgs e)
		{
            // 총합 갯수 증감 처리
			NumericUpDownTotal_ValueChanged(sender, e);
		}

        // 정답 갯수 입력
		private void NumericUpDownCorrect_KeyUp(object sender, KeyEventArgs e)
		{
            // 정답 갯수 증감 처리
			NumericUpDownCorrect_ValueChanged(sender, e);
		}

		// 초기화 버튼
		private void ButtonClear_Click(object sender, EventArgs e)
		{
			numericUpDownTotal.Value = 0;
			numericUpDownCorrect.Value = 0;
		}

		// 점수 계산
		private void Calculate()
		{
            // 총합, 정답이 전부 0일 경우
			if (totalNum == 0 && correctNum == 0)
			{
                textBoxTotal.Text = "";
                textBoxO.Text = "";
                textBoxX.Text = "";
                textBoxAvg.Text = "";
			}

            // 총합만 0일 경우
			else if (totalNum == 0 && correctNum != 0)
			{
				numericUpDownCorrect.Value = 0;
				numericUpDownTotal.Focus();
			}

            // 총합보다 정답이 클 경우
			else if (totalNum < correctNum)
			{
                // 정답의 갯수를 총합으로 제한
				numericUpDownCorrect.Value = totalNum;
				textBoxO.Text = totalNum.ToString();
			}

            // 모든 검증에 부합할 경우
			else
			{
				X = totalNum - correctNum;
				average = Math.Round(Convert.ToDouble(correctNum) / Convert.ToDouble(totalNum) * 100, 2);

				textBoxX.Text = X.ToString();
				textBoxAvg.Text = average.ToString() + "%";
			}
		}
	}
}