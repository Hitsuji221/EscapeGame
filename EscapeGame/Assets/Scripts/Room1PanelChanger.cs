using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room1PanelChanger : MonoBehaviour
{
    //矢印の表示・非表示
    public GameObject backArrow;
    public GameObject stomacpicture;
    string currentPanelStr = "RoomPanel";

    public void OnBackArrow(){
        this.transform.localPosition=new Vector2(350,-100);
        backArrow.SetActive(false);
    }
    /*public void OnPicture(){
        this.transform.localPosition=new Vector2(1000,0);
        backArrow.SetActive(true);
    }*/
}
