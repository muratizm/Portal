using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinPoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject.FindGameObjectWithTag("WinText").GetComponent<Text>().enabled = true;
        GameObject.FindGameObjectWithTag("Background").GetComponent<RawImage>().enabled = true;
    }
}
