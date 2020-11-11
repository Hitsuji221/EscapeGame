using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickImage5 : MonoBehaviour
{
    public static OnClickImage5 instance;
    public GameObject mkizi;
    public GameObject mkizi2;
    void Start(){
        mkizi.SetActive(true);
        mkizi2.SetActive(false);
    }
    public void OnKizi(){
        mkizi.SetActive(false);
        mkizi2.SetActive(true);
    }
}
