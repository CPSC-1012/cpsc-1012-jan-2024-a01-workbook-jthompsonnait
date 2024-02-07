using System;
using System.Runtime.InteropServices;

class Program
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MOUSE_EVENT_RECORD
    {
        public COORD MousePosition;
        public uint ButtonState;
        public uint ControlKeyState;
        public uint EventFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct COORD
    {
        public short X;
        public short Y;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct INPUT_RECORD
    {
        [FieldOffset(0)]
        public short EventType;
        [FieldOffset(4)]
        public MOUSE_EVENT_RECORD MouseEvent;
    }

    [DllImport("kernel32.dll")]
    public static extern bool ReadConsoleInput(
        IntPtr hConsoleInput,
        [Out] INPUT_RECORD[] lpBuffer,
        uint nLength,
        out uint lpNumberOfEventsRead);

    [DllImport("kernel32.dll")]
    public static extern IntPtr GetStdHandle(int nStdHandle);

    [DllImport("kernel32.dll")]
    public static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);

    const int STD_INPUT_HANDLE = -10;
    const uint ENABLE_MOUSE_INPUT = 0x0010;
    const short KEY_EVENT = 1;
    const short MOUSE_EVENT = 2;

    static void Main(string[] args)
    {
        IntPtr consoleHandle = GetStdHandle(STD_INPUT_HANDLE);
        SetConsoleMode(consoleHandle, ENABLE_MOUSE_INPUT);

        INPUT_RECORD[] inputRecords = new INPUT_RECORD[1];
        uint eventsRead = 0;

        while (true)
        {
            ReadConsoleInput(consoleHandle, inputRecords, 1, out eventsRead);

            if (inputRecords[0].EventType == MOUSE_EVENT)
            {
                Console.WriteLine("Mouse event: " +
                                  $"X={inputRecords[0].MouseEvent.MousePosition.X}, " +
                                  $"Y={inputRecords[0].MouseEvent.MousePosition.Y}");
            }
        }
    }
}