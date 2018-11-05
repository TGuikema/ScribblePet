using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonsterPartSelectionManager : MonoBehaviour {

    public List<GameObject> MonsterPartSelectionStages = new List<GameObject>();

    int index = 0;

    public void NextGRP()
    {

        MonsterPartSelectionStages[index].SetActive(false);
        index++;
        MonsterPartSelectionStages[index].SetActive(true);

        if (index > MonsterPartSelectionStages.Count)
        {
            MonsterCompleted();
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
