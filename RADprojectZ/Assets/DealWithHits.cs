using System.Collections.Generic;
using UnityEngine;

public class DealWithHits : MonoBehaviour
{
    int Health = 100;

    internal void IHitYou()
    {
        Health -= 20;
        if (Health < 50)
        {

        }
        if (Health < 0)
        {

            Destroy(gameObject);
        }

    }
               


}
