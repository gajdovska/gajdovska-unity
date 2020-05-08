using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour

{
    public GameObject hands;
    [SerializeField]
    private Vector3 openPosition, closePosition;
    [SerializeField]
    private float animationTime;
    [SerializeField]
    private bool isOpen = false, isLocked = false;
    [SerializeField]
    private enum movementType { Slide,Rotate};
    [SerializeField]
    private movementType moveType;
    [SerializeField]
    private string myMessage;

    private TextAnimator textAnimator;

    private Hashtable iTweenArgs;
    // Start is called before the first frame update
    void Start()
    {
        textAnimator = FindObjectOfType<TextAnimator>();
        iTweenArgs = iTween.Hash();
        iTweenArgs.Add("position", openPosition);
        iTweenArgs.Add("time", animationTime);
        iTweenArgs.Add("islocal", true);
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    public void UpdatePosition()
    {
        if (!isLocked)
        {
            if (isOpen && ((hands.transform.position - transform.position).magnitude < 4.5))
            {
                iTweenArgs["position"] = closePosition;
                iTweenArgs["rotation"] = closePosition;
            }
            else if (!isOpen && ((hands.transform.position - transform.position).magnitude < 4.5))
            {
                iTweenArgs["position"] = openPosition;
                iTweenArgs["rotation"] = openPosition;
            }
            isOpen = !isOpen;
            switch (moveType)
            {
                case movementType.Slide:
                    iTween.MoveTo(gameObject, iTweenArgs);
                    break;
                case movementType.Rotate:
                    iTween.RotateTo(gameObject, iTweenArgs);
                    break;
            }
        }
        else
        {
            textAnimator.Show(myMessage);
        }
    }
    public void Unlock()
    {
        isLocked = false;
    }
}
