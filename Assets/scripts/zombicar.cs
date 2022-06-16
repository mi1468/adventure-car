using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombicar : MonoBehaviour
{
     public GameObject cam , effectsound , explosion , endgame;
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
    public void reStart()
    {
            Application.LoadLevel(0 );

    }
    public void exitapp()
    {
           if (Application.platform == RuntimePlatform.Android)
             {
                 AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
                 activity.Call<bool>("moveTaskToBack", true);
             }
             else
             {
                 Application.Quit();
             }
    }
    public void resetlevel(){
            Application.LoadLevel(Application.loadedLevel );
    }
        IEnumerator afterDestinatoin()
     { 
        yield return new WaitForSeconds(2);
   
   if(Application.loadedLevel == 2)
   {
       endgame.SetActive(true);
   }else
   {

          Application.LoadLevel(Application.loadedLevel + 1);
        }
     

     }
}
