﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYKernel.OS.Common.Models.Mixed.AlgoRule
{
    /// <summary>
    /// 多个课时有相同的开始课位（时间）
    /// </summary>
    public class ClassHoursSameStartingHourRule: BaseRule
    {
        public int[] ID { get; set; }

        /// <summary>
        /// 权重
        /// </summary>
        public int Weight { get; set; }
    }
}
