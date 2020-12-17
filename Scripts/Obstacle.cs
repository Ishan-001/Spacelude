using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage;
    public int speed;
    public float degrees = 360.0f;

    private void Update() {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")){
            other.GetComponent<Player>().health -= damage;
            Destroy(gameObject);
        }
    }
}
