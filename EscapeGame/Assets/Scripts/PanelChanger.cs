using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//矢印クリックで、特定のPanel表示
public class PanelChanger : MonoBehaviour
{
    //矢印の表示・非表示
    public GameObject rightArrow;
    public GameObject leftArrow;
    public GameObject backArrow;
    string currentPanelStr = "Panel0";

    private void Start(){
        HideArrow();
    }
    void HideArrow(){
        rightArrow.SetActive(false);
        leftArrow.SetActive(false);
        backArrow.SetActive(false);
    }
    public void OnRighttArrow(){
        HideArrow();

        if(currentPanelStr == "Panel0"){ //Panel0のstomacgirlを表示
            this.transform.localPosition=new Vector2(-1000,0);
        }
        else if(currentPanelStr == "Panel1"){ //panel2を表示
            this.transform.localPosition=new Vector2(-4700,0);
            currentPanelStr = "Panel2";
            leftArrow.SetActive(true);
        }
    } 
    public void OnLeftArrow(){
        this.transform.localPosition=new Vector2(-3500,0);
        currentPanelStr = "Panel1";

        HideArrow();
        rightArrow.SetActive(true);
    }
    public void OnBackArrow(){
        HideArrow();

        if(currentPanelStr == "Panel3"){
            this.transform.localPosition=new Vector2(-4700,0);
            currentPanelStr = "Panel2";
            leftArrow.SetActive(true);
        }
        else if(currentPanelStr == "Panel4"){
            this.transform.localPosition=new Vector2(-3500,0);
            currentPanelStr = "Panel1";
            rightArrow.SetActive(true);
        }
        else if(currentPanelStr == "StomacPanel"){
            this.transform.localPosition=new Vector2(0,0);
            currentPanelStr = "Panel0";
            rightArrow.SetActive(true);
        }
        else if(currentPanelStr == "Panel11"){
            this.transform.localPosition=new Vector2(-3500,0);
            currentPanelStr = "Panel1";
            rightArrow.SetActive(true);
        }
    }
    public void OnPictures(){
        HideArrow();
        backArrow.SetActive(true);

        this.transform.localPosition=new Vector2(-4700,1000);
        currentPanelStr = "Panel3";
    }
    public void OnToRoom2Panel1Door(){
        HideArrow();

        //panle3を表示
        bool hasItem3 = ItemBox.instance.CanUseItem(Item.Type.Key2); //TODO:アイテムBoxにペットボトルがあるか　=>　ItemとItemBoxをつくる
        if(hasItem3== true){
            //ItemBox.instance.UseItem(Item.Type.Key2);
            this.transform.localPosition=new Vector2(-7000,0);
            currentPanelStr = "Panel4";
            backArrow.SetActive(true);
        }
        else if(hasItem3== false){
            backArrow.SetActive(true);
            this.transform.localPosition=new Vector2(-3500,1000);
            currentPanelStr = "Panel11";
        }
    }
    public void OnToRoom2Panel2Door(){
        HideArrow();

        //panle0を表示
        bool hasItem2 = ItemBox.instance.CanUseItem(Item.Type.Key); //TODO:アイテムBoxにペットボトルがあるか　=>　ItemとItemBoxをつくる
        if(hasItem2== true){
            //ItemBox.instance.UseItem(Item.Type.Key2);
            this.transform.localPosition=new Vector2(0,0);
            currentPanelStr = "Panel0";
        }
    }
    public void OnRoom1Door(){
        HideArrow();

        //panle1を表示
        bool hasItem2 = ItemBox.instance.CanUseItem(Item.Type.Key); //TODO:アイテムBoxにペットボトルがあるか　=>　ItemとItemBoxをつくる
        if(hasItem2== true){
            //ItemBox.instance.UseItem(Item.Type.Key2);
            this.transform.localPosition=new Vector2(-3500,0);
            currentPanelStr = "Panel1";
            rightArrow.SetActive(true);
        }
        else if(hasItem2== false){
            this.transform.localPosition=new Vector2(0,0);
            currentPanelStr = "Panel0";
        }

    }
    public void OnStatu(){
        HideArrow();

        this.transform.localPosition=new Vector2(-7000,1000);
        currentPanelStr = "Panel5";
    }

}
