using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reconstruction : MonoBehaviour
{
    public GameObject templeObject;
    bool reconstruct = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.R)){
            if (reconstruct){
              templeObject.transform.localScale = new Vector3(0, 0, 0);
              Debug.Log ("Reconstruction is enabled and now turned off (2)");
              reconstruct = !reconstruct;
            }
            else if (!reconstruct){
              templeObject.transform.localScale = new Vector3(1, 1, 1);
              Debug.Log ("Reconstruction is disbaled and now turned on (1)");
              reconstruct = !reconstruct;
            }
            
        } 
    }
}

/*
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
            uiObject.GetComponent<Text>().text="Hallo"; 
        
 }

 void OnTriggerExit (Collider other){
   uiObject.SetActive(false);
   infoText.SetActive(false);

 }
}
*/