using System;

namespace KPLNETInterface
{
    public interface ILogger
    {
        void trace(string message);
        void debug(string message);
        void info(string message);
        void warn(string message);
        void error(string message);
        void warn(string message, Exception ex);
        void error(string message, Exception ex);
    }
    
}
