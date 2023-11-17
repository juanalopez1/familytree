using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Library;

public class AgeVisitor : IVisitor<Person>
{
    public int sum { get; private set; } = 0;
    public int nodeHoja { get; private set; } = 0;
    public void Visit(Node<Person> visitable)
    {
        sum += visitable.Element.Age;
        if (visitable.Children.Count == 0 && visitable.Element.Age > nodeHoja)
            nodeHoja = visitable.Element.Age;
        foreach (var child in visitable.Children)
            this.Visit(child);
    }

}