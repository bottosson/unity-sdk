using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class Application 
    {
        public static bool isPlaying { get; }
    }
    public class Component : Object
    { }
    public class Coroutine { }
    public class GameObject : Object
    { 
        public GameObject(string name) { throw new NotImplementedException(); }
        public T AddComponent<T>() where T : Component { throw new NotImplementedException(); }
    }
    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
    public class HideInInspectorAttribute : System.Attribute {}
    public class ScriptableObject : Object
    {
        public static T CreateInstance<T>() where T : ScriptableObject { throw new NotImplementedException(); }
    }
    public class Texture2D { }

    namespace SceneManagement 
    {
        class PrivateClassToMakeUsingStatementNotFail { }
    }
    namespace Events 
    {
        class PrivateClassToMakeUsingStatementNotFail { }
    }
    namespace UI 
    {
        public class Image { }
    }
    namespace Networking
    {
        public class UnityWebRequestAsyncOperation { }
    }
}
