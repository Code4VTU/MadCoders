using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityStandardAssets._2D;

public class DestroyerHurdle : MonoBehaviour
{
    public void GoBack()
    {
        Application.LoadLevel("gameover");
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && PlatformerCharacter2D.HealthLeft() <= 0)
        {
            PlatformerCharacter2D.ResetHealth();
            GoBack();
        }
        else
        {
            PlatformerCharacter2D.TakeDamage(40);
            return;
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