﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SwordOfChaosSkill.Instance.OnSwordTriggerEnter2D(collision);
    }
}
