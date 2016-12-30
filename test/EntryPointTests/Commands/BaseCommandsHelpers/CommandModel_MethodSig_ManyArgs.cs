﻿using EntryPoint;
using EntryPointTests.Commands.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntryPointTests.Commands.BaseCommandsHelpers {
    public class CommandModel_MethodSig_ManyArgs : BaseCommands {
        [Command("C1")]
        public void Command1(string[] args, int i) {
            throw new CommandExecutedException("C1");
        }
    }
}