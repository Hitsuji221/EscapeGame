using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void OnStart () {
        SceneManager.LoadScene("MainGame");
	}
    public void ImageClicked () {
        SceneManager.LoadScene("LastMainGame");
	}
    public void StatueClick(){
        SceneManager.LoadScene("MakingNapkin");
    }
    public void BacktoStartClick(){
        SceneManager.LoadScene("Start");
    }
}
