namespace Library;

public interface IVisitor<T>
{
    public void Visit(Node<T> visitable);
}