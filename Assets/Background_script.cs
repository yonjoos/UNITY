﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_script : MonoBehaviour
{

    public AudioSource aud;
    // Start is called before the first frame update
    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        aud.loop = true;
    }
}
