using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class TextManager : MonoBehaviour {

    public Text TextObject;
    public List<string> TextList = new List<string>();

    int TextIndex = 0;
    /// <summary>
    /// Operators: (Not to be confused with Bit Operators.) 
    /// ==
    ///  !=
    ///  >=
    ///  <=
    ///  >
    ///  <
    ///  
    /// </summary>
    /// 

	public void SolveTextContinueButton()
    {
       
       Debug.Log("reached");
       
       

        if (TextIndex >= TextList.Count)
        {

            ContinueToCC();
            return;
        }
        TextObject.text = TextList[TextIndex];
        TextIndex++;
    }

    public UnityEvent OnTutorialTextCompleted;

    public void ContinueToCC()
    {
        Debug.Log("Tutorial Done.");

        if (OnTutorialTextCompleted != null)
            OnTutorialTextCompleted.Invoke();

    }
}
