using UnityEngine;

namespace Lesson_0 
{
    public class HelloWorld : MonoBehaviour
    {
        public string helloStringClassField = "HelloWorld!";
        
        public void WrongStart(){
            PrintHelloWorldMessageABC();
        }

        public void PrintHelloWorldMessageABC()
        {
            Debug.Log(helloStringClassField);
        }
    }
}
