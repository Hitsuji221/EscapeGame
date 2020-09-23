using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stomac : MonoBehaviour
{
    public GameObject backArrow;
 //クリックしたときに、Playerがアイテム（ペットボトル）を持っていれば、消える
 //タイミング：クリックしたとき
 //処理：消える
 //処理の条件：Playerがアイテム（ペットボトル）を持っていれば

 //タイミング：クリックしたときstomacGirlPanelに移動
 public void OnThis(){
    this.transform.localPosition=new Vector2(-1000,0);
    backArrow.SetActive(true);
 }
}
