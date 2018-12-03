using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour {

    // Touch offset allows not to shake when it starts moving.
    float deltaX, deltaY;

    // Reference to Rigidbody2D component.
    Rigidbody2D rb;

    // Item movement not allowed if you don't touch the item at the first time.
    bool moveAllowed = false;

    // Use this for initialization.
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Add bouncy material to the item.
        PhysicsMaterial2D mat = new PhysicsMaterial2D();
        mat.bounciness = 0.75f;
        mat.friction = 0.4f;
        GetComponent<CircleCollider2D>().sharedMaterial = mat;
   
    }

    // (RectTransform)transform.position;
    // GetComponent<RectTransform>().position;

    //Camera.main.ScreenToWorldPoint(touch.position);

    // Update is called once per frame.
    private void Update()
    {
        // Initiating touch event if touch event takes place.
        if (Input.touchCount > 0)
        {
            // Get touch to take a deal with.
            Touch touch = Input.GetTouch(0);

            // Obtain touch position.
            Vector2 touchPos = touch.position;

            // Processing touch phases.
            switch (touch.phase)
            {
                case TouchPhase.Began:

                    // If you touch the item.
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        // Get the offset between position you touch and the center of the game object.
                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;

                        // If the touch begins within the item's collider then it is allowed to move.
                        moveAllowed = true;

                        // Restrict some rigidbody properties so it moves more smoothly and correctly.
                        rb.freezeRotation = true;
                        rb.velocity = new Vector2(0, 0);
                        //rb.gravityScale = 0;
                        GetComponent<CircleCollider2D>().sharedMaterial = null;
                    }
                    break;

                // When you move your finger.
                case TouchPhase.Moved:
                    
                    // If you touched the ball and movement is allowed then move.
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && moveAllowed)
                    {
                        rb.MovePosition(new Vector2(touchPos.x - deltaX, touchPos.y - deltaY));
                    }
                    break;

                // When you release your finger.
                case TouchPhase.Ended:

                    //restore initial parameters when touch is ended.
                    moveAllowed = false;
                    rb.freezeRotation = false;
                    //rb.gravityScale = 2;
                    PhysicsMaterial2D mat = new PhysicsMaterial2D();
                    mat.bounciness = 0.75f;
                    mat.friction = 0.4f;
                    GetComponent<CircleCollider2D>().sharedMaterial = mat;
                    break;
            }
        }
    }

}
