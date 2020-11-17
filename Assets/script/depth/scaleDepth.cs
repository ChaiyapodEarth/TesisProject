using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scaleDepth : MonoBehaviour
{
    PlayerMovemenrt player;
    FreeFlyCamera camera;

    [SerializeField] Text depthText;

    private float depthPosition = 0f;

    void Start()
    {
        player = FindObjectOfType<PlayerMovemenrt>();
        camera = FindObjectOfType<FreeFlyCamera>();
        
        depthText.text = "0 meter";
    }
    
    void Update()
    {
        depthPosition = player.transform.position.y;

        if (depthPosition > 0)
            depthPosition = 0;

        if (depthPosition < 0) 
            depthPosition = (int)(-1 * (depthPosition));
        

        depthText.text = depthPosition.ToString() + " meter";
    }
}
