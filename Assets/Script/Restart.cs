﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public void RestarLevel()
    {
        Application.LoadLevel("SampleScene");
    }
}
