using UnityEngine;

public class AnimalTest : MonoBehaviour
{
    Animal animal = new Animal();

    private Dog dog;
    private Cat cat;
    private Tiger tiger;
    private Zebra zebra;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dog = new Dog();
        dog.name = "멍멍이";
        tiger = new Tiger() { name = "호랑이" };
        cat = new Cat() { name = "고양이" };
        zebra = new Zebra() { name = "얼룩말" };

        dog.Bark();
        tiger.Bark();
        cat.Bark();
        zebra.Bark();
    }

   
}
