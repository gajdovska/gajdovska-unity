using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    [SerializeField]
    private string myMessage;

    [SerializeField]
    InteractiveObject myUnlockableObject;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            audioSource.Play();
            FindObjectOfType<TextAnimator>().Show(myMessage);
            myUnlockableObject.Unlock();
            Destroy(gameObject);

        }
    }
}
