﻿using UnityEngine;
using System.Collections;

public class FallInChecker : MonoBehaviour {

    public Hole red;
    public Hole blue;
    public Hole green;

    void OnGUI () {
        string label = " ";
        if (red.IsFallIn() && blue.IsFallIn() && green.IsFallIn())
        {
            label = "Fall In Hole!";
        }
        GUI.Label(new Rect(0, 0, 100, 30), label);
	}
}
