using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AutoHide : MonoBehaviour
{
    public GameObject Tooltip;

    void Start()
    {
        StartCoroutine(RemoveAfterSeconds(10, Tooltip));
    }
    IEnumerator RemoveAfterSeconds(int seconds, GameObject obj)
    {
        yield return new WaitForSeconds(10);
        obj.SetActive(false);
    }

}
