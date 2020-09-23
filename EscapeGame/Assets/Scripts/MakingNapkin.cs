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
    public GameObject kizi2;
    public GameObject pori2;
    public GameObject cotton2;
    string currentPanelStr = "Image1";

    void Start(){
        answerisno.SetActive(false);
        answerpanel.SetActive(false);
    }
    public void OnClickStart(){
        this.transform.localPosition=new Vector2(0,0);
        currentPanelStr = "Image1";
    }
    public void OnClickPen(){
        if(currentPanelStr == "Image1"){ //Panel0のstomacgirlを表示
            this.transform.localPosition=new Vector2(-1200,0);
            currentPanelStr = "Image2";
            OnClickCorrectOne();
        }else if(currentPanelStr == "Image4"||currentPanelStr == "Image0"){
            OnClickCorrectOne();
        }else{
            OnClickOtherOne();
        }
    }
     public void OnClickHasami(){
        if(currentPanelStr == "Image2"){ //Panel0のstomacgirlを表示
            this.transform.localPosition=new Vector2(-1200,1000);
            currentPanelStr = "Image21";
            OnClickCorrectOne();
        }else if(currentPanelStr == "Image21" && (kizi2.activeSelf == false || pori2.activeSelf == false || cotton2.activeSelf == false)){
            OnClickCorrectOne();
        }else if(currentPanelStr == "Image4"||currentPanelStr == "Image0"){
            OnClickCorrectOne();
        }else{        
            OnClickOtherOne();
        }
    }
     public void OnClickMishin(){
        if(currentPanelStr == "Image21" && kizi2.activeSelf == true && pori2.activeSelf == true && cotton2.activeSelf == true ){ //Panel0のstomacgirlを表示
            this.transform.localPosition=new Vector2(-2400,1000);
            currentPanelStr = "Image41";
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
        this.transform.localPosition=new Vector2(-2400,0);
        currentPanelStr = "Image41";
        OnClickCorrectOne();
    }
}
