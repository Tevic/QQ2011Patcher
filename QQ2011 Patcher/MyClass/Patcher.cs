using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace QQ2011_Patcher
{
    class Patcher
    {
        private String filePath;

        public Patcher(String filepath)
        {
            filePath = filepath;
        }

        public void ModKernelUtil()
        {
            //3D182:        FF        90
            //3D183:        15        90
            //3D184:        84        68
            //3D185:        40        DC
            //3D186:        86        BE
            //3D187:        31        86
            //3D188:        50        31
            List<HexByte> hexList = new List<HexByte>();
            hexList.Add(new HexByte("3D182", "90"));
            hexList.Add(new HexByte("3D183", "90"));
            hexList.Add(new HexByte("3D184", "68"));
            hexList.Add(new HexByte("3D185", "DC"));
            hexList.Add(new HexByte("3D186", "BE"));
            hexList.Add(new HexByte("3D187", "86"));
            hexList.Add(new HexByte("3D188", "31"));
            FileOperation.Modify(filePath+"\\KernelUtil.dll", hexList);
        }

        public void ModIM()
        {
            //289882:        74        90
            //289883:        60        90
            //289899:        74        EB
            List<HexByte> hexList = new List<HexByte>();
            hexList.Add(new HexByte("289882", "90"));
            hexList.Add(new HexByte("289883", "90"));
            hexList.Add(new HexByte("289899", "EB"));
            FileOperation.Modify(filePath+"\\IM.dll", hexList);
        }

        public void ModAppMisc()
        {
            //10B500:        55        C3
            //10D244:        75        EB
            //10D245:        5C        6D
            List<HexByte> hexList = new List<HexByte>();
            hexList.Add(new HexByte("10B500", "C3"));
            hexList.Add(new HexByte("10D244", "EB"));
            hexList.Add(new HexByte("10D245", "6D"));
            FileOperation.Modify(filePath+"\\AppMisc.dll",hexList);
        }

        public void ModAppUtil()
        {
            //6260:        55        C3
            List<HexByte> hexList = new List<HexByte>();
            hexList.Add(new HexByte("6260", "C3"));
            FileOperation.Modify(filePath+"\\AppUtil.dll", hexList);
        }

        public void ModChatFrameApp()
        {
            //AD50:        55        C3
            List<HexByte> hexList = new List<HexByte>();
            hexList.Add(new HexByte("AD50", "C3"));
            FileOperation.Modify(filePath + "\\ChatFrameApp.dll", hexList);
        }

        public void ModMsgMgr()
        {
            //2BCB0:        55        C3
            List<HexByte> hexList = new List<HexByte>();
            hexList.Add(new HexByte("2BCB0", "C3"));
            FileOperation.Modify(filePath + "\\MsgMgr.dll", hexList);
        }

        //本地会员
        public void LocalVIP()
        {
            Byte[] localVIPDll = Properties.Resources.LocalVIP;
            File.WriteAllBytes(filePath + "\\LocalVIP.dll", localVIPDll);
            Byte[] msimg32Dll = Properties.Resources.msimg32;
            File.WriteAllBytes(filePath + "\\msimg32.dll", msimg32Dll);
        }
    }
}
