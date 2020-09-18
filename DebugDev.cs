using System;
using System.Data;

namespace Commons.Client
{
    public static class DebugDev
    {
        public static void Write(string data)
        {
        }

        public static void Write(string format, params object[] args)
        {
            DebugDev.Write(string.Format(format, args));
        }

        public static void WriteLine()
        {
            DebugDev.Write("\n");
        }

        public static void WriteLine(string data)
        {
            DebugDev.Write(data + "\n");
        }

        public static void WriteLine(string format, params object[] args)
        {
            DebugDev.Write(string.Format(format, args) + "\n");
        }
    }
}
