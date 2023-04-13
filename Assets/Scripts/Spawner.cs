using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] mushrooms;
    public int areaX;
    public int areaY;
    public float time;

    private float clock;

    // Start is called before the first frame update
    void Start()
    {
        clock = 0;
    }

    // Update is called once per frame
    void Update()
    {
        clock += Time.deltaTime;
        if(clock > time)
        {
            SpawnMushroom();
            clock = 0;
        }
    }

    private void SpawnMushroom()
    {
        GameObject mushroom = mushrooms[Random.Range(0, mushrooms.Length - 1)];
        int x = Random.Range(-areaX, areaX);
        int y = Random.Range(-areaY, areaY);

        Instantiate(mushroom, new Vector3(x, 1, y), Quaternion.identity);
    }
}
