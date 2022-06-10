

using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4.0f;
    // Start is called before the first frame update
    

    // Update is called once per frame
    private void Update()
    {
        //work out the speed how they drop 4.0f
       
        
        transform.Translate (Vector3.down * (_speed * Time.deltaTime));
        // and if the bottom of the screen respawns to the top and at random positions
        float randomX = Random.Range(-8f,8f);
        if (transform.position.y < -5f)
        {
            transform.position = new Vector3(randomX, 7, 0);
        }

        
    }
    private void OnTriggerEnter(Collider other)
    {
       
        {
            //if other is player, damage player
            //destroy us
            if (other.CompareTag("Player"))
            {
                Destroy(gameObject);
            }
            // if other is laser
            // destroy laser then us
            if (other.CompareTag("Laser"))
            {
                Destroy(other.gameObject);
                Destroy(gameObject);
            }
        }
        
    }

    
}
