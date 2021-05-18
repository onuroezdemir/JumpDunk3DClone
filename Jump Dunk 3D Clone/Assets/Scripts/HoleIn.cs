using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleIn : MonoBehaviour
{
    public GameObject confetti;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            Instantiate(confetti,other.gameObject.transform.position,confetti.transform.rotation);
            Destroy(other.gameObject, 3f);
        }
    }
}
