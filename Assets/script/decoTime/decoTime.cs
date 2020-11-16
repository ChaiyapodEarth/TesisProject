using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class decoTime : MonoBehaviour
{

    FreeFlyCamera camera;
    PlayerMovemenrt player;
    
    float oldtime; 
    float miniute; 
    float second; 
    string[] millisec;

 
    public float time20 = 50f;
    public float time30 = 30f;
    public float time40 = 10f;
    public float time50 = 5f;

    [SerializeField] Text TimerTxt;

    int position;

    void Start()
    {
        camera = FindObjectOfType<FreeFlyCamera>();
        player = FindObjectOfType<PlayerMovemenrt>();
    }


    void Update()
    {
        float position = camera.transform.position.y;
        if (position < 0)
            position = -1 * (position);

        countDecoTime(position);
    }

    private void countDecoTime(float position)
    {
        if (position < 10f)
        {
            TimerTxt.text = (99).ToString("0");
        }
        if (position >= 10 && position < 20)
        {
            time20 -= Time.deltaTime;
            miniute = Mathf.Floor(time20 / 60);
            second = time20 % 60;
            millisec = second.ToString("f2").Split('.');
            if (second > 59) second = 59;
            if (miniute < 0)
            {
                miniute = 0;
                second = 0;
            }
            TimerTxt.text = ((int)miniute).ToString("D2") + ":" + ((int)Mathf.Floor(second)).ToString("D2");
        }
        if (position >= 20 && position < 30)
        {
            time30 -= Time.deltaTime;
            miniute = Mathf.Floor(time30 / 60);
            second = time30 % 60;
            millisec = second.ToString("f2").Split('.');
            if (second > 59) second = 59;
            if (miniute < 0)
            {
                miniute = 0;
                second = 0;
            }
            TimerTxt.text = ((int)miniute).ToString("D2") + ":" + ((int)Mathf.Floor(second)).ToString("D2");
        }
        if (position >= 30 && position < 40)
        {
            time40 -= Time.deltaTime;
            miniute = Mathf.Floor(time40 / 60);
            second = time40 % 60;
            millisec = second.ToString("f2").Split('.');
            if (second > 59) second = 59;
            if (miniute < 0)
            {
                miniute = 0;
                second = 0;
            }
            TimerTxt.text = ((int)miniute).ToString("D2") + ":" + ((int)Mathf.Floor(second)).ToString("D2");
        }
        if (position >= 40)
        {
            time50 -= Time.deltaTime;
            miniute = Mathf.Floor(time50 / 60);
            second = time50 % 60;
            millisec = second.ToString("f2").Split('.');
            if (second > 59) second = 59;
            if (miniute < 0)
            {
                miniute = 0;
                second = 0;
            }
            TimerTxt.text = ((int)miniute).ToString("D2") + ":" + ((int)Mathf.Floor(second)).ToString("D2");
        }
    }

}
