using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public int playerSpeed;
    public Transform canvasRotator;
    private Rigidbody myRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Vector3 v3 = Camera.main.transform.forward;
            v3.y = 0;
            //transform.position = transform.position +  v3 * playerSpeed * Time.deltaTime;
            myRigidBody.velocity = v3 * Time.deltaTime * playerSpeed;
        }

        float diff = Camera.main.transform.eulerAngles.y - canvasRotator.eulerAngles.y;
        if(Mathf.Abs(diff) > 50)
            canvasRotator.eulerAngles = new Vector3(0, Camera.main.transform.eulerAngles.y, 0);
    }
}
