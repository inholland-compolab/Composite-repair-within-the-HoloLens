﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Midpoint : MonoBehaviour
{

    public Transform Mark1, Mark2;

    public Vector3 divergence;

    public Vector3 m1Start, m2Start;

    public float midpointValueFromA;
    public Vector3 midpoint;
    public Vector3 drawPointOnCurrentTarget;

    public Transform PlyMidpointObject;

    public DataPool dataPool;

    private void Start()
    {
        m1Start = Mark1.position;
        m2Start = Mark2.position;
        dataPool = GameObject.Find("ManagerObject").GetComponent<DataPool>();
    }

        public void Update()
    {
<<<<<<< Updated upstream
=======
        if (isFindingMidpoint)
        {
            midpoint = (Mark1.position + Mark2.position) * 0.5f;
            midpointValueFromA = (midpoint - Mark1.position).magnitude;
            Debug.Log(midpoint);
            PlyMidpointObject.transform.position = midpoint;
            PlyMidpointObject.up = Mark1.up;
            PlyMidpointObject.localScale = new Vector3(2 * midpointValueFromA, 0.01f, 2 * midpointValueFromA);

            drawPointOnCurrentTarget = midpoint;

            dataPool.Midpointmarker = midpointValueFromA;
        }
>>>>>>> Stashed changes

        midpoint = (Mark1.position + Mark2.position) * 0.5f;
        midpointValueFromA = (midpoint - Mark1.position).magnitude;
        Debug.Log(midpoint);
        PlyMidepointObject.transform.position = midpoint;
        PlyMidepointObject.localScale = new Vector3(2*midpointValueFromA, 0.01f, 2*midpointValueFromA);
        drawPointOnCurrentTarget = midpoint;

        dataPool.Midpointmarker = midpointValueFromA;
        
    }




}

