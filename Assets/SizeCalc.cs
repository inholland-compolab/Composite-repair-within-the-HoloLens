using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeCalc : MonoBehaviour
{
    public float Thickness = 0;
    public float Tangens = 0;
    public float Fraction = 0;
    public float maxPlyDiameter = 0;
    public DataPool dataPool;

    public void ThicknessEstimation()
    {
         dataPool = GameObject.Find("ManagerObject").GetComponent<DataPool>();
    }

    public void Update()
    {
        Thickness = 2 * dataPool.nDepth;
        dataPool.Thickness = Thickness;
        Debug.Log(Thickness);

        dataPool.Fraction = (Thickness / dataPool.Tangens);

        dataPool.patchsize = (dataPool.Fraction + (10*dataPool.maxPlyDiameter));
    }


}
   