using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject monster;
    private Transform player;
    [SerializeField] private  float distance;
    [SerializeField] private  float minDistance;

    [SerializeField] private  float repeadTime;
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
    private void Update() 
    {
        Debug.Log(Vector3.Distance(player.position,transform.position));
    }

}
