using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonManagerSettings : MonoBehaviour {

    public void GoBackBtn (string LoadTarget)
    {
        SceneManager.LoadScene(LoadTarget);
    }

}
