using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;


[RequireComponent(typeof(ARAnchorManager))]
public class ReferencePoint : MonoBehaviour
{
    /*
    private ARReferencePointManager arReferencePointManager;
    private ARTrackedImageManager arTrackedImageManager;
    private ARPlaneManager arPlaneManager;

    public GameObject tracked;
    private ARSessionOrigin arSessionOrigin;


  
    private void Awake()
    {
        arReferencePointManager = GetComponent<ARReferencePointManager>();

        



        tracked.transform.position = arTrackedImageManager.trackedImagePrefab.transform.position;

        Vector3 postest = tracked.transform.position;
        Vector3 pos = new Vector3(0, 0, 0);
        Quaternion rot = new Quaternion(0,0,0,0);

        //Vector3 pos = new Vector3(-0.022f, 0.038f, 0.366f);
        //Quaternion rot = new Quaternion(-0.5275029f, -0.4939441f, 0.1413763f, 0.676589f);
        //quat von rot [-94.425f, -54.84601f, -34.94199]
        Pose hitPose = new Pose(postest, rot);

        ARReferencePoint referencePoint = arReferencePointManager.AddReferencePoint(hitPose);
        
        if (referencePoint == null)
        {
            Debug.Log("There was an error creating an anchor");
        }
        else
        {
            Debug.Log("Anchor created");
        }
    }
    /*public void MakeContentAppearAt(ARSessionOrigin, Vector3 postest)

    {

    }
    */
    // Update is called once per frame
    void Update()
    {
        
    }
}
