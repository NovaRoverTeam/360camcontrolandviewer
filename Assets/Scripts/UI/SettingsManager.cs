using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour {
    public InputField camNumberField;
    int camInt;

    public void WhenClicked() {

        camInt = int.Parse(camNumberField.text);
        PlayerPrefs.SetInt("CameraNumber", camInt);
        Debug.Log(PlayerPrefs.GetInt("CameraNumber").ToString());

    }

}
