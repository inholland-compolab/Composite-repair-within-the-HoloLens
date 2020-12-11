using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plies : MonoBehaviour
{
    public Text dispText;
    public string dispStringPlies;
    public string oldString;
    public string newString;
    public string WrongInput;
    public string dispStringEmpty;

    public int nPlies= 0;
    public DataPool dataPool;

    void Start()
    {
        dispText = this.GetComponent<Text>();
        dataPool = GameObject.Find("ManagerObject").GetComponent<DataPool>();

    }

    public void AddNumber(string numberString)
    {
        oldString = dispStringPlies;
        newString = oldString + numberString;
        dispStringPlies = newString;
        this.GetComponent<Text>().text = dispStringPlies;
        Debug.Log(dispStringPlies);

        try
        {
            nPlies = int.Parse(dispStringPlies);
            dataPool.nPlies = nPlies;
        }
        catch(Exception e)
        {
            Debug.Log(e);
        }

        float thing = dataPool.nPlies;

    }

    public void Remove()
    {
        WrongInput = dispStringPlies;
        dispStringPlies = dispStringEmpty;
        this.GetComponent<Text>().text = dispStringEmpty;
    }

    

}

