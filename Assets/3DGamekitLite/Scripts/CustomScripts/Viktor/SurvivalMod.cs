using UnityEngine;

public class SurvivalMod : MonoBehaviour
{
    [SerializeField] private float thirstAmount = 100f;
    [SerializeField] private float thirstSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        thirstAmount = thirstAmount - thirstSpeed;
    }
}
