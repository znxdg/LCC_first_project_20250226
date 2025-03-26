using UnityEngine;

namespace YuCheng
{
    public class Slime:Enemy
    {
        public override void Awake()
        {
            con = 70;
            pow = 60;
            base.Awake();
            hp = hpMax;
            Debug.Log(hpMax);
        } 
    }
}
