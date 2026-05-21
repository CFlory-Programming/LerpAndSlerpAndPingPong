using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBallPingPong : MonoBehaviour
{
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float delta = Mathf.PingPong(Time.time / 2, 4); // Multiply Time.time by 4 to make it complete a cycle in 2 seconds
        transform.position = startPos + new Vector3(delta * 1.25f, delta * 1.25f, 0);
    }
}