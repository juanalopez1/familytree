using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person yo = new Person("Juana", 19);
            Person padre = new Person("Marcos", 52);
            Person madre = new Person("Sandra", 43);
            Person abuelaPaterna = new Person("Juana", 73);
            Person abueloPaterno = new Person("Manuel", 75);
            Person abuelaMaterna = new Person("Josefita", 76);
            Person abueloMaterno = new Person("Carlos", 80);

            Node<Person> nYo = new Node<Person>(yo);
            Node<Person> nPa = new Node<Person>(padre);
            Node<Person> nMa = new Node<Person>(madre);
            Node<Person> nApa = new Node<Person>(abuelaPaterna);
            Node<Person> nApo = new Node<Person>(abueloPaterno);
            Node<Person> nAma = new Node<Person>(abuelaMaterna);
            Node<Person> nAmo = new Node<Person>(abueloMaterno);


            nYo.AddChildren(nPa);
            nYo.AddChildren(nMa);
            nPa.AddChildren(nApa);
            nPa.AddChildren(nApo);
            nMa.AddChildren(nAmo);
            nMa.AddChildren(nAma);

            // visitar el árbol aquí
            AgeVisitor myResult = new AgeVisitor();
            myResult.Visit(nYo);
            Console.WriteLine($"suma de edades: {myResult.sum}");

            Console.WriteLine($"edad del nodo hoja mas grande: {myResult.nodeHoja}");

            NameVisitor myName = new NameVisitor();
            myName.Visit(nYo);
            Console.WriteLine($"nombre mas largo: {myName.longestName}");
        }
    }
}
