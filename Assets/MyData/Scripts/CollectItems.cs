using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Scoring.theScore += 50;
            Destroy(gameObject);
        }
        
    }
    public void grabIt()
    {
        Scoring.theScore += 50;
        Destroy(gameObject);
    }
}
