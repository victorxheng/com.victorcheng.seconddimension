using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    private GameObject player;
    public float moveSpeed;
    // Use this for initialization
    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(moveEnemy());
    }
    IEnumerator moveEnemy()
    {
        while (gameObject.activeSelf)
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, player.transform.position, moveSpeed * Time.deltaTime);
            if (!gameObject.activeSelf)
            {
                break;
            }
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
