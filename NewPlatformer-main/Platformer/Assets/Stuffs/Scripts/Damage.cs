using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public virtual void GetDamage()
    {

    }

    public virtual void Die()
    {
        if (this.gameObject)
        {
            Destroy(this.gameObject);
        }
    }
}
