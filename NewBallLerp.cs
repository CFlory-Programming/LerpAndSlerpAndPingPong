using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBallLerp : MonoBehaviour
{
    Vector3 startPos, endPos1, endPos2, endPos3;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        endPos1 = transform.position;
        endPos1.x = -endPos1.x;
        endPos2 = endPos1;
        endPos2.y = -endPos1.y;
        endPos3 = endPos2;
        endPos3.x = -endPos2.x;
    }

    // Update is called once per frame
    void Update()
    {
        float delta = Time.time % 8f;
        if (delta <= 2)
            transform.position = Vector3.Lerp(startPos, endPos1, delta / 2);
        if (delta > 2 && delta <= 4)
            transform.position = Vector3.Lerp(endPos1, endPos2, (delta - 2) / 2);
        if (delta > 4 && delta <= 6)
            transform.position = Vector3.Lerp(endPos2, endPos3, (delta - 4) / 2);
        if (delta > 6 && delta <= 8)
            transform.position = Vector3.Lerp(endPos3, startPos, (delta - 6) / 2);
    }
}