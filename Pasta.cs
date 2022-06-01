public class Pasta
{
    public bool Fresh {get;set;}
    public decimal Price {get;set;}
    public string Brand {get;set;}
    public int BrandRank {get;set;}
    public int TypeRank {get;set;}
    public int Rating {get {return BrandRank + TypeRank;}}
    public Pasta()
    {

    }
    public Pasta(bool fresh, string brand, decimal price)
    {
        Fresh = fresh;
        Brand = brand;
        Price = price;
    }

    public override string ToString()
    {
        return $"{this.Brand} {GetType().ToString()} for {Price}";
    }
}

public class Lasagne: Pasta
{
    public Lasagne(bool fresh, string brand, decimal price): base(fresh, brand, price)
    {
    } 
}

public class Cannelloni: Pasta
{
    public Cannelloni(bool fresh, string brand, decimal price): base(fresh, brand, price)
    {
    } 
}
public class Fettuccine: Pasta
{
    public Fettuccine(bool fresh, string brand, decimal price): base(fresh, brand, price)
    {
    }     
}

public class Tagliatelle: Pasta
{
    public Tagliatelle(bool fresh, string brand, decimal price): base(fresh, brand, price)
    {
    }     
}

public class Ravioli: Pasta
{
    public Ravioli(bool fresh, string brand, decimal price): base(fresh, brand, price)
    {
    }     
}
public class Tortellini: Pasta
{
    public Tortellini(bool fresh, string brand, decimal price): base(fresh, brand, price)
    {
    }     
}
