using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabBall : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hands;
    private Rigidbody rigidbody;
    public bool inHands = false;
    KeyCode mouseGrab;
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
    }



    public void toggle()
    {
        if (!inHands && (hands.transform.position - transform.position).magnitude < 1.5)
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
            transform.position = new Vector3(transform.position.x, hands.transform.position.y - 0.45f, transform.position.z);
        }
    }

}
