namespace Library.Tests;

public class NameVisitorTests
{
    [Test]
    public void LongestName()
    {
        NameVisitor name = new NameVisitor();
        Person lucas = new Person("Lucas", 19);
        Person maria = new Person("Maria Jose", 20);
        Node<Person> lucassNode = new Node<Person>(lucas);
        Node<Person> mariasNode = new Node<Person>(maria);
        lucassNode.AddChildren(mariasNode);
        name.Visit(lucassNode);

        string expected = "Maria Jose";
        Assert.That(name.longestName, Is.EqualTo(expected));
    }
}