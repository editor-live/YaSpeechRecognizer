﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaSpeechRecognizer.classes
{
    internal class class_Logger : ILogger
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss:ff")}] {logLevel}: {state} {exception}");
        }
    }
}
