using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gas2 : MonoBehaviour
{
    // Start is called before the first frame update
  public GameObject wood ;
    public GameObject mylight , home;
    public GameObject explosion;
     
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.name.Contains("wood")){
         wood = other.gameObject;
         mylight.SetActive(true);
         StartCoroutine(explosionfun());
         GetComponent<AudioSource>().Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
   
      IEnumerator explosionfun()
     { 
        yield return new WaitForSeconds(4);
   
               Destroy( Instantiate(explosion , gameObject.transform.position ,Quaternion.identity) , 3); //gift
            //    Destroy(wood,.5f);
                 Destroy(gameObject,.5f);
                 home.GetComponent<Animator>().enabled = true;


     }
}
