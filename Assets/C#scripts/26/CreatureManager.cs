using System.Collections;
using System.Collections.Generic;
using Ass26;
using Unity.VisualScripting;
using UnityEngine;

namespace Ass26
{
    public class CreatureManager : MonoBehaviour
    {
        void Start()
        {
            Kangaroo kangaroo = new();
            Duck duck = new();

            List<Creature> creatures = new() { kangaroo, duck };
            List<IRunnable> runnables = new() { kangaroo, duck };
            List<IJumpable> jumpables = new() { kangaroo };
            List<Iswimable> swimables = new() { duck };

            foreach (Creature creature in creatures)
            {
                creature.Speak();
            }
            foreach (IRunnable creature in runnables)
            {
                creature.Run();
            }
            foreach (IJumpable creature in jumpables)
            {
                creature.Jump();
            }
            foreach (Iswimable creature in swimables)
            {
                creature.Swim();
            }
        }


    }
}
