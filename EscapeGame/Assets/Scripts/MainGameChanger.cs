using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameChanger : MonoBehaviour
{
    public static MainGameChanger instance;
    public GameObject stomacpicture;
    [SerializeField] GameObject waterImage;
    [SerializeField] GameObject alertText;
    [SerializeField] GameObject keyImage;
    [SerializeField] GameObject alert2Text;
    [SerializeField] GameObject key2Image;
    [SerializeField] GameObject alert3Text;
    public GameObject itemBox;
    //矢印の表示・非表示
    public GameObject rightArrow;
    public GameObject leftArrow;
    public GameObject backArrow;

    string currentPanelStr = "Room1Panel0";
    void Start()
    {
        this.transform.localPosition=new Vector2(0,0);
        string currentPanelStr = "Room1Panel0";
        HideArrow();
        itemBox.SetActive(true);
        waterImage.SetActive(false);
        alertText.SetActive(false);
        keyImage.SetActive(false);
        alert2Text.SetActive(false);
        key2Image.SetActive(false);
        alert3Text.SetActive(false);
    }
    void HideArrow(){
        rightArrow.SetActive(false);
        leftArrow.SetActive(false);
        backArrow.SetActive(false);
    }

    //Room1
    public void OnClickWater(){
        waterImage.SetActive(true);
        alertText.SetActive(true);
    }
    public void OnClickWaterImage(){
        waterImage.SetActive(false);
        alertText.SetActive(false);
    }
    public void OnClickStomacGirl(){
        //クリックしたときに、Playerがアイテム（ペットボトル）を持っていれば、消える
        //タイミング：クリックしたとき
        //処理：消える
        //処理の条件：Playerがアイテム（ペットボトル）を持っていれば

        //タイミング：クリックしたときstomacGirlPanelに移動
        this.transform.localPosition=new Vector2(0,1000);
        currentPanelStr = "Room1Panel1";
        backArrow.SetActive(true);
    }
    public void OnRoom1Door(){
        HideArrow();
        //panle1を表示
        bool hasItem2 = ItemBox.instance.CanUseItem(Item.Type.Key); //TODO:アイテムBoxにペットボトルがあるか　=>　ItemとItemBoxをつくる
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
    public void OnPictures(){
        HideArrow();
        backArrow.SetActive(true);
        this.transform.localPosition=new Vector2(-1200,2000);
        currentPanelStr = "Room2Panel3";
    }
    public void OnToRoom2Panel1Door(){
        HideArrow();
        //panle3を表示
        bool hasItem3 = ItemBox.instance.CanUseItem(Item.Type.Key2); //TODO:アイテムBoxにペットボトルがあるか　=>　ItemとItemBoxをつくる
        if(hasItem3== true){
            //ItemBox.instance.UseItem(Item.Type.Key2);
            this.transform.localPosition=new Vector2(-2400,0);
            currentPanelStr = "Room6Panel1";
            backArrow.SetActive(true);
        }
        else if(hasItem3== false){
            backArrow.SetActive(true);
            this.transform.localPosition=new Vector2(-1200,3000);
            currentPanelStr = "Room2Panel11";
        }
    }
     public void OnToRoom2Panel2Door(){
        HideArrow();
        //panle0を表示
        bool hasItem2 = ItemBox.instance.CanUseItem(Item.Type.Key); //TODO:アイテムBoxにペットボトルがあるか　=>　ItemとItemBoxをつくる
        if(hasItem2== true){
            //ItemBox.instance.UseItem(Item.Type.Key2);
            this.transform.localPosition=new Vector2(0,0);
            currentPanelStr = "Room1Panel0";
        }
    }

    //Room6
    public void OnStatu(){
        HideArrow();
        itemBox.SetActive(false);
        this.transform.localPosition=new Vector2(-2400,1000);
        currentPanelStr = "Room6Panel2";
    }
    public void NapkinGameStart(){
        HideArrow();
        if(currentPanelStr == "Room6Panel2"){
            this.transform.localPosition=new Vector2(-2400,2000);
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
        else if(currentPanelStr == "Room2Panel3"){
            this.transform.localPosition=new Vector2(-1200,1000);
            currentPanelStr = "Room2Panel2";
            leftArrow.SetActive(true);
        }else if(currentPanelStr == "Room2Panel11"){
            this.transform.localPosition=new Vector2(-1200,0);
            currentPanelStr = "Room2Panel1";
            rightArrow.SetActive(true);
        }
        else if(currentPanelStr == "Room3Panel0"){
            this.transform.localPosition=new Vector2(-1200,0);
            currentPanelStr = "Room2Panel1";
            rightArrow.SetActive(true);
        }
    }
    public void OnLeftArrow(){
        HideArrow();
        if(currentPanelStr=="Room2Panel2"){
            this.transform.localPosition=new Vector2(-1200,0);
            currentPanelStr = "Room2Panel1";
            rightArrow.SetActive(true);
        }
    }
    public void OnRighttArrow(){
        HideArrow();
        if(currentPanelStr=="Room2Panel1"){
            this.transform.localPosition=new Vector2(-1200,1000);
            currentPanelStr = "Room2Panel2";
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
    //ペットボトルの画像をクリックするとペットボトル画像を非表示にする
    public void OnClickImage(){
        keyImage.SetActive(false);
        alert2Text.SetActive(false);
        key2Image.SetActive(false);
        alert3Text.SetActive(false);
    }

}
