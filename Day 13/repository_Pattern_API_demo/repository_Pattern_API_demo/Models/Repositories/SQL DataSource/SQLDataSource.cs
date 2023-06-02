namespace repository_Pattern_API_demo.Models.Repositories.SQL_DataSource
{
    public class SQLDataSource : IProducts
    {
        List<Products> pList = new List<Products>()
        {
            new Products(){ pId=101, pName="SQL Server 1", pCategory="InMemory SQL Server", pIsInStock=true, pPrice=40 },
            new Products(){ pId=102, pName="SQL Server 2", pCategory="InMemory SQL Server", pIsInStock=true, pPrice=40 },
            new Products(){ pId=103, pName="SQL Server 3", pCategory="InMemory SQL Server", pIsInStock=true, pPrice=40 },
            new Products(){ pId=104, pName="SQL Server 4", pCategory="InMemory SQL Server", pIsInStock=true, pPrice=40 },
            new Products(){ pId=105, pName="SQL Server 5", pCategory="InMemory SQL Server", pIsInStock=true, pPrice=40 },
            new Products(){ pId=106, pName="SQL Server 6", pCategory="InMemory SQL Server", pIsInStock=true, pPrice=40 },
        };

        public string AddNewProduct(Products newProductObj)
        {
            //code and logic here
            return "Added new Product to SQL Server";
        }

        public string deleteProduct(int pId)
        {
            //code and logic here
            return "Deleted  Product from SQL Server";
        }

        public Products GetProductById(int id)
        {
            var pr = (from p in pList
                      where p.pId == id
                      select p).Single();

            return pr;
        }

        public List<Products> GetProductsList()
        {
            return pList;
        }

        public string updateproduct(Products changes)
        {
            return "Product Udpated to SQL Server";
        }
    }
}
