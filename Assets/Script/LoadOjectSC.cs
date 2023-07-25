using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadOjectSC : MonoBehaviour
{
  
    public void ShowOBJ(GameObject obj) 
    {           
       obj.SetActive (true);           


    }
    public void HideOBJ(GameObject obj)
    {
        obj.SetActive (false);
   
    }  
}

