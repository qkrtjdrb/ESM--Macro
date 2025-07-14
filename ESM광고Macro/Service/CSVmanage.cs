using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using ESM광고Macro.Resources;

namespace ESM광고Macro.Service
{
    internal class ReadCSV
    {
        private static List<Userdata> LoadCSVtoList(string filepath)
        {
            Userdata userdata = new Userdata();
            var lines = File.ReadAllLines(filepath, Encoding.UTF8);
            for (int i = 1; i < lines.Length; i++) // i=1 → 첫 줄은 헤더이므로 건너뜀
            {
                string[] parts = lines[i].Split(',');

                if (parts.Length >= 2)
                {
                    Userdata.SetUserData(parts[0].Trim(), parts[1].Trim());
                }
            }
            return Userdata.GetAllUserdatas();
        }

        public void FindFilePath(DataGridView dgv, List<Userdata> userdatas)
        {
            //MessageBox.Show("현재 작업 디렉터리: " + Environment.CurrentDirectory);
            try
            {
                string[] csvFiles = Directory.GetFiles(".","아이디비번.csv");
                if (csvFiles.Length == 0) 
                    throw new FileNotFoundException("CSV파일이 없습니다 추가 버튼을 통해 새로 생성하십시오");
                string selectedFIle = csvFiles[0];
                userdatas = LoadCSVtoList(selectedFIle);
                FilltoGrid(dgv, userdatas);
                MessageBox.Show($"자동 불러오기 완료: {Path.GetFileName(selectedFIle)}");
            }
            catch (Exception)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "CSV 파일 (*.csv)|*.csv";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        userdatas = LoadCSVtoList(ofd.FileName);
                        FilltoGrid(dgv, userdatas);
                        MessageBox.Show("불러오기 완료!");
                    }
                }
            }

        }      


        public void FilltoGrid(DataGridView dgv,List<Userdata> userdatas)
        {
            dgv.Rows.Clear();

            foreach (Userdata userdata in userdatas)
            {
                dgv.Rows.Add(userdata.GetUserID(), userdata.GetUserPassWord());
            }
        }
    }
}
