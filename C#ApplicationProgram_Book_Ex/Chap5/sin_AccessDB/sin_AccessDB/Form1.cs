using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // .Net FrameWork Data Provider for OLE DB 이다.
using System.Diagnostics.Contracts;

namespace sin_AccessDB
{
    public partial class Form1 : Form
    {
        // 먼저 database로 사용할 accdb(Access Data Base) 파일을 프로젝트폴더\bin\Debug 폴더에 Human.accdb 라고 생성해야한다.


        string ConSql = ""; // MS ACCESS 연결문

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cbSex.Text = "Male";
            this.cbBlood.Text = "A";

            string DbPath = Application.StartupPath;
            ConSql = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DbPath + @"\Human.accdb;Mode=ReadWrite";

            /*
            MS ACCESS 버전별 접속 방법
            - MS office 2003
            "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Human.mdb"
            - MS Office 2007/2010/2013
            "Provider" +
            "Microsoft.ACE.OLEDB.12.0;Data Source=C:\Human.accdb;Mode=ReadWrite"

            * Data Source : MS Access 데이터베이스 파일의 절대 경로를 나타낸다.
             */

            lvViewListUp();
        }

        // 초기 데이터 불러오기
        private void lvViewListUp()
        {
            int ItemsCount = 1;
            this.lvView.Items.Clear();
            var Conn = new OleDbConnection(ConSql);
            Conn.Open();

            var Comm = new OleDbCommand("Select * from HumanTable", Conn);
            var myRead = Comm.ExecuteReader();

            while (myRead.Read())
            {
                string[] ReadArray = new string[]
                {
                    ItemsCount.ToString(), myRead[0].ToString(), myRead[1].ToString()
                    , myRead[2].ToString() , myRead[3].ToString()
                    , myRead[4].ToString() , myRead[5].ToString()
                    , myRead[6].ToString()
                };
                this.lvView.Items.Add(new ListViewItem(ReadArray));
                ItemsCount++;
            }
            // Close() 메서드를 이용하여 사용한 개체의 리소스를 해제하는 작업 시행
            myRead.Close();
            Conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text != "")
            {
                this.txtId.Text = "";
                this.txtName.Text = "";
                this.txtAge.Text = "";
                this.cbSex.Text = "Male";
                this.cbBlood.Text = "A";
                this.txtBirth.Text = "";
                this.txtPhone.Text = "";
                return;
            }
            if (TxtCheck() == true)
            {
                var Conn = new OleDbConnection(ConSql);
                Conn.Open();

                string Sql = "Insert into HumanTable(H_Name, H_Age, "
                    + "H_Sex, H_Blood, H_Birth, H_Phone)";
                Sql += "values(" + this.txtName.Text + ", " + this.txtAge.Text
                    + ", " + this.cbSex.Text + ", ";
                Sql += "" + this.cbBlood.Text + ", " + this.txtBirth.Text
                    + ", " + this.txtPhone.Text + ")";
                var Comm = new OleDbCommand(Sql, Conn);
                int i = Comm.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("정상적으로 정보가 추가되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lvViewListUp();
                }
                else
                {
                    MessageBox.Show("정보가 추가되지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool TxtCheck()
        {
            string ConName = "";
            if (this.txtName.Text == "")
                ConName = "이름";
            else if (this.txtAge.Text == "")
                ConName = "나이";
            else if (this.txtBirth.Text == "")
                ConName = "생년월일";
            else if (this.txtPhone.Text == "")
                ConName = "전화번호";

            if (ConName == "")
                return true;
            else
            {
                MessageBox.Show(ConName + "이(가) 입력되지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void lvView_Click(object sender, EventArgs e)
        {
            if (this.lvView.SelectedItems.Count > 0)
            {
                int n = 0;
                this.txtId.Text = this.lvView.Items[n].SubItems[0].Text;

            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (this.lvView.SelectedItems.Count == 0)
            {
                MessageBox.Show("수정할 정보가 선택되지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var dlg = MessageBox.Show("수정하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(dlg == DialogResult.Yes)
                {
                    if (TxtCheck() == true)
                    {
                        var Conn = new OleDbConnection(ConSql);
                        Conn.Open();

                        string Sql = "Update HumanTable set H_Name = " + this.txtName.Text
                            + ", H_Age = " + this.txtAge.Text + ", ";
                        Sql += "H_Sex = " + this.cbSex.Text
                            + ", H_Blood = " + this.cbBlood.Text + ", ";
                        Sql += "H_Birth = " + this.txtBirth.Text
                            + ", H_Phone = " + this.txtPhone.Text + "";
                        Sql += "where H_ID = " + Convert.ToInt32(txtId.Text) + "";
                        var Comm = new OleDbCommand(Sql, Conn);
                        int i = Comm.ExecuteNonQuery();

                        if (i == 1)
                        {
                            MessageBox.Show("정상적으로 정보가 수정되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lvViewListUp();
                        }
                        else
                        {
                            MessageBox.Show("정보가 수정되지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        Conn.Close();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lvView.SelectedItems.Count == 0)
            {
                MessageBox.Show("삭제할 정보가 선택되지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var dlg = MessageBox.Show("삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(dlg == DialogResult.Yes)
                {
                    var Conn = new OleDbConnection(ConSql);
                    Conn.Open();

                    string Sql = "Delete from HumanTable H_ID = "
                        + Convert.ToInt32(txtId.Text) + "";

                    var Comm = new OleDbCommand(Sql, Conn);
                    int i = Comm.ExecuteNonQuery();

                    if (i == 1)
                    {
                        MessageBox.Show("정상적으로 정보가 삭제되었씁니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lvViewListUp();
                    }
                    else
                    {
                        MessageBox.Show("정보가 삭제되지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
