﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudySikyu : MonoBehaviour
{
    public GameObject rightArrow;
    string currentPanelStr = "Sikyu1";

    void Start()
    {
        rightArrow.SetActive(false);
    }

    public void OnClickStart(){
        this.transform.localPosition=new Vector2(-1200,3000);
        currentPanelStr = "Sikyu1";
        rightArrow.SetActive(true);
    }
    public void OnArrow(){
        if(currentPanelStr == "Sikyu1"){
            this.transform.localPosition = new Vector2(-1200,4000);
            currentPanelStr = "Sikyu2";
        }
        else if(currentPanelStr == "Sikyu2"){
            this.transform.localPosition = new Vector2(-1200,5000);
            currentPanelStr = "Sikyu3";   
        }
        else if(currentPanelStr == "Sikyu3"){
            this.transform.localPosition = new Vector2(-1200,6000);
            currentPanelStr = "Sikyu4";
        }
        else if(currentPanelStr == "Sikyu4"){
            this.transform.localPosition = new Vector2(-1200,7000);
            currentPanelStr = "Sikyu5";
        }
        else if(currentPanelStr == "Sikyu5"){
            this.transform.localPosition = new Vector2(-1200,8000);
            currentPanelStr = "Sikyu6";
        }
        else if(currentPanelStr == "Sikyu6"){
            this.transform.localPosition = new Vector2(-1200,9000);
            currentPanelStr = "SikyuEND";
            rightArrow.SetActive(false);
        }
    }

    public void OnUnderstand(){
        if(currentPanelStr == "SikyuEND"){
            this.transform.localPosition = new Vector2(-1200,0);
            currentPanelStr = "Room2Panel2";
        }
    }
    public void OnNotUnderstand(){
        if(currentPanelStr == "SikyuEND"){
            this.transform.localPosition = new Vector2(-1200,3000);
            currentPanelStr = "Sikyu1";
            rightArrow.SetActive(true);
        }
    }
}
