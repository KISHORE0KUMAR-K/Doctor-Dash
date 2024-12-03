using UnityEngine;

public class obstacle : MonoBehaviour
{
    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision){

        if(collision.tag == "border")
        {
            Destroy(this.gameObject);

        }
        else if(collision.tag == "Player")
        {
            Destroy(player.gameObject);
        }
    }
}
