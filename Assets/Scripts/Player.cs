using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;

    public ParticleSystem edibleParticles;
    public ParticleSystem poisonParticles;

    private GameObject gm;
    // Start is called before the first frame update
    void Start()
    {
        gameOverText.enabled = false;
        gm = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Collectible>().IsPosion == true)
        {
            ParticleSystem particle = Instantiate(poisonParticles, transform.position, transform.rotation);
            particle.Play();
            gameOverText.enabled = true;
            Destroy(gameObject);
        }
        else
        {
            ParticleSystem particle = Instantiate(edibleParticles, transform.position,transform.rotation);
            particle.Play();
            gm.GetComponent<GameManager>().EdibleShroom();
        }
        Destroy(other.gameObject);
    }
}
