using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sin_Error
{
    // 이 예제는 오류 제어를 설명하기 위해 단순히 오류를 발생시키는 작업을 수행하며, 그 외에는 아무런 작업을 하지 않는다.
    // 버튼을 누르면 에러가 발생된다. 이 에러를 다른 프로그램에서 모니터링 하고 있다가 오류가 발생하면 자동으로 클릭하여 오류를 처리하는
    // 기능을 구현할 것이다.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception("망할책");
            }
            catch (Exception ex)
            {
                ErrorForm errorForm = new ErrorForm();
                errorForm.ErrorText = "에러발생";
                errorForm.ShowDialog();
            }
        }
    }
}
