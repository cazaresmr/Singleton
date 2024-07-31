using System;

namespace Singleton
{
    public class ClassicSingletonLogger : SingletonBase
    {
        private static ClassicSingletonLogger? instance;

        private ClassicSingletonLogger()
        {
        }

        public static ClassicSingletonLogger GetInstance
        {
            get
            {
                lock (typeof(ClassicSingletonLogger))
                {
                    if (instance == null)
                    {
                        instance = new ClassicSingletonLogger();
                    }
                    return instance;
                }
            }
        }
    }
}