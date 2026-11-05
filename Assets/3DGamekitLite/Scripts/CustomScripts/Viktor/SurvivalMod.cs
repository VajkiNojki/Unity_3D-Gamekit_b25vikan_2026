using Gamekit3D;
using UnityEngine;

public class SurvivalMod : MonoBehaviour
{
    [SerializeField] private float thirstAmount = 100f;
    [SerializeField] private float thirstSpeed;

    [SerializeField] private bool thirsty;
    [SerializeField] private bool parched;
    
    [SerializeField] private GameObject playerObject;
    [SerializeField] private float timer = 10f
        ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerObject = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        /* Subtracing the current value of thirstlevel with thirstSpeed. thirstSpeed is normalized
        by using Time.delthaTime, so that itäs frame rate independent.
        Math.Clamp restricts the thirstlevel between its current max value and 0.
        */
        thirstAmount -= Mathf.Clamp(thirstSpeed * Time.deltaTime, 0, thirstAmount);

        // if statement check if thirstamount is equal to or lower, then 50 AND if thirsty = false
        if (thirstAmount <= 50f && !thirsty)
        {
            Debug.Log("Getting thirsty....");
            thirsty = true;
        }

        
        if (timer <= 0f)
        {
            Damageable.DamageMessage msg = new Damageable.DamageMessage()
            {
            amount = 1,
            damager = this,
            damageSource = new Vector3(x: 0, y: 0, z: 0),
            direction = new Vector3(x: 0, y: 0, z: 0),
            throwing = false,
            stopCamera = false
            };
            playerObject.GetComponent<Damageable>().ApplyDamage(msg);
            ResetThirst();
            Debug.Log("Damage by thirst!");
            timer = 10f;
        }
        if (thirstAmount <= 0 && thirsty)
        {
           timer -= Time.deltaTime;
        }
    }
    
    public void ResetThirst()
    {
        thirstAmount = 100f;
        timer = 10f;
        thirstSpeed = 10f;
        thirsty = false;
    }
    
}
