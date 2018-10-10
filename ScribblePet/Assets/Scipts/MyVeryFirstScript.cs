using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TGuikema
{
    
    public class MyVeryFirstScript : MonoBehaviour
    {
        //[HideInInspector] // Hides the next line of code in the Inspector.
        //public int Strokes = 10;
        public MyButton P_Button; // Reference to an object with the script 'MyButton'.
        private void Reset() { P_Button = GetComponent<MyButton>(); }

        /*
         * Summary: Example.
        public int StrokeCat(int amount)
        {
            Debug.Log("Stroked cat " + amount + " times.");

            int remaining = amount;
            remaining -= Random.Range(0, amount);

            return remaining;
        }

        public int GetStrokes()
        {
            return Strokes;
        }
        */

        private void OnEnable()
        {
            Debug.Log("Enabled");
            P_Button.OnButtonClick.AddListener(Interact); // On click adds as it were a subscription to the button. In this case the Interact.
        }
        private void OnDisable()
        {
            Debug.Log("Disabled");
            P_Button.OnButtonClick.RemoveListener(Interact);
        }





        public int MyInt = 5;
        public void Showcase()
        {
            int[] intArray = new int[2] { 0, 2 };
            int test = intArray[5];
            Debug.LogError("THIS FUCKING MOUSE");
        }



        public void Interact()
        {
            Debug.LogWarning("Interacting");
        }

        public void Hello(string name)
        {
            Debug.Log("Hello " + name);
        }
    }
}