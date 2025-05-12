namespace personalBlog.Shared.DTOs;

public class ListPaged<T> : List<T>
{
    /// <summary>
    /// Número de efilas totales
    /// </summary>
    public int RowCount { get; }
    
    public ListPaged(IEnumerable<T> items, int count, int pageSize) : base()
    {
        RowCount = count;
    }

    public ListPaged(IEnumerable<T> items, int count) : base(items) 
    {
        RowCount = count;
    }
}