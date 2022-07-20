using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiLl : MonoBehaviour
{
    IEnumerator OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("stomp"))
        {
                yield return new WaitForSeconds(0.1f);
                Destroy(trig.gameObject);
        }
    }
}
