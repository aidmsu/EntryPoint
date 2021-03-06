﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using EntryPoint;
using EntryPoint.Exceptions;
using Xunit;
using EntryPointTests.Arguments.AppOptionModels;

namespace EntryPointTests.Arguments {
    public class IntegerArguments {
        [Fact]
        public void NotProvided() {
            string[] args = new string[] { };

            var model = Cli.Parse<IntegerArgsModel>(args);

            Assert.StrictEqual(null, model.DefaultNull);
            Assert.StrictEqual(0, model.DefaultZero);
            Assert.StrictEqual(7, model.Default7);
        }

        [Fact]
        public void Normal() {
            string[] args = new string[] {
                "--default-null", "1",
                "--default-zero", "2",
                "--default-7", "3"
            };

            var model = Cli.Parse<IntegerArgsModel>(args);

            Assert.StrictEqual(1, model.DefaultNull);
            Assert.StrictEqual(2, model.DefaultZero);
            Assert.StrictEqual(3, model.Default7);
        }

        [Fact]
        public void InvalidType() {
            string[] args = new string[] {
                "--default-null", "1",
                "--default-zero", "2",
                "--default-7", "FAIL"
            };

            Assert.Throws<VariableTypeException>(
                () => Cli.Parse<IntegerArgsModel>(args));
        }

        [Fact]
        public void NoParameter_DefaultNull() {
            string[] args = new string[] {
                "--default-null",
                "--default-zero", "2",
                "--default-7", "3"
            };

            Assert.Throws<NoParameterException>(
                () => Cli.Parse<IntegerArgsModel>(args));
        }

        [Fact]
        public void NoParameter_DefaultNoName() {
            string[] args = new string[] {
                "--default-null", "1",
                "--default-zero", "2",
                "--default-7"
            };

            Assert.Throws<NoParameterException>(
                () => Cli.Parse<IntegerArgsModel>(args));
        }
    }
}
