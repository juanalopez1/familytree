namespace Library.Tests;

public class AgeVisitorTests
{
    [Test]
    public void CorrectSum()
    {
        AgeVisitor suma = new AgeVisitor();
        Person lucas = new Person("Lucas", 19);
        Person maria = new Person("Maria", 20);
        Node<Person> lucassNode = new Node<Person>(lucas);
        Node<Person> mariasNode = new Node<Person>(maria);
        lucassNode.AddChildren(mariasNode);
        suma.Visit(lucassNode);

        int expected = 39;
        Assert.That(suma.sum, Is.EqualTo(expected));
    }

    [Test]
    public void CorrectNodeHoja()
    {
        AgeVisitor suma = new AgeVisitor();
        Person lucas = new Person("Lucas", 19);
        Person maria = new Person("Maria", 20);
        Node<Person> lucassNode = new Node<Person>(lucas);
        Node<Person> mariasNode = new Node<Person>(maria);
        lucassNode.AddChildren(mariasNode);
        suma.Visit(lucassNode);

        int expected = 20;
        Assert.That(suma.nodeHoja, Is.EqualTo(expected));
    }
}