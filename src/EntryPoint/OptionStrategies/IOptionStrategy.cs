﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using EntryPoint.Helpers;
using EntryPoint.Parsing;
using EntryPoint.Arguments;

namespace EntryPoint.OptionStrategies {

    internal interface IOptionStrategy {
        object GetValue(Option modelOption, TokenGroup tokenGroup);
        bool RequiresParameter { get; }
    }

}
