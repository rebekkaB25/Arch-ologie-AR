using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARSubsystems;



public class ButtonPressed : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{


    void Update()
    {
        if (!ispressed)
            return;
    }

    public static bool ispressed = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }

    public void OnPointerUp (PointerEventData eventData)
    {
        ispressed = false;
    }
}