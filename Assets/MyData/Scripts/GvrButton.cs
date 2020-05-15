using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class GvrButton : MonoBehaviour
{
    public UnityEvent gvrEnter;
    public float totalTime = 2;
    bool gvrStatus;
    public float gvrTimer;
    public GameObject Panel;
   
    // Start is called before the first frame update
    // Update is called once per frame
    private void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
        }
        if (gvrTimer > totalTime)
        {
            gvrEnter.Invoke();
        }
    }
    public void gvrOn() {
      
        gvrStatus = true;
        
    }
    public void gvrOff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        if(Panel != null)
            Panel.SetActive(false);
     
   
    }
}
