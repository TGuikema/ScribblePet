using UnityEngine;
using Vuforia;
using System.Collections;
public class ExampleActivation : MonoBehaviour, ITrackableEventHandler
{
    public Sprite NewSprite;
    private TrackableBehaviour mTrackableBehaviour;
    public Transform myModelPrefab;
    // Use this for initialization
    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            OnTrackingFound();
    }

    public void OnTrackableStateChanged(
      TrackableBehaviour.Status previousStatus,
      TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            OnTrackingFound();
        }
    }

    public Color[] colorArray;
    public int Index = 0;
    public int ActualIndex = 0;
    private void OnTrackingFound()
    {
        Debug.Log("LEL");
        if (myModelPrefab != null)
        {
            Debug.Log("LELOY");
            Transform myModelTrf = GameObject.Instantiate(myModelPrefab).transform;
            //myModelTrf.parent = mTrackableBehaviour.transform;
            myModelTrf.gameObject.GetComponent<MeshRenderer>().material.color = colorArray[Index];
            Index++;

            if (Index >= colorArray.Length)
                Index = 0;


            myModelTrf.position = new Vector3((5 * ActualIndex) - 10,0, 30);
            ActualIndex++;
            myModelTrf.localRotation = Quaternion.identity;
            myModelTrf.localScale = new Vector3(20, 20, 20);
            myModelTrf.gameObject.active = true;
        }
    }
}
