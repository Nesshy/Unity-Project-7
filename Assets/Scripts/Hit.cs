using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    { 
        if (other.gameObject.tag == "Engel")
        {
            Destroy(gameObject);
        }
    }
}
