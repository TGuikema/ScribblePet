using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TGuikema //Another way to call on the namespace is: calling 'using <name_namespace>' in library.
{
    [RequireComponent(typeof(UnityEngine.UI.Image))]
    public class MyButton : MonoBehaviour, IPointerClickHandler
    {
        public UnityEvent OnButtonClick;

        //public MyVeryFirstScript mvfs;  // Allows this script to acces MyVeryFirstScript. The referencing being mfvs. Reference to an object with the script 'MyVeryFirstScript'.


        private void Update()
        {


            if (Input.touchCount > 0  // This counts the amount of fingers currently touching the screen.
                &&  // Both conditions, before and after the && sign must be met before the if statement is accepted.
                Input.GetTouch(0).phase
                == TouchPhase.Ended)
            {
                //SolveClick();
                SolveClick(Input.GetTouch(0).position);
            }
        }


        public void OnPointerClick(PointerEventData PED) { SolveClick(PED.position); } // Detect if a click occurs.

        /// <summary>
        /// Calls the click method and onclick event.
        /// </summary>
        /// <param name="position">Position where the click will be solved</param>
        private void SolveClick(Vector2 position)
        {
            ClickPosition(position);
            SolveClick();
        }
        /// <summary>
        /// Calls the click method and onclick event.
        /// </summary>
        private void SolveClick()
        {
            Click();
            if (OnButtonClick != null)
                OnButtonClick.Invoke();
        }

        protected virtual void ClickPosition(Vector2 position) { Debug.Log("Click on position: " + position); }


        public virtual void Click()
        {
            
        }

    }
}


