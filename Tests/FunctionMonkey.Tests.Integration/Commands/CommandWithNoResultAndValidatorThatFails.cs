﻿using AzureFromTheTrenches.Commanding.Abstractions;
using FunctionMonkey.Tests.Integration.Commands.Model;

namespace FunctionMonkey.Tests.Integration.Commands
{
    public class CommandWithNoResultAndValidatorThatFails : ICommand
    {
        public int Value { get; set; }
    }
}
