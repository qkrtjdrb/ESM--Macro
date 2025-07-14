using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESM광고Macro.Resources
{
    internal class Userdata
    {
        private string ID { get; set; }
        private string PassWord { get; set; }

        private static List<Userdata> userdatas = new List<Userdata>();

        // 리스트에 있는 모든 Userdata 정보를 반환하는 함수
        public static List<Userdata> GetAllUserdatas()
        {
            return userdatas;
        }
        
        
        // 특정 ID와 비밀번호를 설정하는 함수
        public static void SetUserData(string id, string password)
        {
            userdatas.Add(new Userdata { ID = id, PassWord = password });
        }

        public string GetUserID() { return ID; }
        public string GetUserPassWord() { return PassWord; }


    }

    
}
