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
<<<<<<< Updated upstream
        materialThickness = dataPool.nDepth;
=======
        nPlies = dataPool.nPlies;
        CalcPlies(nPlies, Thickness, dataPool.maxPlyDiameter); 
>>>>>>> Stashed changes
    }

    public void CalcPlies(int n, float materialThickness, float maxPlyDiameter)
    {
        Lpatch = new float[n];
        plyDiameter = new float[n];

        for (int i = 0; i<n; i++)
        {
<<<<<<< Updated upstream
            float k = materialThickness / n * (n - i);
            Lpatch[i] = 2 * k / Mathf.Tan(patchAngle) + Dhole;
            plyDiameter[i] = plyDiameter[i + 1] - 0.5f;
=======
            k[i] = materialThickness / n * (n - i);
            Lpatch[i] = Mathf.Abs((2 * k[i] / Mathf.Tan(patchAngle))) + (Dhole);   //Used to be negative
            Debug.Log("this is step " + n);
            plyDiameter[i] = plyDiameter[i] - 0.5f; // This is still static, I did not really get what you wanted to do there. We will have to adjust this.

>>>>>>> Stashed changes
        }
    }

    public void ApplyPlyParameters(int index)
    {
<<<<<<< Updated upstream
        ply.transform.localScale = new Vector3(plyDiameter[index], Lpatch[index], plyDiameter[index]);
=======
        //we do the ply indication here. If you want to have the numbers dispayed as well somewhere. Simply add a UI text

        //adjusting the appearacne of the Plyos
        scaling = new Vector3(Lpatch[index] / 1000, plyThickness, Lpatch[index] / 1000);
        Ply.transform.localScale = scaling;
        Transform someTransform = Ply.GetComponent<Transform>();
        someTransform.localScale = scaling;

        Debug.Log("Scaling Adjusted");
      

    }

    public void NextPly()
    {

        if (PlyToShow > nPlies)
        {

        }
        else
        {
            PlyToShow++;
            Debug.Log("next Ply");
            ApplyPlyParameters(PlyToShow);
        }
>>>>>>> Stashed changes
    }
}
