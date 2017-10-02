﻿using System;

namespace Neutronium.MVVMComponents.Relay
{
    /// <summary>
    /// ISimpleCommand implmentation based on an action taking one argument
    /// <seealso cref="ISimpleCommand"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RelaySimpleCommand<T> : ISimpleCommand<T> where T:class
    {
        private readonly Action<T> _Do;

        public RelaySimpleCommand(Action<T> doAction)
        {
            _Do = doAction;
        }

        public void Execute(T argument)
        {
            _Do(argument as T);
        }
    }
}
