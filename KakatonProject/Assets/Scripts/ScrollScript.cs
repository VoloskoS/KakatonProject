﻿using UnityEngine;
using System.Collections;

public class ScrollScript : MonoBehaviour
{

    [SerializeField]
    private float speed;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(Time.time * speed, 0f);
    }
}
