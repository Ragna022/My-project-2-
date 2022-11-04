using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoginValidation : MonoBehaviour
{

    public TMP_InputField USERNAME;
    public TMP_InputField PASSWORD;

    public GameObject ScreenPanel;


    public void CheckValidation()
    {
        string uname = USERNAME.text;
        string pass = PASSWORD.text;

        if (uname == "Pezi" && pass == "PeziTask")
        {
            Debug.Log("Login Successfully....");
            ScreenPanel.SetActive(false);
        }
        else if (uname == "" || pass == "")
        {
            Debug.Log("Please Enter Username And Password And Try Again...");
            ScreenPanel.SetActive(true);
        }
        else
        {
            Debug.Log("Please Enter Correct Username And Password And Try Again...");
            ScreenPanel.SetActive(true);
        }
    }

    
   
}
