using UnityEngine;
using Vuforia;
using System.Collections;
using UnityEngine.UI;

public class ExampleActivation : MonoBehaviour, ITrackableEventHandler
{
    public Camera ARCamera;
    public Sprite NewSprite;
    private TrackableBehaviour mTrackableBehaviour;
    public GameObject myModelPrefab;
    public Transform Canvas;
    public Rumble Rumble;

    // Use this for initialization
    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }

        //OnTrackableStateChanged(TrackableBehaviour.Status.TRACKED, TrackableBehaviour.Status.DETECTED);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            //OnDetected();
            OnTrackingFound();
    }

    public void OnTrackableStateChanged(
      TrackableBehaviour.Status previousStatus,
      TrackableBehaviour.Status newStatus)
    {
        switch (newStatus)
        {
            case TrackableBehaviour.Status.NO_POSE:     //This is the one we want to use to set the projection to "false" when the image target is not present on the screen.
                OnTrackingLost();
                break;

            case TrackableBehaviour.Status.LIMITED:
                break;

            case TrackableBehaviour.Status.DETECTED:
            case TrackableBehaviour.Status.TRACKED:
            case TrackableBehaviour.Status.EXTENDED_TRACKED:
                OnTrackingFound();
                break;
            default:
                break;
        }
    }

    public Color[] colorArray;
    public int Index = 0;
    public int ActualIndex = 0;

    Vector3 projectionPos;
    GameObject instantiatedGo;

    private void OnTrackingFound()
    {
        Debug.Log("Method OnTrackingFound reached.");
        if (myModelPrefab != null)
        {
            //Debug.Log("If reached.");
            //Transform myModelTrf = GameObject.Instantiate(myModelPrefab).transform;     //Instantiate the Object myModelPrefab which is of the type Transform (The object is the GameObject which you dragged into the variable in the Inspector).

            //Instantiate the prefab(GameObject) and then parent the newly instatiated gameobjects transform to the second argument. (Done by overload.)
            if (instantiatedGo == null)
            {
                instantiatedGo = Instantiate(myModelPrefab, Canvas);
                Debug.Log("Check instantiation");
            }
            Debug.Log("Passed instantiation");

            UnityEngine.UI.Image image = instantiatedGo.GetComponentInChildren<UnityEngine.UI.Image>();
            image.sprite = NewSprite;
            instantiatedGo.SetActive(true);

            instantiatedGo.transform.localPosition = new Vector3(0, 0, 0);


            Rumble = instantiatedGo.GetComponentInChildren<Rumble>();

            // Link to UIProjectionLocation script.


            //USE THIS TO ESTABLISH THE LINK BACK BETWEEN FOOD (B) AND EXAMPLE ACTIVATION (A).
            Food food = instantiatedGo.GetComponentInChildren<Food>();
            food.ARSpriteObject = gameObject;   //gameObject <-- note that its noted with a small "g", so it's a variable.
            
        }
    }

    private void OnTrackingLost()
    {
       if (instantiatedGo != null)
            instantiatedGo.SetActive(false);    
    }

    private void OnDetected()
    {
        // Rumble method call
        Rumble.XRumble = true;
        //Rumble.YRumble = true;
    }
}
