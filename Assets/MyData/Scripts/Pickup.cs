using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    [SerializeField]
    private string myMessage;

    [SerializeField]
    InteractiveObject myUnlockableObject;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            FindObjectOfType<TextAnimator>().Show(myMessage);
            myUnlockableObject.Unlock();
            Destroy(gameObject);
        }
    }
}
