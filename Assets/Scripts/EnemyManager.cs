using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public float health;
    public float damage;
    bool colliderBusiy = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player" && !colliderBusiy)
        {
            colliderBusiy = true;
            other.GetComponent<PlayerManager>().GetDamage(damage);
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "Player")
        {
            colliderBusiy = false;
        }
    }

    // private void OnTriggerStay2D(Collider2D other) {
        
    // }
    
    // private void OnTriggerExit2D(Collider2D other) {
        
    // }
}
