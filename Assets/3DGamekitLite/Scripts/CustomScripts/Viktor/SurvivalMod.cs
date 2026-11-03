using UnityEngine;

public class SurvivalMod : MonoBehaviour
{
    [SerializeField] private float thirstAmount = 100f;
    [SerializeField] private float thirstSpeed;

    [SerializeField] private bool thirsty;
    [SerializeField] private bool parched;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* Subtracing the current value of thirstlevel with thirstSpeed. thirstSpeed is normalized
        by using Time.delthaTime, so that itäs frame rate independent.
        Math.Clamp restricts the thirstlevel between its current max value and 0.
        */
        thirstAmount -= Mathf.Clamp(thirstSpeed*Time.deltaTime, 0, thirstAmount);

        if (thirstAmount <= 50f && !thirsty)
        {
            Debug.Log("Getting thirsty....");
            thirsty = true;
        }
          
    }
}
