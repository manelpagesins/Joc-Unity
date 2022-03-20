using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void onClickButton(){
        SceneManager.LoadScene("Scene1");
    }
}