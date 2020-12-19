using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage;
    public int speed;
    public GameObject effect;

    private void Update() {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow)){
            speed = 15;
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")){
            if (other.GetComponent<Player>().health != 1){
                Instantiate(effect, transform.position, Quaternion.identity);
            }
            other.GetComponent<Player>().health -= damage;
            Destroy(gameObject);
        }
    }
}
