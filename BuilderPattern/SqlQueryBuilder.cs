namespace BuilderPattern;

public class SqlQueryBuilder
{
    private string _select = "";
    private string _from = "";
    private string _where = "";
    private string _orderBy = "";

    public SqlQueryBuilder Select(string columns)
    {
        _select = $"SELECT {columns}";
        return this;
    }

    public SqlQueryBuilder From(string table)
    {
        _from = $"FROM {table}";
        return this;
    }

    public SqlQueryBuilder Where(string condition)
    {
        _where = $"WHERE {condition}";
        return this;
    }

    public SqlQueryBuilder OrderBy(string order)
    {
        _orderBy = $"ORDER BY {order}";
        return this;
    }

    public string Build()
    {
        return $"{_select} {_from} {_where} {_orderBy};";
    }
}