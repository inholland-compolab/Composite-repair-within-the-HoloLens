using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Depth : MonoBehaviour
{
    public TMP_Text dispText;
    public string dispStringDepth;
    public string oldString;
    public string newString;
    public string WrongInput;
    public string dispStringEmpty;

    public int nDepth = 0;
    public DataPool dataPool;

    void Start()
    {
        dispText = this.GetComponent<TMP_Text>();
        dataPool = GameObject.Find("ManagerObject").GetComponent<DataPool>();

    }

    public void AddNumber(string numberString)
    {
        oldString = dispStringDepth;
        newString = oldString + numberString;
        dispStringDepth = newString;
        this.GetComponent<TMP_Text>().text = dispStringDepth;
        Debug.Log(dispStringDepth);

        try
        {
            nDepth = int.Parse(dispStringDepth);
            dataPool.nDepth = nDepth;
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }

        float thing = dataPool.nDepth;

    }

public void Remove()
    {
        WrongInput = dispStringDepth;
        dispStringDepth = dispStringEmpty;
        this.GetComponent<TMP_Text>().text = dispStringEmpty;
    }
    







}

