using System;
using System.Collections;

namespace UnityEngine
{
    public class MonoBehaviour : Component
    {
        public GameObject gameObject { get; }
        public static void DontDestroyOnLoad(Object target) {}
        public Coroutine StartCoroutine(IEnumerator routine)
        {
            MockUnityEngine.Runtime.StartCoroutine(routine);
            return null;
        }
    }
}
