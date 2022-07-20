using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class killOkill : MonoBehaviour
    
{
    IEnumerator OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("opokill"))
        {
            yield return new WaitForSeconds(0.1f);
            Destroy(transform.parent.gameObject);
            
        }
    }
}
