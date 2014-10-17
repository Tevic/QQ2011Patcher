using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QQ2011_Patcher
{
    //定义HexByte结构体
    public struct HexByte
    {
        internal String Offset;
        internal String Content;
        public HexByte(String offset,String content)
        {
            Offset = offset;
            Content = content;
        }
    }
}
