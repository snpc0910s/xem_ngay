using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xem_Ngay.model.ngu_hanh
{
    public interface NguHanh
    {
        NguHanh sinh();
        NguHanh khac();

        NguHanh biKhacBoi();

        NguHanh duocSinhBoi();

    }
}
