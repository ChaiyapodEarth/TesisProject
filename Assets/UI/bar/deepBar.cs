using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class deepBar : MonoBehaviour
{

    RawImage healthBarRawImage;
    PlayerMovemenrt player;

    //Use this for initialization
    void Start()
    {
       player = FindObjectOfType<PlayerMovemenrt>();
       healthBarRawImage = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
       float xValue = -(player.positionAsPercentage / 2f) - 0.5f;
        healthBarRawImage.uvRect = new Rect(xValue, 0f, 0.5f, 1f);
    }
}
