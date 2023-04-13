using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float speed;
    public bool IsPosion;
    public float lifeTime;

    private Rigidbody rb;
    private float clock;

    // Start is called before the first frame update
    void Start()
    {
        clock = 0;
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += new Vector3 (0, 1, 0) * Time.deltaTime * speed;

        clock += Time.deltaTime;
        if(clock > lifeTime)
        {
            Destroy(gameObject);
        }
    }
}
