using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerCollider : MonoBehaviour
{

public GameObject uiObject;
public GameObject infoText;

 void OnTriggerEnter (Collider other){
   uiObject.SetActive(true);
 }

 void OnTriggerStay (Collider other){
   if (Input.GetKeyDown(KeyCode.I)){
      infoText.SetActive(true);
   }
   else if (Input.GetKeyDown(KeyCode.Escape)){
      infoText.SetActive(false);
   }

           
           //infoText1.SetActive(!infoText1.activeSelf);
          /*  Debug.Log ("i gedrückt");
            uiObject.GetComponent<Text>().text="Hallo"; */
        
 }

 void OnTriggerExit (Collider other){
   uiObject.SetActive(false);
   infoText.SetActive(false);

 }
}
