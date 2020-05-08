using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseManager : MonoBehaviour
{
    // need to change the look of the cursor as it goes over different assets
    // need to tell the interaction with objects
    // potentially make the char move to that object 
    public LayerMask clickableLayer;

    // variables for the different pointers
    public Texture2D normalPointer; // the normal pointer
    public Texture2D target; // pointer for clickable objects
    public Texture2D vehicles; // pointer for clickable vehicles
    public Texture2D interact; // pointer for interacting with char
    public Texture2D doorway; // pointer for interacting with door

    public EventVector3 OnClickEnvironment;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 50, clickableLayer.value))
        {
            // this is to set the cursor to a clickable object
            if (hit.collider.gameObject.tag == "Vehicle")
            {
                Cursor.SetCursor(vehicles, new Vector2(16, 16), CursorMode.Auto);
            }

            if (hit.collider.gameObject.tag == "Object")
            {
                Cursor.SetCursor(target, new Vector2(16, 16), CursorMode.Auto);
            }

            if (hit.collider.gameObject.tag == "Character")
            {
                Cursor.SetCursor(interact, new Vector2(16, 16), CursorMode.Auto);
            }

            if(hit.collider.gameObject.tag == "Door")
            {
                Cursor.SetCursor(doorway, new Vector2(16, 16), CursorMode.Auto);
            }

            if (Input.GetMouseButtonDown(0))
            {
                OnClickEnvironment.Invoke(hit.point);
            }
        }
        else
        {
            Cursor.SetCursor(normalPointer, Vector2.zero, CursorMode.Auto);
        }
    }

}

[System.Serializable]
public class EventVector3 : UnityEvent<Vector3>
{

}