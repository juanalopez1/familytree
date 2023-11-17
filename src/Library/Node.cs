using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Linq.Expressions;

/* Para hacer la clase mas abstracta hice que, en lugar de guardar 
unicamente ints, guarde objetos de cualquier tipo, como por ejemplo objetos de la clase Person. */
namespace Library
{
    public class Node<T> : IVisitable<T>
    {
        private T element;

        private List<Node<T>> children = new List<Node<T>>();

        public T Element
        {
            get
            {
                return this.element;
            }
        }

        public ReadOnlyCollection<Node<T>> Children
        {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(T element)
        {
            this.element = element;
        }

        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }
        public void Accept(IVisitor<T> visitor)
        {
            visitor.Visit(this);
        }
    }

}
