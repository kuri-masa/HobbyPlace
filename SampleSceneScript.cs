using System.Net.WebSockets;
using UnityEngine;
using UnityEngine.InputSystem;

public class SampleSceneScript : MonoBehaviour
{
    Vector3 cv = new Vector3(0f, 1.5f, -3.5f);

    Rigidbody rb = null;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var sv = transform.position + cv;
        Camera.main.transform.position = sv;

        var v = Vector3.zero;
        var g = new Vector3(0f, -5f, 0f);
        var current = Keyboard.current;

        if (current == null)
        {
            return;
        }

        var wKey = current.wKey;
        var sKey = current.sKey;
        var aKey = current.aKey;
        var dKey = current.dKey;
        var spaceKey = current.spaceKey;


        if (wKey.isPressed)
        {
            v = new Vector3(0f, 0f, 100f);
        }

        if (sKey.isPressed)
        {
            v = new Vector3(0f, 0f, -100f);
        }

        if (aKey.isPressed)
        {
            v = new Vector3(-100f, 0f, 0f);
        }

        if (dKey.isPressed)
        {
            v = new Vector3(100f, 0f, 0f);
        }

        if (spaceKey.wasPressedThisFrame)
        {
            v = new Vector3(0f, 800f, 0f);
        }

        rb.linearVelocity = Vector3.down;
        rb.angularVelocity = Vector3.zero;
        rb.AddForce(v);

    }
}
