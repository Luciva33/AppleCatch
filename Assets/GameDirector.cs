using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameDirector : MonoBehaviour
{
    // GameObject timerText;
    public TextMeshProUGUI timerText;
    // GameObject pointText;
    public TextMeshProUGUI pointText;

    float time = 30.0f;
    int point = 0;
    public void GetApple()
    {
        this.point += 100;
    }
    public void GetBomb()
    {
        this.point /= 2;
    }

    void Start()
    {
        // this.timerText = GameObject.Find("Time");


        // this.pointText = GameObject.Find("Point");
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;
        // this.timerText.GetComponent<TextMeshProUGUI>().text =
        // this.time.ToString("F1");
        this.timerText.text = this.time.ToString("F1");

        // this.pointText.GetComponent<TextMeshProUGUI>().text =
        // this.point.ToString() + " point";
        this.pointText.text = this.point.ToString() + " point";

    }
}

