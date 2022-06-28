using UnityEngine;

namespace Lesson_0 
{
    public class HelloWorld : MonoBehaviour
    {
        public string helloString = "HelloWorld!";
        
        public void Start(){
            Print();
        }

        public string Print()
        {
            Debug.Log(helloString);
            return helloString;
        }
    }
}
