using System;
using System.Windows;

namespace SkorkEngine
{
    /// <summary>
    /// Contains the entry point for <see langword="SkorkEngine"/>.
    /// </summary>
    public class SkorkEngineMain
    {
        public Window SkorkWindow { get; internal set; }

        public SkorkEngineMain(ref Window window)
        {
            if (!window.Tag.GetType().FullName.Equals(GetType().FullName))
            {
                throw new InvalidCastException($"The {window.Tag.GetType().FullName} " +
                    $"window does not match the frameworks " +
                    $"{GetType().FullName}");
            }
            SkorkWindow = window;
        }


    }
}
