﻿using ImaginaryLearning.Core.BaGua;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImaginaryLearning.Core
{
    public class Tai : FuGua
    {
        public Tai(PointF startPoint, int totalWidth, int midWidth, int heigth)
        {
            XiaGua = new Qian(CreateXiaGuaPoint(startPoint,heigth),totalWidth,heigth);
            ShangGua = new Kun(startPoint,totalWidth,midWidth,heigth);
            Name = "泰";
            IsTwelvePIGua = true;
        }
    }
}
