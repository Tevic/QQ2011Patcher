using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace QQ2011_Patcher
{
    class FileOperation
    {
        //以16进制格式字节方式修改文件
        public static void Modify(String fileName, String positionHex, String content)
        {
            BackUp(fileName);
            Int32 positionInt32 = Convert.ToInt32(positionHex, 16);
            FileStream fsR = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            Byte[] data = new Byte[fsR.Length];
            fsR.Read(data, 0, data.Length);
            fsR.Close();
            data[positionInt32] = Convert.ToByte(content, 16);
            FileStream fsW = new FileStream(fileName, FileMode.Open, FileAccess.Write);
            fsW.Write(data, 0, data.Length);
            fsW.Close();
        }

        //以16进制格式连续修改文件
        public static void Modify(String fileName, List<HexByte> list)
        {
            BackUp(fileName);
            FileStream fsR = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            Byte[] data = new Byte[fsR.Length];
            fsR.Read(data, 0, data.Length);
            fsR.Close();
            foreach (var item in list)
            {
                Int32 offset = Convert.ToInt32(item.Offset, 16);
                data[offset] = Convert.ToByte(item.Content, 16);
            }
            FileStream fsW = new FileStream(fileName, FileMode.Open, FileAccess.Write);
            fsW.Write(data, 0, data.Length);
            fsW.Close();
        }

        //备份原文件
        private static void BackUp(String fileName)
        {
            if (File.Exists(fileName))
            {
                if (!File.Exists(fileName + ".Bak"))
                {
                    File.Copy(fileName, fileName + ".Bak");
                }
            }
        }
    }
}
