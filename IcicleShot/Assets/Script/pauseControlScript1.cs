using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseControlScript1 : MonoBehaviour {

    public void Pause()
    {
        P1controller.paused = !P1controller.paused;   
    }
}
