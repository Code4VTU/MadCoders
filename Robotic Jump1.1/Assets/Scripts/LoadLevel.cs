using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class LoadLevel : MonoBehaviour
{

    public void LevelMenu()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            LevelMenu();
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