using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombicar : MonoBehaviour
{
     public GameObject cam , effectsound , explosion;
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.name == "destination")
        {
            Destroy(other.gameObject);
            GetComponent<PrometeoCarController>().enabled = false;
                Destroy( Instantiate(effectsound ) , 3); //gift
            StartCoroutine(afterDestinatoin())    ;
                
        }
       
    }
    private void OnTriggerEnter(Collider other) {
              if(other.gameObject.name.Contains("water"))
        {
            cam.GetComponent<CameraFollow>().carexplosion();
                Destroy( Instantiate(explosion , gameObject.transform.position ,Quaternion.identity) , 3); //gift
              Destroy(gameObject, .5f);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void resetlevel(){
            Application.LoadLevel(Application.loadedLevel );
    }
        IEnumerator afterDestinatoin()
     { 
        yield return new WaitForSeconds(2);
   
            Application.LoadLevel(Application.loadedLevel + 1);
        

     }
}
