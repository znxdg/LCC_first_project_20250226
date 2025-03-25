using System.Security.Cryptography;
using UnityEngine;

namespace YuCheng
{

    public class Mushroom:Enemy
    {
        public override void Awake()
        {
            con = 73;
            pow = 68;
            base.Awake();
            hp = hpMax;
            Debug.Log(hpMax);
        }
    }
}
