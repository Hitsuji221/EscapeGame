using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakingNapkin : MonoBehaviour
{
    public GameObject pen;
    public GameObject hasami;
    public GameObject mishin;
    public static MakingNapkin instance;
    [SerializeField] GameObject answerisno;
    [SerializeField] GameObject answerpanel;
    public GameObject kizi;
    public GameObject pori;
    public GameObject cotton;
    public GameObject kizi2;
    public GameObject pori2;
    public GameObject cotton2;
    public GameObject mkizi1;
    public GameObject mkizi2;
    public GameObject mkizi3;
    public GameObject message1;
    public GameObject message2;
    public GameObject toolBox;

    string currentPanelStr = "Image1";

    void Start(){
        answerisno.SetActive(false);
        answerpanel.SetActive(false);
        toolBox.SetActive(false);
        message1.SetActive(false);
        message2.SetActive(false);
    }
    public void OnClickStart(){
        toolBox.SetActive(true);
        this.transform.localPosition=new Vector2(-2400,2000);
        currentPanelStr = "Image1";
    }
    public void OnClickPen(){
        if(currentPanelStr == "Image1"){ //Panel0のstomacgirlを表示
            this.transform.localPosition=new Vector2(-2400,3000);
            currentPanelStr = "Image11";
            OnClickCorrectOne();
        }else if(currentPanelStr == "Image11" && (kizi.activeSelf == false || pori.activeSelf == false || cotton.activeSelf == false)){
            OnClickCorrectOne();
        }else if(currentPanelStr == "Image6"){
            this.transform.localPosition=new Vector2(-3600,3000);
            currentPanelStr = "Image61";
            OnClickCorrectOne();
        }else if(currentPanelStr == "Image4"||currentPanelStr == "Image0"){
            OnClickCorrectOne();   
        }else if(currentPanelStr == "Image61" && (mkizi1.activeSelf == false)){
            OnClickCorrectOne();
        }else{
            OnClickOtherOne();
        }
    }
     public void OnClickHasami(){
        if(currentPanelStr == "Image11"&& (kizi.activeSelf == true && pori.activeSelf == true && cotton.activeSelf == true)){ //Panel0のstomacgirlを表示
            this.transform.localPosition=new Vector2(-2400,4000);
            currentPanelStr = "Image21";
            OnClickCorrectOne();
        }else if(currentPanelStr == "Image21" && (kizi2.activeSelf == false || pori2.activeSelf == false || cotton2.activeSelf == false)){
            OnClickCorrectOne();
        }else if(currentPanelStr == "Image61"&& (mkizi1.activeSelf == true)){
            this.transform.localPosition=new Vector2(-3600,4000);
            currentPanelStr = "Image62";
            OnClickCorrectOne();
        }else if(currentPanelStr == "Image62" && (mkizi2.activeSelf == false)){
            OnClickCorrectOne();
        }else if(currentPanelStr == "Image4"||currentPanelStr == "Image0"){
            OnClickCorrectOne();
        }else{        
            OnClickOtherOne();
        }
    }
     public void OnClickMishin(){
        if(currentPanelStr == "Image21" && kizi2.activeSelf == true && pori2.activeSelf == true && cotton2.activeSelf == true ){ //Panel0のstomacgirlを表示
            this.transform.localPosition=new Vector2(-2400,5000);
            currentPanelStr = "Image41";
            OnClickCorrectOne();
        }else if(currentPanelStr == "Image62"&& (mkizi2.activeSelf == true)){
            this.transform.localPosition=new Vector2(-3600,5000);
            currentPanelStr = "Image63";
            OnClickCorrectOne();
        }else if(currentPanelStr == "Image63" && (mkizi3.activeSelf == false)){
            OnClickCorrectOne();
        }else if(currentPanelStr == "Image41"||currentPanelStr == "Image0" ||currentPanelStr == "Image4"){
            OnClickCorrectOne();
        }else{
            OnClickOtherOne();
        }
    }
    void OnClickOtherOne(){
        answerisno.SetActive(true);
        answerpanel.SetActive(true);
    }
    void OnClickCorrectOne(){
        answerisno.SetActive(false);
        answerpanel.SetActive(false);
    }
    public void OnClickMiss(){
        answerisno.SetActive(false);
        answerpanel.SetActive(false);
    }
    public void OnClickPanel(){
        this.transform.localPosition=new Vector2(-2400,6000);
        currentPanelStr = "Image4";
        OnClickCorrectOne();
    }
    public void OnClickNapkin(){
        this.transform.localPosition=new Vector2(-2400,7000);
        currentPanelStr = "Image5";
        toolBox.SetActive(false);
        message1.SetActive(true);
        OnClickCorrectOne();
    }
    public void OnClickNextGame(){
        this.transform.localPosition=new Vector2(-3600,1000);
        currentPanelStr = "Image51";
        toolBox.SetActive(false);
        OnClickCorrectOne();
    }
    public void OnClickGameStart2(){
        this.transform.localPosition=new Vector2(-3600,2000);
        currentPanelStr = "Image6";
        toolBox.SetActive(true);
        OnClickCorrectOne();
    }
    public void OnClickMawashi(){
        this.transform.localPosition=new Vector2(-3600,6000);
        currentPanelStr = "Image7";
        toolBox.SetActive(false);
        message2.SetActive(true);
        OnClickCorrectOne();
    }
    public void OnClickGattai(){
        this.transform.localPosition=new Vector2(-3600,7000);
        currentPanelStr = "Image71";
        toolBox.SetActive(false);
        OnClickCorrectOne();
    }
}