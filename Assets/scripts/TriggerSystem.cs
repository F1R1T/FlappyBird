using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerSystem : MonoBehaviour
{
        void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.tag == "Enemy")
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    

}
