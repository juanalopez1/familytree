namespace Library.Tests;

public class NodeTests
{
    [Test]
    public void CorrectAdd()
    {
        Person lucas = new Person("Lucas", 19);
        Person maria = new Person("Maria Jose", 20);
        Node<Person> lucassNode = new Node<Person>(lucas);
        Node<Person> mariasNode = new Node<Person>(maria);
        lucassNode.AddChildren(mariasNode);

        int expected = 1;
        Assert.That(lucassNode.Children.Count, Is.EqualTo(expected));
    }
}