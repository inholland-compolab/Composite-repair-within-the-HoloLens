using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeCalc : MonoBehaviour
{

    public float nPlies;
    public float[] Lpatch;
    public float[] plyDiameter;
    public float patchAngle = 3f;
    public float Dhole;
    public GameObject ply;
    public DataPool dataPool;
    public float materialThickness;

    
    public void Update()
    {
        dataPool = GameObject.Find("ManagerObject").GetComponent<DataPool>();
        Dhole = dataPool.maxPlyDiameter;
        materialThickness = dataPool.nDepth;
    }

    public void CalcPlies(int n, float materialThickness, float maxPlyDiameter)
    {
        Lpatch = new float[n];
        plyDiameter = new float[n];

        for (int i = 0; i<n; i++)
        {
            float k = materialThickness / n * (n - i);
            Lpatch[i] = 2 * k / Mathf.Tan(patchAngle) + Dhole;
            plyDiameter[i] = plyDiameter[i + 1] - 0.5f;
        }
    }

    public void ApplyPlyParameters(int index)
    {
        ply.transform.localScale = new Vector3(plyDiameter[index], Lpatch[index], plyDiameter[index]);
    }
}
