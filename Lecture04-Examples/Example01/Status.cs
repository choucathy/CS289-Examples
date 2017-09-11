using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public enum Status    //未給值會從0開始計數
    {
        ConnectionSuccess = 1,
        ConnectionError,
        ReadSuccess = 10,
        ReadError
    }
}