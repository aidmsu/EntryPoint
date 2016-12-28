﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

using EntryPoint;
using Xunit;
using EntryPointTests.AppOptionModels;

namespace EntryPointTests {
    public class HelpTests {
        [Fact]
        public void Help_CheckRequiredDoesNotThrow_Std() {
            string[] args = new string[] {
                "--help"
            };

            // Check this doesn't throw because of Required validation
            EntryPointApi.Parse<HelpWithRequiredArgsModel>(args);
        }

        [Fact]
        public void Help_CheckRequiredDoesNotThrow_OtherParams() {
            string[] args = new string[] {
                "-o", "name", "--help"
            };

            // Check this doesn't throw because of Required validation
            // Also check it doesn't throw because of an option being included
            // Behaviour: --help will take control
            EntryPointApi.Parse<HelpWithRequiredArgsModel>(args);
        }

        [Fact]
        public void Help_CheckRequiredDoesNotThrow_RequiredProvided() {
            string[] args = new string[] {
                "-r", "1", "--help"
            };

            // Check this doesn't throw because of an option being included
            // Behaviour: --help will take control
            EntryPointApi.Parse<HelpWithRequiredArgsModel>(args);
        }
    }
}
