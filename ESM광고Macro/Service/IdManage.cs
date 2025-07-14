using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESM광고Macro.Resources;

namespace ESM광고Macro.Service
{
    internal class IdManage
    {
        
        public static List<Userdata> IDPWDinput(TextBox ID, TextBox Password, DataGridView grid)
        {
            string inputID = ID.Text.Trim();
            string inputPassword = Password.Text.Trim();

            if (!string.IsNullOrEmpty(inputID))
            {
                grid.Rows.Add(inputID, inputPassword);
                Userdata.SetUserData(inputID, inputPassword);
                ID.Clear();
                Password.Clear();
            }
            else
            {
                MessageBox.Show("내용을 입력하세요.");
            }
            return Userdata.GetAllUserdatas();
        }

        public static void SaveUserListToCsv(List<Userdata> userList, string filePath)
        {     
            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // 헤더 쓰기
                sw.WriteLine("ID,Password");

                // 내용 쓰기
                foreach (var user in userList)
                {
                    string line = $"{user.GetUserID()},{user.GetUserPassWord()}";
                    sw.WriteLine(line);
                }
            }
        }


    }

}



