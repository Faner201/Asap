using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject monster;
    private Transform player;
    private const float distance = 3f;
    private const float minDistance = 1f;

    private const float repeadTime = 5f;
    private void SpawnMonster()
    {   
        if(Vector3.Distance(player.position,transform.position) < distance && Vector3.Distance(player.position,transform.position) > minDistance)
        {
            GameObject newMonster = Instantiate(monster);
        }
    }
    private void Start() 
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        InvokeRepeating(nameof(SpawnMonster),0,repeadTime);
    }

}
