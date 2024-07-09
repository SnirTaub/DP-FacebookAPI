using System;
using System.Reflection;

namespace BasicFacebookFeatures.Logic
{
    public static class Singleton<T>
        where T : class
    {
        private static T s_Instance = null;
        private static object s_LockObject = new object();

        static Singleton()
        {
        }

        public static T Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObject)
                    {
                        if (s_Instance == null)
                        {
                            Type typeOfT = typeof(T);
                            try
                            {
                                s_Instance = typeOfT.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic,
                                    null, Type.EmptyTypes, null).Invoke(null) as T;
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                        }
                    }
                }

                return s_Instance;
            }
        }
    }
}