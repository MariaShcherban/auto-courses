using System;

namespace SingleInstance
{
    public class SingleClass
    {
        private SingleClass() { }
        private static readonly SingleClass single = new SingleClass();
        public static SingleClass GetInstance() => single;
    }
}
