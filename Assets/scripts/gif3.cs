using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gif3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject effectsound , water;

    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name.Contains("man")){
                  Destroy( Instantiate(effectsound ) , 3); //gift
                  water.GetComponent<Animator>().enabled = true;
                  Destroy(other.gameObject);
                  Destroy(gameObject);
                  

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
