using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeManagementScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Cat  cat = new Cat();
        Animal animalFromCat = cat;
        animalFromCat.MakeSound();
        animalFromCat.Move();

        Debug.Log("========================");
        Cat catFromAnimal = cat as Cat;
        catFromAnimal.MakeSound();
        catFromAnimal.Move();



       
        // لم يعمل هذا الكود 
        // Animal animal = new Animal();
        // Cat animalToCat =  animal as Cat;
        // animalToCat.Move();
        // animalToCat.MakeSound();

        // Cat cat1 = new Animal() as Cat;
        // cat1.MakeSound();
        // cat1.Move();

        List<ICanFight> fighters = new() { new Cat(), new Warrior() };
        foreach (var item in fighters)
        {
            
            if (item is Cat)
            {
                Debug.Log("Cat");
            }
            else if (item is Warrior)
            {
                Debug.Log("warior");
            }
            item.Attack();
        }


    }


}

public class Animal
{
    public virtual void MakeSound()
    {
        Debug.Log("Animal Sound");
    }
    public virtual void Move()
    {
        Debug.Log("Animal Moves");
    }
}

public class Cat : Animal, ICanFight
{
    public void Attack()
    {
        Debug.Log("Cat Attacks with claws!");
    }

    public override void MakeSound()
    {
        Debug.Log("Mew");
    }
    public override void Move()
    {
        Debug.Log("Cat runs Quickly");
    }
}

public interface ICanFight
{
    void Attack();
}
public class Warrior : ICanFight
{
    public void Attack()
    {
        Debug.Log("WArrior attacks with a sword!");
    }
}
