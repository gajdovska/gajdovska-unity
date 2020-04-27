using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public int playerSpeed;
    public Transform canvasRotator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
        }

        float diff = Camera.main.transform.eulerAngles.y - canvasRotator.eulerAngles.y;
        if(Mathf.Abs(diff) > 50)
            canvasRotator.eulerAngles = new Vector3(0, Camera.main.transform.eulerAngles.y, 0);
    }
}
