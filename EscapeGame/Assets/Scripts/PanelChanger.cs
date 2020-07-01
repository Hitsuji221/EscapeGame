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
        rightArrow.SetActive(false);
        leftArrow.SetActive(false);
        backArrow.SetActive(false);

        rightArrow.SetActive(true);
    }
  public void OnRighttArrow(){
      //Panel1を表示：Parentを(-1200,0,0)
      this.transform.localPosition=new Vector2(-1200,0);
      currentPanelStr = "Panel1";

       rightArrow.SetActive(false);
       leftArrow.SetActive(false);
       backArrow.SetActive(false);

       leftArrow.SetActive(true);
  } 
  public void OnLeftArrow(){
      this.transform.localPosition=new Vector2(0,0);
      currentPanelStr = "Panel0";

      rightArrow.SetActive(false);
      leftArrow.SetActive(false);
      backArrow.SetActive(false);

      rightArrow.SetActive(true);
  }
  public void OnBackArrow(){
      rightArrow.SetActive(false);
      leftArrow.SetActive(false);
      backArrow.SetActive(false);

      if(currentPanelStr == "Panel2"){
        this.transform.localPosition=new Vector2(-1200,0);
        currentPanelStr = "Panel1";
        leftArrow.SetActive(true);
      }
  }
  public void OnPictures(){
      rightArrow.SetActive(false);
      leftArrow.SetActive(false);
      backArrow.SetActive(false);
      backArrow.SetActive(true);

      this.transform.localPosition=new Vector2(-1200,1000);
      currentPanelStr = "Panel2";
  }
}
