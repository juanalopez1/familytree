using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Library;

public class NameVisitor : IVisitor<Person>
{
    public string longestName { get; private set; } = " ";
    public void Visit(Node<Person> visitable)
    {
        if (visitable.Element.Name.Length > longestName.Length)
        {
            longestName = visitable.Element.Name;
        }

        foreach (var child in visitable.Children)
            this.Visit(child);
    }

}