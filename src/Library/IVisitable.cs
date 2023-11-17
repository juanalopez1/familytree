using System.ComponentModel.DataAnnotations.Schema;

namespace Library;

public interface IVisitable<T>
{
    public void Accept(IVisitor<T> visitor);
}