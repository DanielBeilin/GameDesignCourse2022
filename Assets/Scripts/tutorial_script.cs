using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial_script : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        StartCoroutine(ShowPanel());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator ShowPanel()
    {
        yield return new WaitForSeconds(3);
        gameObject.SetActive(false);
    }
}
