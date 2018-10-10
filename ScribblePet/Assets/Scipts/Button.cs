using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace TGuikema
{
    [RequireComponent(typeof(UnityEngine.UI.Image))]
    public class Button : MonoBehaviour, IPointerClickHandler
    {
        public UnityEvent OnButtonClick;

        //public MyVeryFirstScript mvfs;


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


        public virtual void Click() {
            //int strokes = mvfs.StrokeCat(5);
        }

    }



























    /*
    private void Awake()
    {
        
    }
    // Use this for initialization
    void Start () {
        
        //if (mvfs == null)
        //   mvfs = GetComponent<MyVeryFirstScript>();

        //mvfs.MyInt += 5;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

   // public MyVeryFirstScript mvfs;
    private void Reset()
    {
        //if (mvfs == null)
        //    mvfs = GetComponent<MyVeryFirstScript>();

    }*/
}
