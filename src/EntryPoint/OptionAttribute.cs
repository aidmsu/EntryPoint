﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using EntryPoint.Internals;
using EntryPoint.OptionStrategies;

namespace EntryPoint {

    /// <summary>
    /// Declares a standard Option argument which can either be On or Off
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Property,
        AllowMultiple = false,
        Inherited = true)]
    public class OptionAttribute : BaseOptionAttribute {
        public OptionAttribute() : base(OptionStrategyFactory.Option) { }
    }

}
