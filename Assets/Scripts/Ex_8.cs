using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ex_8 : MonoBehaviour
{
   public TMP_InputField username;
    public TextMeshProUGUI message;



    public void Username()
    {
        
        if (!string.IsNullOrWhiteSpace(username.text))
        {
            //insert text after the player introduce the username
           message.text = $"¡Hello {username.text} and welcome to this wonderful world!";
        }
    }
}
