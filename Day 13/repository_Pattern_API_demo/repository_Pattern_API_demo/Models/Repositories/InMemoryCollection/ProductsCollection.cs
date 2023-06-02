namespace repository_Pattern_API_demo.Models.Repositories.InMemoryCollection
{
    public class ProductsCollection : IProducts
    {

        List<Products> pList = new List<Products>()
        {
            new Products(){ pId=101, pName="Collection 1", pCategory="InMemory Collection", pIsInStock=true, pPrice=40 },
            new Products(){ pId=102, pName="Collection 2", pCategory="InMemory Collection", pIsInStock=true, pPrice=40 },
            new Products(){ pId=103, pName="Collection 3", pCategory="InMemory Collection", pIsInStock=true, pPrice=40 },
            new Products(){ pId=104, pName="Collection 4", pCategory="InMemory Collection", pIsInStock=true, pPrice=40 },
            new Products(){ pId=105, pName="Collection 5", pCategory="InMemory Collection", pIsInStock=true, pPrice=40 },
            new Products(){ pId=106, pName="Collection 6", pCategory="InMemory Collection", pIsInStock=true, pPrice=40 },
        };

        public string AddNewProduct(Products newProductObj)
        {
            //code and logic here
            return "Added new Product to Collection";
        }

        public string deleteProduct(int pId)
        {
            //code and logic here
            return "Deleted  Product from Collection";
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
            return "Product Udpated to Collection";
        }
    }
}
