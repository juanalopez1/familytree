using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Library;

public class NameVisitor : IVisitor<Person>
{
    public string longerName { get; private set; } = " ";
    public void Visit(Node<Person> visitable)
    {
        if (visitable.Element.Name.Length > longerName.Length)
        {
            longerName = visitable.Element.Name;
        }

        foreach (var child in visitable.Children)
            this.Visit(child);
    }

}