using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowKeyController : MonoBehaviour
{
    public float panSpeed = 20f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            pos.z += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            pos.z -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= panSpeed * Time.deltaTime;
        }


        transform.position = pos;
    }
}
