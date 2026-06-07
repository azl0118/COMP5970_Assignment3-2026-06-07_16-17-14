using UnityEngine;
using UnityEngine.SceneManagement;

public class Meteor : MonoBehaviour
{
    float speed = 4f;
    public AudioClip explosionSound;

    private bool hasHit = false;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;

        if  (transform.position.y < -7f)   
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (hasHit) return;

        if (collision.CompareTag("Player"))
        {
            hasHit = true;

            if (explosionSound != null)
            {
                AudioSource.PlayClipAtPoint(explosionSound, Camera.main.transform.position);
            }
            
            collision.gameObject.SetActive(false);

            // Trigger game over
            HealthManager.instance.KillPlayer();

            Destroy(gameObject);


        }
    }
}