using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabItem: MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hands;
    private Rigidbody rigidbody;
    public bool inHands = false;
    KeyCode mouseGrab;
    [SerializeField]
    private string myMessage;
    Collider collider;

    [SerializeField]
    InteractiveObject myUnlockableObject;
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
    }



    public void toggle()
    {
        if (!inHands )
        {
            inHands = true;
            rigidbody.isKinematic = true;
        }
        else if (inHands)
        {
            transform.position = hands.transform.position + Camera.main.transform.forward * 2f;
            inHands = false;
            rigidbody.isKinematic = false;
         
            

        }
    }


    private void Update()
    {
        if (inHands)
        {
            transform.position = hands.transform.position + Camera.main.transform.forward;
            transform.position = new Vector3(transform.position.x, hands.transform.position.y - 0.55f, transform.position.z);
            
        }

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "DoorLocked")
        {
            myUnlockableObject.Unlock();
            Destroy(gameObject);
        }
        if(collider.tag == "Player")
        {
            FindObjectOfType<TextAnimator>().Show(myMessage);
            inHands = true;
        }
    }

}
