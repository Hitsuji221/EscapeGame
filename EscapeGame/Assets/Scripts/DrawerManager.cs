using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerManager : MonoBehaviour
{
    public static DrawerManager instance;
    [SerializeField] GameObject waterImage;
    [SerializeField] GameObject alertText;
    [SerializeField] GameObject keyImage;
    [SerializeField] GameObject alert2Text;
    [SerializeField] GameObject key2Image;
    [SerializeField] GameObject alert3Text;

    void Start()
    {
        waterImage.SetActive(false);
        alertText.SetActive(false);
        keyImage.SetActive(false);
        alert2Text.SetActive(false);
        key2Image.SetActive(false);
        alert3Text.SetActive(false);
    }
   //引き出しが押されたら
   //1.ペットボトルの画像を出す
   //2.Textをだす
   public void OnClick(){
       waterImage.SetActive(true);
       alertText.SetActive(true);
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
        waterImage.SetActive(false);
        alertText.SetActive(false);
        keyImage.SetActive(false);
        alert2Text.SetActive(false);
        key2Image.SetActive(false);
        alert3Text.SetActive(false);
    }
}
