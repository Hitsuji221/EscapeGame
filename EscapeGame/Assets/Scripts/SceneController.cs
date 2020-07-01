using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void ButtonClicked () {
        SceneManager.LoadScene("ToRoom2");
	}
}
