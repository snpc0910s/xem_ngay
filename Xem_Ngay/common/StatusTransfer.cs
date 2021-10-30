using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xem_Ngay.common
{
    public class StatusTransfer<T>
    {
        public bool status;
        public T data;
        public String message;

        public StatusTransfer()
        {
            this.status = false;
            this.data = default(T);
            this.message = "";
        }
    }
}
