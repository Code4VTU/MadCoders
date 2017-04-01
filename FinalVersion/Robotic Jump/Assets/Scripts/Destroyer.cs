using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Destroyer : MonoBehaviour
{

    public void GoBack()
    {
        Application.LoadLevel("gameover");
    }

    private void OnTriggerEnter2D(Collider2D other)
      {
          if (other.tag == "Player")
          {
            GoBack();
        }

          if (other.gameObject.transform.parent)
          {
              Destroy(other.gameObject.transform.parent.gameObject);
        }
          else
          {
              Destroy(other.gameObject);
          }
        
      }
}