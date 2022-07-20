using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("stomp"))
            Destroy(trig.gameObject);
    }
}
