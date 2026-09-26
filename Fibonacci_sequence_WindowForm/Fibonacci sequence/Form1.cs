namespace Fibonacci_sequence
{
    public partial class frmFibonacci : Form
    {
        public frmFibonacci()
        {
            InitializeComponent();
        }
        private int Fibonacci(int n)
        {
            if (n <= 2)
            {
                return 1;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);   //一直回推直到n<=2，拿到1代入
        }

        /*
         n=5時程式執行流程: 
        Fibonacci(5)
         ↓
        Fibonacci(4) + Fibonacci(3)
         ↓
        Fibonacci(4)
         ↓
        Fibonacci(3) + Fibonacci(2)
         ↓
        Fibonacci(3)
        ↓
        Fibonacci(2) + Fibonacci(1)
        ↓                 n<=2，拿到1代入
        Fibonacci(2) = 1
        Fibonacci(1) = 1
        ↓
        Fibonacci(3) = 2
        ↓
        Fibonacci(4) = 3
        ↓
        Fibonacci(3) = 2
        ↓
        Fibonacci(5) = 5         
         */

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
               
               
                if (String.IsNullOrWhiteSpace(txtUser.Text))
                {
                    MessageBox.Show("請輸入數字");               //防止沒輸入數字
                }
                else if (!int.TryParse(txtUser.Text.Trim(), out int number))
                {
                    MessageBox.Show("請勿輸入輸入數字以外字詞");
                }
                else { 
                    int n = int .Parse(txtUser.Text.Trim());
                    txtShow.Text = Fibonacci(n).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "例外案發生錯誤：" + ex.Message,
                    "系統提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                /*
                 1. 顯示內容,
                 2. 視窗標題,
                 3. 按鈕,
                 4. 圖示
                */
            }
        }
    }
}
