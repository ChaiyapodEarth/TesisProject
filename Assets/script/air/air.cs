using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class air : MonoBehaviour
{
    [SerializeField] Text airText;
    public float maxAir = 200f;
    public float currentAir;

    public float useAirPerMin = 1;
    
    void Start()
    {
        airText.text = "200 bar";
        currentAir = maxAir;
    }
    
    void Update()
    {
        currentAir -= useAirPerMin * Time.deltaTime;

        airText.text = currentAir.ToString();
    }
}
