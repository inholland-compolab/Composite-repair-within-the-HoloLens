using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceCalculator : MonoBehaviour
{
    
    public Transform Marker1, Marker2;

    public Vector3 divergence;

    public Vector3 m1Start, m2Start;

    public float distance;


    public DataPool dataPool;

    private void Start()
    {
        m1Start = Marker1.position;
        m2Start = Marker2.position;

        dataPool = GameObject.Find("ManagerObject").GetComponent<DataPool>();

    }


    private void Update()
    {
        CalcDistance();
    }
    // Update is called once per frame
    public void CalcDistance()
    {
        distance = CalcDistance(Marker1, Marker2);
        dataPool.maxPlyDiameter = distance;
        //Debug.Log(distance);
    }



    static float CalcDistance(Transform a, Transform b)
    {
        Vector3 div = b.position - a.position;
        float f = div.magnitude;


        return f;
    }

    public void Reset()
    {
        distance = 0;
        Marker1.position = m1Start;
        Marker2.position = m2Start;
    }
}
