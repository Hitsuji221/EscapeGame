﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class MainGameChanger : MonoBehaviour
{
    public static MainGameChanger instance;
    //public GameObject stomacpicture;

    [SerializeField] GameObject mapImage;
    [SerializeField] GameObject alert4Text;
    [SerializeField] GameObject waterImage;
    [SerializeField] GameObject alertText;
    [SerializeField] GameObject keyImage;
    [SerializeField] GameObject alert2Text;
    [SerializeField] GameObject key2Image;
    [SerializeField] GameObject alert3Text;
    [SerializeField] GameObject room2Girl;
    [SerializeField] GameObject room2Boy;

    public GameObject itemBox;
    //矢印の表示・非表示
    public GameObject rightArrow;
    public GameObject leftArrow;
    public GameObject backArrow;
    public GameObject message3;
    public GameObject stomacbutton;
    public GameObject tileGame;

    string currentPanelStr = "Room1Panel0";
    void Start()
    {
        HideArrow();
        HideItem();
        tileGame.SetActive(true);
        itemBox.SetActive(true);
        message3.SetActive(false);
        stomacbutton.SetActive(false);
        room2Boy.SetActive(true);
        room2Girl.SetActive(true);
    }
    void HideArrow(){
        rightArrow.SetActive(false);
        leftArrow.SetActive(false);
        backArrow.SetActive(false);
    }
    void HideItem(){
        mapImage.SetActive(false);
        waterImage.SetActive(false);
        keyImage.SetActive(false);
        key2Image.SetActive(false);
        alert4Text.SetActive(false);        
        alertText.SetActive(false);
        alert2Text.SetActive(false);
        alert3Text.SetActive(false);
    }

    //Room1
    public void OnRoom1Door(){
        HideArrow();
        //panle1を表示
        bool hasItem2 = ItemBox.instance.CanUseItem(Item.Type.Map); //TODO:アイテムBoxにkeyがあるか　=>　ItemとItemBoxをつくる
        if(hasItem2== true){
            //ItemBox.instance.UseItem(Item.Type.Key2);
            this.transform.localPosition=new Vector2(-1200,0);
            currentPanelStr = "Room2Panel1";
            rightArrow.SetActive(true);
        }
        else if(hasItem2== false){
            this.transform.localPosition=new Vector2(0,0);
            currentPanelStr = "Room1Panel0";
        }
    }

    //Room2
    public void OnToRoom2Panel1Door(){
        HideArrow();
        //panle3を表示
        bool hasItem3 = ItemBox.instance.CanUseItem(Item.Type.Key); //TODO:アイテムBoxにkey2があるか
        if(hasItem3== true){
            //ItemBox.instance.UseItem(Item.Type.Key2);
            this.transform.localPosition=new Vector2(-2400,0);
            currentPanelStr = "Room3Panel1";
            rightArrow.SetActive(true);
            leftArrow.SetActive(true);
        }
        else if(hasItem3== false){
            backArrow.SetActive(true);
            this.transform.localPosition=new Vector2(-1200,2000);
            currentPanelStr = "Room2Panel11";
        }
    }
    public void OnClickGirlRoom2(){
        message3.SetActive(true);
        stomacbutton.SetActive(true);
        itemBox.SetActive(false);
    }
     public void OnToRoom2Panel2Door(){
        HideArrow();
        //panle0を表示
        bool hasItem2 = ItemBox.instance.CanUseItem(Item.Type.Map); //TODO:アイテムBoxにペットボトルがあるか　=>　ItemとItemBoxをつくる
        if(hasItem2== true){
            //ItemBox.instance.UseItem(Item.Type.Key2);
            this.transform.localPosition=new Vector2(0,0);
            currentPanelStr = "Room1Panel0";
        }
    }
    public void OnLookButton(){
        HideArrow();
        itemBox.SetActive(false);
        if(currentPanelStr == "Room2Panel2"){
            this.transform.localPosition=new Vector2(-1200,3000);
            currentPanelStr = "Room2Sikyu1";
        }
    }

    public void OnUnderstand(){
        HideArrow();
        itemBox.SetActive(true);
        this.transform.localPosition=new Vector2(-1200,0);
        currentPanelStr = "Room2Panel1";
        room2Boy.SetActive(false);
        room2Girl.SetActive(false);
        stomacbutton.SetActive(false);
    }


    //Room3
    public void OnRoom3Panel2Door(){
        HideArrow();
        itemBox.SetActive(true);
        this.transform.localPosition=new Vector2(-1200,1000);
        currentPanelStr = "Room2Panel2";
        leftArrow.SetActive(true);
    }
    public void OnRoom3Panel3Door(){
        HideArrow();
        itemBox.SetActive(true);
        this.transform.localPosition=new Vector2(-3600,0);
        currentPanelStr = "Room4Panel1";
        leftArrow.SetActive(true);
    }
    public void OnRoom3Panel4Door(){
        HideArrow();
        bool hasItem4 = ItemBox.instance.CanUseItem(Item.Type.Key2);
        if(hasItem4== true){
            this.transform.localPosition=new Vector2(-7200,0);
            currentPanelStr = "Room6Panel1";
            backArrow.SetActive(true);
        }
    }
    public void OnClickWater(){
        waterImage.SetActive(true);
        alertText.SetActive(true);
    }
    public void OnClickWaterImage(){
        waterImage.SetActive(false);
        alertText.SetActive(false);
    }


    //Room4
    public void OnClickStomacGirl(){
        HideArrow();
        //クリックしたときに、Playerがアイテム（ペットボトル）を持っていれば、消える
        //タイミング：クリックしたとき
        //処理：消える
        //処理の条件：Playerがアイテム（ペットボトル）を持っていれば

        //タイミング：クリックしたときstomacGirlPanelに移動
        this.transform.localPosition=new Vector2(-3600,2000);
        currentPanelStr = "Room4Panel3";
        backArrow.SetActive(true);
    }
    public void OnRoom4Panel1Door(){
        HideArrow();
        //panle1を表示
        bool hasItem4 = ItemBox.instance.CanUseItem(Item.Type.Key2); //TODO:アイテムBoxにkeyがあるか　=>　ItemとItemBoxをつくる
        if(hasItem4 == true){
            //ItemBox.instance.UseItem(Item.Type.Key2);
            this.transform.localPosition=new Vector2(-4800,0);
            currentPanelStr = "Room5Panel1";
            //rightArrow.SetActive(true);
        }
        else if(hasItem4 == false){
            this.transform.localPosition=new Vector2(-3600,0);
            currentPanelStr = "Room4Panel1";
            leftArrow.SetActive(true);
        }
    }
    public void OnRoom4Panel2Door(){
        HideArrow();
        //panle1を表示
        bool hasItem5 = ItemBox.instance.CanUseItem(Item.Type.Key); //TODO:アイテムBoxにkeyがあるか　=>　ItemとItemBoxをつくる
        if(hasItem5 == true){
            //ItemBox.instance.UseItem(Item.Type.Key);
            this.transform.localPosition=new Vector2(-2400,0);
            currentPanelStr = "Room3Panel1";
            rightArrow.SetActive(true);
            leftArrow.SetActive(true);
        }
        else if(hasItem5 == false){
            this.transform.localPosition=new Vector2(-3600,1000);
            currentPanelStr = "Room4Panel2";
            rightArrow.SetActive(true);
        }
    }


    //Room5
    public void OnRoom5Door(){
        this.transform.localPosition=new Vector2(-3600,1000);
        currentPanelStr = "Room4Panel2";
        rightArrow.SetActive(true);
    }


    //Room6
    public void OnStatu(){
        HideArrow();
        itemBox.SetActive(false);
        this.transform.localPosition=new Vector2(-7200,1000);
        currentPanelStr = "Room6Panel2";
    }
    public void NapkinGameStart(){
        HideArrow();
        if(currentPanelStr == "Room6Panel2"){
            this.transform.localPosition=new Vector2(-7200,2000);
            currentPanelStr = "Room6Image1";
        }
    }


    //Arrows
    public void OnBackArrow(){
        HideArrow();
        if(currentPanelStr == "Room1Panel1"){
            this.transform.localPosition=new Vector2(0,0);
            currentPanelStr = "Room1Panel0";
            backArrow.SetActive(false);
        }
        else if(currentPanelStr == "Room2Panel11"){
            this.transform.localPosition=new Vector2(-1200,0);
            currentPanelStr = "Room2Panel1";
            rightArrow.SetActive(true);
        }
        else if(currentPanelStr == "Room4Panel3"){
            this.transform.localPosition=new Vector2(-3600,1000);
            currentPanelStr = "Room4Panel2";
            rightArrow.SetActive(true);
        }
        else if(currentPanelStr == "Room6Panel1"){
            this.transform.localPosition=new Vector2(-2400,3000);
            currentPanelStr = "Room3Panel4";
            rightArrow.SetActive(true);
            leftArrow.SetActive(true);
        }
    }
    public void OnLeftArrow(){
        HideArrow();
        if(currentPanelStr=="Room2Panel2")
        {
            this.transform.localPosition=new Vector2(-1200,0);
            currentPanelStr = "Room2Panel1";
            rightArrow.SetActive(true);
        }
        else if(currentPanelStr=="Room3Panel1"){
            this.transform.localPosition=new Vector2(-2400,2000);
            currentPanelStr = "Room3Panel3";
            rightArrow.SetActive(true);
            leftArrow.SetActive(true);
        }
        else if(currentPanelStr=="Room3Panel2"){
            this.transform.localPosition=new Vector2(-2400,0);
            currentPanelStr = "Room3Panel1";
            rightArrow.SetActive(true);
            leftArrow.SetActive(true);
        }
        else if(currentPanelStr=="Room3Panel3"){
            this.transform.localPosition=new Vector2(-2400,3000);
            currentPanelStr = "Room3Panel4";
            rightArrow.SetActive(true);
            leftArrow.SetActive(true);
        }
        else if(currentPanelStr=="Room3Panel4"){
            this.transform.localPosition=new Vector2(-2400,1000);
            currentPanelStr = "Room3Panel2";
            rightArrow.SetActive(true);
            leftArrow.SetActive(true);
        }
        else if(currentPanelStr=="Room4Panel1"){
            this.transform.localPosition=new Vector2(-3600,1000);
            currentPanelStr = "Room4Panel2";
            rightArrow.SetActive(true);
        }
    }
    public void OnRighttArrow(){
        HideArrow();
        if(currentPanelStr=="Room2Panel1")
        {
            this.transform.localPosition=new Vector2(-1200,1000);
            currentPanelStr = "Room2Panel2";
            leftArrow.SetActive(true);
        }
        else if(currentPanelStr=="Room3Panel1"){
            this.transform.localPosition=new Vector2(-2400,1000);
            currentPanelStr = "Room3Panel2";
            leftArrow.SetActive(true);
            rightArrow.SetActive(true);
        }
        else if(currentPanelStr=="Room3Panel2"){
            this.transform.localPosition=new Vector2(-2400,3000);
            currentPanelStr = "Room3Panel4";
            rightArrow.SetActive(true);
            leftArrow.SetActive(true);
        }
        else if(currentPanelStr=="Room3Panel3"){
            this.transform.localPosition=new Vector2(-2400,0);
            currentPanelStr = "Room3Panel1";
            rightArrow.SetActive(true);
            leftArrow.SetActive(true);
        }
        else if(currentPanelStr=="Room3Panel4"){
            this.transform.localPosition=new Vector2(-2400,2000);
            currentPanelStr = "Room3Panel3";
            rightArrow.SetActive(true);
            leftArrow.SetActive(true);
        }
        else if(currentPanelStr=="Room4Panel2"){
            this.transform.localPosition=new Vector2(-3600,0);
            currentPanelStr = "Room4Panel1";
            leftArrow.SetActive(true);
        }
    } 
    
   public void OnKeyClick(){
       keyImage.SetActive(true);
       alert2Text.SetActive(true);
   }
   public void DialLockerClear(){
       key2Image.SetActive(true);
       alert3Text.SetActive(true);
   }

   public void TileGameClear(){
        tileGame.SetActive(false);
        mapImage.SetActive(true);
        alert4Text.SetActive(true);
   }
   public void OnClickMapImage(){
        mapImage.SetActive(false);
        alert4Text.SetActive(false);
    }

    //ペットボトルの画像をクリックするとペットボトル画像を非表示にする
    public void OnClickImage(){
        keyImage.SetActive(false);
        alert2Text.SetActive(false);
        key2Image.SetActive(false);
        alert3Text.SetActive(false);
    }

}
