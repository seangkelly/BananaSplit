using UnityEngine;
using System.Collections;

    


public class ScaleScript : MonoBehaviour {

    public AudioSource GrowAudioSound;
    public AudioSource ShrinkSound; 

    
    void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space)) {
            transform.localScale *=1.1f;
            GrowAudioSound.Play();
        }
        
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            transform.localScale /= 1.1f;
            ShrinkSound.Play();

        }
    }

}
