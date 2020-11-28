using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveName : MonoBehaviour
{
 public Text name1;
 public Text name2;

   private void OnDisable()      
   {
       if(name1.text==null)
       {
           PlayerPrefs.SetString("name1", name1.text);
       }

   }
}
