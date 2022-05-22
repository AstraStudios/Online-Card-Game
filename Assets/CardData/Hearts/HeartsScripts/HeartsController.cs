using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartsController : MonoBehaviour
{

    TestCardSelect overview_algothirm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KingHearts(int king_hearts_health, int king_hearts_damage, int king_hearts_healing, bool has_healed)
    {
        king_hearts_health = 20;
        king_hearts_damage = 7;
        king_hearts_healing = 12;
        has_healed = false;
    }
}
