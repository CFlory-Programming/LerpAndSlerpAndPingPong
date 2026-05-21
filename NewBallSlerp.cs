using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBallSlerp : MonoBehaviour
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
        Vector3 pos;

        if (delta <= 2)
        {
            pos = Vector3.Slerp(startPos, endPos1, delta / 2);
            pos.y = startPos.y;
            pos.z = startPos.z;
            transform.position = pos;
        }
        if (delta > 2 && delta <= 4)
        {
            pos = Vector3.Slerp(endPos1, endPos2, (delta - 2) / 2);
            pos.x = endPos1.x;
            pos.z = endPos1.z;
            transform.position = pos;
        }
        if (delta > 4 && delta <= 6)
        {
            pos = Vector3.Slerp(endPos2, endPos3, (delta - 4) / 2);
            pos.y = endPos2.y;
            pos.z = endPos2.z;
            transform.position = pos;
        }
        if (delta > 6 && delta <= 8)
        {
            pos = Vector3.Slerp(endPos3, startPos, (delta - 6) / 2);
            pos.x = endPos3.x;
            pos.z = endPos3.z;
            transform.position = pos;
        }
    }
}