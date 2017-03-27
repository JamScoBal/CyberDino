﻿using UnityEngine;
using System;
using System.Collections;

public interface IHitbox {

    /// <summary>
    /// Can this hitbox be hit right now?
    /// </summary>
    /// <returns></returns>
    bool CanBeHit();
    /// <summary>
    /// Deal damage to this hitbox.
    /// </summary>
    /// <param name="damage"></param>
    void TakeDamage(float damage);
    /// <summary>
    /// What hitboxes should take damage first?
    /// For example: when a bullet hits multiple hitboxes at once, the hitbox with the lowest priority take damage and the rest are uneffected.
    /// </summary>
    int GetHitPriority();   
}
