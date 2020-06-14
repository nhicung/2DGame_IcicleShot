using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearTexture : MonoBehaviour
{
    public float sec = 14f;
    void Start()
    {
        if (gameObject.activeInHierarchy)
            gameObject.SetActive(false);

        StartCoroutine(LateCall());
    }

    IEnumerator LateCall()
    {

        yield return new WaitForSeconds(sec);

        gameObject.SetActive(true);
        //Do Function here...
    }
}