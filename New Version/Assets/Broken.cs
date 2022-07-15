using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Broken : MonoBehaviour
{
	public TMP_Text text; 
	
    // Start is called before the first frame update
    void Start()
    {
    	//text = GetComponent<TMP_Text>(); 
    	
        Debug.Log("testing"); 
        
        float testFloat = 0f;
	    if (!Mathf.Approximately(testFloat, 0f))
	    {
		text.text = "0 is not approximately";
	    }
	    else
	    {
		text.text = "0 is approximately 0!";
	    }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
        	Application.Quit();
        }
    }
}
