using UnityEngine;

public class Scorefordraganddrop : MonoBehaviour
{
    public GameObject myIncisor;
    public GameObject myCanine;
    public GameObject myPremolar;
    public GameObject myMolar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "")
    }
}
