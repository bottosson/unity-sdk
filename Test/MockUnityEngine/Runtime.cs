using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MockUnityEngine
{
    public static class Runtime
    {
        public static void Tick()
        {
            for (int i = s_coroutines.Count - 1; i >= 0; i--)
            {
                IEnumerator coroutine = s_coroutines[i];
                if (!coroutine.MoveNext())
                    s_coroutines.RemoveAt(i);

                // Todo: Do we need to implement behaviour based on coroutine.Current here or can it be ignored in all cases?
            }

            // Todo: Update the Time class
        }

        internal static void StartCoroutine(IEnumerator coroutine)
        {
            if (coroutine.MoveNext())
                s_coroutines.Add(coroutine);
        }

        static List<IEnumerator> s_coroutines = new List<IEnumerator>();
    }
}