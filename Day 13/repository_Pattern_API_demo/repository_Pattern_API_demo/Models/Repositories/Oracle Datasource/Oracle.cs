namespace repository_Pattern_API_demo.Models.Repositories.Oracle_Datasource
{
    public class Oracle : IProducts
    {

        List<Products> pList = new List<Products>()
        {
            new Products(){ pId=101, pName="Oracle 1", pCategory="InMemory Oracle", pIsInStock=true, pPrice=40 },
            new Products(){ pId=102, pName="Oracle 2", pCategory="InMemory Oracle", pIsInStock=true, pPrice=40 },
            new Products(){ pId=103, pName="Oracle 3", pCategory="InMemory Oracle", pIsInStock=true, pPrice=40 },
            new Products(){ pId=104, pName="Oracle 4", pCategory="InMemory Oracle", pIsInStock=true, pPrice=40 },
            new Products(){ pId=105, pName="Oracle 5", pCategory="InMemory Oracle", pIsInStock=true, pPrice=40 },
            new Products(){ pId=106, pName="Oracle 6", pCategory="InMemory Oracle", pIsInStock=true, pPrice=40 },
        };

        public string AddNewProduct(Products newProductObj)
        {
            //code and logic here
            return "Added new Product to Oracle";
        }

        public string deleteProduct(int pId)
        {
            //code and logic here
            return "Deleted  Product from Oracle";
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
            return "Product Udpated to Oracle";
        }
    }
}
