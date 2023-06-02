namespace repository_Pattern_API_demo.Models.Repositories.MongoDB
{
    public class MongodataSource : IProducts
    {

        List<Products> pList = new List<Products>()
        {
            new Products(){ pId=101, pName="Mongo 1", pCategory="InMemory Mongo", pIsInStock=true, pPrice=40 },
            new Products(){ pId=102, pName="Mongo 2", pCategory="InMemory Mongo", pIsInStock=true, pPrice=40 },
            new Products(){ pId=103, pName="Mongo 3", pCategory="InMemory Mongo", pIsInStock=true, pPrice=40 },
            new Products(){ pId=104, pName="Mongo 4", pCategory="InMemory Mongo", pIsInStock=true, pPrice=40 },
            new Products(){ pId=105, pName="Mongo 5", pCategory="InMemory Mongo", pIsInStock=true, pPrice=40 },
            new Products(){ pId=106, pName="Mongo 6", pCategory="InMemory Mongo", pIsInStock=true, pPrice=40 },
        };

        public string AddNewProduct(Products newProductObj)
        {
            //code and logic here
            return "Added new Product to Mongo";
        }

        public string deleteProduct(int pId)
        {
            //code and logic here
            return "Deleted  Product from Mongo";
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
            return "Product Udpated to Mongo";
        }
    }
}
