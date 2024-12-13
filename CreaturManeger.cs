using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assignment26
{
    public class CreaturManeger : MonoBehaviour
    {
        void Start()
        {
            List<Creature> creaturs = new List<Creature>();
            creaturs.Add(new Duck());
            creaturs.Add(new Kangaroo());

            List<IJumpable> jumpables = new List<IJumpable>();
            jumpables.Add(new Kangaroo());

            List<IRunable> runables = new List<IRunable>();
            runables.Add(new Duck());
            runables.Add(new Kangaroo());

            List<ISwimmable> swimmables = new List<ISwimmable>();
            swimmables.Add(new Duck());

            foreach(Creature creature in creaturs) {
                creature.Speak();
            }
            foreach(IRunable runable in runables) {
                runable.Run();
            }
            foreach(IJumpable jumpable in jumpables) {
                jumpable.Jump();
            }
            foreach(ISwimmable swimmable in swimmables) {
                swimmable.Swim();
            }

        }

    }
}