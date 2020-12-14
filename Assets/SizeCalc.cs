using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeCalc : MonoBehaviour
{
    public DataPool dataPool;
    public int nPlies;
    public float[] Lpatch;
    public float[] plyDiameter;
    public float patchAngle = 3f;
    public float Dhole;
    public GameObject Ply;
    public float Thickness;
    public float plyThickness = 0.01f;


    public int PlyToShow = 0;

    //Debug only

    public float[] k;
    public Vector3 scaling;



    private void Start()
    {
        dataPool = GameObject.Find("ManagerObject").GetComponent<DataPool>();


    }

    public void StartCalucaltions()
    {
        Thickness = dataPool.nDepth;
        Dhole = dataPool.maxPlyDiameter;
        nPlies = dataPool.nPlies;
        CalcPlies(nPlies, Thickness, dataPool.maxPlyDiameter); // These are he values we want to use
    }
    public void CalcPlies(int n, float materialThickness, float maxPlyDiameter)
    {
        this.GetComponent<Midpoint>().isFindingMidpoint = false;
        Dhole = 10 * dataPool.maxPlyDiameter;

        Lpatch = new float[n];
        plyDiameter = new float[n];
        k = new float[n];


        //start of the loop
        for (int i = 0; i < n; i++)
        {
            k[i] = materialThickness / n * (n - i);
            Lpatch[i] = Mathf.Abs((2 * k[i] / Mathf.Tan(patchAngle))) + (Dhole);   //USed to be negative
            Debug.Log("this is step " + n);
            plyDiameter[i] = plyDiameter[i] - 0.5f; // This is still static, I did not really get what you wanted to do there. We will have to adjust this.

        }
        ApplyPlyParameters(0);
    }

    public void ApplyPlyParameters(int index)
    {
        //we do the ply indication here. If you want to have the numbers dispayed as well somewhere. Simply add a UI text

        //adjusting the appearacne of the Plyos
        scaling = new Vector3(Lpatch[index] / 1000, plyThickness, Lpatch[index] / 1000);
        Ply.transform.localScale = scaling;
        Transform someTransform = Ply.GetComponent<Transform>();
        someTransform.localScale = scaling;

        Debug.Log("Scaling Adjusted");
        //adjusting the location of the Ply to be fair, the location does not have to be adjusted. just the size. Since the ply is set to appear in the middle between the two markers, which should more or less be the middle of the damage
        //alright then heck it

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
    }
    public void PreviousPly()
    {

        if (PlyToShow <= 0)
        {

        }
        else
        {
            PlyToShow--;
            Debug.Log("PrevPly");
            ApplyPlyParameters(PlyToShow);
        }
    }

}
