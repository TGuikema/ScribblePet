using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonsterPartSelectionManager : MonoBehaviour {

    public List<GameObject> MonsterPartSelectionStages = new List<GameObject>();

    int index = 0;

    public void NextGRP()
    {
        MonsterPartSelectionStages[index].SetActive(false); //Set current MonsterPart to Innactive.
        if (index >= MonsterPartSelectionStages.Count - 1)
        {
            //Debug.Log("Does this only activate on max?");
            MonsterCompleted();
        }
        else
        {
            MonsterPartSelectionStages[index + 1].SetActive(true);  //Set next MonsterPart to Active. 
            index++;
        }
    }



    public UnityEvent OnMonsterCompleted;

    private void MonsterCompleted()
    {
        Debug.Log("Monster completed");

        if (OnMonsterCompleted != null)
            OnMonsterCompleted.Invoke();
    }
}
