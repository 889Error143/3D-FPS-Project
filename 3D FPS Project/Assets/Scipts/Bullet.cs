using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float lifeTime = 5f;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.velocity = transform.forward * moveSpeed;

        lifeTime -= Time.deltaTime;

        if (lifeTime <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TargetStanding"))
        {
            Debug.Log("I hit the standing target.");
            //add code to add hit points to your scoreboard
            GameObject.Find("Game Manager").GetComponent<GameManager>().UpdateTargetAmount();
            //gray out the standing target
            Destroy(this.gameObject);
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("TargetFloating"))
        {
            Debug.Log("I hit the floating target");
            //add code to add hit points to your scoreboard
            GameObject.Find("Game Manager").GetComponent<GameManager>().UpdateTargetAmount();
            //gray out the standing target
            Destroy(this.gameObject);
            other.gameObject.SetActive(false);
        }
    }
}