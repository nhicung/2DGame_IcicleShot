﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour {

    public static bool border;
    public static float minX=-8;
    public static float maxX=8;
    public static float minY;
    public static float maxY;

    // Use this for initialization
    void Start () {
        minX = -8;
        maxX = 10;
        minY = -6;
        maxY = 6;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
