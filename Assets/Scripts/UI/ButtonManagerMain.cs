using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonManagerMain : MonoBehaviour {

    public void StartCamBtn (string LoadTarget)
    {
        SceneManager.LoadScene(LoadTarget);
    }
}
